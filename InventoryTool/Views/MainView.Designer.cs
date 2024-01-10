namespace InventoryTool.Views
{
    partial class MainView
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
            this.pnlPageWrapper = new System.Windows.Forms.Panel();
            this.tblayProductContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlProductsHeadCont = new System.Windows.Forms.Panel();
            this.lblProductsTitle = new System.Windows.Forms.Label();
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.pnlProductsBtnCont = new System.Windows.Forms.Panel();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.tblayPartsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPartsHeadCon = new System.Windows.Forms.Panel();
            this.lblParts = new System.Windows.Forms.Label();
            this.dataParts = new System.Windows.Forms.DataGridView();
            this.pnlPartsBtnCon = new System.Windows.Forms.Panel();
            this.btnModifyPart = new System.Windows.Forms.Button();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.pnlExitAppContainer = new System.Windows.Forms.Panel();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.inpPartSearch = new System.Windows.Forms.TextBox();
            this.lblSearchPart = new System.Windows.Forms.Label();
            this.lblProductSearch = new System.Windows.Forms.Label();
            this.inpProductSearch = new System.Windows.Forms.TextBox();
            this.pnlPageWrapper.SuspendLayout();
            this.tblayProductContainer.SuspendLayout();
            this.pnlProductsHeadCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
            this.pnlProductsBtnCont.SuspendLayout();
            this.tblayPartsContainer.SuspendLayout();
            this.pnlPartsHeadCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataParts)).BeginInit();
            this.pnlPartsBtnCon.SuspendLayout();
            this.pnlExitAppContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPageWrapper
            // 
            this.pnlPageWrapper.AutoSize = true;
            this.pnlPageWrapper.Controls.Add(this.tblayProductContainer);
            this.pnlPageWrapper.Controls.Add(this.pnlHeader);
            this.pnlPageWrapper.Controls.Add(this.tblayPartsContainer);
            this.pnlPageWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPageWrapper.Location = new System.Drawing.Point(0, 0);
            this.pnlPageWrapper.Name = "pnlPageWrapper";
            this.pnlPageWrapper.Size = new System.Drawing.Size(1863, 652);
            this.pnlPageWrapper.TabIndex = 2;
            // 
            // tblayProductContainer
            // 
            this.tblayProductContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblayProductContainer.ColumnCount = 1;
            this.tblayProductContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblayProductContainer.Controls.Add(this.pnlProductsHeadCont, 0, 0);
            this.tblayProductContainer.Controls.Add(this.dataProducts, 0, 1);
            this.tblayProductContainer.Controls.Add(this.pnlProductsBtnCont, 0, 2);
            this.tblayProductContainer.Location = new System.Drawing.Point(958, 87);
            this.tblayProductContainer.Name = "tblayProductContainer";
            this.tblayProductContainer.RowCount = 4;
            this.tblayProductContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblayProductContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblayProductContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblayProductContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblayProductContainer.Size = new System.Drawing.Size(879, 441);
            this.tblayProductContainer.TabIndex = 4;
            // 
            // pnlProductsHeadCont
            // 
            this.pnlProductsHeadCont.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlProductsHeadCont.Controls.Add(this.lblProductSearch);
            this.pnlProductsHeadCont.Controls.Add(this.lblProductsTitle);
            this.pnlProductsHeadCont.Controls.Add(this.inpProductSearch);
            this.pnlProductsHeadCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductsHeadCont.Location = new System.Drawing.Point(3, 3);
            this.pnlProductsHeadCont.Name = "pnlProductsHeadCont";
            this.pnlProductsHeadCont.Size = new System.Drawing.Size(873, 38);
            this.pnlProductsHeadCont.TabIndex = 0;
            // 
            // lblProductsTitle
            // 
            this.lblProductsTitle.AutoSize = true;
            this.lblProductsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsTitle.Location = new System.Drawing.Point(4, 5);
            this.lblProductsTitle.Name = "lblProductsTitle";
            this.lblProductsTitle.Size = new System.Drawing.Size(113, 29);
            this.lblProductsTitle.TabIndex = 0;
            this.lblProductsTitle.Text = "Products";
            // 
            // dataProducts
            // 
            this.dataProducts.AllowUserToAddRows = false;
            this.dataProducts.AllowUserToDeleteRows = false;
            this.dataProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataProducts.Location = new System.Drawing.Point(3, 47);
            this.dataProducts.Name = "dataProducts";
            this.dataProducts.RowHeadersWidth = 51;
            this.dataProducts.RowTemplate.Height = 24;
            this.dataProducts.Size = new System.Drawing.Size(873, 302);
            this.dataProducts.TabIndex = 1;
            // 
            // pnlProductsBtnCont
            // 
            this.pnlProductsBtnCont.Controls.Add(this.btnModifyProduct);
            this.pnlProductsBtnCont.Controls.Add(this.btnDeleteProduct);
            this.pnlProductsBtnCont.Controls.Add(this.btnAddProduct);
            this.pnlProductsBtnCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductsBtnCont.Location = new System.Drawing.Point(3, 355);
            this.pnlProductsBtnCont.Name = "pnlProductsBtnCont";
            this.pnlProductsBtnCont.Size = new System.Drawing.Size(873, 38);
            this.pnlProductsBtnCont.TabIndex = 2;
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyProduct.Location = new System.Drawing.Point(670, 3);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(95, 31);
            this.btnModifyProduct.TabIndex = 2;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(781, 3);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(95, 31);
            this.btnDeleteProduct.TabIndex = 1;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(560, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(95, 31);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1863, 63);
            this.pnlHeader.TabIndex = 1;
            // 
            // tblayPartsContainer
            // 
            this.tblayPartsContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblayPartsContainer.ColumnCount = 1;
            this.tblayPartsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblayPartsContainer.Controls.Add(this.pnlPartsHeadCon, 0, 0);
            this.tblayPartsContainer.Controls.Add(this.dataParts, 0, 1);
            this.tblayPartsContainer.Controls.Add(this.pnlPartsBtnCon, 0, 2);
            this.tblayPartsContainer.Controls.Add(this.pnlExitAppContainer, 0, 3);
            this.tblayPartsContainer.Location = new System.Drawing.Point(28, 87);
            this.tblayPartsContainer.Name = "tblayPartsContainer";
            this.tblayPartsContainer.RowCount = 4;
            this.tblayPartsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblayPartsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblayPartsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblayPartsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblayPartsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblayPartsContainer.Size = new System.Drawing.Size(885, 441);
            this.tblayPartsContainer.TabIndex = 2;
            // 
            // pnlPartsHeadCon
            // 
            this.pnlPartsHeadCon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlPartsHeadCon.Controls.Add(this.lblSearchPart);
            this.pnlPartsHeadCon.Controls.Add(this.inpPartSearch);
            this.pnlPartsHeadCon.Controls.Add(this.lblParts);
            this.pnlPartsHeadCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPartsHeadCon.Location = new System.Drawing.Point(3, 3);
            this.pnlPartsHeadCon.Name = "pnlPartsHeadCon";
            this.pnlPartsHeadCon.Size = new System.Drawing.Size(879, 38);
            this.pnlPartsHeadCon.TabIndex = 0;
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParts.Location = new System.Drawing.Point(4, 5);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(72, 29);
            this.lblParts.TabIndex = 0;
            this.lblParts.Text = "Parts";
            // 
            // dataParts
            // 
            this.dataParts.AllowUserToAddRows = false;
            this.dataParts.AllowUserToDeleteRows = false;
            this.dataParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataParts.Location = new System.Drawing.Point(3, 47);
            this.dataParts.Name = "dataParts";
            this.dataParts.RowHeadersWidth = 51;
            this.dataParts.RowTemplate.Height = 24;
            this.dataParts.Size = new System.Drawing.Size(879, 302);
            this.dataParts.TabIndex = 1;
            // 
            // pnlPartsBtnCon
            // 
            this.pnlPartsBtnCon.Controls.Add(this.btnModifyPart);
            this.pnlPartsBtnCon.Controls.Add(this.btnDeletePart);
            this.pnlPartsBtnCon.Controls.Add(this.btnAddPart);
            this.pnlPartsBtnCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPartsBtnCon.Location = new System.Drawing.Point(3, 355);
            this.pnlPartsBtnCon.Name = "pnlPartsBtnCon";
            this.pnlPartsBtnCon.Size = new System.Drawing.Size(879, 38);
            this.pnlPartsBtnCon.TabIndex = 2;
            // 
            // btnModifyPart
            // 
            this.btnModifyPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyPart.Location = new System.Drawing.Point(670, 3);
            this.btnModifyPart.Name = "btnModifyPart";
            this.btnModifyPart.Size = new System.Drawing.Size(95, 31);
            this.btnModifyPart.TabIndex = 2;
            this.btnModifyPart.Text = "Modify";
            this.btnModifyPart.UseVisualStyleBackColor = true;
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePart.Location = new System.Drawing.Point(781, 3);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(95, 31);
            this.btnDeletePart.TabIndex = 1;
            this.btnDeletePart.Text = "Delete";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            // 
            // btnAddPart
            // 
            this.btnAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPart.Location = new System.Drawing.Point(560, 3);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(95, 31);
            this.btnAddPart.TabIndex = 0;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            // 
            // pnlExitAppContainer
            // 
            this.pnlExitAppContainer.Controls.Add(this.btnExitApplication);
            this.pnlExitAppContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExitAppContainer.Location = new System.Drawing.Point(3, 399);
            this.pnlExitAppContainer.Name = "pnlExitAppContainer";
            this.pnlExitAppContainer.Size = new System.Drawing.Size(879, 39);
            this.pnlExitAppContainer.TabIndex = 3;
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitApplication.Location = new System.Drawing.Point(781, 5);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(95, 31);
            this.btnExitApplication.TabIndex = 3;
            this.btnExitApplication.Text = "Exit";
            this.btnExitApplication.UseVisualStyleBackColor = true;
            // 
            // inpPartSearch
            // 
            this.inpPartSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpPartSearch.Location = new System.Drawing.Point(521, 6);
            this.inpPartSearch.Name = "inpPartSearch";
            this.inpPartSearch.Size = new System.Drawing.Size(355, 27);
            this.inpPartSearch.TabIndex = 0;
            this.inpPartSearch.TextChanged += new System.EventHandler(this.inpPartSearch_TextChanged);
            // 
            // lblSearchPart
            // 
            this.lblSearchPart.AutoSize = true;
            this.lblSearchPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPart.Location = new System.Drawing.Point(422, 4);
            this.lblSearchPart.Name = "lblSearchPart";
            this.lblSearchPart.Size = new System.Drawing.Size(93, 29);
            this.lblSearchPart.TabIndex = 1;
            this.lblSearchPart.Text = "Search";
            // 
            // lblProductSearch
            // 
            this.lblProductSearch.AutoSize = true;
            this.lblProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSearch.Location = new System.Drawing.Point(416, 5);
            this.lblProductSearch.Name = "lblProductSearch";
            this.lblProductSearch.Size = new System.Drawing.Size(93, 29);
            this.lblProductSearch.TabIndex = 3;
            this.lblProductSearch.Text = "Search";
            // 
            // inpProductSearch
            // 
            this.inpProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpProductSearch.Location = new System.Drawing.Point(515, 7);
            this.inpProductSearch.Name = "inpProductSearch";
            this.inpProductSearch.Size = new System.Drawing.Size(355, 27);
            this.inpProductSearch.TabIndex = 2;
            this.inpProductSearch.TextChanged += new System.EventHandler(this.inpProductSearch_TextChanged);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1863, 652);
            this.Controls.Add(this.pnlPageWrapper);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.pnlPageWrapper.ResumeLayout(false);
            this.tblayProductContainer.ResumeLayout(false);
            this.pnlProductsHeadCont.ResumeLayout(false);
            this.pnlProductsHeadCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            this.pnlProductsBtnCont.ResumeLayout(false);
            this.tblayPartsContainer.ResumeLayout(false);
            this.pnlPartsHeadCon.ResumeLayout(false);
            this.pnlPartsHeadCon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataParts)).EndInit();
            this.pnlPartsBtnCon.ResumeLayout(false);
            this.pnlExitAppContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlPageWrapper;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TableLayoutPanel tblayPartsContainer;
        private System.Windows.Forms.Panel pnlPartsHeadCon;
        private System.Windows.Forms.DataGridView dataParts;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Panel pnlPartsBtnCon;
        private System.Windows.Forms.Button btnModifyPart;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnExitApplication;
        private System.Windows.Forms.Panel pnlExitAppContainer;
        private System.Windows.Forms.TableLayoutPanel tblayProductContainer;
        private System.Windows.Forms.Panel pnlProductsHeadCont;
        private System.Windows.Forms.Label lblProductsTitle;
        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.Panel pnlProductsBtnCont;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblProductSearch;
        private System.Windows.Forms.TextBox inpProductSearch;
        private System.Windows.Forms.Label lblSearchPart;
        private System.Windows.Forms.TextBox inpPartSearch;
    }
}

