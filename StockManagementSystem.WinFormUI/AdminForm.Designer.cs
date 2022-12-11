namespace StockManagementSystem.WinFormUI
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.lblSearchAdmin = new System.Windows.Forms.Label();
            this.txtSearchAdmin = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pbSearchAdmin = new System.Windows.Forms.PictureBox();
            this.gbUpdateAdmin = new System.Windows.Forms.GroupBox();
            this.rbPasive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.btnUpdateAdmin = new System.Windows.Forms.Button();
            this.txtAdminPasswordAgain = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAdminPasswordAgain = new System.Windows.Forms.Label();
            this.txtAdminUserName = new System.Windows.Forms.TextBox();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblAdminUserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddNewAdmin = new System.Windows.Forms.Button();
            this.dgwAdmin = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchAdmin)).BeginInit();
            this.gbUpdateAdmin.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteAdmin);
            this.panel1.Controls.Add(this.lblSearchAdmin);
            this.panel1.Controls.Add(this.txtSearchAdmin);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.pbSearchAdmin);
            this.panel1.Controls.Add(this.gbUpdateAdmin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgwAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1514, 620);
            this.panel1.TabIndex = 3;
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAdmin.Image")));
            this.btnDeleteAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAdmin.Location = new System.Drawing.Point(1270, 536);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(120, 34);
            this.btnDeleteAdmin.TabIndex = 51;
            this.btnDeleteAdmin.Text = "Delete";
            this.btnDeleteAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteAdmin.UseVisualStyleBackColor = true;
            this.btnDeleteAdmin.Click += new System.EventHandler(this.btnDeleteAdmin_Click);
            // 
            // lblSearchAdmin
            // 
            this.lblSearchAdmin.AutoSize = true;
            this.lblSearchAdmin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchAdmin.Location = new System.Drawing.Point(1052, 48);
            this.lblSearchAdmin.Name = "lblSearchAdmin";
            this.lblSearchAdmin.Size = new System.Drawing.Size(79, 19);
            this.lblSearchAdmin.TabIndex = 50;
            this.lblSearchAdmin.Text = "Admin No";
            // 
            // txtSearchAdmin
            // 
            this.txtSearchAdmin.Location = new System.Drawing.Point(1134, 45);
            this.txtSearchAdmin.Name = "txtSearchAdmin";
            this.txtSearchAdmin.Size = new System.Drawing.Size(229, 22);
            this.txtSearchAdmin.TabIndex = 49;
            this.txtSearchAdmin.TextChanged += new System.EventHandler(this.txtSearchAdmin_TextChanged);
            this.txtSearchAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchAdmin_KeyPress);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel11.Location = new System.Drawing.Point(1134, 67);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(229, 3);
            this.panel11.TabIndex = 47;
            // 
            // pbSearchAdmin
            // 
            this.pbSearchAdmin.BackColor = System.Drawing.Color.Transparent;
            this.pbSearchAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchAdmin.Image")));
            this.pbSearchAdmin.Location = new System.Drawing.Point(1362, 45);
            this.pbSearchAdmin.Name = "pbSearchAdmin";
            this.pbSearchAdmin.Size = new System.Drawing.Size(28, 25);
            this.pbSearchAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchAdmin.TabIndex = 48;
            this.pbSearchAdmin.TabStop = false;
            // 
            // gbUpdateAdmin
            // 
            this.gbUpdateAdmin.Controls.Add(this.rbPasive);
            this.gbUpdateAdmin.Controls.Add(this.rbActive);
            this.gbUpdateAdmin.Controls.Add(this.btnUpdateAdmin);
            this.gbUpdateAdmin.Controls.Add(this.txtAdminPasswordAgain);
            this.gbUpdateAdmin.Controls.Add(this.panel6);
            this.gbUpdateAdmin.Controls.Add(this.txtAdminPassword);
            this.gbUpdateAdmin.Controls.Add(this.panel5);
            this.gbUpdateAdmin.Controls.Add(this.lblAdminPasswordAgain);
            this.gbUpdateAdmin.Controls.Add(this.txtAdminUserName);
            this.gbUpdateAdmin.Controls.Add(this.lblAdminPassword);
            this.gbUpdateAdmin.Controls.Add(this.panel4);
            this.gbUpdateAdmin.Controls.Add(this.lblAdminUserName);
            this.gbUpdateAdmin.Location = new System.Drawing.Point(90, 110);
            this.gbUpdateAdmin.Name = "gbUpdateAdmin";
            this.gbUpdateAdmin.Size = new System.Drawing.Size(343, 362);
            this.gbUpdateAdmin.TabIndex = 3;
            this.gbUpdateAdmin.TabStop = false;
            this.gbUpdateAdmin.Text = "Update Admin";
            // 
            // rbPasive
            // 
            this.rbPasive.AutoSize = true;
            this.rbPasive.Location = new System.Drawing.Point(178, 260);
            this.rbPasive.Name = "rbPasive";
            this.rbPasive.Size = new System.Drawing.Size(77, 20);
            this.rbPasive.TabIndex = 55;
            this.rbPasive.TabStop = true;
            this.rbPasive.Text = "Passive";
            this.rbPasive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(93, 260);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(65, 20);
            this.rbActive.TabIndex = 55;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAdmin
            // 
            this.btnUpdateAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateAdmin.Image")));
            this.btnUpdateAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAdmin.Location = new System.Drawing.Point(112, 302);
            this.btnUpdateAdmin.Name = "btnUpdateAdmin";
            this.btnUpdateAdmin.Size = new System.Drawing.Size(120, 32);
            this.btnUpdateAdmin.TabIndex = 54;
            this.btnUpdateAdmin.Text = "Update";
            this.btnUpdateAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdateAdmin.UseVisualStyleBackColor = true;
            this.btnUpdateAdmin.Click += new System.EventHandler(this.btnUpdateAdmin_Click);
            // 
            // txtAdminPasswordAgain
            // 
            this.txtAdminPasswordAgain.Location = new System.Drawing.Point(44, 190);
            this.txtAdminPasswordAgain.Name = "txtAdminPasswordAgain";
            this.txtAdminPasswordAgain.Size = new System.Drawing.Size(255, 22);
            this.txtAdminPasswordAgain.TabIndex = 44;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel6.Location = new System.Drawing.Point(44, 212);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(255, 3);
            this.panel6.TabIndex = 47;
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(44, 124);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(255, 22);
            this.txtAdminPassword.TabIndex = 43;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Location = new System.Drawing.Point(44, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 3);
            this.panel5.TabIndex = 48;
            // 
            // lblAdminPasswordAgain
            // 
            this.lblAdminPasswordAgain.AutoSize = true;
            this.lblAdminPasswordAgain.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminPasswordAgain.Location = new System.Drawing.Point(44, 168);
            this.lblAdminPasswordAgain.Name = "lblAdminPasswordAgain";
            this.lblAdminPasswordAgain.Size = new System.Drawing.Size(116, 19);
            this.lblAdminPasswordAgain.TabIndex = 53;
            this.lblAdminPasswordAgain.Text = "Password Again";
            // 
            // txtAdminUserName
            // 
            this.txtAdminUserName.Location = new System.Drawing.Point(44, 58);
            this.txtAdminUserName.Name = "txtAdminUserName";
            this.txtAdminUserName.Size = new System.Drawing.Size(255, 22);
            this.txtAdminUserName.TabIndex = 42;
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminPassword.Location = new System.Drawing.Point(44, 102);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(74, 19);
            this.lblAdminPassword.TabIndex = 51;
            this.lblAdminPassword.Text = "Password";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(44, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 3);
            this.panel4.TabIndex = 49;
            // 
            // lblAdminUserName
            // 
            this.lblAdminUserName.AutoSize = true;
            this.lblAdminUserName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminUserName.Location = new System.Drawing.Point(44, 36);
            this.lblAdminUserName.Name = "lblAdminUserName";
            this.lblAdminUserName.Size = new System.Drawing.Size(86, 19);
            this.lblAdminUserName.TabIndex = 52;
            this.lblAdminUserName.Text = "User Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btnAddNewAdmin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 540);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1514, 80);
            this.panel2.TabIndex = 2;
            // 
            // btnAddNewAdmin
            // 
            this.btnAddNewAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewAdmin.FlatAppearance.BorderSize = 0;
            this.btnAddNewAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewAdmin.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewAdmin.Image")));
            this.btnAddNewAdmin.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewAdmin.Name = "btnAddNewAdmin";
            this.btnAddNewAdmin.Size = new System.Drawing.Size(1514, 80);
            this.btnAddNewAdmin.TabIndex = 9;
            this.btnAddNewAdmin.Text = "Add New Admin";
            this.btnAddNewAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddNewAdmin.UseVisualStyleBackColor = false;
            this.btnAddNewAdmin.Click += new System.EventHandler(this.btnAddNewAdmin_Click);
            // 
            // dgwAdmin
            // 
            this.dgwAdmin.AllowUserToAddRows = false;
            this.dgwAdmin.AllowUserToDeleteRows = false;
            this.dgwAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwAdmin.BackgroundColor = System.Drawing.Color.White;
            this.dgwAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAdmin.Location = new System.Drawing.Point(490, 80);
            this.dgwAdmin.Name = "dgwAdmin";
            this.dgwAdmin.ReadOnly = true;
            this.dgwAdmin.RowHeadersWidth = 51;
            this.dgwAdmin.RowTemplate.Height = 24;
            this.dgwAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwAdmin.Size = new System.Drawing.Size(900, 450);
            this.dgwAdmin.TabIndex = 0;
            this.dgwAdmin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAdmin_CellDoubleClick);
            // 
            // AdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1514, 620);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchAdmin)).EndInit();
            this.gbUpdateAdmin.ResumeLayout(false);
            this.gbUpdateAdmin.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.Label lblSearchAdmin;
        private System.Windows.Forms.TextBox txtSearchAdmin;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox pbSearchAdmin;
        private System.Windows.Forms.GroupBox gbUpdateAdmin;
        private System.Windows.Forms.RadioButton rbPasive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.Button btnUpdateAdmin;
        private System.Windows.Forms.TextBox txtAdminPasswordAgain;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblAdminPasswordAgain;
        private System.Windows.Forms.TextBox txtAdminUserName;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblAdminUserName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddNewAdmin;
        private System.Windows.Forms.DataGridView dgwAdmin;
    }
}