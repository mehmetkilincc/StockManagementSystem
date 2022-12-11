using StockManagementSystem.Business.Abstract;
using StockManagementSystem.Business.DependencySolvers.Ninject;
using StockManagementSystem.Entities.Concrete;
using StockManagementSystem.WinFormUI.Utilities;
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
    public partial class AddNewAdminForm : Form
    {
        private IAdminService _adminService;

        public AddNewAdminForm()
        {
            InitializeComponent();
            _adminService = InstanceFactory.GetInstance<IAdminService>();
        }

        private void AddAdmin()
        {
            _adminService.Add(new Admin()
            {
                UserName = txtAdminUserName.Text,
                Password = txtAdminPassword.Text,
            });
        }
        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (txtAdminPassword.Text == txtAdminPasswordAgain.Text)
            {
                if (Ex.HandleException(() => { AddAdmin(); }))
                {
                    MessageBox.Show("Admin successfully added", "Stock Management System");
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Does not match Passwords", "Stock Management System");
            }
        }

        private void Clear()
        {
            foreach (Control item in this.panel1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
