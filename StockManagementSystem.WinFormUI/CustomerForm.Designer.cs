namespace StockManagementSystem.WinFormUI
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pbSearchCustomer = new System.Windows.Forms.PictureBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.gbUpdateCustomer = new System.Windows.Forms.GroupBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.txtCustomerMail = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCustomerMail = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.dgwCustomer = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchCustomer)).BeginInit();
            this.gbUpdateCustomer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblSearchCustomer);
            this.panel1.Controls.Add(this.txtSearchCustomer);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.pbSearchCustomer);
            this.panel1.Controls.Add(this.btnDeleteCustomer);
            this.panel1.Controls.Add(this.gbUpdateCustomer);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgwCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1532, 667);
            this.panel1.TabIndex = 1;
            // 
            // lblSearchCustomer
            // 
            this.lblSearchCustomer.AutoSize = true;
            this.lblSearchCustomer.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchCustomer.Location = new System.Drawing.Point(1031, 48);
            this.lblSearchCustomer.Name = "lblSearchCustomer";
            this.lblSearchCustomer.Size = new System.Drawing.Size(101, 19);
            this.lblSearchCustomer.TabIndex = 46;
            this.lblSearchCustomer.Text = "Customer No";
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(1134, 45);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(229, 22);
            this.txtSearchCustomer.TabIndex = 45;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            this.txtSearchCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchCustomer_KeyPress);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel11.Location = new System.Drawing.Point(1134, 67);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(229, 3);
            this.panel11.TabIndex = 43;
            // 
            // pbSearchCustomer
            // 
            this.pbSearchCustomer.BackColor = System.Drawing.Color.Transparent;
            this.pbSearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchCustomer.Image")));
            this.pbSearchCustomer.Location = new System.Drawing.Point(1362, 45);
            this.pbSearchCustomer.Name = "pbSearchCustomer";
            this.pbSearchCustomer.Size = new System.Drawing.Size(28, 25);
            this.pbSearchCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchCustomer.TabIndex = 44;
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
            this.btnDeleteCustomer.TabIndex = 42;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // gbUpdateCustomer
            // 
            this.gbUpdateCustomer.Controls.Add(this.btnUpdateCustomer);
            this.gbUpdateCustomer.Controls.Add(this.txtCustomerMail);
            this.gbUpdateCustomer.Controls.Add(this.txtCustomerAddress);
            this.gbUpdateCustomer.Controls.Add(this.panel7);
            this.gbUpdateCustomer.Controls.Add(this.panel6);
            this.gbUpdateCustomer.Controls.Add(this.txtCustomerPhone);
            this.gbUpdateCustomer.Controls.Add(this.panel5);
            this.gbUpdateCustomer.Controls.Add(this.lblCustomerMail);
            this.gbUpdateCustomer.Controls.Add(this.lblCustomerAddress);
            this.gbUpdateCustomer.Controls.Add(this.txtCustomerName);
            this.gbUpdateCustomer.Controls.Add(this.lblCustomerPhone);
            this.gbUpdateCustomer.Controls.Add(this.panel4);
            this.gbUpdateCustomer.Controls.Add(this.lblCustomerName);
            this.gbUpdateCustomer.Location = new System.Drawing.Point(90, 110);
            this.gbUpdateCustomer.Name = "gbUpdateCustomer";
            this.gbUpdateCustomer.Size = new System.Drawing.Size(336, 359);
            this.gbUpdateCustomer.TabIndex = 17;
            this.gbUpdateCustomer.TabStop = false;
            this.gbUpdateCustomer.Text = "Update Customer";
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCustomer.Image")));
            this.btnUpdateCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(107, 300);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(120, 32);
            this.btnUpdateCustomer.TabIndex = 41;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // txtCustomerMail
            // 
            this.txtCustomerMail.Location = new System.Drawing.Point(39, 252);
            this.txtCustomerMail.Name = "txtCustomerMail";
            this.txtCustomerMail.Size = new System.Drawing.Size(255, 22);
            this.txtCustomerMail.TabIndex = 30;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(39, 188);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(255, 22);
            this.txtCustomerAddress.TabIndex = 29;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel7.Location = new System.Drawing.Point(39, 274);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(255, 3);
            this.panel7.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel6.Location = new System.Drawing.Point(39, 210);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(255, 3);
            this.panel6.TabIndex = 32;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(39, 122);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(255, 22);
            this.txtCustomerPhone.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Location = new System.Drawing.Point(39, 144);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 3);
            this.panel5.TabIndex = 33;
            // 
            // lblCustomerMail
            // 
            this.lblCustomerMail.AutoSize = true;
            this.lblCustomerMail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerMail.Location = new System.Drawing.Point(39, 230);
            this.lblCustomerMail.Name = "lblCustomerMail";
            this.lblCustomerMail.Size = new System.Drawing.Size(99, 19);
            this.lblCustomerMail.TabIndex = 36;
            this.lblCustomerMail.Text = "Mail Address";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(39, 166);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(64, 19);
            this.lblCustomerAddress.TabIndex = 40;
            this.lblCustomerAddress.Text = "Address";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(39, 56);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(255, 22);
            this.txtCustomerName.TabIndex = 27;
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerPhone.Location = new System.Drawing.Point(39, 100);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(111, 19);
            this.lblCustomerPhone.TabIndex = 38;
            this.lblCustomerPhone.Text = "Phone Number";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(39, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 3);
            this.panel4.TabIndex = 34;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerName.Location = new System.Drawing.Point(39, 34);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(80, 19);
            this.lblCustomerName.TabIndex = 39;
            this.lblCustomerName.Text = "Full Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnAddNewCustomer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 587);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1532, 80);
            this.panel2.TabIndex = 16;
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddNewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewCustomer.Image")));
            this.btnAddNewCustomer.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(1532, 80);
            this.btnAddNewCustomer.TabIndex = 8;
            this.btnAddNewCustomer.Text = "Add New Customer";
            this.btnAddNewCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddNewCustomer.UseVisualStyleBackColor = false;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // dgwCustomer
            // 
            this.dgwCustomer.AllowUserToAddRows = false;
            this.dgwCustomer.AllowUserToDeleteRows = false;
            this.dgwCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgwCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomer.Location = new System.Drawing.Point(490, 80);
            this.dgwCustomer.Name = "dgwCustomer";
            this.dgwCustomer.ReadOnly = true;
            this.dgwCustomer.RowHeadersWidth = 51;
            this.dgwCustomer.RowTemplate.Height = 24;
            this.dgwCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCustomer.Size = new System.Drawing.Size(900, 450);
            this.dgwCustomer.TabIndex = 8;
            this.dgwCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCustomer_CellDoubleClick);
            // 
            // CustomerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1532, 667);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchCustomer)).EndInit();
            this.gbUpdateCustomer.ResumeLayout(false);
            this.gbUpdateCustomer.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox pbSearchCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.GroupBox gbUpdateCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.TextBox txtCustomerMail;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCustomerMail;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.DataGridView dgwCustomer;
    }
}