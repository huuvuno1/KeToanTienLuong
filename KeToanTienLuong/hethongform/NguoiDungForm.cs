using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong.hethongform
{
    public partial class NguoiDungForm : UserControl
    {
        public NguoiDungForm()
        {
            InitializeComponent();

            
            
        }

        private void dataGridViewNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();
            db.nguoidungs.Add(new nguoidung() {
                quyen = comboQuyenHeThong.SelectedItem.ToString(),
                tennguoidung = inpTenNguoiDung.Text,
                tendangnhap = inpTenDangNhap.Text,
                matkhau = inpMatKhau.Text,
            });
            db.SaveChanges();
            dataGridViewNguoiDung.DataSource = db.nguoidungs.Select((p) => p).ToList().Select((p, i) => new nguoidung() {
                id = i + 1,
                matkhau = "******",
                quyen = p.quyen,
                tendangnhap = p.tendangnhap,
                tennguoidung = p.tennguoidung,
            }).ToList();

            buttonThem.Enabled = true;
            inpMatKhau.Enabled = inpTenDangNhap.Enabled = inpTenNguoiDung.Enabled = comboQuyenHeThong.Enabled = false;

        }

        private void dataGridViewNguoiDung_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
                }
        
        private void NguoiDungForm_Load(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();
            dataGridViewNguoiDung.DataSource = db.nguoidungs.Select((p) => p).ToList().Select((p, i) => new nguoidung() {
                id = i + 1,
                matkhau = "******",
                quyen = p.quyen,
                tendangnhap = p.tendangnhap,
                tennguoidung = p.tennguoidung,
            }).ToList();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            buttonThem.Enabled = false;
            inpMatKhau.Enabled = inpTenDangNhap.Enabled = inpTenNguoiDung.Enabled = comboQuyenHeThong.Enabled = true;
        }
    }
}
