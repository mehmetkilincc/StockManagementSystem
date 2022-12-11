using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.WinFormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CartForm());
            PanelDesign(btnCart);
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerForm());
            PanelDesign(btnCustomer);
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductForm());
            PanelDesign(btnProduct);
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CategoryForm());
            PanelDesign(btnCategory);
        }
        private void btnSale_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SaleForm());
            PanelDesign(btnSale);
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForm());
            PanelDesign(btnAdmin);
        }

        private void PanelDesign(Button btn)
        {
            dashboard.Visible = true;
            dashboard.Left = btn.Left;
        }
        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pnlHeader.ClientRectangle,
                Color.DodgerBlue, 0, ButtonBorderStyle.Solid,
                Color.DodgerBlue, 0, ButtonBorderStyle.Solid,
                Color.DodgerBlue, 0, ButtonBorderStyle.Solid,
                Color.DodgerBlue, 1, ButtonBorderStyle.Solid);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
