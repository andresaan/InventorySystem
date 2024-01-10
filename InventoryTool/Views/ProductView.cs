using Data.Parts;
using Data.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryTool.Views
{
    public partial class ProductView : Form, IProductView
    {
        private Product _selectedProduct;
        public Product SelectedProduct { get => _selectedProduct; set => _selectedProduct = value; }
        public string SelectedCandidatePartId { get => dataCandidateParts.RowCount != 0 && dataCandidateParts.CurrentCell != null ? dataCandidateParts.CurrentRow.Cells[0].Value.ToString() : null; }
        public string SelectedAssociatedPartId { get => dataAssociatedParts.RowCount != 0 && dataAssociatedParts.CurrentCell != null ? dataAssociatedParts.CurrentRow.Cells[0].Value.ToString() : null; }
        public string Id { get => inpProductId.Text; set => inpProductId.Text = value; }
        string IProductView.ProductName { get => inpProductName.Text; set => inpProductName.Text = value; }
        public string Price { get => inpProductCost.Text; set => inpProductCost.Text = value; }
        public string InventoryCount { get => inpProductInvActual.Text; set => inpProductInvActual.Text = value; }
        public string MinimumInventoryCount { get => inpProductInvMin.Text; set => inpProductInvMin.Text = value; }
        public string MaximumInventoryCount { get => inpProductInvMax.Text; set => inpProductInvMax.Text = value; }


        public event EventHandler AddProduct;
        public event EventHandler ModifyProduct;
        public event EventHandler CancelAction;
        public event EventHandler AssociatePartToProduct;
        public event EventHandler DeletePartFromProduct;

        public ProductView()
        {
            InitializeComponent();
        }

        public ProductView(string type)
        {
            InitializeComponent();

            btnAddProduct.Click += delegate { AddProduct?.Invoke(this, EventArgs.Empty); };
            btnCancelAction.Click += delegate { CancelAction?.Invoke(this, EventArgs.Empty); };
            btnAddPartToProduct.Click += delegate { AssociatePartToProduct?.Invoke(this, EventArgs.Empty); };
            btnDeletePartFromProduct.Click += delegate { DeletePartFromProduct?.Invoke(this, EventArgs.Empty); };

            btnModifyProduct.Visible = type == "mod" ? true : false;
            btnAddProduct.Visible = type == "add" ? true : false;
            lblModifyProductTitle.Visible = type == "mod" ? true : false;
            lblAddProductTitle.Visible = type == "add" ? true : false;
        }
        public ProductView(string type, Product product)
        {
            InitializeComponent();

            btnModifyProduct.Click += delegate { ModifyProduct?.Invoke(this, EventArgs.Empty); };
            btnCancelAction.Click += delegate { CancelAction?.Invoke(this, EventArgs.Empty); };
            btnAddPartToProduct.Click += delegate { AssociatePartToProduct?.Invoke(this, EventArgs.Empty); };
            btnDeletePartFromProduct.Click += delegate { DeletePartFromProduct?.Invoke(this, EventArgs.Empty); };

            btnModifyProduct.Visible = type == "mod" ? true : false;
            btnAddProduct.Visible = type == "add" ? true : false;
            lblModifyProductTitle.Visible = type == "mod" ? true : false;
            lblAddProductTitle.Visible = type == "add" ? true : false;

            _selectedProduct = product;
        }

        public void SetCandidatePartsBindingSource(BindingSource bindingSource)
        {
            dataCandidateParts.DataSource = bindingSource;

            dataCandidateParts.Columns["Products"].Visible = false;
            dataCandidateParts.Columns["Id"].HeaderText = "Part ID";
            dataCandidateParts.Columns["InventoryCount"].HeaderText = "Inventory";
            dataCandidateParts.Columns["MinimumInventoryCount"].HeaderText = "Min";
            dataCandidateParts.Columns["MaximumInventoryCount"].HeaderText = "Max";
        }

        public void SetAssociatedPartsBindingSource(BindingSource bindingSource)
        {
            dataAssociatedParts.DataSource = bindingSource;

            dataAssociatedParts.Columns["Products"].Visible = false;
            dataAssociatedParts.Columns["Id"].HeaderText = "Part ID";
            dataAssociatedParts.Columns["InventoryCount"].HeaderText = "Inventory";
            dataAssociatedParts.Columns["MinimumInventoryCount"].HeaderText = "Min";
            dataAssociatedParts.Columns["MaximumInventoryCount"].HeaderText = "Max";
        }

        private void inpCanPartSearch_TextChanged(object sender, EventArgs e)
        {
            var searchValue = inpCanPartSearch.Text;

            dataCandidateParts.CurrentCell = null;

            foreach (DataGridViewRow dr in dataCandidateParts.Rows)
            {
                for (var i = 0; i <= 1; i++)
                {
                    var cellValue = dr.Cells[i].Value.ToString();

                    if (cellValue.Contains(searchValue))
                    {
                        dr.Visible = true;
                        break;
                    }
                    else
                    {
                        dr.Visible = false;
                    }
                }
            }
        }

        private void inpAssocPartSearch_TextChanged(object sender, EventArgs e)
        {
            var searchValue = inpAssocPartSearch.Text;

            dataAssociatedParts.CurrentCell = null;

            foreach (DataGridViewRow dr in dataAssociatedParts.Rows)
            {
                for (var i = 0; i <= 1; i++)
                {
                    var cellValue = dr.Cells[i].Value.ToString();

                    if (cellValue.Contains(searchValue))
                    {
                        dr.Visible = true;
                        break;
                    }
                    else
                    {
                        dr.Visible = false;
                    }
                }
            }
        }
    }
}
