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
    public partial class CartForm : Form
    {
        private readonly ICartService _cartService;
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;
        private readonly ISaleService _saleService;

        public CartForm()
        {
            InitializeComponent();
            _cartService = InstanceFactory.GetInstance<ICartService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _saleService = InstanceFactory.GetInstance<ISaleService>();
        }

        private void LoadCartData()
        {
            Ex.HandleException(() =>
            {
                dgwCart.DataSource = _cartService.GetAll();
                lblTotalCartPrice.Text = _cartService.Calculate() + " TL";
            });
        }
        private void CartForm_Load(object sender, EventArgs e)
        {
            LoadCartData();
        }

        private void AddtoCart()
        {
            _cartService.Add(new Cart()
            {
                CustomerId = Convert.ToInt32(txtCustomerId.Text),
                CustomerName = txtCustomerName.Text,
                CustomerPhone = txtCustomerPhone.Text,
                ProductId = Convert.ToInt32(txtProductId.Text),
                ProductName = txtProductName.Text,
                Amount = Convert.ToInt32(txtProductAmount.Text),
                SalePrice = Convert.ToDecimal(txtProductSalePrice.Text),
                TotalPrice = Convert.ToInt32(txtProductAmount.Text) * Convert.ToDecimal(txtProductSalePrice.Text)
            });
        }
        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text != "" && txtProductName.Text != "" && txtProductAmount.Text != "")
            {
                if (StockControl(Convert.ToInt32( txtProductId.Text),Convert.ToInt32(txtProductAmount.Text)))
                {
                    if (Ex.HandleException(() => { AddtoCart(); }))
                    {
                        LoadCartData();
                        MessageBox.Show("Product added to cart", "Stock Management System");
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("There are not enough products in stock","Stock Management System");
                }
            }
            else
            {
                MessageBox.Show("Please enter information", "Stock Management System");
            }
        }
        private bool StockControl(int id, int amount)
        {
            Product product = _productService.getProduct(id);

            bool checkStock = product.Quantity < amount ? false : true;

            return checkStock;
        }

        private void MakeSale()
        {
            var cartList = _cartService.GetAll();
            foreach (var item in cartList)
            {
                _saleService.Add(new Sale()
                {
                    CustomerId = item.CustomerId,
                    CustomerName = item.CustomerName,
                    CustomerPhone = item.CustomerPhone,
                    ProductId = item.ProductId,
                    ProductName = item.ProductName,
                    Amount = item.Amount,
                    SalePrice = item.SalePrice,
                    TotalPrice = item.TotalPrice,
                    Date = item.Date
                });

                _productService.ReduceProductAmount(new Product()
                {
                    ProductId = item.ProductId,
                    Quantity = item.Amount,
                });
            }
        }
        private void btnMakeSale_Click(object sender, EventArgs e)
        {
            if (dgwCart.Rows.Count != 0)
            {
                if (Ex.HandleException(() => { MakeSale(); }))
                {
                    CancelSale();
                    LoadCartData();
                    MessageBox.Show("Sale successfully completed.", "Stock Management System");
                }
            }
            else
            {
                MessageBox.Show("Please add product to cart", "Stock Management System");
            }
        }

        private void CancelSale()
        {
            var cartList = _cartService.GetAll();
            foreach (var cart in cartList)
            {
                _cartService.Delete(cart);
            }
        }
        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            if (dgwCart.Rows.Count != 0)
            {
                if (MessageBox.Show("Are you sure you want to remove all product from the cart?", "Stock Management System", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Ex.HandleException(() => { CancelSale(); }))
                    {
                        LoadCartData();
                        MessageBox.Show("Sale successfully cleared", "Stock Management System");
                    }
                }
            }
            else
                MessageBox.Show("Cart is already empty", "Stock Management System");

        }

        private void RemoveProductFromCart()
        {
            _cartService.Delete(new Cart()
            {
                ProductId = Convert.ToInt32(dgwCart.CurrentRow.Cells["ProductId"].Value)
            });
        }
        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dgwCart.Rows.Count != 0)
            {
                if (MessageBox.Show("Are you sure you want to remove this product from the cart?", "Stock Management System", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Ex.HandleException(() => { RemoveProductFromCart(); }))
                    {
                        LoadCartData();
                        MessageBox.Show("Product removed from cart", "Stock Management System");
                    }
                }
            }
            else
            {
                MessageBox.Show("Cart is already empty", "Stock Management System");
            }
        }
        private void Clear()
        {
            foreach (Control item in this.gbProduct.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustomerId.Text))
            {
                Customer customer = _customerService.GetCustomer(Convert.ToInt32(txtCustomerId.Text));
                if (customer != null)
                {
                    txtCustomerName.Text = customer.CustomerName;
                    txtCustomerPhone.Text = customer.CustomerPhone;
                }
            }
            else
            {
                txtCustomerName.Text = string.Empty;
                txtCustomerPhone.Text = string.Empty;
            }
        }
        private void txtProductId_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductId.Text))
            {
                Product product = _productService.getProduct(Convert.ToInt32(txtProductId.Text));
                if (product != null)
                {
                    txtProductName.Text = product.ProductName;
                    txtProductSalePrice.Text = product.SalePrice.ToString();
                }
            }
            else
            {
                txtProductName.Text = string.Empty;
                txtProductSalePrice.Text = string.Empty;
                txtProductTotalPrice.Text = string.Empty;
            }
        }

        private void txtProductAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtProductAmount.Text != "" && txtProductSalePrice.Text != "")
            {
                txtProductTotalPrice.Text =
                    (Convert.ToInt32(txtProductAmount.Text) * Convert.ToDecimal(txtProductSalePrice.Text)).ToString();
            }
            else
            {
                txtProductTotalPrice.Text = "";
            }
        }

        private void txtProductAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtCustomerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtProductId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
