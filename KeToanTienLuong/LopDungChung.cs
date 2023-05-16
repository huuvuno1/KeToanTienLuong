using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong
{
    class LopDungChung
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        //Chuỗi kết nối
        public SqlConnection Ketnoi1()
        {
            try
            {
                // string strconn = @"Data Source=.;Initial Catalog=KTTL_50;User ID=sa;Password=123";
                //SqlConnection con = new SqlConnection(strconn);
                con = new SqlConnection(Util.Util.getConnectionString());
                if (con.State == ConnectionState.Closed)
                    con.Open();
                return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
        }
        // lấy ra một bảng dữ liệu
        public DataTable laybang(string s1)
        {
            DataTable dt = new DataTable();
            SqlConnection con = Ketnoi1();
            //       string s1 = "SELECT Ma, Ten FROM dmtk";
            cmd.CommandText = s1;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            adt.SelectCommand = cmd;
            adt.Fill(dt);
            return dt;
        }
        // Kiểm tra thực thi các câu lệnh SQL
        public bool Kiemtrathucthilenh(string s1)
        {
            int ktra = 0;
            SqlConnection con = Ketnoi1();
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd.Connection = con;
                cmd.CommandText = s1;
                ktra = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (ktra > 0)
                return true;
            return false;
        }
        //Kiểm tra tính duy nhất, sử dụng trong trường hợp kiểm tra thêm mới, trả về true nếu có và false nếu không
        public bool Kiemtratinhduynhat(string tenbang, string tentruong, string giatri)
        {
            string strsql1 = "SELECT * FROM " + tenbang + " WHERE " + tentruong + " =  N'" + giatri + "'";
            DataTable dtkiemtratinhduynhat = new DataTable();
            dtkiemtratinhduynhat = laybang(strsql1);
            if (dtkiemtratinhduynhat.Rows.Count > 0)
                return true;
            return false;
        }
        //Kiểm tra tính duy nhất với khóa là 2 trường, sử dụng trong trường hợp kiểm tra thêm mới, trả về true nếu có và false nếu không
        public bool Kiemtratinhduynhat(string tenbang, string tentruong1, string giatri1, string tentruong2, string giatri2)
        {
            string strsql1 = "SELECT * FROM " + tenbang + " WHERE " + tentruong1 + " =  N'" + giatri1 + "'";
            strsql1 = strsql1 + " AND " + tentruong2 + " = N'" + giatri2 + "'";
            DataTable dtkiemtratinhduynhat = new DataTable();
            dtkiemtratinhduynhat = laybang(strsql1);
            if (dtkiemtratinhduynhat.Rows.Count > 0)
                return true;
            return false;
        }
        // Lấy một giá trị
        public string giatritrave(string s1)
        {
            SqlConnection con = Ketnoi1();
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandText = s1;
            cmd.Connection = con;
            string kq = cmd.ExecuteScalar().ToString();
            con.Close();
            cmd.Dispose();
            return kq;
        }
        // Lấy giá trị
        public string giatritrave(string tendn, string tenbang, string quyen)
        {
            SqlConnection con = Ketnoi1();
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandText = " select " + quyen +
                              " FROM " + tenbang + " where ten = '" + tendn + "'";
            cmd.Connection = con;
            string kq = cmd.ExecuteScalar().ToString();
            con.Close();
            cmd.Dispose();
            return kq;
        }
        // Thực thi câu lênh chèn dữ liệu
        public bool them(string tenbang, string atentruong, string agiatri)
        {
            try
            {
                string str = "";
                str = str + "INSERT INTO " + tenbang + "(";
                str += atentruong;
                str += ") VALUES (";
                str += agiatri;
                str += ")";
                bool ktra = Kiemtrathucthilenh(str);
                return ktra;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        // Thực thi câu lênh chèn dữ liệu có kiểm tra dữ liệu
        public bool them(string tenbang, string atentruong, string agiatri, string tentruong, string giatri, bool duynhat)
        {
            SqlConnection con = Ketnoi1();
            if (con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                if (Kiemtratinhduynhat(tenbang, tentruong, giatri) == true)
                {
                    //   MessageBox.Show("Đã tồn tại mã này, nhập lại mã khác");
                    return false;
                }
                else
                {
                    try
                    {
                        string str = "";
                        str = str + "INSERT INTO " + tenbang + "(";
                        str += atentruong;
                        str += ") VALUES (";
                        str += agiatri;
                        str += ")";
                        bool ktra = Kiemtrathucthilenh(str);
                        return ktra;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        // Thực thi câu lênh chèn dữ liệu có kiểm tra dữ liệu, chứng từ chi tiết vật tưu
        public bool them(string tenbang, string atentruong, string agiatri, string tentruong1, string giatri1, string tentruong2, string giatri2, bool duynhat)
        {
            SqlConnection con = Ketnoi1();
            if (con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                if (Kiemtratinhduynhat(tenbang, tentruong1, giatri2, tentruong2, giatri2) == true)
                {
                    //       MessageBox.Show("Đã tồn tại mã này, nhập lại mã khác");
                    return false;
                }
                else
                {
                    try
                    {
                        string str = "";
                        str = str + "INSERT INTO " + tenbang + "(";
                        str += atentruong;
                        str += ") VALUES (";
                        str += agiatri;
                        str += ")";
                        bool ktra = Kiemtrathucthilenh(str);
                        return ktra;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        // Thực thi câu lệnh update
        public bool sua(string tenbang, string acapnhat, string tentruong, string giatri)
        {
            try
            {
                string str = "";
                str = str + "UPDATE " + tenbang + " SET ";
                str += acapnhat;
                str += " WHERE ";
                str += tentruong + " = '" + giatri + "'";
                bool ktra = Kiemtrathucthilenh(str);
                return ktra;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        // Thực thi câu lệnh xóa
        public bool xoa(string tenbang, string tentruong, string giatri)
        {
            try
            {
                string str = "";
                str = str + "DELETE FROM " + tenbang + " WHERE ";
                str += tentruong + " = '" + giatri + "'";
                bool ktra = Kiemtrathucthilenh(str);
                return ktra;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        // Thực thi ngày tháng năm
        public string ngaythang(DateTime d1, DateTime d2)
        {
            string _bc = "";
            if (d1.Day != 1)
            {
                _bc = "Từ ngày " + d1.ToString("dd/MM/yyyy") + " đến ngày " + d2.ToString("dd/MM/yyyy");
            }
            else if (d1 == d2.AddDays(1).AddMonths(-1))
            {
                _bc = "Tháng " + d1.ToString("MM") + " năm " + d1.ToString("yyyy");
            }
            else if (d1.Year == d2.Year && d1.Month == 1 && d2.Month == 12 && d2.Day == 31)
            {
                _bc = "Năm " + d2.ToString("yyyy");
            }
            else if (d1.Month == 1 && d2.Day == 31 && d2.Month == 3)
            {
                _bc = "Quý I năm " + d2.ToString("yyyy");
            }
            else if (d1.Month == 4 && d2.Day == 30 && d2.Month == 6)
            {
                _bc = "Quý II năm " + d2.ToString("yyyy");
            }
            else if (d1.Month == 7 && d2.Day == 30 && d2.Month == 9)
            {
                _bc = "Quý III năm " + d2.ToString("yyyy");
            }
            else if (d1.Month == 10 && d2.Day == 31 && d2.Month == 12)
            {
                _bc = "Quý IV năm " + d2.ToString("yyyy");
            }
            else
            {
                _bc = "Từ ngày " + d1.ToString("dd/MM/yyyy") + " đến ngày " + d2.ToString("dd/MM/yyyy");
            }
            return _bc;
        }
    }
}
