using KeToanTienLuong.chungtu;
using KeToanTienLuong.thamsoluongform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong.categoryForm
{
    public partial class ChungTuForm : UserControl
    {
        public ChungTuForm()
        {
            InitializeComponent();
        }

        private void ChungTu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PhieuKeToanForm f = new PhieuKeToanForm();
            f.Dock = DockStyle.Top;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(f);
            f.Show();
        }
    }
}
