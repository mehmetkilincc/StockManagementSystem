namespace StockManagementSystem.WinFormUI
{
    partial class AddNewAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewAdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.txtAdminPasswordAgain = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAdminPasswordAgain = new System.Windows.Forms.Label();
            this.txtAdminUserName = new System.Windows.Forms.TextBox();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblAdminUserName = new System.Windows.Forms.Label();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.lblFormHeader);
            this.panel1.Controls.Add(this.txtAdminPasswordAgain);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.txtAdminPassword);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lblAdminPasswordAgain);
            this.panel1.Controls.Add(this.txtAdminUserName);
            this.panel1.Controls.Add(this.lblAdminPassword);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblAdminUserName);
            this.panel1.Controls.Add(this.btnAddAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 298);
            this.panel1.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(155, 210);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 36);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormHeader.Location = new System.Drawing.Point(191, 28);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(128, 25);
            this.lblFormHeader.TabIndex = 33;
            this.lblFormHeader.Text = "New Admin";
            // 
            // txtAdminPasswordAgain
            // 
            this.txtAdminPasswordAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminPasswordAgain.Location = new System.Drawing.Point(155, 163);
            this.txtAdminPasswordAgain.Name = "txtAdminPasswordAgain";
            this.txtAdminPasswordAgain.Size = new System.Drawing.Size(295, 24);
            this.txtAdminPasswordAgain.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Location = new System.Drawing.Point(155, 185);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(295, 3);
            this.panel6.TabIndex = 26;
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminPassword.Location = new System.Drawing.Point(155, 122);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(295, 24);
            this.txtAdminPassword.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Location = new System.Drawing.Point(155, 144);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(295, 3);
            this.panel5.TabIndex = 27;
            // 
            // lblAdminPasswordAgain
            // 
            this.lblAdminPasswordAgain.AutoSize = true;
            this.lblAdminPasswordAgain.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminPasswordAgain.Location = new System.Drawing.Point(37, 168);
            this.lblAdminPasswordAgain.Name = "lblAdminPasswordAgain";
            this.lblAdminPasswordAgain.Size = new System.Drawing.Size(116, 19);
            this.lblAdminPasswordAgain.TabIndex = 30;
            this.lblAdminPasswordAgain.Text = "Password Again";
            // 
            // txtAdminUserName
            // 
            this.txtAdminUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminUserName.Location = new System.Drawing.Point(155, 81);
            this.txtAdminUserName.Name = "txtAdminUserName";
            this.txtAdminUserName.Size = new System.Drawing.Size(295, 24);
            this.txtAdminUserName.TabIndex = 1;
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminPassword.Location = new System.Drawing.Point(79, 126);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(74, 19);
            this.lblAdminPassword.TabIndex = 31;
            this.lblAdminPassword.Text = "Password";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(155, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 3);
            this.panel4.TabIndex = 28;
            // 
            // lblAdminUserName
            // 
            this.lblAdminUserName.AutoSize = true;
            this.lblAdminUserName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminUserName.Location = new System.Drawing.Point(67, 84);
            this.lblAdminUserName.Name = "lblAdminUserName";
            this.lblAdminUserName.Size = new System.Drawing.Size(86, 19);
            this.lblAdminUserName.TabIndex = 32;
            this.lblAdminUserName.Text = "User Name";
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAdmin.Image")));
            this.btnAddAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAdmin.Location = new System.Drawing.Point(303, 210);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(147, 36);
            this.btnAddAdmin.TabIndex = 5;
            this.btnAddAdmin.Text = "Add Admin";
            this.btnAddAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // AddNewAdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(512, 298);
            this.Controls.Add(this.panel1);
            this.Name = "AddNewAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Management System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.TextBox txtAdminPasswordAgain;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblAdminPasswordAgain;
        private System.Windows.Forms.TextBox txtAdminUserName;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblAdminUserName;
        private System.Windows.Forms.Button btnAddAdmin;
    }
}