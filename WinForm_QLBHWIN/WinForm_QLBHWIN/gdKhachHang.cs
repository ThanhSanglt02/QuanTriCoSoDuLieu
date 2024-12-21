using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForm_QLBHWIN
{
    public partial class gdKhachHang : Form
    {
        string sCon = "Data Source=DESKTOP-UJM6TJ3;Initial Catalog=QuanlybanhangWinMart;Integrated Security=True;Encrypt=False";
        DataTable dtKhachHang;
        public gdKhachHang()
        {
            InitializeComponent();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            SqlConnection con = new SqlConnection(sCon);

            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Co loi xay ra");
            }

            //Buoc 2: Lay du lieu ve
            // Gọi thủ tục sp_giaimaDVVC mà không truyền tham số (NULL)
            SqlCommand cmd = new SqlCommand("sp_giaimaKH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;

            tbMaKH.Enabled = false;
            // Đặt lại tên cột trong DataGridView
            dataGridView1.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            dataGridView1.Columns["LoaiKH"].HeaderText = "Loại Khách Hàng";
            dataGridView1.Columns["UuDai"].HeaderText = "Ưu Đãi";
            dataGridView1.Columns["decryptedSDT_KH"].HeaderText = "Số Điện Thoại";

            //Buoc 3: Dong ket noi
            con.Close();
        }

        //get iD of customer
        private string maKH(string sdt)
        {
            string maKH = "";
            string query = "GetMaKHBySDT"; // Gọi Stored Procedure

            using (SqlConnection conn = new SqlConnection(sCon))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Sử dụng Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Gắn tham số an toàn
                    cmd.Parameters.Add(new SqlParameter("@SoDienThoai", SqlDbType.NVarChar, 15)).Value = sdt;

                    try
                    {
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Lấy mã khách hàng từ kết quả
                                maKH = reader["MaKH"].ToString();
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi với cơ sở dữ liệu: {ex.Message}");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            return maKH;

        }

        private void QuanLyKH_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void button11_Insert(object sender, EventArgs e)
        {
            int loaiKH = 0;
            string sdt = tbSDT.Text.Trim();
            decimal uuDai = Convert.ToDecimal(tbUuDai.Text.Trim());

            //kiem tra button radio
            if (KhThanThiet.Checked && !KHVangLai.Checked)
            {
                loaiKH = 1;
            }
            else if (!KhThanThiet.Checked && KHVangLai.Checked)
            {
                loaiKH = 0;
            }

            if (sdt.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
            }
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Da xay ra loi");
                }

                SqlCommand cmd = new SqlCommand("sp_themkh", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Them cac tham so
                cmd.Parameters.Add(new SqlParameter("@loaiKH", loaiKH));
                cmd.Parameters.Add(new SqlParameter("@sdt_kh", sdt));
                cmd.Parameters.Add(new SqlParameter("@Uudai", uuDai));


                try
                {
                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Thêm khách hàng thành công!",
                        "Thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        LoadData();

                        tbMaKH.Enabled = false;
                        KhThanThiet.Checked = false;
                        KHVangLai.Checked = false;
                        tbSDT.Clear();
                        tbUuDai.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng không thành công!",
                        "Thất bại",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }


            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaKH.Text = dataGridView1.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
            string txtLoaiKH = dataGridView1.Rows[e.RowIndex].Cells["LoaiKh"].Value.ToString();
            tbSDT.Text = dataGridView1.Rows[e.RowIndex].Cells["decryptedSDT_KH"].Value.ToString();
            tbUuDai.Text = dataGridView1.Rows[e.RowIndex].Cells["UuDai"].Value.ToString();

            if (txtLoaiKH == "True")
            {
                KhThanThiet.Checked = true;
            }
            else
            {
                KHVangLai.Checked = true;
            }
            //enable input maKh
            tbMaKH.Enabled = false;
        }
        private int getTypeofRadioKH()
        {
            int loaiKh = 0;
            if (KhThanThiet.Checked && !KHVangLai.Checked)
            {
                loaiKh = 1;

            }
            else if (!KhThanThiet.Checked && KHVangLai.Checked)
            {
                loaiKh = 0;
            }
            return loaiKh;
        }
        
        private void button9_Update(object sender, EventArgs e)
        {
            string maKH = tbMaKH.Text.Trim();
            string sdt = tbSDT.Text.Trim();
            decimal uuDai = Convert.ToDecimal(tbUuDai.Text.Trim());

            //kiem tra so dien thoai va kiem tra radio
            if ((KhThanThiet.Checked && !KHVangLai.Checked) && sdt == "")
            {
                MessageBox.Show("Vui lòng điền số điện thoại");
            }
            else if ((!KhThanThiet.Checked && KHVangLai.Checked) && sdt != "")
            {
                MessageBox.Show("Số điện thoại không hợp lệ với loại khách hàng");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(sCon))
                {
                    try
                    {
                        conn.Open();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Da xay ra loi" + ex.Message);
                    }
                    SqlCommand cmd = new SqlCommand("sp_updateKH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Them cac tham so
                    cmd.Parameters.Add(new SqlParameter("@maKH", maKH));
                    cmd.Parameters.Add(new SqlParameter("@loaiKH", getTypeofRadioKH()));
                    cmd.Parameters.Add(new SqlParameter("@sdt_kh", sdt));
                    cmd.Parameters.Add(new SqlParameter("@Uudai", uuDai));


                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Cập nhật khách hàng thành công!",
                            "Thành công",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                            //cap nhat dữ liệu trực tiếp vào DataGridView
                            LoadData();

                            tbMaKH.Enabled = false;
                            KhThanThiet.Checked = false;
                            KHVangLai.Checked = false;
                            tbSDT.Clear();
                            tbUuDai.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật khách hàng không thành công!",
                            "Thất bại",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xay ra loi khi chay lệnh", ex.Message);
                    }


                }
            }
        }

        private void button10_delete_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Có chắc chắn xóa hay không ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                using (SqlConnection conn = new SqlConnection(sCon))
                {
                    try
                    {
                        conn.Open();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Da xay ra loi");
                    }
                    string maKH = tbMaKH.Text.Trim();
                    string query = "Delete KHACHHANG where maKh = @maKH";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    //Them cac tham so
                    cmd.Parameters.Add(new SqlParameter("@maKH", maKH));


                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Xóa khách hàng thành công!",
                            "Thành công",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                            //cap nhat dữ liệu trực tiếp vào DataGridView
                            LoadData();

                            tbMaKH.Enabled = false;
                            KhThanThiet.Checked = false;
                            KHVangLai.Checked = false;
                            tbSDT.Clear();
                            tbUuDai.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Xóa khách hàng không thành công!",
                            "Thất bại",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xay ra loi khi chay lệnh");
                    }

                }
            }
            
        }

        private void button13_huy_Click(object sender, EventArgs e)
        {
            tbMaKH.Enabled = false;
            tbMaKH.Clear();
            KhThanThiet.Checked = false;
            KHVangLai.Checked = false;
            tbSDT.Clear();
            tbUuDai.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormQLBH bh =new FormQLBH();
            bh.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gdSanPham sp = new gdSanPham();
            sp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormNV nv = new FormNV();
            nv.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gdDatHang datHang = new gdDatHang();
            datHang.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gdNCC ncc = new gdNCC();
            ncc.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormDVVC dvvc = new FormDVVC();
            dvvc.Show();
            this.Close();
        }

        private void tbMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void textBox1_search_KeyDown(object sender, KeyEventArgs e)
        {
            string sdtMaKH = textBox1_search.Text.Trim();
            if (e.KeyCode == Keys.Enter)
            {

                // Gọi Stored Procedure
                string sQuery = "SearchKhachHang";

                using (SqlConnection conn = new SqlConnection(sCon))
                {
                    try
                    {
                        conn.Open();

                        // Sử dụng SqlCommand với Stored Procedure
                        SqlCommand cmd = new SqlCommand(sQuery, conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số đầu vào
                        cmd.Parameters.Add(new SqlParameter("@Keyword", SqlDbType.NVarChar, 50)).Value = sdtMaKH;

                        // Lấy dữ liệu về DataSet
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();

                        adapter.Fill(ds, "KhachHang");
                        dataGridView1.DataSource = ds.Tables["KhachHang"];
                        dataGridView1.ReadOnly = true;

                        tbMaKH.Enabled = false;
                        textBox1_search.Text = sdtMaKH;

                        // Kiểm tra kết quả
                        if (ds.Tables["KhachHang"].Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy khách hàng nào với thông tin này.");
                            LoadData(); // Hàm nạp lại dữ liệu mặc định
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                    }
                }
            }
            
        }

        private string placeholderText = "Tìm kiếm khách hàng theo số điện thoại hoặc mã khách hàng";

        private void textBox1_search_Enter(object sender, EventArgs e)
        {
            // Chỉ xóa placeholder nếu TextBox đang chứa placeholder
            if (textBox1_search.Text == placeholderText)
            {
                textBox1_search.Text = ""; // Xóa placeholder
                textBox1_search.ForeColor = Color.Black; // Đổi màu chữ về màu bình thường
            }
        }

        private void textBox1_search_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1_search.Text))
            {
                textBox1_search.Text = placeholderText; // Khôi phục placeholder nếu không nhập gì
                textBox1_search.ForeColor = Color.Gray;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
