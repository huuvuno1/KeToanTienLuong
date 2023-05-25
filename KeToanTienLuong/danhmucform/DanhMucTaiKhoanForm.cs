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

        private void DanhMucTaiKhoanForm_Load(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();

            dgvdmtk.DataSource = db.dmtks.Select(p => p).ToList();
            dgvdmtk.Refresh();

            

            cbotkme.DataSource = a.Select(x => new {
                Name = x,   
            }).ToList();

            cbotkme.DisplayMember = "Name";
            cbotkme.ValueMember = "Name";
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            inpTenTk.Enabled = inpMaTk.Enabled = inpCapTk.Enabled = cbotkme.Enabled = true;
            Util.Util.activeButton("add", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {

            var db = new ketoantienluongEntities();
            db.dmtks.Add(new dmtk() {
                tkme = cbotkme.SelectedValue.ToString(),
                captk = int.Parse(inpCapTk.Text),
                matk = inpMaTk.Text,
                tentk = inpTenTk.Text,
            });
            db.SaveChanges();
            dgvdmtk.DataSource = db.dmtks.Select(p => p).ToList();
            dgvdmtk.Refresh();
            inpTenTk.Enabled = inpMaTk.Enabled = inpCapTk.Enabled = cbotkme.Enabled = false;
            inpTenTk.Text = inpMaTk.Text = inpCapTk.Text = cbotkme.Text = "";
            Util.Util.activeButton("add", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);

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

                inpMaTk.Text = rowData[0].ToString();
                inpCapTk.Text = rowData[3].ToString();
                cbotkme.SelectedValue = rowData[2].ToString();
                inpTenTk.Text = rowData[1].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inpMaTk.Text != "")
            {
                var db = new ketoantienluongEntities();
                var del = new dmtk() {
                    matk = inpMaTk.Text
                };
                db.dmtks.Attach(del);
                db.dmtks.Remove(del);
                db.SaveChanges();
                dgvdmtk.DataSource = db.dmtks.Select(p => p).ToList();
                Util.Util.activeButton("delete", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Util.Util.activeButton("cancel", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            Util.Util.activeButton("edit", buttonThem, buttonLuu, buttonHuy, buttonXoa, buttonSua);

        }

        private void pnDoiTuong_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
