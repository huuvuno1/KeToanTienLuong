using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;


namespace KeToanTienLuong.chungtu
{
    public partial class PhieuChiForm : UserControl
    {
        public PhieuChiForm()
        {
            InitializeComponent();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new ketoantienluongEntities();
                if (current_action == "add")
                {
                    if (!validate()) return;
                    db.phieuchis.Add(new phieuchi() {
                        so = "PC_" + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss"),
                        ctlq = txtctlq.Text,
                        manv = cbomanv.SelectedValue.ToString(),
                        ngay = dtngay.Value,
                        tkno = comboBoxTkNo.SelectedValue.ToString(),
                        tkco = inpTkCo.Text,
                        tien = Decimal.Parse(inpTien.Text),
                        noidung = txtnoidung.Text
                    });

                    db.SaveChanges();


                    MessageBox.Show("Lưu thành công!");
                    resetInput();

                }

                if (current_action == "edit")
                {
                    if (!validate()) return;
                    var phieu = db.phieuchis.FirstOrDefault(p => p.so == txtso.Text);
                    if (phieu != null)
                    {
                        phieu.ctlq = txtctlq.Text;
                        phieu.ngay = dtngay.Value;
                        phieu.tkno = comboBoxTkNo.SelectedValue.ToString();
                        phieu.tkco = inpTkCo.Text;
                        phieu.manv = cbomanv.SelectedValue.ToString();
                        phieu.tien = Decimal.Parse(inpTien.Text);
                        phieu.noidung = txtnoidung.Text;

                        var confirm = MessageBox.Show("Việc sửa có thể sẽ ảnh hưởng đến giấy tờ khác, bạn có đồng ý không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                        if (confirm == DialogResult.Yes)
                        {
                            db.SaveChanges();
                            MessageBox.Show("Cập nhật thành công!");
                            resetInput();
                        }
                        else
                        {
                            return;
                        }

                    }

                }

                current_action = Util.Util.activeButton("save", buttonThem, buttonLuu, buttonHuy, new Button(), buttonSua); ;
                getDataSource();
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra!");
            }


        }

        private void addComboboxCell(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private bool checkBoxShow = false;


        private void pnDoiTuong_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void PhieuChiForm_Load(object sender, EventArgs e)
        {
            checkBoxShowAll.Checked = checkBoxShow;
            dataGridView.ReadOnly = true;
            cbomanv.DataSource = new ketoantienluongEntities().dmnvs.ToList().Where(p => p.trangthai == 1).Select(p => new dmnv() {
                manv = p.manv.Trim(),
                tenv = p.tenv.Trim()
            }).ToList() ;
            cbomanv.DisplayMember = "tenv";
            cbomanv.ValueMember = "manv";

            comboBoxTkNo.DataSource = new ketoantienluongEntities().dmtks.ToList().Where(p => p.trangthai == 1).Select(p => new dmtk() { 
                matk = p.matk.Trim()
            }).ToList();

            comboBoxTkNo.DisplayMember = "matk";
            comboBoxTkNo.ValueMember = "matk";

            getDataSource();

            inpTkCo.Text = "1111";

            cbomanv.Format += ComboBox1_Format;
        }

        private void ComboBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            // Định dạng lại giá trị hiển thị cho từng mục trong ComboBox
            if (e.ListItem is dmnv value)
            {
                // Tùy chỉnh định dạng ở đây, ví dụ: thêm tiền tố vào tên
                e.Value = value.manv.Trim() + " - " + value.tenv;
            }
        }
        ///--------------------------------

        private string current_action = "none";
        private void resetInput()
        {
            txtso.Text = txtnoidung.Text = txtctlq.Text = inpTien.Text =  "";
            try
            {
                cbomanv.SelectedIndex = 0;
            }
            catch { }
            dtngay.Value = DateTime.Now;
            txtso.Enabled = txtnoidung.Enabled = txtctlq.Enabled = inpTien.Enabled = inpTkCo.Enabled = cbomanv.Enabled = dtngay.Enabled = comboBoxTkNo.Enabled = false;
        }
        private void enableInput()
        {
            comboBoxTkNo.Enabled = true; 
            txtnoidung.Enabled = txtctlq.Enabled = inpTien.Enabled = cbomanv.Enabled = dtngay.Enabled = true;
        }
        private void getDataSource(params bool[] isChecked)
        {
            int trangthai = (isChecked.Length == 0 || !isChecked[0]) ? 1 : 0;

            var db = new ketoantienluongEntities();
            var query = from p in db.phieuchis
                        join nv in db.dmnvs on p.manv equals nv.manv
                        where nv.trangthai == trangthai
                        select new {
                            p.manv,
                            p.ngay,
                            p.noidung,
                            p.so,
                            p.tien,
                            p.tkco,
                            p.tkno,
                            nv.tenv,
                            p.ctlq
                        };
                            
            dataGridView.DataSource = query.ToList();
        }
        private bool validate()
        {
            var check = Util.Util.validateInput(txtctlq,inpTien,inpTkCo);

            try
            {
                Decimal.Parse(inpTien.Text);
            }
            catch
            {
                MessageBox.Show("Tiền không đúng định dạng!");
                return false;
            }

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
            resetInput();
            enableInput();
            txtso.Text = "Mã phiếu sẽ được tạo tự động";
            current_action = Util.Util.activeButton("add", buttonThem, buttonLuu, buttonHuy, new Button(), buttonSua);
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (txtso.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 phiếu từ bảng để sửa!");
                current_action = Util.Util.activeButton("cancel", buttonThem, buttonLuu, buttonHuy, new Button(), buttonSua);
                return;
            }
            else
            {
                enableInput();
            }

            current_action = Util.Util.activeButton("edit", buttonThem, buttonLuu, buttonHuy, new Button(), buttonSua);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;
                DataGridViewRow clickedRow = dataGridView.Rows[e.RowIndex];

                // Lấy dữ liệu của cả hàng
                string[] rowData = clickedRow.Cells.Cast<DataGridViewCell>()
                                                  .Select(cell => {
                                                      var x = cell.Value?.ToString()?.Trim();
                                                      return x == null ? "" : x;
                                                  })
                                                  .ToArray();

                if (current_action == "none")
                    txtso.Text = rowData[0];
                dtngay.Value = DateTime.Parse(rowData[1]);
                cbomanv.SelectedValue = rowData[2];
                txtnoidung.Text = rowData[4];
                txtctlq.Text = rowData[5];
                comboBoxTkNo.SelectedValue = rowData[6];
                inpTkCo.Text = rowData[7];
                inpTien.Text = rowData[8];


            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            current_action = Util.Util.activeButton("cancel", buttonThem, buttonLuu, buttonHuy, new Button(), buttonSua);
            resetInput();
        }

        private void checkBoxShowAll_CheckedChanged(object sender, EventArgs e)
        {
            getDataSource(checkBoxShowAll.Checked);

            if (checkBoxShowAll.Checked)
            {
                buttonHuy.Enabled = buttonThem.Enabled = buttonLuu.Enabled = buttonSua.Enabled = false;
            }
            else
            {
                buttonHuy.Enabled = buttonThem.Enabled = buttonLuu.Enabled = buttonSua.Enabled = true;
                resetInput();

            }
        }
    }
}
