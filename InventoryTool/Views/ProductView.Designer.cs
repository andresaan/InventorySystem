namespace InventoryTool.Views
{
    partial class ProductView
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
            this.lblModifyProductTitle = new System.Windows.Forms.Label();
            this.lblAddProductTitle = new System.Windows.Forms.Label();
            this.btnCancelAction = new System.Windows.Forms.Button();
            this.inpProductCost = new System.Windows.Forms.TextBox();
            this.inpProductInvMax = new System.Windows.Forms.NumericUpDown();
            this.lblProductInvMax = new System.Windows.Forms.Label();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.inpProductInvMin = new System.Windows.Forms.NumericUpDown();
            this.inpProductInvActual = new System.Windows.Forms.NumericUpDown();
            this.inpProductName = new System.Windows.Forms.TextBox();
            this.inpProductId = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductInvActual = new System.Windows.Forms.Label();
            this.lblProductCost = new System.Windows.Forms.Label();
            this.lblProductInvMin = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.tblayPartsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPartsHeadCon = new System.Windows.Forms.Panel();
            this.lblSearchCanPart = new System.Windows.Forms.Label();
            this.lblParts = new System.Windows.Forms.Label();
            this.inpCanPartSearch = new System.Windows.Forms.TextBox();
            this.dataCandidateParts = new System.Windows.Forms.DataGridView();
            this.pnlPartsBtnCon = new System.Windows.Forms.Panel();
            this.btnAddPartToProduct = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAssocPartSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inpAssocPartSearch = new System.Windows.Forms.TextBox();
            this.dataAssociatedParts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeletePartFromProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inpProductInvMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpProductInvMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpProductInvActual)).BeginInit();
            this.tblayPartsContainer.SuspendLayout();
            this.pnlPartsHeadCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCandidateParts)).BeginInit();
            this.pnlPartsBtnCon.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAssociatedParts)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModifyProductTitle
            // 
            this.lblModifyProductTitle.AutoSize = true;
            this.lblModifyProductTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyProductTitle.Location = new System.Drawing.Point(12, 9);
            this.lblModifyProductTitle.Name = "lblModifyProductTitle";
            this.lblModifyProductTitle.Size = new System.Drawing.Size(157, 26);
            this.lblModifyProductTitle.TabIndex = 52;
            this.lblModifyProductTitle.Text = "Modify Product";
            this.lblModifyProductTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddProductTitle
            // 
            this.lblAddProductTitle.AutoSize = true;
            this.lblAddProductTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProductTitle.Location = new System.Drawing.Point(12, 9);
            this.lblAddProductTitle.Name = "lblAddProductTitle";
            this.lblAddProductTitle.Size = new System.Drawing.Size(132, 26);
            this.lblAddProductTitle.TabIndex = 51;
            this.lblAddProductTitle.Text = "Add Product";
            this.lblAddProductTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancelAction
            // 
            this.btnCancelAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAction.Location = new System.Drawing.Point(306, 499);
            this.btnCancelAction.Name = "btnCancelAction";
            this.btnCancelAction.Size = new System.Drawing.Size(95, 31);
            this.btnCancelAction.TabIndex = 50;
            this.btnCancelAction.Text = "Cancel";
            this.btnCancelAction.UseVisualStyleBackColor = true;
            // 
            // inpProductCost
            // 
            this.inpProductCost.Location = new System.Drawing.Point(175, 336);
            this.inpProductCost.Name = "inpProductCost";
            this.inpProductCost.Size = new System.Drawing.Size(226, 22);
            this.inpProductCost.TabIndex = 49;
            this.inpProductCost.Text = "0";
            // 
            // inpProductInvMax
            // 
            this.inpProductInvMax.Location = new System.Drawing.Point(327, 440);
            this.inpProductInvMax.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.inpProductInvMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpProductInvMax.Name = "inpProductInvMax";
            this.inpProductInvMax.Size = new System.Drawing.Size(74, 22);
            this.inpProductInvMax.TabIndex = 48;
            this.inpProductInvMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblProductInvMax
            // 
            this.lblProductInvMax.AutoSize = true;
            this.lblProductInvMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductInvMax.Location = new System.Drawing.Point(274, 442);
            this.lblProductInvMax.Name = "lblProductInvMax";
            this.lblProductInvMax.Size = new System.Drawing.Size(40, 20);
            this.lblProductInvMax.TabIndex = 47;
            this.lblProductInvMax.Text = "Max";
            this.lblProductInvMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyProduct.Location = new System.Drawing.Point(155, 499);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(95, 31);
            this.btnModifyProduct.TabIndex = 44;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            this.btnModifyProduct.Visible = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(154, 499);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(95, 31);
            this.btnAddProduct.TabIndex = 43;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Visible = false;
            // 
            // inpProductInvMin
            // 
            this.inpProductInvMin.AccessibleDescription = "Minimum Inventory Count";
            this.inpProductInvMin.Location = new System.Drawing.Point(175, 440);
            this.inpProductInvMin.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.inpProductInvMin.Name = "inpProductInvMin";
            this.inpProductInvMin.Size = new System.Drawing.Size(74, 22);
            this.inpProductInvMin.TabIndex = 42;
            // 
            // inpProductInvActual
            // 
            this.inpProductInvActual.Location = new System.Drawing.Point(175, 388);
            this.inpProductInvActual.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.inpProductInvActual.Name = "inpProductInvActual";
            this.inpProductInvActual.Size = new System.Drawing.Size(226, 22);
            this.inpProductInvActual.TabIndex = 40;
            // 
            // inpProductName
            // 
            this.inpProductName.Location = new System.Drawing.Point(175, 284);
            this.inpProductName.Name = "inpProductName";
            this.inpProductName.Size = new System.Drawing.Size(226, 22);
            this.inpProductName.TabIndex = 39;
            // 
            // inpProductId
            // 
            this.inpProductId.Cursor = System.Windows.Forms.Cursors.No;
            this.inpProductId.Location = new System.Drawing.Point(175, 232);
            this.inpProductId.Name = "inpProductId";
            this.inpProductId.ReadOnly = true;
            this.inpProductId.Size = new System.Drawing.Size(226, 22);
            this.inpProductId.TabIndex = 38;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(105, 286);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(53, 20);
            this.lblProductName.TabIndex = 37;
            this.lblProductName.Text = "Name";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductInvActual
            // 
            this.lblProductInvActual.AutoSize = true;
            this.lblProductInvActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductInvActual.Location = new System.Drawing.Point(82, 390);
            this.lblProductInvActual.Name = "lblProductInvActual";
            this.lblProductInvActual.Size = new System.Drawing.Size(76, 20);
            this.lblProductInvActual.TabIndex = 36;
            this.lblProductInvActual.Text = "Inventory";
            this.lblProductInvActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductCost
            // 
            this.lblProductCost.AutoSize = true;
            this.lblProductCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCost.Location = new System.Drawing.Point(60, 338);
            this.lblProductCost.Name = "lblProductCost";
            this.lblProductCost.Size = new System.Drawing.Size(98, 20);
            this.lblProductCost.TabIndex = 35;
            this.lblProductCost.Text = "Price / Cost";
            this.lblProductCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductInvMin
            // 
            this.lblProductInvMin.AutoSize = true;
            this.lblProductInvMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductInvMin.Location = new System.Drawing.Point(122, 442);
            this.lblProductInvMin.Name = "lblProductInvMin";
            this.lblProductInvMin.Size = new System.Drawing.Size(36, 20);
            this.lblProductInvMin.TabIndex = 33;
            this.lblProductInvMin.Text = "Min";
            this.lblProductInvMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(132, 234);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(26, 20);
            this.lblProductId.TabIndex = 32;
            this.lblProductId.Text = "ID";
            this.lblProductId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblayPartsContainer
            // 
            this.tblayPartsContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblayPartsContainer.ColumnCount = 1;
            this.tblayPartsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblayPartsContainer.Controls.Add(this.pnlPartsHeadCon, 0, 0);
            this.tblayPartsContainer.Controls.Add(this.dataCandidateParts, 0, 1);
            this.tblayPartsContainer.Controls.Add(this.pnlPartsBtnCon, 0, 2);
            this.tblayPartsContainer.Location = new System.Drawing.Point(597, 49);
            this.tblayPartsContainer.Name = "tblayPartsContainer";
            this.tblayPartsContainer.RowCount = 3;
            this.tblayPartsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tblayPartsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tblayPartsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tblayPartsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblayPartsContainer.Size = new System.Drawing.Size(813, 291);
            this.tblayPartsContainer.TabIndex = 53;
            // 
            // pnlPartsHeadCon
            // 
            this.pnlPartsHeadCon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlPartsHeadCon.Controls.Add(this.lblSearchCanPart);
            this.pnlPartsHeadCon.Controls.Add(this.lblParts);
            this.pnlPartsHeadCon.Controls.Add(this.inpCanPartSearch);
            this.pnlPartsHeadCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPartsHeadCon.Location = new System.Drawing.Point(3, 3);
            this.pnlPartsHeadCon.Name = "pnlPartsHeadCon";
            this.pnlPartsHeadCon.Size = new System.Drawing.Size(807, 40);
            this.pnlPartsHeadCon.TabIndex = 0;
            // 
            // lblSearchCanPart
            // 
            this.lblSearchCanPart.AutoSize = true;
            this.lblSearchCanPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCanPart.Location = new System.Drawing.Point(381, 11);
            this.lblSearchCanPart.Name = "lblSearchCanPart";
            this.lblSearchCanPart.Size = new System.Drawing.Size(62, 20);
            this.lblSearchCanPart.TabIndex = 56;
            this.lblSearchCanPart.Text = "Search";
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParts.Location = new System.Drawing.Point(12, 9);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(164, 22);
            this.lblParts.TabIndex = 0;
            this.lblParts.Text = "All Candidate Parts";
            // 
            // inpCanPartSearch
            // 
            this.inpCanPartSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpCanPartSearch.Location = new System.Drawing.Point(449, 8);
            this.inpCanPartSearch.Name = "inpCanPartSearch";
            this.inpCanPartSearch.Size = new System.Drawing.Size(355, 27);
            this.inpCanPartSearch.TabIndex = 55;
            this.inpCanPartSearch.TextChanged += new System.EventHandler(this.inpCanPartSearch_TextChanged);
            // 
            // dataCandidateParts
            // 
            this.dataCandidateParts.AllowUserToAddRows = false;
            this.dataCandidateParts.AllowUserToDeleteRows = false;
            this.dataCandidateParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCandidateParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCandidateParts.Location = new System.Drawing.Point(3, 49);
            this.dataCandidateParts.Name = "dataCandidateParts";
            this.dataCandidateParts.RowHeadersWidth = 51;
            this.dataCandidateParts.RowTemplate.Height = 24;
            this.dataCandidateParts.Size = new System.Drawing.Size(807, 203);
            this.dataCandidateParts.TabIndex = 1;
            // 
            // pnlPartsBtnCon
            // 
            this.pnlPartsBtnCon.Controls.Add(this.btnAddPartToProduct);
            this.pnlPartsBtnCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPartsBtnCon.Location = new System.Drawing.Point(3, 258);
            this.pnlPartsBtnCon.Name = "pnlPartsBtnCon";
            this.pnlPartsBtnCon.Size = new System.Drawing.Size(807, 30);
            this.pnlPartsBtnCon.TabIndex = 2;
            // 
            // btnAddPartToProduct
            // 
            this.btnAddPartToProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPartToProduct.Location = new System.Drawing.Point(741, 3);
            this.btnAddPartToProduct.Name = "btnAddPartToProduct";
            this.btnAddPartToProduct.Size = new System.Drawing.Size(63, 27);
            this.btnAddPartToProduct.TabIndex = 0;
            this.btnAddPartToProduct.Text = "Add";
            this.btnAddPartToProduct.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataAssociatedParts, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(597, 389);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(813, 291);
            this.tableLayoutPanel1.TabIndex = 54;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lblAssocPartSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inpAssocPartSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 40);
            this.panel1.TabIndex = 0;
            // 
            // lblAssocPartSearch
            // 
            this.lblAssocPartSearch.AutoSize = true;
            this.lblAssocPartSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssocPartSearch.Location = new System.Drawing.Point(381, 11);
            this.lblAssocPartSearch.Name = "lblAssocPartSearch";
            this.lblAssocPartSearch.Size = new System.Drawing.Size(62, 20);
            this.lblAssocPartSearch.TabIndex = 58;
            this.lblAssocPartSearch.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts Associated with this Product";
            // 
            // inpAssocPartSearch
            // 
            this.inpAssocPartSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpAssocPartSearch.Location = new System.Drawing.Point(449, 8);
            this.inpAssocPartSearch.Name = "inpAssocPartSearch";
            this.inpAssocPartSearch.Size = new System.Drawing.Size(355, 27);
            this.inpAssocPartSearch.TabIndex = 57;
            this.inpAssocPartSearch.TextChanged += new System.EventHandler(this.inpAssocPartSearch_TextChanged);
            // 
            // dataAssociatedParts
            // 
            this.dataAssociatedParts.AllowUserToAddRows = false;
            this.dataAssociatedParts.AllowUserToDeleteRows = false;
            this.dataAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAssociatedParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataAssociatedParts.Location = new System.Drawing.Point(3, 49);
            this.dataAssociatedParts.Name = "dataAssociatedParts";
            this.dataAssociatedParts.RowHeadersWidth = 51;
            this.dataAssociatedParts.RowTemplate.Height = 24;
            this.dataAssociatedParts.Size = new System.Drawing.Size(807, 203);
            this.dataAssociatedParts.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeletePartFromProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 30);
            this.panel2.TabIndex = 2;
            // 
            // btnDeletePartFromProduct
            // 
            this.btnDeletePartFromProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePartFromProduct.Location = new System.Drawing.Point(741, 3);
            this.btnDeletePartFromProduct.Name = "btnDeletePartFromProduct";
            this.btnDeletePartFromProduct.Size = new System.Drawing.Size(63, 27);
            this.btnDeletePartFromProduct.TabIndex = 0;
            this.btnDeletePartFromProduct.Text = "Delete";
            this.btnDeletePartFromProduct.UseVisualStyleBackColor = true;
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tblayPartsContainer);
            this.Controls.Add(this.lblModifyProductTitle);
            this.Controls.Add(this.lblAddProductTitle);
            this.Controls.Add(this.btnCancelAction);
            this.Controls.Add(this.inpProductCost);
            this.Controls.Add(this.inpProductInvMax);
            this.Controls.Add(this.lblProductInvMax);
            this.Controls.Add(this.btnModifyProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.inpProductInvMin);
            this.Controls.Add(this.inpProductInvActual);
            this.Controls.Add(this.inpProductName);
            this.Controls.Add(this.inpProductId);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductInvActual);
            this.Controls.Add(this.lblProductCost);
            this.Controls.Add(this.lblProductInvMin);
            this.Controls.Add(this.lblProductId);
            this.Name = "ProductView";
            this.Text = "ProductView";
            ((System.ComponentModel.ISupportInitialize)(this.inpProductInvMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpProductInvMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpProductInvActual)).EndInit();
            this.tblayPartsContainer.ResumeLayout(false);
            this.pnlPartsHeadCon.ResumeLayout(false);
            this.pnlPartsHeadCon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCandidateParts)).EndInit();
            this.pnlPartsBtnCon.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAssociatedParts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModifyProductTitle;
        private System.Windows.Forms.Label lblAddProductTitle;
        private System.Windows.Forms.Button btnCancelAction;
        private System.Windows.Forms.TextBox inpProductCost;
        private System.Windows.Forms.NumericUpDown inpProductInvMax;
        private System.Windows.Forms.Label lblProductInvMax;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.NumericUpDown inpProductInvMin;
        private System.Windows.Forms.NumericUpDown inpProductInvActual;
        private System.Windows.Forms.TextBox inpProductName;
        private System.Windows.Forms.TextBox inpProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductInvActual;
        private System.Windows.Forms.Label lblProductCost;
        private System.Windows.Forms.Label lblProductInvMin;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TableLayoutPanel tblayPartsContainer;
        private System.Windows.Forms.Panel pnlPartsHeadCon;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.DataGridView dataCandidateParts;
        private System.Windows.Forms.Panel pnlPartsBtnCon;
        private System.Windows.Forms.Button btnAddPartToProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataAssociatedParts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeletePartFromProduct;
        private System.Windows.Forms.Label lblSearchCanPart;
        private System.Windows.Forms.TextBox inpCanPartSearch;
        private System.Windows.Forms.Label lblAssocPartSearch;
        private System.Windows.Forms.TextBox inpAssocPartSearch;
    }
}