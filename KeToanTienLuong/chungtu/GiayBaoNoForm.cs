using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong.chungtu
{
    public partial class GiayBaoNoForm : UserControl
    {
        public int _them = 0;
        LopDungChung kn = new LopDungChung();
        public string _Tenbang = "phieuchi";
        public string _Tenbangchitiet = "chitietphieu";
        public string _so = "";
        DataTable dtct = new DataTable();

        public GiayBaoNoForm()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void dgvchitietchungtu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public bool kiemtradulieu()
        {
            if (txtso.Text.Trim() == "")
            {
                MessageBox.Show("số không được để trống");
                txtso.Select();
                return false;
            }
            else return true;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (kiemtradulieu() == false) return;
            try
            {
                if (_them == 1)
                {
                    string tentruong = "so,ngay,manv,manh,noidung,ctlq";
                    string giatri = "'" + txtso.Text +
                        "',N'" + Convert.ToDateTime(dtngay.Value.ToShortDateString()).ToString("MM/dd/yy") +
                        "','" + cbomanv.SelectedValue +
                        "','" + cbomanh.SelectedValue +
                        "',N'" + txtnoidung.Text +
                        "',N'" + txtctlq.Text + "'";
                    if (kn.them(_Tenbang, tentruong, giatri, "so", txtso.Text.Trim(), true) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        txtso.Text = "";
                        MessageBox.Show("mã đã tồn tại");
                        txtso.Select();
                        return;
                    }
                }
                else
                {
                    string capnhat = "ngay=N'" + Convert.ToDateTime(dtngay.Value.ToShortDateString()).ToString("MM/dd/yy") + "',";
                    capnhat += "manv='" + cbomanv.SelectedValue + "',";
                    capnhat += "manh='" + cbomanh.SelectedValue + "',";
                    capnhat += "noidung=N'" + txtnoidung.Text + "',";
                    capnhat += "ctlq='" + txtctlq.Text + "'";
                    if (kn.sua(_Tenbang, capnhat, "so", txtso.Text.Trim()))
                    {
                        MessageBox.Show("cập nhật thành công");

                    }
                    else
                    {
                        MessageBox.Show("cập nhật thất bại");
                        return;
                    }
                }



                kn.xoa(_Tenbangchitiet, "so", _so);
                for (int i = 0; i < dtct.Rows.Count; i++)
                {
                    string tentruong = "so,tkno,tkco,noidung,tien";
                    string giatri = "'" + txtso.Text +
                        "','" + dtct.Rows[i]["tkno"].ToString() +
                        "','" + dtct.Rows[i]["tkco"].ToString() +
                        "',N'" + dtct.Rows[i]["noidung"].ToString() +
                        "'," + dtct.Rows[i]["tien"].ToString();
                    kn.them(_Tenbangchitiet, tentruong, giatri);
                }
            }
            catch
            {
            }
        }
    }
}
