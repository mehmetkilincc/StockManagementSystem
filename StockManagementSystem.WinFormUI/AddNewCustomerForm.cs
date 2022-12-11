using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Business.Abstract;
using StockManagementSystem.Business.DependencySolvers.Ninject;
using StockManagementSystem.Entities.Concrete;
using StockManagementSystem.WinFormUI.Utilities;

namespace StockManagementSystem.WinFormUI
{
    public partial class AddNewCustomerForm : Form
    {
        private ICustomerService _customerService;

        public AddNewCustomerForm()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        private void AddCustomer()
        {
            _customerService.Add(new Customer()
            {
                CustomerName = txtCustomerName.Text,
                CustomerPhone = txtCustomerPhone.Text,
                CustomerAddress = txtCustomerAddress.Text,
                CustomerMail = txtCustomerMail.Text
            });
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (Ex.HandleException(() => { AddCustomer(); }))
            {
                MessageBox.Show("Customer successfully added", "Stock Management System");
                Clear();
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
