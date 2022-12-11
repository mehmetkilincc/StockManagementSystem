namespace StockManagementSystem.WinFormUI
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.gbUpdateProduct = new System.Windows.Forms.GroupBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pbSearchCustomer = new System.Windows.Forms.PictureBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.gbUpdateProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.gbUpdateProduct);
            this.panel1.Controls.Add(this.lblSearchProduct);
            this.panel1.Controls.Add(this.txtSearchProduct);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.pbSearchCustomer);
            this.panel1.Controls.Add(this.btnDeleteCustomer);
            this.panel1.Controls.Add(this.dgwProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1532, 667);
            this.panel1.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.Controls.Add(this.btnAddNewProduct);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 587);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1532, 80);
            this.panel8.TabIndex = 54;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddNewProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewProduct.FlatAppearance.BorderSize = 0;
            this.btnAddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewProduct.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewProduct.Image")));
            this.btnAddNewProduct.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(1532, 80);
            this.btnAddNewProduct.TabIndex = 0;
            this.btnAddNewProduct.Text = "Add New Product";
            this.btnAddNewProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddNewProduct.UseVisualStyleBackColor = false;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // gbUpdateProduct
            // 
            this.gbUpdateProduct.Controls.Add(this.btnUpdateCustomer);
            this.gbUpdateProduct.Controls.Add(this.txtSalePrice);
            this.gbUpdateProduct.Controls.Add(this.txtPurchasePrice);
            this.gbUpdateProduct.Controls.Add(this.txtQuantity);
            this.gbUpdateProduct.Controls.Add(this.txtBrandName);
            this.gbUpdateProduct.Controls.Add(this.txtCategoryName);
            this.gbUpdateProduct.Controls.Add(this.txtProductName);
            this.gbUpdateProduct.Controls.Add(this.panel7);
            this.gbUpdateProduct.Controls.Add(this.panel6);
            this.gbUpdateProduct.Controls.Add(this.panel5);
            this.gbUpdateProduct.Controls.Add(this.panel3);
            this.gbUpdateProduct.Controls.Add(this.panel2);
            this.gbUpdateProduct.Controls.Add(this.panel4);
            this.gbUpdateProduct.Controls.Add(this.lblSalePrice);
            this.gbUpdateProduct.Controls.Add(this.lblPurchasePrice);
            this.gbUpdateProduct.Controls.Add(this.lblQuantity);
            this.gbUpdateProduct.Controls.Add(this.lblBrandName);
            this.gbUpdateProduct.Controls.Add(this.lblCategoryName);
            this.gbUpdateProduct.Controls.Add(this.lblProductName);
            this.gbUpdateProduct.Location = new System.Drawing.Point(42, 96);
            this.gbUpdateProduct.Name = "gbUpdateProduct";
            this.gbUpdateProduct.Size = new System.Drawing.Size(429, 419);
            this.gbUpdateProduct.TabIndex = 1;
            this.gbUpdateProduct.TabStop = false;
            this.gbUpdateProduct.Text = "Update Product";
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCustomer.Image")));
            this.btnUpdateCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(195, 359);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(120, 32);
            this.btnUpdateCustomer.TabIndex = 5;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(128, 313);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(255, 22);
            this.txtSalePrice.TabIndex = 4;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(128, 263);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(255, 22);
            this.txtPurchasePrice.TabIndex = 3;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(128, 207);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(255, 22);
            this.txtQuantity.TabIndex = 18;
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(128, 155);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.ReadOnly = true;
            this.txtBrandName.Size = new System.Drawing.Size(255, 22);
            this.txtBrandName.TabIndex = 17;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(128, 103);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.ReadOnly = true;
            this.txtCategoryName.Size = new System.Drawing.Size(255, 22);
            this.txtCategoryName.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(128, 52);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(255, 22);
            this.txtProductName.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel7.Location = new System.Drawing.Point(128, 335);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(255, 3);
            this.panel7.TabIndex = 48;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel6.Location = new System.Drawing.Point(128, 285);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(255, 3);
            this.panel6.TabIndex = 48;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Location = new System.Drawing.Point(128, 229);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 3);
            this.panel5.TabIndex = 48;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(128, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 3);
            this.panel3.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(128, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 3);
            this.panel2.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(128, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 3);
            this.panel4.TabIndex = 48;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalePrice.Location = new System.Drawing.Point(43, 316);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(79, 19);
            this.lblSalePrice.TabIndex = 51;
            this.lblSalePrice.Text = "Sale Price";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPurchasePrice.Location = new System.Drawing.Point(10, 266);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(112, 19);
            this.lblPurchasePrice.TabIndex = 51;
            this.lblPurchasePrice.Text = "Purchase Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.Location = new System.Drawing.Point(55, 210);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(67, 19);
            this.lblQuantity.TabIndex = 51;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrandName.Location = new System.Drawing.Point(73, 158);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(49, 19);
            this.lblBrandName.TabIndex = 0;
            this.lblBrandName.Text = "Brand";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryName.Location = new System.Drawing.Point(51, 106);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(71, 19);
            this.lblCategoryName.TabIndex = 51;
            this.lblCategoryName.Text = "Category";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(15, 55);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(107, 19);
            this.lblProductName.TabIndex = 51;
            this.lblProductName.Text = "Product Name";
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchProduct.Location = new System.Drawing.Point(1043, 48);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(88, 19);
            this.lblSearchProduct.TabIndex = 52;
            this.lblSearchProduct.Text = "Product No";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(1134, 45);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(229, 22);
            this.txtSearchProduct.TabIndex = 2;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            this.txtSearchProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchProduct_KeyPress);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel11.Location = new System.Drawing.Point(1134, 67);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(229, 3);
            this.panel11.TabIndex = 49;
            // 
            // pbSearchCustomer
            // 
            this.pbSearchCustomer.BackColor = System.Drawing.Color.Transparent;
            this.pbSearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchCustomer.Image")));
            this.pbSearchCustomer.Location = new System.Drawing.Point(1362, 45);
            this.pbSearchCustomer.Name = "pbSearchCustomer";
            this.pbSearchCustomer.Size = new System.Drawing.Size(28, 25);
            this.pbSearchCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchCustomer.TabIndex = 50;
            this.pbSearchCustomer.TabStop = false;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCustomer.Image")));
            this.btnDeleteCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(1270, 536);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(120, 34);
            this.btnDeleteCustomer.TabIndex = 3;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // dgwProduct
            // 
            this.dgwProduct.AllowUserToAddRows = false;
            this.dgwProduct.AllowUserToDeleteRows = false;
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(490, 80);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.ReadOnly = true;
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProduct.Size = new System.Drawing.Size(900, 450);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellDoubleClick);
            // 
            // ProductForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1532, 667);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.gbUpdateProduct.ResumeLayout(false);
            this.gbUpdateProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.GroupBox gbUpdateProduct;
        private System.Windows.Forms.Button btnUpdateCustomer;
        public System.Windows.Forms.TextBox txtSalePrice;
        public System.Windows.Forms.TextBox txtPurchasePrice;
        public System.Windows.Forms.TextBox txtQuantity;
        public System.Windows.Forms.TextBox txtBrandName;
        public System.Windows.Forms.TextBox txtCategoryName;
        public System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblSearchProduct;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox pbSearchCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.DataGridView dgwProduct;
    }
}