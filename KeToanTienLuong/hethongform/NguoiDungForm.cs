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

        
        private void dataGridViewNguoiDung_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
                }

        ///--------------------------------

        private string current_action = "none";
        private void resetInput()
        {
            inpMatKhau.Text = inpTenDangNhap.Text = inpTenNguoiDung.Text = "";
            comboQuyenHeThong.SelectedIndex = 1;
            inpMatKhau.Enabled = inpTenDangNhap.Enabled = inpTenNguoiDung.Enabled = comboQuyenHeThong.Enabled = false;
        }
        private void enableInput()
        {
            inpMatKhau.Enabled = inpTenDangNhap.Enabled = inpTenNguoiDung.Enabled = comboQuyenHeThong.Enabled = true;

        }
        private void getDataSource()
        {
            var db = new ketoantienluongEntities();
            dataGridView.DataSource = db.nguoidungs.Select((p) => p).ToList().Select((p, i) => new nguoidung() {
                id = i + 1,
                matkhau = "******",
                quyen = p.quyen,
                tendangnhap = p.tendangnhap,
                tennguoidung = p.tennguoidung,
            }).ToList();
        }
        private bool validate()
        {
            var check = Util.Util.validateInput(inpMatKhau,inpTenDangNhap,inpTenNguoiDung);

            if (!check)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return false;
            }

            return true;
        }
        ///--------------------------------
        private void NguoiDungForm_Load(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();
            getDataSource();
            dataGridView.ReadOnly = true;
        }

        private void dgvdmtk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;
                DataGridViewRow clickedRow = dataGridView.Rows[e.RowIndex];

                // Lấy dữ liệu của cả hàng
                string[] rowData = clickedRow.Cells.Cast<DataGridViewCell>()
                                                  .Select(cell => cell.Value.ToString().Trim())
                                                  .ToArray();

                inpMatKhau.Text = rowData[3];
                if (current_action == "none")
                    inpTenDangNhap.Text = rowData[1];
                comboQuyenHeThong.SelectedItem = rowData[4];
                inpTenNguoiDung.Text = rowData[2];
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
                dataGridView.DataSource = db.nguoidungs.Select((p) => p).ToList().Select((p, i) => new nguoidung() {
                    id = i + 1,
                    matkhau = "******",
                    quyen = p.quyen,
                    tendangnhap = p.tendangnhap,
                    tennguoidung = p.tennguoidung,
                }).ToList();
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void buttonThem_Click_1(object sender, EventArgs e)
        {
            resetInput();
            enableInput();
            current_action = Util.Util.activeButton("add", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
        }

        private int manv_select = -1;

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (inpTenDangNhap.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 người dùng từ bảng để sửa!");
                current_action = Util.Util.activeButton("cancel", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
                return;
            }
            else
            {
                enableInput();
                inpTenDangNhap.Enabled = false;
            }

            current_action = Util.Util.activeButton("edit", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (inpTenDangNhap.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 người dùng từ bảng");
                return;
            }


            if (Util.Util.user_login.quyen == "Kế toán")
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này!");
                return;
            }

            var db = new ketoantienluongEntities();
            var p = db.nguoidungs.FirstOrDefault(p1 => p1.tendangnhap == inpTenDangNhap.Text);
            if (p != null)
            {
                if (Util.Util.user_login.tendangnhap == p.tendangnhap)
                {
                    MessageBox.Show("Bạn không thể tự xóa chính mình!");
                    return;
                }
                db.nguoidungs.Remove(p);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công!");
                getDataSource();
                resetInput();
                Util.Util.activeButton("delete", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
            }
        }

        private void buttonLuu_Click_1(object sender, EventArgs e)
        {
            try
            {
                var db = new ketoantienluongEntities();
                if (current_action == "add")
                {
                    if (!validate()) return;
                    db.nguoidungs.Add(new nguoidung() {
                        quyen = comboQuyenHeThong.SelectedItem.ToString(),
                        tennguoidung = inpTenNguoiDung.Text,
                        tendangnhap = inpTenDangNhap.Text,
                        matkhau = inpMatKhau.Text,
                    });

                    db.SaveChanges();


                    MessageBox.Show("Lưu thành công!");
                    resetInput();

                }

                if (current_action == "edit")
                {
                    if (!validate()) return;
                    var old = db.nguoidungs.FirstOrDefault(p => p.tendangnhap == inpTenDangNhap.Text);
                    if (old != null)
                    {
                        old.tendangnhap = inpTenDangNhap.Text;
                        old.tennguoidung = inpTenNguoiDung.Text;
                        if (inpMatKhau.Text != "******")
                            old.matkhau = inpMatKhau.Text;
                        old.quyen = comboQuyenHeThong.SelectedItem.ToString();
                        db.SaveChanges();
                        MessageBox.Show("Cập nhật thành công!");
                        resetInput();

                    }

                }

                current_action = Util.Util.activeButton("save", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
                getDataSource();
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra!");
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            current_action = Util.Util.activeButton("cancel", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
            resetInput();
        }
    }
}
