using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using Data.Parts;

namespace InventoryTool.Views
{
    public partial class PartView : Form, IPartView
    {
        private Part _selectedPart;
        public Part SelectedPart { get => _selectedPart; set => _selectedPart = value; } 

        public string Id { get => inpPartId.Text; set => inpPartId.Text = value; }
        public string PartName { get => inpPartName.Text; set => inpPartName.Text = value; }
        public string Price { get => inpPartCost.Text; set => inpPartCost.Text = value; }
        public string InventoryCount { get => inpPartInvActual.Text; set => inpPartInvActual.Text = value; }
        public string MinimumInventoryCount { get => inpPartInvMin.Text; set => inpPartInvMin.Text = value; }
        public string MaximumInventoryCount { get => inpPartInvMax.Text; set => inpPartInvMax.Text = value; }
        string IPartView.CompanyName { get => inpPartCompName.Text; set => inpPartCompName.Text = value; }
        public string MachineId { get => inpPartMachineId.Text; set => inpPartMachineId.Text = value; }
        public bool IsInHouse { get => radPartInHoust.Checked; set => radPartInHoust.Checked = value; }
        public bool IsOutsourced { get => radPartOutsourced.Checked; set => radPartOutsourced.Checked = value; }


        public event EventHandler AddPart;
        public event EventHandler ModifyPart;
        public event EventHandler CancelAction;


        public PartView(string type)
        {
            InitializeComponent();

            btnAddPart.Click += delegate { AddPart?.Invoke(this, EventArgs.Empty); };
            btnCancelAction.Click += delegate { CancelAction?.Invoke(this, EventArgs.Empty); };
            
            btnModifyPart.Visible = type == "mod" ? true : false;
            btnAddPart.Visible = type == "add" ? true : false;
            lblModifyPartTitle.Visible = type == "mod" ? true : false;
            lblAddPartTitle.Visible = type == "add" ? true : false;
        }
        public PartView(string type, Part part)
        {
            InitializeComponent();

            btnModifyPart.Click += delegate { ModifyPart?.Invoke(this, EventArgs.Empty); };
            btnCancelAction.Click += delegate { CancelAction?.Invoke(this, EventArgs.Empty); };

            btnModifyPart.Visible = type == "mod" ? true : false;
            btnAddPart.Visible = type == "add" ? true : false;
            lblModifyPartTitle.Visible = type == "mod" ? true : false;
            lblAddPartTitle.Visible = type == "add" ? true : false;

            _selectedPart = part;
        }

        private void radPartInHoust_CheckedChanged(object sender, EventArgs e)
        {
            lblPartCompName.Visible = false;
            inpPartCompName.Visible = false;

            lblPartMachineId.Visible = true;
            inpPartMachineId.Visible = true;
        }

        private void radPartOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            lblPartCompName.Visible = true;
            inpPartCompName.Visible = true;

            lblPartMachineId.Visible = false;
            inpPartMachineId.Visible = false;
        }

        private void inpPartCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
