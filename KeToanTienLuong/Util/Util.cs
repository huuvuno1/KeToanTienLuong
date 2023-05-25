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
        public static nguoidung user_login = null;
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

        public static string activeButton(string type, Button add, Button save, Button cancel, Button edit, Button delete)
        {
            switch (type)
            {
                case "add":
                case "edit":
                    add.Enabled = edit.Enabled = delete.Enabled = false;
                    save.Enabled = cancel.Enabled = true;
                    return type;
                case "save":
                case "cancel":
                case "delete":
                    add.Enabled = edit.Enabled = delete.Enabled =save.Enabled = cancel.Enabled = true;
                    break;

            }
            return "none";
        }

        public static decimal CalculatePersonalIncomeTax(decimal monthlyIncome)
        {
            decimal taxAmount = 0;
            decimal taxableIncome = monthlyIncome;

            // Bảng thuế thu nhập cá nhân theo luật hiện hành
            // Các mức thuế và ngưỡng được định nghĩa trong các dòng dưới đây
            decimal[] taxThresholds = { 5000000, 10000000, 18000000, 32000000, 52000000, 80000000 };
            decimal[] taxRates = { 0.05m, 0.1m, 0.15m, 0.2m, 0.25m, 0.3m };

            // Tính thuế dựa trên các ngưỡng và mức thuế
            for (int i = 0; i < taxThresholds.Length; i++)
            {
                if (taxableIncome <= 0)
                {
                    break;
                }

                decimal threshold = taxThresholds[i];
                decimal rate = taxRates[i];

                if (taxableIncome <= threshold)
                {
                    taxAmount += taxableIncome * rate;
                    break;
                }
                else
                {
                    taxAmount += threshold * rate;
                    taxableIncome -= threshold;
                }
            }

            return taxAmount;
        }

        public static bool validateInput(params TextBox[] inputs)
        {
            foreach (var input in inputs)
            {
                if (input.Text == "")
                {
                    return false;
                }
            }

            return true;
        }
    }
}
