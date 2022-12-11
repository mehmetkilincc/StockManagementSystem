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
    public partial class AddNewProductForm : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;

        public AddNewProductForm()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _brandService = InstanceFactory.GetInstance<IBrandService>();
        }
        private void AddNewProductForm_Load(object sender, EventArgs e)
        {
            LoadCategoryData();
            LoadBrandData();
        }

        private void LoadBrandData()
        {
            Ex.HandleException(() =>
            {
                cbProductBrand.DataSource = _brandService.GetByCategoryName(cbProductCategory.SelectedValue.ToString());
                cbProductBrand.DisplayMember = "BrandName";
                cbProductBrand.ValueMember = "BrandName";
            });
        }
        private void LoadCategoryData()
        {
            Ex.HandleException(() =>
            {
                cbProductCategory.DataSource = _categoryService.GetAll();
                cbProductCategory.DisplayMember = "CategoryName";
                cbProductCategory.ValueMember = "CategoryName";
            });
        }

        private void AddProduct()
        {
            _productService.Add(new Product()
            {
                ProductName = txtProductName.Text,
                CategoryName = cbProductCategory.SelectedValue.ToString(),
                BrandName = cbProductBrand.SelectedValue.ToString(),
                Quantity = Convert.ToInt32(txtProductQuantity.Text),
                PurchasePrice = Convert.ToDecimal(txtProductPurchasePrice.Text),
                SalePrice = Convert.ToDecimal(txtProductSalePrice.Text),
                Date = Convert.ToDateTime(DateTime.Now)
            });
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (Ex.HandleException(() => { AddProduct(); }))
            {
                MessageBox.Show("Product successfully added", "Stock Management System");
                Clear();
            }
            else
            {
                txtProductName.Text = "";
                txtProductName.Focus();
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

                if (item is ComboBox)
                {
                    item.Text = string.Empty;
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBrandData();
        }
    }
}

