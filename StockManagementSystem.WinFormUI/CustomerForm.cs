using StockManagementSystem.Business.Abstract;
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
using StockManagementSystem.Business.DependencySolvers.Ninject;

namespace StockManagementSystem.WinFormUI
{
    public partial class CustomerForm : Form
    {
        private ICustomerService _customerService;

        public CustomerForm()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }
        private void LoadCustomerData()
        {
            Ex.HandleException(() =>
            {
                dgwCustomer.DataSource = _customerService.GetAll();
            });
        }

        private void UpdateCustomer()
        {
            _customerService.Update(new Customer()
            {
                CustomerId = Convert.ToInt32(dgwCustomer.CurrentRow.Cells["CustomerId"].Value),
                CustomerName = txtCustomerName.Text,
                CustomerPhone = txtCustomerPhone.Text,
                CustomerAddress = txtCustomerAddress.Text,
                CustomerMail = txtCustomerMail.Text
            });
        }
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (Ex.HandleException(() => { UpdateCustomer(); }))
            {
                LoadCustomerData();
                MessageBox.Show("Customer successfully updated", "Stock Management System");
                Clear();
            }
        }

        private void DeleteCustomer()
        {
            _customerService.Delete(new Customer()
            {
                CustomerId = Convert.ToInt32(dgwCustomer.CurrentRow.Cells["CustomerId"].Value)
            });
        }
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this customer?", "Stock Management System", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Ex.HandleException(() => { DeleteCustomer(); }))
                {
                    LoadCustomerData();
                    MessageBox.Show("Customer successfully deleted", "Stock Management System");
                    Clear();
                }
            }
        }

        private void GetCustomerById()
        {
            Ex.HandleException(() =>
            {
                dgwCustomer.DataSource = _customerService.GetByCustomerId(Convert.ToInt32(txtSearchCustomer.Text));
            });
        }
        private void Clear()
        {
            foreach (Control item in this.gbUpdateCustomer.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
            txtSearchCustomer.Text = string.Empty;
        }
        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchCustomer.Text))
            {
                GetCustomerById();
            }
            else
            {
                LoadCustomerData();
            }
        }
        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            AddNewCustomerForm form = new AddNewCustomerForm();
            form.ShowDialog();
            LoadCustomerData();
        }
        private void dgwCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerName.Text = dgwCustomer.CurrentRow.Cells["CustomerName"].Value.ToString();
            txtCustomerPhone.Text = dgwCustomer.CurrentRow.Cells["CustomerPhone"].Value.ToString();
            txtCustomerAddress.Text = dgwCustomer.CurrentRow.Cells["CustomerAddress"].Value.ToString();
            txtCustomerMail.Text = dgwCustomer.CurrentRow.Cells["CustomerMail"].Value.ToString();
        }
        private void txtSearchCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
