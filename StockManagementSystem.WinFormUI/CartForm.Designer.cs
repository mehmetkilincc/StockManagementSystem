namespace StockManagementSystem.WinFormUI
{
    partial class CartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalCartPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMakeSale = new System.Windows.Forms.Button();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.lblProductAmount = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblProductId = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductAmount = new System.Windows.Forms.TextBox();
            this.txtProductTotalPrice = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtProductSalePrice = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblProductTotalPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductSalePrice = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dgwCart = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.gbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnMakeSale);
            this.panel1.Controls.Add(this.btnCancelSale);
            this.panel1.Controls.Add(this.btnRemoveFromCart);
            this.panel1.Controls.Add(this.btnAddtoCart);
            this.panel1.Controls.Add(this.gbCustomer);
            this.panel1.Controls.Add(this.gbProduct);
            this.panel1.Controls.Add(this.dgwCart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1532, 667);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.lblTotalCartPrice);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(490, 550);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(900, 31);
            this.panel4.TabIndex = 21;
            // 
            // lblTotalCartPrice
            // 
            this.lblTotalCartPrice.AutoSize = true;
            this.lblTotalCartPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalCartPrice.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalCartPrice.Location = new System.Drawing.Point(900, 0);
            this.lblTotalCartPrice.Name = "lblTotalCartPrice";
            this.lblTotalCartPrice.Size = new System.Drawing.Size(0, 26);
            this.lblTotalCartPrice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Price :";
            // 
            // btnMakeSale
            // 
            this.btnMakeSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeSale.Image = ((System.Drawing.Image)(resources.GetObject("btnMakeSale.Image")));
            this.btnMakeSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMakeSale.Location = new System.Drawing.Point(1220, 594);
            this.btnMakeSale.Name = "btnMakeSale";
            this.btnMakeSale.Size = new System.Drawing.Size(170, 32);
            this.btnMakeSale.TabIndex = 18;
            this.btnMakeSale.Text = "Make Sale";
            this.btnMakeSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMakeSale.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMakeSale.UseVisualStyleBackColor = true;
            this.btnMakeSale.Click += new System.EventHandler(this.btnMakeSale_Click);
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelSale.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelSale.Image")));
            this.btnCancelSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelSale.Location = new System.Drawing.Point(490, 594);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(170, 32);
            this.btnCancelSale.TabIndex = 18;
            this.btnCancelSale.Text = "Clear Cart";
            this.btnCancelSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelSale.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelSale.UseVisualStyleBackColor = true;
            this.btnCancelSale.Click += new System.EventHandler(this.btnCancelSale_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveFromCart.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveFromCart.Image")));
            this.btnRemoveFromCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveFromCart.Location = new System.Drawing.Point(666, 594);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(170, 32);
            this.btnRemoveFromCart.TabIndex = 19;
            this.btnRemoveFromCart.Text = "Remove From Cart";
            this.btnRemoveFromCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveFromCart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddtoCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddtoCart.Image")));
            this.btnAddtoCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddtoCart.Location = new System.Drawing.Point(202, 594);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(154, 38);
            this.btnAddtoCart.TabIndex = 20;
            this.btnAddtoCart.Text = "Add to Cart";
            this.btnAddtoCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddtoCart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.txtCustomerId);
            this.gbCustomer.Controls.Add(this.panel3);
            this.gbCustomer.Controls.Add(this.txtCustomerName);
            this.gbCustomer.Controls.Add(this.lblCustomerName);
            this.gbCustomer.Controls.Add(this.lblCustomerId);
            this.gbCustomer.Controls.Add(this.lblCustomerPhone);
            this.gbCustomer.Controls.Add(this.txtCustomerPhone);
            this.gbCustomer.Controls.Add(this.panel5);
            this.gbCustomer.Controls.Add(this.panel6);
            this.gbCustomer.Location = new System.Drawing.Point(117, 30);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(324, 222);
            this.gbCustomer.TabIndex = 16;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(38, 50);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(255, 22);
            this.txtCustomerId.TabIndex = 4;
            this.txtCustomerId.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            this.txtCustomerId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerId_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(38, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 3);
            this.panel3.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.Control;
            this.txtCustomerName.Location = new System.Drawing.Point(38, 110);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(255, 22);
            this.txtCustomerName.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerName.Location = new System.Drawing.Point(38, 88);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(80, 19);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Full Name";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerId.Location = new System.Drawing.Point(38, 30);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(93, 19);
            this.lblCustomerId.TabIndex = 3;
            this.lblCustomerId.Text = "Customer Id";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerPhone.Location = new System.Drawing.Point(38, 148);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(111, 19);
            this.lblCustomerPhone.TabIndex = 3;
            this.lblCustomerPhone.Text = "Phone Number";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.BackColor = System.Drawing.SystemColors.Control;
            this.txtCustomerPhone.Location = new System.Drawing.Point(38, 170);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.ReadOnly = true;
            this.txtCustomerPhone.Size = new System.Drawing.Size(255, 22);
            this.txtCustomerPhone.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Location = new System.Drawing.Point(38, 132);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 3);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel6.Location = new System.Drawing.Point(38, 192);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(255, 3);
            this.panel6.TabIndex = 1;
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.lblProductAmount);
            this.gbProduct.Controls.Add(this.txtProductId);
            this.gbProduct.Controls.Add(this.panel7);
            this.gbProduct.Controls.Add(this.lblProductId);
            this.gbProduct.Controls.Add(this.panel8);
            this.gbProduct.Controls.Add(this.txtProductName);
            this.gbProduct.Controls.Add(this.txtProductAmount);
            this.gbProduct.Controls.Add(this.txtProductTotalPrice);
            this.gbProduct.Controls.Add(this.panel2);
            this.gbProduct.Controls.Add(this.txtProductSalePrice);
            this.gbProduct.Controls.Add(this.panel10);
            this.gbProduct.Controls.Add(this.lblProductTotalPrice);
            this.gbProduct.Controls.Add(this.lblProductName);
            this.gbProduct.Controls.Add(this.lblProductSalePrice);
            this.gbProduct.Controls.Add(this.panel9);
            this.gbProduct.Location = new System.Drawing.Point(117, 257);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(324, 331);
            this.gbProduct.TabIndex = 17;
            this.gbProduct.TabStop = false;
            this.gbProduct.Text = "Product";
            // 
            // lblProductAmount
            // 
            this.lblProductAmount.AutoSize = true;
            this.lblProductAmount.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductAmount.Location = new System.Drawing.Point(38, 148);
            this.lblProductAmount.Name = "lblProductAmount";
            this.lblProductAmount.Size = new System.Drawing.Size(63, 19);
            this.lblProductAmount.TabIndex = 3;
            this.lblProductAmount.Text = "Amount";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(38, 50);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(255, 22);
            this.txtProductId.TabIndex = 2;
            this.txtProductId.TextChanged += new System.EventHandler(this.txtProductId_TextChanged);
            this.txtProductId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductId_KeyPress);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel7.Location = new System.Drawing.Point(38, 72);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(255, 3);
            this.panel7.TabIndex = 1;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductId.Location = new System.Drawing.Point(38, 28);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(80, 19);
            this.lblProductId.TabIndex = 3;
            this.lblProductId.Text = "Product Id";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel8.Location = new System.Drawing.Point(38, 132);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(255, 3);
            this.panel8.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(38, 110);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(255, 22);
            this.txtProductName.TabIndex = 2;
            // 
            // txtProductAmount
            // 
            this.txtProductAmount.Location = new System.Drawing.Point(38, 170);
            this.txtProductAmount.Name = "txtProductAmount";
            this.txtProductAmount.Size = new System.Drawing.Size(255, 22);
            this.txtProductAmount.TabIndex = 2;
            this.txtProductAmount.TextChanged += new System.EventHandler(this.txtProductAmount_TextChanged);
            this.txtProductAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductAmount_KeyPress);
            // 
            // txtProductTotalPrice
            // 
            this.txtProductTotalPrice.Location = new System.Drawing.Point(38, 290);
            this.txtProductTotalPrice.Name = "txtProductTotalPrice";
            this.txtProductTotalPrice.ReadOnly = true;
            this.txtProductTotalPrice.Size = new System.Drawing.Size(255, 22);
            this.txtProductTotalPrice.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(38, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 3);
            this.panel2.TabIndex = 1;
            // 
            // txtProductSalePrice
            // 
            this.txtProductSalePrice.Location = new System.Drawing.Point(38, 230);
            this.txtProductSalePrice.Name = "txtProductSalePrice";
            this.txtProductSalePrice.ReadOnly = true;
            this.txtProductSalePrice.Size = new System.Drawing.Size(255, 22);
            this.txtProductSalePrice.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel10.Location = new System.Drawing.Point(38, 252);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(255, 3);
            this.panel10.TabIndex = 1;
            // 
            // lblProductTotalPrice
            // 
            this.lblProductTotalPrice.AutoSize = true;
            this.lblProductTotalPrice.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductTotalPrice.Location = new System.Drawing.Point(38, 268);
            this.lblProductTotalPrice.Name = "lblProductTotalPrice";
            this.lblProductTotalPrice.Size = new System.Drawing.Size(84, 19);
            this.lblProductTotalPrice.TabIndex = 3;
            this.lblProductTotalPrice.Text = "Total Price";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(38, 88);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(107, 19);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductSalePrice
            // 
            this.lblProductSalePrice.AutoSize = true;
            this.lblProductSalePrice.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductSalePrice.Location = new System.Drawing.Point(38, 208);
            this.lblProductSalePrice.Name = "lblProductSalePrice";
            this.lblProductSalePrice.Size = new System.Drawing.Size(46, 19);
            this.lblProductSalePrice.TabIndex = 3;
            this.lblProductSalePrice.Text = "Price";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel9.Location = new System.Drawing.Point(38, 192);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(255, 3);
            this.panel9.TabIndex = 1;
            // 
            // dgwCart
            // 
            this.dgwCart.AllowUserToAddRows = false;
            this.dgwCart.AllowUserToDeleteRows = false;
            this.dgwCart.AllowUserToResizeColumns = false;
            this.dgwCart.AllowUserToResizeRows = false;
            this.dgwCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCart.BackgroundColor = System.Drawing.Color.White;
            this.dgwCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCart.Location = new System.Drawing.Point(490, 80);
            this.dgwCart.Name = "dgwCart";
            this.dgwCart.ReadOnly = true;
            this.dgwCart.RowHeadersWidth = 51;
            this.dgwCart.RowTemplate.Height = 24;
            this.dgwCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCart.Size = new System.Drawing.Size(900, 464);
            this.dgwCart.TabIndex = 15;
            // 
            // CartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1532, 667);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbProduct.ResumeLayout(false);
            this.gbProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalCartPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMakeSale;
        private System.Windows.Forms.Button btnCancelSale;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.Label lblProductAmount;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductAmount;
        private System.Windows.Forms.TextBox txtProductTotalPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtProductSalePrice;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblProductTotalPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductSalePrice;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dgwCart;
    }
}