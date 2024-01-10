using Data.EventArguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryTool.Views
{
    public interface IMainView
    {
        string SelectedPartId { get; }
        string SelectedPartName { get; }
        string SelectedProductId { get; }
        string SelectedProductName { get; }

        event EventHandler<ShowAddOrModifyEventArguments> ShowAddPartView;
        event EventHandler<ShowAddOrModifyEventArguments> ShowModifyPartView;
        event EventHandler DeletePart;

        event EventHandler<ShowAddOrModifyEventArguments> ShowAddProductView;
        event EventHandler<ShowAddOrModifyEventArguments> ShowModifyProductView;
        event EventHandler DeleteProduct;

        event EventHandler ExitApplication;

        void SetPartListBindingSource(BindingSource bindingSource);
        void SetProductListBindingSource(BindingSource bindingSource);
        void Show();
    }
}
