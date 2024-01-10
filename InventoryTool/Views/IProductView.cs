using Data.Parts;
using Data.Products;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryTool.Views
{
    public interface IProductView
    {
        string SelectedCandidatePartId { get; }
        string SelectedAssociatedPartId { get; }
        Product SelectedProduct { get; }
        string Id { get; set; }
        string ProductName { get; set; }
        string Price { get; set; }
        string InventoryCount { get; set; }
        string MinimumInventoryCount { get; set; }
        string MaximumInventoryCount { get; set; }


        event EventHandler AddProduct;
        event EventHandler ModifyProduct;
        event EventHandler CancelAction;
        event EventHandler AssociatePartToProduct;
        event EventHandler DeletePartFromProduct;

        void SetCandidatePartsBindingSource(BindingSource bindingSource);
        void SetAssociatedPartsBindingSource(BindingSource bindingSource);
        void Show();
        void Close();
    }
}
