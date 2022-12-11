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
using StockManagementSystem.Business.Abstract;
using StockManagementSystem.Business.DependencySolvers.Ninject;

namespace StockManagementSystem.WinFormUI
{
    public partial class SaleForm : Form
    {
        private ISaleService _saleService;

        public SaleForm()
        {
            InitializeComponent();
            _saleService = InstanceFactory.GetInstance<ISaleService>();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            LoadSaleData();
        }

        private void LoadSaleData()
        {
            Ex.HandleException(() =>
            {
                dgwSales.DataSource = _saleService.GetAll();
            });
        }
    }
}
