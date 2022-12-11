namespace StockManagementSystem.WinFormUI
{
    partial class SaleForm
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgwSales = new System.Windows.Forms.DataGridView();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSales)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgwSales);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1514, 620);
            this.pnlMain.TabIndex = 3;
            // 
            // dgwSales
            // 
            this.dgwSales.AllowUserToAddRows = false;
            this.dgwSales.AllowUserToDeleteRows = false;
            this.dgwSales.AllowUserToResizeColumns = false;
            this.dgwSales.AllowUserToResizeRows = false;
            this.dgwSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwSales.BackgroundColor = System.Drawing.Color.White;
            this.dgwSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSales.Location = new System.Drawing.Point(113, 106);
            this.dgwSales.Name = "dgwSales";
            this.dgwSales.ReadOnly = true;
            this.dgwSales.RowHeadersWidth = 51;
            this.dgwSales.RowTemplate.Height = 24;
            this.dgwSales.Size = new System.Drawing.Size(1279, 453);
            this.dgwSales.TabIndex = 0;
            // 
            // SaleForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1514, 620);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleForm";
            this.Text = "SalePage";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgwSales;
    }
}