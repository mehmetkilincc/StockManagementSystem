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
    public partial class CategoryForm : Form
    {
        private ICategoryService _categoryService;
        private IBrandService _brandService;

        public CategoryForm()
        {
            InitializeComponent();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _brandService = InstanceFactory.GetInstance<IBrandService>();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategoryData();
            LoadBrandData();
        }

        private void LoadBrandData()
        {
            Ex.HandleException(() =>
            {
                dgwBrand.DataSource = _brandService.GetAll();
            });
        }
        private void LoadCategoryData()
        {
            Ex.HandleException(() =>
            {
                dgwCategory.DataSource = _categoryService.GetAll();

                cbCategoryName.DataSource = _categoryService.GetAll();
                cbCategoryName.DisplayMember = "CategoryName";
                cbCategoryName.ValueMember = "CategoryName";
            });
        }

        private void AddCategory()
        {
            _categoryService.Add(new Category()
            {
                CategoryName = txtCategoryName.Text
            });
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (Ex.HandleException(() => { AddCategory(); }))
            {
                LoadCategoryData();
                MessageBox.Show("Category successfully added", "Stock Management System");
                txtCategoryName.Text = "";
            }
        }

        private void DeleteCategory()
        {
            _categoryService.Delete(new Category()
            {
                CategoryName = dgwCategory.CurrentRow.Cells["CategoryName"].Value.ToString()
            });
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this category?", "Stock Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Ex.HandleException(() => { DeleteCategory(); }))
                {
                    LoadCategoryData();
                    LoadBrandData();
                    MessageBox.Show("Category successfully deleted.", "Stock Management System");
                    txtCategoryName.Text = "";
                }
            }
        }

        private void AddBrand()
        {
            _brandService.Add(new Brand()
            {
                CategoryName = cbCategoryName.SelectedValue.ToString(),
                BrandName = txtBrandName.Text
            });
        }
        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            if (Ex.HandleException(() => { AddBrand(); }))
            {
                LoadBrandData();
                txtBrandName.Text = "";
                MessageBox.Show("Brand successfully added", "Stock Management System");
            }
        }

        private void DeleteBrand()
        {
            _brandService.Delete(new Brand()
            {
                CategoryName = dgwBrand.CurrentRow.Cells["CategoryName"].Value.ToString(),
                BrandName = dgwBrand.CurrentRow.Cells["BrandName"].Value.ToString()
            });
        }
        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this brand?", "Stock Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Ex.HandleException(() => { DeleteBrand(); }))
                {
                    LoadBrandData();
                    MessageBox.Show("Brand successfully deleted.", "Stock Management System");
                    txtBrandName.Text = "";
                }
            }
        }
    }
}
