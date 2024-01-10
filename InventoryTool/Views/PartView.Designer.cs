namespace InventoryTool.Views
{
    partial class PartView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radPartInHoust = new System.Windows.Forms.RadioButton();
            this.radPartOutsourced = new System.Windows.Forms.RadioButton();
            this.lblPartId = new System.Windows.Forms.Label();
            this.lblPartInvMin = new System.Windows.Forms.Label();
            this.lblPartMachineId = new System.Windows.Forms.Label();
            this.lblPartCost = new System.Windows.Forms.Label();
            this.lblPartInvActual = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.inpPartId = new System.Windows.Forms.TextBox();
            this.inpPartName = new System.Windows.Forms.TextBox();
            this.inpPartInvActual = new System.Windows.Forms.NumericUpDown();
            this.inpPartMachineId = new System.Windows.Forms.NumericUpDown();
            this.inpPartInvMin = new System.Windows.Forms.NumericUpDown();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnModifyPart = new System.Windows.Forms.Button();
            this.lblPartCompName = new System.Windows.Forms.Label();
            this.inpPartCompName = new System.Windows.Forms.TextBox();
            this.inpPartInvMax = new System.Windows.Forms.NumericUpDown();
            this.lblPartInvMax = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.inpPartCost = new System.Windows.Forms.TextBox();
            this.btnCancelAction = new System.Windows.Forms.Button();
            this.lblAddPartTitle = new System.Windows.Forms.Label();
            this.lblModifyPartTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inpPartInvActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpPartMachineId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpPartInvMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpPartInvMax)).BeginInit();
            this.SuspendLayout();
            // 
            // radPartInHoust
            // 
            this.radPartInHoust.AutoSize = true;
            this.radPartInHoust.Checked = true;
            this.radPartInHoust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPartInHoust.Location = new System.Drawing.Point(191, 60);
            this.radPartInHoust.Name = "radPartInHoust";
            this.radPartInHoust.Size = new System.Drawing.Size(98, 24);
            this.radPartInHoust.TabIndex = 0;
            this.radPartInHoust.TabStop = true;
            this.radPartInHoust.Text = "In-House";
            this.radPartInHoust.UseVisualStyleBackColor = true;
            this.radPartInHoust.CheckedChanged += new System.EventHandler(this.radPartInHoust_CheckedChanged);
            // 
            // radPartOutsourced
            // 
            this.radPartOutsourced.AutoSize = true;
            this.radPartOutsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPartOutsourced.Location = new System.Drawing.Point(355, 60);
            this.radPartOutsourced.Name = "radPartOutsourced";
            this.radPartOutsourced.Size = new System.Drawing.Size(117, 24);
            this.radPartOutsourced.TabIndex = 1;
            this.radPartOutsourced.Text = "Outsourced";
            this.radPartOutsourced.UseVisualStyleBackColor = true;
            this.radPartOutsourced.CheckedChanged += new System.EventHandler(this.radPartOutsourced_CheckedChanged);
            // 
            // lblPartId
            // 
            this.lblPartId.AutoSize = true;
            this.lblPartId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartId.Location = new System.Drawing.Point(191, 123);
            this.lblPartId.Name = "lblPartId";
            this.lblPartId.Size = new System.Drawing.Size(26, 20);
            this.lblPartId.TabIndex = 2;
            this.lblPartId.Text = "ID";
            this.lblPartId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPartInvMin
            // 
            this.lblPartInvMin.AutoSize = true;
            this.lblPartInvMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartInvMin.Location = new System.Drawing.Point(181, 331);
            this.lblPartInvMin.Name = "lblPartInvMin";
            this.lblPartInvMin.Size = new System.Drawing.Size(36, 20);
            this.lblPartInvMin.TabIndex = 3;
            this.lblPartInvMin.Text = "Min";
            this.lblPartInvMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPartMachineId
            // 
            this.lblPartMachineId.AutoSize = true;
            this.lblPartMachineId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartMachineId.Location = new System.Drawing.Point(123, 383);
            this.lblPartMachineId.Name = "lblPartMachineId";
            this.lblPartMachineId.Size = new System.Drawing.Size(94, 20);
            this.lblPartMachineId.TabIndex = 4;
            this.lblPartMachineId.Text = "Machine ID";
            this.lblPartMachineId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPartCost
            // 
            this.lblPartCost.AutoSize = true;
            this.lblPartCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartCost.Location = new System.Drawing.Point(119, 227);
            this.lblPartCost.Name = "lblPartCost";
            this.lblPartCost.Size = new System.Drawing.Size(98, 20);
            this.lblPartCost.TabIndex = 6;
            this.lblPartCost.Text = "Price / Cost";
            this.lblPartCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPartInvActual
            // 
            this.lblPartInvActual.AutoSize = true;
            this.lblPartInvActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartInvActual.Location = new System.Drawing.Point(141, 279);
            this.lblPartInvActual.Name = "lblPartInvActual";
            this.lblPartInvActual.Size = new System.Drawing.Size(76, 20);
            this.lblPartInvActual.TabIndex = 7;
            this.lblPartInvActual.Text = "Inventory";
            this.lblPartInvActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartName.Location = new System.Drawing.Point(164, 175);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(53, 20);
            this.lblPartName.TabIndex = 8;
            this.lblPartName.Text = "Name";
            this.lblPartName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inpPartId
            // 
            this.inpPartId.Location = new System.Drawing.Point(234, 121);
            this.inpPartId.Name = "inpPartId";
            this.inpPartId.ReadOnly = true;
            this.inpPartId.Size = new System.Drawing.Size(226, 22);
            this.inpPartId.TabIndex = 9;
            // 
            // inpPartName
            // 
            this.inpPartName.Location = new System.Drawing.Point(234, 173);
            this.inpPartName.Name = "inpPartName";
            this.inpPartName.Size = new System.Drawing.Size(226, 22);
            this.inpPartName.TabIndex = 10;
            this.toolTip.SetToolTip(this.inpPartName, "Name of Part");
            // 
            // inpPartInvActual
            // 
            this.inpPartInvActual.Location = new System.Drawing.Point(234, 277);
            this.inpPartInvActual.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.inpPartInvActual.Name = "inpPartInvActual";
            this.inpPartInvActual.Size = new System.Drawing.Size(226, 22);
            this.inpPartInvActual.TabIndex = 12;
            this.toolTip.SetToolTip(this.inpPartInvActual, "Number of parts the company currently has available");
            // 
            // inpPartMachineId
            // 
            this.inpPartMachineId.Location = new System.Drawing.Point(234, 381);
            this.inpPartMachineId.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.inpPartMachineId.Name = "inpPartMachineId";
            this.inpPartMachineId.Size = new System.Drawing.Size(226, 22);
            this.inpPartMachineId.TabIndex = 13;
            this.toolTip.SetToolTip(this.inpPartMachineId, "Machine Id for in-house part");
            // 
            // inpPartInvMin
            // 
            this.inpPartInvMin.AccessibleDescription = "Minimum Inventory Count";
            this.inpPartInvMin.Location = new System.Drawing.Point(234, 329);
            this.inpPartInvMin.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.inpPartInvMin.Name = "inpPartInvMin";
            this.inpPartInvMin.Size = new System.Drawing.Size(74, 22);
            this.inpPartInvMin.TabIndex = 14;
            this.toolTip.SetToolTip(this.inpPartInvMin, "Minimum Inventory Count");
            // 
            // btnAddPart
            // 
            this.btnAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPart.Location = new System.Drawing.Point(204, 449);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(95, 31);
            this.btnAddPart.TabIndex = 17;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Visible = false;
            // 
            // btnModifyPart
            // 
            this.btnModifyPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyPart.Location = new System.Drawing.Point(204, 449);
            this.btnModifyPart.Name = "btnModifyPart";
            this.btnModifyPart.Size = new System.Drawing.Size(95, 31);
            this.btnModifyPart.TabIndex = 18;
            this.btnModifyPart.Text = "Save";
            this.btnModifyPart.UseVisualStyleBackColor = true;
            this.btnModifyPart.Visible = false;
            // 
            // lblPartCompName
            // 
            this.lblPartCompName.AutoSize = true;
            this.lblPartCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartCompName.Location = new System.Drawing.Point(89, 382);
            this.lblPartCompName.Name = "lblPartCompName";
            this.lblPartCompName.Size = new System.Drawing.Size(128, 20);
            this.lblPartCompName.TabIndex = 22;
            this.lblPartCompName.Text = "Company Name";
            this.lblPartCompName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPartCompName.Visible = false;
            // 
            // inpPartCompName
            // 
            this.inpPartCompName.Location = new System.Drawing.Point(234, 380);
            this.inpPartCompName.Name = "inpPartCompName";
            this.inpPartCompName.Size = new System.Drawing.Size(226, 22);
            this.inpPartCompName.TabIndex = 23;
            this.toolTip.SetToolTip(this.inpPartCompName, "Name of company that provides outsourced part");
            this.inpPartCompName.Visible = false;
            // 
            // inpPartInvMax
            // 
            this.inpPartInvMax.Location = new System.Drawing.Point(386, 329);
            this.inpPartInvMax.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.inpPartInvMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpPartInvMax.Name = "inpPartInvMax";
            this.inpPartInvMax.Size = new System.Drawing.Size(74, 22);
            this.inpPartInvMax.TabIndex = 25;
            this.toolTip.SetToolTip(this.inpPartInvMax, "Minimum Inventory Count");
            this.inpPartInvMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPartInvMax
            // 
            this.lblPartInvMax.AutoSize = true;
            this.lblPartInvMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartInvMax.Location = new System.Drawing.Point(333, 331);
            this.lblPartInvMax.Name = "lblPartInvMax";
            this.lblPartInvMax.Size = new System.Drawing.Size(40, 20);
            this.lblPartInvMax.TabIndex = 24;
            this.lblPartInvMax.Text = "Max";
            this.lblPartInvMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inpPartCost
            // 
            this.inpPartCost.Location = new System.Drawing.Point(234, 225);
            this.inpPartCost.Name = "inpPartCost";
            this.inpPartCost.Size = new System.Drawing.Size(226, 22);
            this.inpPartCost.TabIndex = 26;
            this.inpPartCost.Text = "0";
            this.toolTip.SetToolTip(this.inpPartCost, "Cost of part");
            this.inpPartCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inpPartCost_KeyPress);
            // 
            // btnCancelAction
            // 
            this.btnCancelAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAction.Location = new System.Drawing.Point(355, 449);
            this.btnCancelAction.Name = "btnCancelAction";
            this.btnCancelAction.Size = new System.Drawing.Size(95, 31);
            this.btnCancelAction.TabIndex = 27;
            this.btnCancelAction.Text = "Cancel";
            this.btnCancelAction.UseVisualStyleBackColor = true;
            // 
            // lblAddPartTitle
            // 
            this.lblAddPartTitle.AutoSize = true;
            this.lblAddPartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPartTitle.Location = new System.Drawing.Point(23, 20);
            this.lblAddPartTitle.Name = "lblAddPartTitle";
            this.lblAddPartTitle.Size = new System.Drawing.Size(97, 26);
            this.lblAddPartTitle.TabIndex = 28;
            this.lblAddPartTitle.Text = "Add Part";
            this.lblAddPartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModifyPartTitle
            // 
            this.lblModifyPartTitle.AutoSize = true;
            this.lblModifyPartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyPartTitle.Location = new System.Drawing.Point(23, 20);
            this.lblModifyPartTitle.Name = "lblModifyPartTitle";
            this.lblModifyPartTitle.Size = new System.Drawing.Size(122, 26);
            this.lblModifyPartTitle.TabIndex = 29;
            this.lblModifyPartTitle.Text = "Modify Part";
            this.lblModifyPartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 501);
            this.Controls.Add(this.lblModifyPartTitle);
            this.Controls.Add(this.lblAddPartTitle);
            this.Controls.Add(this.btnCancelAction);
            this.Controls.Add(this.inpPartCost);
            this.Controls.Add(this.inpPartInvMax);
            this.Controls.Add(this.lblPartInvMax);
            this.Controls.Add(this.inpPartCompName);
            this.Controls.Add(this.lblPartCompName);
            this.Controls.Add(this.btnModifyPart);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.inpPartInvMin);
            this.Controls.Add(this.inpPartMachineId);
            this.Controls.Add(this.inpPartInvActual);
            this.Controls.Add(this.inpPartName);
            this.Controls.Add(this.inpPartId);
            this.Controls.Add(this.lblPartName);
            this.Controls.Add(this.lblPartInvActual);
            this.Controls.Add(this.lblPartCost);
            this.Controls.Add(this.lblPartMachineId);
            this.Controls.Add(this.lblPartInvMin);
            this.Controls.Add(this.lblPartId);
            this.Controls.Add(this.radPartOutsourced);
            this.Controls.Add(this.radPartInHoust);
            this.Name = "PartView";
            this.Text = "Part";
            ((System.ComponentModel.ISupportInitialize)(this.inpPartInvActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpPartMachineId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpPartInvMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpPartInvMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radPartInHoust;
        private System.Windows.Forms.RadioButton radPartOutsourced;
        private System.Windows.Forms.Label lblPartId;
        private System.Windows.Forms.Label lblPartInvMin;
        private System.Windows.Forms.Label lblPartMachineId;
        private System.Windows.Forms.Label lblPartCost;
        private System.Windows.Forms.Label lblPartInvActual;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.TextBox inpPartId;
        private System.Windows.Forms.TextBox inpPartName;
        private System.Windows.Forms.NumericUpDown inpPartInvActual;
        private System.Windows.Forms.NumericUpDown inpPartMachineId;
        private System.Windows.Forms.NumericUpDown inpPartInvMin;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnModifyPart;
        private System.Windows.Forms.Label lblPartCompName;
        private System.Windows.Forms.TextBox inpPartCompName;
        private System.Windows.Forms.NumericUpDown inpPartInvMax;
        private System.Windows.Forms.Label lblPartInvMax;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox inpPartCost;
        private System.Windows.Forms.Button btnCancelAction;
        private System.Windows.Forms.Label lblAddPartTitle;
        private System.Windows.Forms.Label lblModifyPartTitle;
    }
}