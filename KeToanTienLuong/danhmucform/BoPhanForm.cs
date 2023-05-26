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
    public partial class BoPhanForm : UserControl
    {
        public BoPhanForm()
        {
            InitializeComponent();
        }

        private void BoPhanForm_Load(object sender, EventArgs e)
        {
            dataGridViewBoPhan.ReadOnly = true;
            getDataSource();
        }

        private void getDataSource()
        {
            var db = new ketoantienluongEntities();
            dataGridViewBoPhan.DataSource = db.dmbps.ToList().Where(p => p.trangthai == 1).ToList();
        }

        private void resetInput()
        {
            inpDiaChi.Text = inpHotline.Text = inpMa.Text = inpTenBoPhan.Text = "";
            inpDiaChi.Enabled = inpHotline.Enabled = inpMa.Enabled = inpTenBoPhan.Enabled = false;
        }

        private void enableInput()
        {
            inpDiaChi.Enabled = inpHotline.Enabled = inpTenBoPhan.Enabled = true;
        }

        private string current_action = "none";

        private void buttonThem_Click(object sender, EventArgs e)
        {
            resetInput();
            enableInput();
            current_action = Util.Util.activeButton("add", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetInput();
            enableInput();
            inpMa.Text = "Mã bộ phận sẽ được tạo tự động";
            current_action = Util.Util.activeButton("add", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (inpMa.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 bộ phận từ bảng để sửa!");
                current_action = Util.Util.activeButton("cancel", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
                return;
            }
            else
            {
                enableInput();
            }

            current_action = Util.Util.activeButton("edit", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (inpMa.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 bộ phận từ bảng");
                return;
            }


            var db = new ketoantienluongEntities();
            var bp = db.dmbps.FirstOrDefault(p => p.Mabp == inpMa.Text);
            if (bp != null)
            {
                bp.trangthai = 0;
                db.SaveChanges();
                MessageBox.Show("Xóa thành công!");
                getDataSource();
                resetInput();
                Util.Util.activeButton("delete", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
            }

        }

        private bool validate()
        {
            var check = Util.Util.validateInput(inpDiaChi, inpHotline, inpTenBoPhan);

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
                    db.dmbps.Add(new dmbp() {
                        Mabp = "BP_" + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss"),
                        diachi = inpDiaChi.Text,
                        sdt = inpHotline.Text,
                        Tenbp = inpTenBoPhan.Text,
                        trangthai = 1,
                    });

                    db.SaveChanges();


                    MessageBox.Show("Lưu thành công!");
                    resetInput();

                }

                if (current_action == "edit")
                {
                    if (!validate()) return;
                    var bp = db.dmbps.FirstOrDefault(p => p.Mabp == inpMa.Text);
                    if (bp != null)
                    {
                        bp.diachi = inpDiaChi.Text;
                        bp.sdt = inpHotline.Text;
                        bp.Tenbp = inpTenBoPhan.Text;
                        db.SaveChanges();
                        MessageBox.Show("Cập nhật thành công!");
                        resetInput();

                    }

                }

                current_action = Util.Util.activeButton("save", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
                getDataSource();
            } catch
            {
                MessageBox.Show("Đã có lỗi xảy ra!");
            }
        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
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
                    inpTenBoPhan.Text = rowData[1];
                    inpDiaChi.Text = rowData[3];
                    inpHotline.Text = rowData[2];

                }
            } catch { }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            current_action = Util.Util.activeButton("cancel", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
            resetInput();
        }
    }
}
