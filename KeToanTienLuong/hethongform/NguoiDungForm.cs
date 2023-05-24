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
            var old = db.nguoidungs.FirstOrDefault(p => p.tendangnhap == inpTenDangNhap.Text);
            if (buttonThem.Enabled)

            {
                if (old != null)
                {
                    old.tendangnhap = inpTenDangNhap.Text;
                    old.tennguoidung = inpTenNguoiDung.Text;
                    if (inpMatKhau.Text != "******")
                        old.matkhau = inpMatKhau.Text;
                    old.quyen = comboQuyenHeThong.SelectedItem.ToString();
                }
                
            }
            else
            {
                if (old == null)
                {
                    db.nguoidungs.Add(new nguoidung() {
                        quyen = comboQuyenHeThong.SelectedItem.ToString(),
                        tennguoidung = inpTenNguoiDung.Text,
                        tendangnhap = inpTenDangNhap.Text,
                        matkhau = inpMatKhau.Text,
                    });
                }
                else
                {
                    //MessageBox.Show("Trùng lặp tên đăng nhập");
                }
            }

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
            inpMatKhau.Text = inpTenDangNhap.Text = inpTenNguoiDung.Text = "";
            comboQuyenHeThong.SelectedIndex = 1;
        }

        private void dgvdmtk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;
                DataGridViewRow clickedRow = dataGridView.Rows[e.RowIndex];

                // Lấy dữ liệu của cả hàng
                object[] rowData = clickedRow.Cells.Cast<DataGridViewCell>()
                                                  .Select(cell => cell.Value.ToString().Trim())
                                                  .ToArray();

                inpMatKhau.Text = rowData[3].ToString();
                inpTenDangNhap.Text = rowData[1].ToString();
                comboQuyenHeThong.SelectedItem = rowData[4].ToString();
                inpTenNguoiDung.Text = rowData[2].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inpTenNguoiDung.Text != "" && inpMatKhau.Text != "")
            {
                inpMatKhau.Enabled = inpTenDangNhap.Enabled = inpTenNguoiDung.Enabled = comboQuyenHeThong.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inpTenNguoiDung.Text != "" && inpMatKhau.Text != "")
            {
                var db = new ketoantienluongEntities();
                var ng = db.nguoidungs.Where(p => p.tendangnhap == inpTenDangNhap.Text);
                db.nguoidungs.RemoveRange(ng);
                db.SaveChanges();
                inpMatKhau.Enabled = inpTenDangNhap.Enabled = inpTenNguoiDung.Enabled = comboQuyenHeThong.Enabled = false;
                inpMatKhau.Text = inpTenDangNhap.Text = inpTenNguoiDung.Text = "";
                comboQuyenHeThong.SelectedIndex = 1;
                dataGridViewNguoiDung.DataSource = db.nguoidungs.Select((p) => p).ToList().Select((p, i) => new nguoidung() {
                    id = i + 1,
                    matkhau = "******",
                    quyen = p.quyen,
                    tendangnhap = p.tendangnhap,
                    tennguoidung = p.tennguoidung,
                }).ToList();
                MessageBox.Show("Xóa thành công!");
            }
        }
    }
}
