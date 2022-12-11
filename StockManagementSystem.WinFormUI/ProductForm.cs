using StockManagementSystem.Business.Abstract;
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
using StockManagementSystem.Entities.Concrete;

namespace StockManagementSystem.WinFormUI
{
    public partial class ProductForm : Form
    {
        private IProductService _productService;

        public ProductForm()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadProductData();
        }
        private void LoadProductData()
        {
            Ex.HandleException(() =>
            {
                dgwProduct.DataSource = _productService.GetAll();
            });
        }

        private void UpdateProduct()
        {
            _productService.Update(new Product()
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells["ProductId"].Value),
                ProductName = txtProductName.Text,
                CategoryName = txtCategoryName.Text,
                BrandName = txtBrandName.Text,
                Quantity = Convert.ToInt32(txtQuantity.Text),
                PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text),
                SalePrice = Convert.ToDecimal(txtSalePrice.Text),
                Date = DateTime.Now
            });
        }
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (Ex.HandleException(() => { UpdateProduct(); }))
            {
                LoadProductData();
                MessageBox.Show("Product successfully updated", "Stock Management System");
                Clear();
            }
        }

        private void DeleteProduct()
        {
            _productService.Delete(new Product()
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells["ProductId"].Value)
            });

        }
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this product?", "Stock Management System", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Ex.HandleException(() => { DeleteProduct(); }))
                {
                    LoadProductData();
                    MessageBox.Show("Product successfully deleted");
                    Clear();
                }
            }
        }

        private void GetProductById()
        {
            Ex.HandleException(() =>
            {
                dgwProduct.DataSource = _productService.GetByProductId(Convert.ToInt32(txtSearchProduct.Text));
            });
        }
        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchProduct.Text))
            {
                GetProductById();
            }
            else
            {
                LoadProductData();
            }
        }

        private void Clear()
        {
            foreach (Control item in this.gbUpdateProduct.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
            txtSearchProduct.Text = string.Empty;
        }
        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            AddNewProductForm form = new AddNewProductForm();
            form.ShowDialog();
            LoadProductData();
        }
        private void dgwProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = dgwProduct.CurrentRow.Cells["ProductName"].Value.ToString();
            txtCategoryName.Text = dgwProduct.CurrentRow.Cells["CategoryName"].Value.ToString();
            txtBrandName.Text = dgwProduct.CurrentRow.Cells["BrandName"].Value.ToString();
            txtQuantity.Text = dgwProduct.CurrentRow.Cells["Quantity"].Value.ToString();
            txtPurchasePrice.Text = dgwProduct.CurrentRow.Cells["PurchasePrice"].Value.ToString();
            txtSalePrice.Text = dgwProduct.CurrentRow.Cells["SalePrice"].Value.ToString();
            txtSearchProduct.Text = string.Empty;
        }
        private void txtSearchProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
