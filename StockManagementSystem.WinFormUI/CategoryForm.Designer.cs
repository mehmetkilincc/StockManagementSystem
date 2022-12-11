namespace StockManagementSystem.WinFormUI
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.btnDeleteBrand = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.gbBrand = new System.Windows.Forms.GroupBox();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.cbCategoryName = new System.Windows.Forms.ComboBox();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.lblCategoryName2 = new System.Windows.Forms.Label();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.dgwBrand = new System.Windows.Forms.DataGridView();
            this.dgwCategory = new System.Windows.Forms.DataGridView();
            this.gbBrand.SuspendLayout();
            this.gbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteBrand
            // 
            this.btnDeleteBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBrand.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBrand.Image")));
            this.btnDeleteBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBrand.Location = new System.Drawing.Point(1148, 587);
            this.btnDeleteBrand.Name = "btnDeleteBrand";
            this.btnDeleteBrand.Size = new System.Drawing.Size(140, 34);
            this.btnDeleteBrand.TabIndex = 16;
            this.btnDeleteBrand.Text = "Delete Brand";
            this.btnDeleteBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteBrand.UseVisualStyleBackColor = true;
            this.btnDeleteBrand.Click += new System.EventHandler(this.btnDeleteBrand_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategory.Image")));
            this.btnDeleteCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCategory.Location = new System.Drawing.Point(468, 588);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(145, 34);
            this.btnDeleteCategory.TabIndex = 14;
            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // gbBrand
            // 
            this.gbBrand.Controls.Add(this.btnAddBrand);
            this.gbBrand.Controls.Add(this.cbCategoryName);
            this.gbBrand.Controls.Add(this.txtBrandName);
            this.gbBrand.Controls.Add(this.panel1);
            this.gbBrand.Controls.Add(this.lblBrandName);
            this.gbBrand.Controls.Add(this.lblCategoryName2);
            this.gbBrand.Location = new System.Drawing.Point(826, 45);
            this.gbBrand.Name = "gbBrand";
            this.gbBrand.Size = new System.Drawing.Size(462, 197);
            this.gbBrand.TabIndex = 15;
            this.gbBrand.TabStop = false;
            this.gbBrand.Text = "Add Brand";
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBrand.Image")));
            this.btnAddBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBrand.Location = new System.Drawing.Point(216, 138);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(150, 35);
            this.btnAddBrand.TabIndex = 2;
            this.btnAddBrand.Text = "Add Brand";
            this.btnAddBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddBrand.UseVisualStyleBackColor = true;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // cbCategoryName
            // 
            this.cbCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryName.FormattingEnabled = true;
            this.cbCategoryName.Location = new System.Drawing.Point(111, 53);
            this.cbCategoryName.Name = "cbCategoryName";
            this.cbCategoryName.Size = new System.Drawing.Size(255, 24);
            this.cbCategoryName.TabIndex = 0;
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(111, 107);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(255, 22);
            this.txtBrandName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(111, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 3);
            this.panel1.TabIndex = 41;
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrandName.Location = new System.Drawing.Point(107, 86);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(93, 19);
            this.lblBrandName.TabIndex = 42;
            this.lblBrandName.Text = "Brand Name";
            // 
            // lblCategoryName2
            // 
            this.lblCategoryName2.AutoSize = true;
            this.lblCategoryName2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryName2.Location = new System.Drawing.Point(107, 31);
            this.lblCategoryName2.Name = "lblCategoryName2";
            this.lblCategoryName2.Size = new System.Drawing.Size(115, 19);
            this.lblCategoryName2.TabIndex = 42;
            this.lblCategoryName2.Text = "Category Name";
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.btnAddCategory);
            this.gbCategory.Controls.Add(this.txtCategoryName);
            this.gbCategory.Controls.Add(this.panel4);
            this.gbCategory.Controls.Add(this.lblCategoryName);
            this.gbCategory.Location = new System.Drawing.Point(244, 45);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(369, 177);
            this.gbCategory.TabIndex = 13;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Add Category";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Image")));
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.Location = new System.Drawing.Point(155, 105);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(150, 35);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(50, 65);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(255, 22);
            this.txtCategoryName.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(50, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 3);
            this.panel4.TabIndex = 41;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryName.Location = new System.Drawing.Point(50, 43);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(115, 19);
            this.lblCategoryName.TabIndex = 42;
            this.lblCategoryName.Text = "Category Name";
            // 
            // dgwBrand
            // 
            this.dgwBrand.AllowUserToAddRows = false;
            this.dgwBrand.AllowUserToDeleteRows = false;
            this.dgwBrand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBrand.BackgroundColor = System.Drawing.Color.White;
            this.dgwBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBrand.Location = new System.Drawing.Point(826, 280);
            this.dgwBrand.Name = "dgwBrand";
            this.dgwBrand.ReadOnly = true;
            this.dgwBrand.RowHeadersWidth = 51;
            this.dgwBrand.RowTemplate.Height = 24;
            this.dgwBrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwBrand.Size = new System.Drawing.Size(462, 301);
            this.dgwBrand.TabIndex = 11;
            // 
            // dgwCategory
            // 
            this.dgwCategory.AllowUserToAddRows = false;
            this.dgwCategory.AllowUserToDeleteRows = false;
            this.dgwCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgwCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCategory.Location = new System.Drawing.Point(244, 280);
            this.dgwCategory.Name = "dgwCategory";
            this.dgwCategory.ReadOnly = true;
            this.dgwCategory.RowHeadersWidth = 51;
            this.dgwCategory.RowTemplate.Height = 24;
            this.dgwCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCategory.Size = new System.Drawing.Size(369, 301);
            this.dgwCategory.TabIndex = 12;
            // 
            // CategoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1532, 667);
            this.Controls.Add(this.btnDeleteBrand);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.gbBrand);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.dgwBrand);
            this.Controls.Add(this.dgwCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.Text = "CategoryPage";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.gbBrand.ResumeLayout(false);
            this.gbBrand.PerformLayout();
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteBrand;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.GroupBox gbBrand;
        private System.Windows.Forms.Button btnAddBrand;
        private System.Windows.Forms.ComboBox cbCategoryName;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblCategoryName2;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.DataGridView dgwBrand;
        private System.Windows.Forms.DataGridView dgwCategory;
    }
}