using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Helpers
{
    public static class GenericsHelper
    {
        public static void LoadComboBox<T>(ComboBox combo, T items, string display, string value)
        {
            combo.DataSource= items;
            combo.DisplayMember = display;
            combo.ValueMember = value;
        }
    }
}
