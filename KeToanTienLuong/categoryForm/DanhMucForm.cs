using KeToanTienLuong.danhmucform;
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
    public partial class DanhMucForm : UserControl
    {
        public DanhMucForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Util.Util.changeBackground(buttonTk, buttonNhanVien, buttonChucVu, buttonTk, btnNganHang);

            DanhMucTaiKhoanForm f = new DanhMucTaiKhoanForm();
            f.Dock = DockStyle.Top;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(f);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Util.Util.changeBackground(buttonNhanVien, buttonChucVu, buttonTk, btnBoPhan, btnNganHang);

            NhanVienForm f = new NhanVienForm();
            f.Dock = DockStyle.Top;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(f);
            f.Show();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Util.Util.changeBackground(buttonChucVu, buttonNhanVien, buttonTk, btnBoPhan, btnNganHang);
            ChucVuForm f = new ChucVuForm();
            f.Dock = DockStyle.Top;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(f);
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Util.Util.changeBackground(btnBoPhan, buttonTk, buttonChucVu, buttonNhanVien, btnNganHang);

            BoPhanForm f = new BoPhanForm();
            f.Dock = DockStyle.Top;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(f);
            f.Show();
        }

        private void btnNganHang_Click(object sender, EventArgs e)
        {
            Util.Util.changeBackground(btnNganHang, btnBoPhan, buttonTk, buttonChucVu, buttonNhanVien);
            NganHangForm f = new NganHangForm();
            f.Dock = DockStyle.Top;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(f);
            f.Show();
        }
    }
}
