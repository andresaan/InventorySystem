using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EventArguments
{
    public class ShowAddOrModifyEventArguments : EventArgs
    {
        public string FormType;
        public ShowAddOrModifyEventArguments(string formType)
        {
            this.FormType = formType;
        }
       
    }
}
