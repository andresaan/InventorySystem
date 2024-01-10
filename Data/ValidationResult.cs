using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ValidationResult
    {
        public string message { get; set; }
        public bool success { get; set; }

        public ValidationResult(bool success)
        {
            this.success = success;
        }
        public ValidationResult(bool success, string message)
        {
            this.message = message;
            this.success = success;
        }
    }
}
