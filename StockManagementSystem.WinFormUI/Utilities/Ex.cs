using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.WinFormUI.Utilities
{
    public class Ex : Exception
    {
        public static bool HandleException(Action action)
        {
            try
            {
                action.Invoke();
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Stock Management System");
                return false;
            }
        }
    }
}
