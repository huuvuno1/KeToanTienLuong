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
    public partial class ChucVuForm : UserControl
    {
        public ChucVuForm()
        {
            InitializeComponent();
        }

        private void resetInput()
        {
            inpMaCv.Text = inpMoTa.Text = inpTen.Text = "";
            inpMaCv.Enabled = inpMoTa.Enabled = inpTen.Enabled = false;
        }

        private void enableInput()
        {
            inpMoTa.Enabled = inpTen.Enabled = true;
        }

        private void getDataSource()
        {
            var db = new ketoantienluongEntities();
            dataGridView.DataSource = db.dmcvs.ToList().Where(p => p.trangthai == 1).ToList();
        }

        private void ChucVuForm_Load(object sender, EventArgs e)
        {
            getDataSource();
            dataGridView.ReadOnly = true;
        }


        private void buttonThem_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            
        }

        private bool validate()
        {
            var check = Util.Util.validateInput(inpMoTa, inpTen);

            if (!check)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return false;
            }

            return true;
        }

        private void buttonLuu_Click_1(object sender, EventArgs e)
        {
             try
            {
                var db = new ketoantienluongEntities();
                if (current_action == "add")
                {
                    if (!validate()) return;
                    db.dmcvs.Add(new dmcv() {
                        macv = "CV_" + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss"),
                        mota = inpMoTa.Text,
                        tencv = inpTen.Text,
                        trangthai = 1
                    }); ;

                    db.SaveChanges();

                    MessageBox.Show("Lưu thành công!");
                    getDataSource();
                    resetInput();
                }

                if (current_action == "edit")
                {
                    if (!validate()) return;
                    var cv = db.dmcvs.FirstOrDefault(p => p.macv == inpMaCv.Text);
                    if (cv != null)
                    {
                        cv.tencv = inpTen.Text;
                        cv.mota = inpMoTa.Text;
                        db.SaveChanges();
                        MessageBox.Show("Cập nhật thành công!");
                        resetInput();

                    }
                    getDataSource();
                    resetInput();
                }

                current_action = Util.Util.activeButton("save", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);

            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }

        private string current_action = "none";
        private void buttonThem_Click_1(object sender, EventArgs e)
        {
            resetInput();
            enableInput();
            inpMaCv.Text = "Mã chức vụ sẽ được tạo tự động";
            current_action = Util.Util.activeButton("add", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            current_action = Util.Util.activeButton("cancel", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
            resetInput();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (inpMaCv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 chức vụ từ bảng để sửa!");
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
            if (inpMaCv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 chức vụ từ bảng");
                return;
            }


            var db = new ketoantienluongEntities();
            var cv = db.dmcvs.FirstOrDefault(p => p.macv == inpMaCv.Text);
            if (cv != null)
            {
                cv.trangthai = 0;
                db.SaveChanges();
                MessageBox.Show("Xóa thành công!");
                getDataSource();
                resetInput();
                Util.Util.activeButton("delete", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    inpMaCv.Text = rowData[0];
                inpTen.Text = rowData[1];
                inpMoTa.Text = rowData[2];

            }
        }
    }
}
