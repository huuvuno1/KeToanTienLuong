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
            Util.Util.changeBackground(btnPhieuKeToan, btnPhieuChi, btnGiayBaoNo);
            PhieuKeToanForm f = new PhieuKeToanForm();
            f.Dock = DockStyle.Top;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(f);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Util.Util.changeBackground(btnPhieuChi, btnGiayBaoNo, btnPhieuKeToan);

            PhieuChiForm f = new PhieuChiForm();
            f.Dock = DockStyle.Top;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(f);
            f.Show();
        }

        private void btnGiayBaoNo_Click(object sender, EventArgs e)
        {
            Util.Util.changeBackground(btnGiayBaoNo, btnPhieuKeToan, btnPhieuChi);
            GiayBaoNoForm f = new GiayBaoNoForm();
            f.Dock = DockStyle.Top;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(f);
            f.Show();
        }
    }
}
