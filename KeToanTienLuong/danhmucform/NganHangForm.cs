using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong.danhmucform
{
    public partial class NganHangForm : UserControl
    {
        public NganHangForm()
        {
            InitializeComponent();
        }

        ///--------------------------------

        private string current_action = "none";
        private void resetInput()
        {
            inpChiNhanh.Text = inpMa.Text = inpStk.Text = inpTen.Text = "";
            inpChiNhanh.Enabled = inpMa.Enabled = inpStk.Enabled = inpTen.Enabled = false;
        }
        private void enableInput()
        {
            inpChiNhanh.Enabled = inpStk.Enabled = inpTen.Enabled = true;

        }
        private void getDataSource()
        {
                var db = new ketoantienluongEntities();
                dataGridView.DataSource = db.dmnhs.ToList().Where(p => p.trangthai == 1).ToList();
        }
        private bool validate()
        {
            var check = Util.Util.validateInput(inpChiNhanh, inpStk, inpTen);

            if (!check)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return false;
            }

            return true;
        }
        ///--------------------------------
        private void buttonThem_Click(object sender, EventArgs e)
        {
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();
            db.dmnhs.Add(new dmnh() {
                so = inpMa.Text,
                chinhanh = inpChiNhanh.Text,
                tennh = inpTen.Text,
                stk = inpStk.Text
            });;

        }

        private void NganHangForm_Load(object sender, EventArgs e)
        {
            dataGridView.ReadOnly = true;
            getDataSource();
        }

        

        private void buttonLuu_Click_1(object sender, EventArgs e)
        {
            try
            {
                var db = new ketoantienluongEntities();
                if (current_action == "add")
                {
                    if (!validate()) return;
                    db.dmnhs.Add(new dmnh() {
                        so = "NH_" + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss"),
                        tennh = inpTen.Text,
                        chinhanh = inpChiNhanh.Text,
                        stk = inpStk.Text,
                        trangthai = 1,
                    });

                    db.SaveChanges();


                    MessageBox.Show("Lưu thành công!");
                    resetInput();

                }

                if (current_action == "edit")
                {
                    if (!validate()) return;
                    var nh = db.dmnhs.FirstOrDefault(p => p.so == inpMa.Text);
                    if (nh != null)
                    {
                        nh.tennh = inpTen.Text;
                        nh.chinhanh = inpChiNhanh.Text;
                        nh.stk = inpStk.Text;
                        nh.trangthai = 1;
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

        private void buttonThem_Click_1(object sender, EventArgs e)
        {
            resetInput();
            enableInput();
            inpMa.Text = "Mã ngân hàng sẽ được tạo tự động";
            current_action = Util.Util.activeButton("add", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            current_action = Util.Util.activeButton("cancel", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
            resetInput();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (inpMa.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 ngân hàng từ bảng để sửa!");
                current_action = Util.Util.activeButton("cancel", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
                return;
            }
            else
            {
                enableInput();
            }

            current_action = Util.Util.activeButton("edit", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (inpMa.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 bộ phận từ bảng");
                return;
            }


            var db = new ketoantienluongEntities();
            var nh = db.dmnhs.FirstOrDefault(p => p.so == inpMa.Text);
            if (nh != null)
            {
                nh.trangthai = 0;
                db.SaveChanges();
                MessageBox.Show("Xóa thành công!");
                getDataSource();
                resetInput();
                Util.Util.activeButton("delete", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
            }

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridView dataGridView = (DataGridView)sender;
                    DataGridViewRow clickedRow = dataGridView.Rows[e.RowIndex];

                    // Lấy dữ liệu của cả hàng
                    string[] rowData = clickedRow.Cells.Cast<DataGridViewCell>()
                                                      .Select(cell => cell.Value?.ToString()?.Trim())
                                                      .ToArray();

                    if (current_action == "none")
                        inpMa.Text = rowData[0];
                    inpStk.Text = rowData[1];
                    inpTen.Text = rowData[2];
                    inpChiNhanh.Text = rowData[3];

                }
            }
            catch { }
        }
    }
}
