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
    public partial class AdminForm : Form
    {
        private IAdminService _adminService;

        public AdminForm()
        {
            InitializeComponent();
            _adminService = InstanceFactory.GetInstance<IAdminService>();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadAdminData();
        }
        private void LoadAdminData()
        {
            Ex.HandleException(() =>
            {
                dgwAdmin.DataSource = _adminService.GetAll();
            });
        }

        private void UpdateAdmin()
        {
            _adminService.Update(new Admin()
            {
                AdminId = Convert.ToInt32(dgwAdmin.CurrentRow.Cells["AdminId"].Value),
                UserName = txtAdminUserName.Text,
                Password = txtAdminPassword.Text,
                IsActive = rbActive.Checked
            });
        }
        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            if (txtAdminPassword.Text == txtAdminPasswordAgain.Text)
            {
                if (Ex.HandleException(() => { UpdateAdmin(); }))
                {
                    LoadAdminData();
                    MessageBox.Show("Admin successfully updated", "Stock Management System");
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Does not match Passwords", "Stock Management System");
            }
        }

        private void DeleteAdmin()
        {
            _adminService.Delete(new Admin()
            {
                AdminId = Convert.ToInt32(dgwAdmin.CurrentRow.Cells["AdminId"].Value)
            });
        }
        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this admin?", "Stock Management System", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Ex.HandleException(() => { DeleteAdmin(); }))
                {
                    LoadAdminData();
                    MessageBox.Show("Admin successfully deleted", "Stock Management System");
                    Clear();
                }
            }
        }

        private void GetAdminById()
        {
            Ex.HandleException(() =>
            {
                dgwAdmin.DataSource = _adminService.GetByAdminId(Convert.ToInt32(txtSearchAdmin.Text));
            });
        }
        private void txtSearchAdmin_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchAdmin.Text))
            {
                GetAdminById();
            }
            else
            {
                LoadAdminData();
            }
        }

        private void Clear()
        {
            foreach (Control item in this.gbUpdateAdmin.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }

                if (item is RadioButton)
                {
                    ((RadioButton)item).Checked = false;
                }
            }
            txtSearchAdmin.Text = string.Empty;
        }
        private void btnAddNewAdmin_Click(object sender, EventArgs e)
        {
            AddNewAdminForm form = new AddNewAdminForm();
            form.ShowDialog();
            LoadAdminData();
        }
        private void dgwAdmin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdminUserName.Text = dgwAdmin.CurrentRow.Cells["UserName"].Value.ToString();
            txtAdminPassword.Text = dgwAdmin.CurrentRow.Cells["Password"].Value.ToString();

            if (Convert.ToBoolean(dgwAdmin.CurrentRow.Cells["IsActive"].Value))
                rbActive.Checked = true;
            else
                rbPasive.Checked = true;
        }
        private void txtSearchAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
