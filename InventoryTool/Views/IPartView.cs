using Data.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTool.Views
{
    public interface IPartView
    {
        Part SelectedPart { get; }
        string Id { get; set; }
        string PartName { get; set; }
        string Price { get; set; }
        string InventoryCount { get; set; }
        string MinimumInventoryCount { get; set; }
        string MaximumInventoryCount { get; set; }
        string CompanyName { get; set; }
        string MachineId { get; set; }
        bool IsInHouse { get; set; }
        bool IsOutsourced { get; set; }

        event EventHandler AddPart;
        event EventHandler ModifyPart;
        event EventHandler CancelAction;

        void Show();
        void Close();
    }
}
