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
    public partial class DanhMucTaiKhoanForm : UserControl
    {

        string[] a = new string[] {
                "111", "112", "113", "121", "128", "131", "133", "136", "138", "141", "151", "152", "153", "154", "155", "156", "157", "158", "161", "171", "211", "212", "213", "214", "217", "221", "222", "228", "229", "241", "242", "243", "244", "331", "333", "334", "335", "336", "337", "338", "341", "343", "344", "347", "352", "353", "356", "357", "411", "412", "413", "414", "417", "418", "419", "421", "441", "461", "466", "511", "515", "521", "611", "621", "622", "623", "627", "631", "632", "635", "641", "642", "711", "811", "821", "911"
            };
        public DanhMucTaiKhoanForm()
        {
            InitializeComponent();
        }

        ///--------------------------------

        private string current_action = "none";
        private void resetInput()
        {
            inpTenTk.Text = inpMaTk.Text = inpCapTk.Text = "";
            cbotkme.SelectedIndex = 0;
            inpTenTk.Enabled = inpMaTk.Enabled = inpCapTk.Enabled = cbotkme.Enabled = false;
        }
        private void enableInput()
        {
            inpTenTk.Enabled = inpMaTk.Enabled = inpCapTk.Enabled = cbotkme.Enabled = true;


        }
        private void getDataSource()
        {
            var db = new ketoantienluongEntities();
            dataGridView.DataSource = db.dmtks.ToList().Where(p => p.trangthai == 1).ToList();
        }
        private bool validate()
        {
            var check = Util.Util.validateInput(inpTenTk, inpCapTk);

            if (!check)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return false;
            }

            try
            {
                int.Parse(inpCapTk.Text);
            }
            catch
            {
                MessageBox.Show("Cấp tài khoản không hợp lệ");
                return false;
            }

            return true;
        }
        ///--------------------------------

        private void DanhMucTaiKhoanForm_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ReadOnly = true;
            var db = new ketoantienluongEntities();

            getDataSource();

            

            cbotkme.DataSource = a.Select(x => new {
                Name = x,   
            }).ToList();

            cbotkme.DisplayMember = "Name";
            cbotkme.ValueMember = "Name";

            cbotkme.SelectedIndex = 0;
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

                if (current_action == "none")
                    inpMaTk.Text = rowData[0];
                inpCapTk.Text = rowData[2];
                cbotkme.SelectedValue = rowData[1];
                inpTenTk.Text = rowData[3];
            }
        }


        private void pnDoiTuong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            resetInput();
            enableInput();
            current_action = Util.Util.activeButton("add", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);

        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new ketoantienluongEntities();
                if (current_action == "add")
                {
                    if (!validate()) return;
                    var b = db.dmtks.FirstOrDefault(p => p.matk == inpMaTk.Text);
                    if (b != null)
                    {
                        MessageBox.Show("Mã tài khoản đã tồn tại!");
                        return;
                    }

                    db.dmtks.Add(new dmtk() {
                        tkme = cbotkme.SelectedValue.ToString(),
                        captk = int.Parse(inpCapTk.Text),
                        matk = inpMaTk.Text,
                        tentk = inpTenTk.Text,
                        trangthai = 1
                    });

                    db.SaveChanges();


                    MessageBox.Show("Lưu thành công!");
                    resetInput();

                }

                if (current_action == "edit")
                {
                    if (!validate()) return;
                    var tk = db.dmtks.FirstOrDefault(p => p.matk == inpMaTk.Text);
                    if (tk != null)
                    {
                        tk.tkme = cbotkme.SelectedValue.ToString();
                        tk.captk = int.Parse(inpCapTk.Text);
                        tk.tentk = inpTenTk.Text;
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

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (inpMaTk.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 tài khoản từ bảng để sửa!");
                current_action = Util.Util.activeButton("cancel", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
                return;
            }
            else
            {
                enableInput();
                inpMaTk.Enabled = false;
            }

            current_action = Util.Util.activeButton("edit", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (inpMaTk.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 tài khoản từ bảng");
                return;
            }


            var db = new ketoantienluongEntities();
            var tk = db.dmtks.FirstOrDefault(p => p.matk == inpMaTk.Text);
            if (tk != null)
            {
                tk.trangthai = 0;
                db.SaveChanges();
                MessageBox.Show("Xóa thành công!");
                getDataSource();
                resetInput();
                Util.Util.activeButton("delete", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnCacNut_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            current_action = Util.Util.activeButton("cancel", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
            resetInput();
        }
    }
}
