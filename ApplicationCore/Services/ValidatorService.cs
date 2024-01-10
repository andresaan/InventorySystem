using ApplicationCore.Interfaces;
using Data;
using Data.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ValidatorService : IValidatorService
    {
        public ValidationResult ValidateBaseContent(string name, string price, string inventoryCount, string minimumInventoryCount, string maximumInventoryCount)
        {

            // Null Check
            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(price) ||
                string.IsNullOrEmpty(inventoryCount) ||
                string.IsNullOrEmpty(minimumInventoryCount) ||
                string.IsNullOrEmpty(maximumInventoryCount))
            {
                return new ValidationResult(false, "Not all information was present to create item");
            }


            // Try parse price
            if (double.TryParse(price, out var parsedPrice) && parsedPrice == 0)
            {
                return new ValidationResult(false, "Price cannot be 0");
            }

            // Decimal rules
            if (price.IndexOf('.') > -1)
            {
                var dollarsAndCents = price.Split('.');

                if (dollarsAndCents[1].Length > 2)
                {
                    return new ValidationResult(false, "There can only be two decimal places");
                }
                if (dollarsAndCents[1].Length == 0)
                {
                    return new ValidationResult(false, "Remove the decimal point if there are no cents");
                }
            }

            // Inventory count rules 
            if (int.TryParse(inventoryCount, out var invCount) && int.TryParse(minimumInventoryCount, out var minInvCount) && int.TryParse(maximumInventoryCount, out var maxInvCount))
            {
                if (maxInvCount == 0)
                {
                    return new ValidationResult(false, "Maximum cannot be 0");
                }

                if (minInvCount == maxInvCount || minInvCount > maxInvCount)
                {
                    return new ValidationResult(false, "Minimum must be less than maximum and they cannot be equal");
                }

                if (minInvCount > invCount || invCount > maxInvCount)
                {
                    return new ValidationResult(false, "Current inventory is outside minimum and maximum range.");
                }
            }
            else
            {
                return new ValidationResult(false, "Inventory counts are not valid");
            }

            return new ValidationResult(true, "");
        }

        public ValidationResult ValidatePartContent(string name, string price, string inventoryCount, string minimumInventoryCount, string maximumInventoryCount, string companyName, string machineId, bool isInHouse, bool isOutsourced)
        {

            var result = ValidateBaseContent(name, price, inventoryCount, minimumInventoryCount, maximumInventoryCount);

            if (!result.success)
            {
                return new ValidationResult(false, result.message);
            }

            //In House part null check
            if (isInHouse && string.IsNullOrEmpty(machineId))
            {
                return new ValidationResult(false, "Error: Cannot add an in-house part without a Machine ID present");
            }

            //Outsourced part null check
            if (isOutsourced && string.IsNullOrEmpty(companyName))
            {
                return new ValidationResult(false, "Error: Cannot add an outsourced part without a Company Name present");
            }

            return new ValidationResult(true, "");
        }

        public ValidationResult ValidateProductContent(string name, string price, string inventoryCount, string minimumInventoryCount, string maximumInventoryCount, HashSet<Part> associatedParts)
        {
            var result = ValidateBaseContent(name, price, inventoryCount, minimumInventoryCount, maximumInventoryCount);

            if (!result.success)
            {
                return new ValidationResult(false, result.message);
            }

            //if (associatedParts == null || associatedParts.Count == 0) 
            //{
            //    return new ValidationResult(false, "A new product must have at least one part associated with it");
            //}

            return new ValidationResult(true, "");
        }
    }
}
