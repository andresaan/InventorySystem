using System;
using System.Collections.Generic;
using Data;
using Data.Parts;

namespace ApplicationCore.Interfaces
{
    public interface IValidatorService
    {
        ValidationResult ValidateBaseContent(string name, string price, string inventoryCount, string minimumInventoryCount, string maximumInventoryCount);
        ValidationResult ValidateProductContent(string name, string price, string inventoryCount, string minimumInventoryCount, string maximumInventoryCount, HashSet<Part> associatedParts);
        ValidationResult ValidatePartContent(string name, string price, string inventoryCount, string minimumInventoryCount, string maximumInventoryCount, string companyName, string machineId, bool isInHouse, bool isOutsourced);
    }
}
