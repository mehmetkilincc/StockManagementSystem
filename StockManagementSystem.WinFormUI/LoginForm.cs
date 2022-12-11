using StockManagementSystem.Business.Abstract;
using StockManagementSystem.Business.DependencySolvers.Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Entities.Concrete;
using StockManagementSystem.WinFormUI.Utilities;

namespace StockManagementSystem.WinFormUI
{
    public partial class LoginForm : Form
    {
        private IAdminService _adminService;
        public LoginForm()
        {
            InitializeComponent();
            _adminService = InstanceFactory.GetInstance<IAdminService>();
        }

        private bool CheckAdmin()
        {
            bool checkAdmin = false;
            Ex.HandleException(() =>
            {
                checkAdmin = _adminService.Login(new Admin() { UserName = txtUserName.Text, Password = txtPassword.Text, IsActive = true }) ? true : false;
            });

            return checkAdmin;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isExist = CheckAdmin();

            if (isExist)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Stock Management System");
                txtUserName.Focus();
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Type Your Username")
            {
                txtUserName.Clear();
                txtUserName.ForeColor = Color.Black;
            }
        }
        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.ForeColor = Color.Gray;
                txtUserName.Text += "Type Your Username";
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Type Your Password")
            {
                txtPassword.Clear();
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.ForeColor = Color.Black;
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.ForeColor = Color.Gray;
                txtPassword.Text += "Type Your Password";
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked != true && txtPassword.Text != "Type Your Password")
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
                Color.DodgerBlue, 0, ButtonBorderStyle.Solid,
                Color.Green, 0, ButtonBorderStyle.Solid,
                Color.DodgerBlue, 0, ButtonBorderStyle.Solid,
                Color.DodgerBlue, 1, ButtonBorderStyle.Solid);
        }
    }
}
