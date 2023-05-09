using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong.Util
{
    class Util
    {
        public static string getConnectionString()
        {
            string strcon = ConfigurationManager.ConnectionStrings["WebLaptopConnection"].ConnectionString;
            return strcon;
        }

        public static void changeBackground(params Button[] items)
        {

            foreach (var item in items)
            {
                item.BackColor = SystemColors.Control;
            }

            items[0].BackColor = SystemColors.ControlLightLight;
        }

    }
}
