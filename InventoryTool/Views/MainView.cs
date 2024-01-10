using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Data.Products;
using Data.Parts;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Data.EventArguments;
using System.Drawing;

namespace InventoryTool.Views
{
    public partial class MainView : Form, IMainView
    {
        public string SelectedPartId { get => dataParts.RowCount != 0 && dataParts.CurrentCell != null ?  dataParts.CurrentRow.Cells[0].Value.ToString() : null; }
        public string SelectedPartName { get => dataParts.RowCount != 0 && dataParts.CurrentCell != null ? dataParts.CurrentRow.Cells[1].Value.ToString() : null; }
        public string SelectedProductId { get => dataProducts.RowCount != 0 && dataProducts.CurrentCell != null ? dataProducts.CurrentRow.Cells[0].Value.ToString() : null; }
        public string SelectedProductName { get => dataProducts.RowCount != 0 && dataProducts.CurrentCell != null ? dataProducts.CurrentRow.Cells[1].Value.ToString() : null; }

        public MainView()
        {
            InitializeComponent();

            btnAddPart.Click += delegate { ShowAddPartView?.Invoke(this, new ShowAddOrModifyEventArguments("add")); };
            btnModifyPart.Click += delegate { ShowModifyPartView?.Invoke(this, new ShowAddOrModifyEventArguments("mod")); };
            btnDeletePart.Click += delegate { DeletePart?.Invoke(this, EventArgs.Empty); };

            btnAddProduct.Click += delegate { ShowAddProductView?.Invoke(this, new ShowAddOrModifyEventArguments("add")); };
            btnModifyProduct.Click += delegate { ShowModifyProductView?.Invoke(this, new ShowAddOrModifyEventArguments("mod")); };
            btnDeleteProduct.Click += delegate { DeleteProduct?.Invoke(this, EventArgs.Empty); };
            
            btnExitApplication.Click += delegate { ExitApplication?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler<ShowAddOrModifyEventArguments> ShowAddPartView;
        public event EventHandler<ShowAddOrModifyEventArguments> ShowModifyPartView;
        public event EventHandler DeletePart;

        public event EventHandler<ShowAddOrModifyEventArguments> ShowAddProductView;
        public event EventHandler<ShowAddOrModifyEventArguments> ShowModifyProductView;
        public event EventHandler DeleteProduct;

        public event EventHandler ExitApplication;


        public void SetPartListBindingSource(BindingSource bindingSource)
        {

            dataParts.DataSource = bindingSource;

            dataParts.Columns["Products"].Visible = false;
            dataParts.Columns["Id"].HeaderText = "Part ID";
            dataParts.Columns["InventoryCount"].HeaderText = "Inventory";
            dataParts.Columns["MinimumInventoryCount"].HeaderText = "Min";
            dataParts.Columns["MaximumInventoryCount"].HeaderText = "Max";

        }

        public void SetProductListBindingSource(BindingSource bindingSource)
        {
            dataProducts.DataSource = bindingSource;

            dataProducts.Columns["Parts"].Visible = false;
            dataProducts.Columns["Id"].HeaderText = "Part ID";
            dataProducts.Columns["InventoryCount"].HeaderText = "Inventory";
            dataProducts.Columns["MinimumInventoryCount"].HeaderText = "Min";
            dataProducts.Columns["MaximumInventoryCount"].HeaderText = "Max";
        }

        private void inpPartSearch_TextChanged(object sender, EventArgs e)
        {
            var searchValue = inpPartSearch.Text;

            dataParts.CurrentCell = null;

            foreach (DataGridViewRow dr in dataParts.Rows)
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

        private void inpProductSearch_TextChanged(object sender, EventArgs e)
        {
            var searchValue = inpProductSearch.Text;
            dataProducts.CurrentCell = null;

            foreach (DataGridViewRow dr in dataProducts.Rows)
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
