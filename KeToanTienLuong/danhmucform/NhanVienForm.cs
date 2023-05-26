using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong.danhmucform
{
    public partial class NhanVienForm : UserControl
    {

        private string current_action = "none";
        public NhanVienForm()
        {
            InitializeComponent();
        }

        private List<dmnv> getDataSource()
        {
            var db = new ketoantienluongEntities();
            return db.dmnvs.ToList().Where(p => p.trangthai == 1).ToList();
        }

        private void resetInput()
        {
            inpBangCap.Text = inpDiaChi.Text = inpLuongCoban.Text = inpMa.Text = inpMaSoThue.Text
                = inpNgaySinh.Text = inpTen.Text = inpTrinhDo.Text = inpPhuThuoc.Text = "";
            comboBoxChucVu.SelectedIndex = comboBoxDMBP.SelectedIndex = comboBoxGioiTinh.SelectedIndex = 0;

            inpBangCap.Enabled = inpPhuThuoc.Enabled = inpDiaChi.Enabled = inpLuongCoban.Enabled = 
                inpMa.Enabled = inpMaSoThue.Enabled = inpNgaySinh.Enabled = inpTen.Enabled = 
                inpTrinhDo.Enabled = comboBoxChucVu.Enabled = comboBoxDMBP.Enabled = comboBoxGioiTinh.Enabled = false;

        }

        private void enableInput()
        {
            inpBangCap.Enabled = inpDiaChi.Enabled = inpLuongCoban.Enabled = comboBoxGioiTinh.Enabled = inpMaSoThue.Enabled = inpNgaySinh.Enabled = inpTen.Enabled = inpTrinhDo.Enabled = comboBoxChucVu.Enabled = comboBoxDMBP.Enabled = inpPhuThuoc.Enabled = true;

        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            dataGridView.ReadOnly = true;
            var db = new ketoantienluongEntities();

            dataGridView.DataSource = getDataSource();


            comboBoxDMBP.DataSource = db.dmbps.ToList().Where(p => p.trangthai == 1).Select(p => new dmbp() {
                Tenbp = p.Tenbp,
                Mabp = p.Mabp.Trim()
            }).ToList();
            comboBoxDMBP.DisplayMember = "Tenbp";
            comboBoxDMBP.ValueMember = "Mabp";

            comboBoxChucVu.DataSource = db.dmcvs.ToList().Where(p => p.trangthai == 1).Select(p => new dmcv() {
                tencv = p.tencv,
                macv = p.macv.Trim()
            }).ToList();
            comboBoxChucVu.DisplayMember = "tencv";
            comboBoxChucVu.ValueMember = "macv";

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
               }

        private void comboBoxDMBP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click_1(object sender, EventArgs e)
        {
            current_action = Util.Util.activeButton("add", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
            resetInput();
            enableInput();
            inpMa.Text = "Mã nhân viên sẽ được tạo tự động";
        }

        private bool validate()
        {
            var check = Util.Util.validateInput(inpBangCap, inpDiaChi, inpLuongCoban, inpMa, inpMaSoThue,
                inpNgaySinh, inpTen, inpTrinhDo, inpPhuThuoc);

            if (!check)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return false;
            }

            try
            {
                DateTime.ParseExact(inpNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                int.Parse(inpPhuThuoc.Text);
                decimal.Parse(inpLuongCoban.Text);
            }
            catch
            {
                MessageBox.Show(" - Ngày cần nhập theo định dạng dd/mm/yyyy\n - Số người phụ thuộc và lương cơ bản phải là số");
                return false;
            }

            return true;
        }

        private void buttonLuu_Click_1(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();
            try
            {
                if (current_action == "add")
                {
                    if (!validate()) return;
                    db.dmnvs.Add(new dmnv() {
                        manv = "NV_" + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss"),
                        tenv = inpTen.Text,
                        ngaysinh = DateTime.ParseExact(inpNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        diachi = inpDiaChi.Text,
                        trinhdo = inpTrinhDo.Text,
                        songuoiphuthuoc = int.Parse(inpPhuThuoc.Text),
                        mabp = comboBoxDMBP.SelectedValue.ToString(),
                        macv = comboBoxChucVu.SelectedValue.ToString(),
                        masothue = inpMaSoThue.Text,
                        bangcap = inpBangCap.Text,
                        luongcoban = decimal.Parse(inpLuongCoban.Text),
                        gioitinh = comboBoxGioiTinh.SelectedItem.ToString(),
                        trangthai = 1
                    }); ;
                    db.SaveChanges();

                    MessageBox.Show("Lưu thành công!");
                }
                if (current_action == "edit")
                {
                    if (!validate()) return;
                    var nv = db.dmnvs.FirstOrDefault(p => p.manv == inpMa.Text);
                    if (nv != null)
                    {
                        nv.tenv = inpTen.Text;
                        nv.ngaysinh = DateTime.ParseExact(inpNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        nv.diachi = inpDiaChi.Text;
                        nv.trinhdo = inpTrinhDo.Text;
                        nv.songuoiphuthuoc = int.Parse(inpPhuThuoc.Text);
                        nv.mabp = comboBoxDMBP.SelectedValue.ToString();
                        nv.macv = comboBoxChucVu.SelectedValue.ToString();
                        nv.masothue = inpMaSoThue.Text;
                        nv.bangcap = inpBangCap.Text;
                        nv.luongcoban = decimal.Parse(inpLuongCoban.Text);
                        nv.gioitinh = comboBoxGioiTinh.SelectedItem.ToString();
                        db.SaveChanges();

                        MessageBox.Show("Sửa thành công!");
                    }
                }

                dataGridView.DataSource = getDataSource();
                resetInput();

            }
            catch (Exception ee)
            {
                MessageBox.Show("Đã có lỗi xảy ra", ee.Message);
            }

            current_action = Util.Util.activeButton("save", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
            
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            current_action = Util.Util.activeButton("cancel", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
            resetInput();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (inpMa.Text == "" )
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên từ bảng để sửa!");
            } else
            {
                enableInput();
            }

            current_action = Util.Util.activeButton("edit", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (inpMa.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên từ bảng");
                return;
            }


            var db = new ketoantienluongEntities();
            var nv = db.dmnvs.FirstOrDefault(p => p.manv == inpMa.Text);
            if (nv != null)
            {
                nv.trangthai = 0;
                db.SaveChanges();
                MessageBox.Show("Xóa thành công!");
                dataGridView.DataSource = getDataSource();
                resetInput();
                Util.Util.activeButton("delete", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
            }

        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (e.RowIndex >= 0)
                {
                    DataGridView dataGridView = (DataGridView)sender;
                    DataGridViewRow clickedRow = dataGridView.Rows[e.RowIndex];

                    // Lấy dữ liệu của cả hàng
                    string[] rowData = clickedRow.Cells.Cast<DataGridViewCell>()
                                                      .Select(cell => {
                                                          if (cell.Value is DateTime value)
                                                          {
                                                              return value.ToString("dd/MM/yyyy")?.Trim();
                                                          }
                                                          else
                                                              return cell.Value?.ToString()?.Trim();
                                                      })
                                                      .ToArray();

                    inpMa.Text = rowData[0];
                    inpTen.Text = rowData[1];
                    inpNgaySinh.Text = rowData[2];
                    inpDiaChi.Text = rowData[3];
                    inpMaSoThue.Text = rowData[4];
                    comboBoxGioiTinh.SelectedItem = rowData[5];
                    comboBoxChucVu.SelectedValue = rowData[6];
                    comboBoxDMBP.SelectedValue = rowData[7];
                    inpBangCap.Text = rowData[8];
                    inpTrinhDo.Text = rowData[9];
                    inpPhuThuoc.Text = rowData[10];
                    inpLuongCoban.Text = rowData[12];

                }
            }
            catch { }
        }
    }
}
