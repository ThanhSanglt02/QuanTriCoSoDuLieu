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

namespace WinForm_QLBHWIN
{
    public partial class gdSanPham : Form
    {
        string sCon = "Data Source=DESKTOP-UJM6TJ3;Initial Catalog=QuanlybanhangWinMart;Integrated Security=True";
        DataTable dtSanPham;
        public gdSanPham()
        {
            InitializeComponent();
        }

        //load data
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
            string sQuery = "select * from SanPham";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            //data SP table
            adapter.Fill(ds, "SanPham");
            dtSanPham = ds.Tables["SanPham"];
            dataGridView1.DataSource = dtSanPham;
            dataGridView1.ReadOnly = true;

            //data Dat_chitiet table

            tbMaHV.Enabled = false;
            tbMaSp.Enabled = false;

            //Buoc 3: Dong ket noi
            con.Close();
        }

        //set data from gridview1
        private void displayData(DataGridViewCellEventArgs e)
        {
            tbMaHV.Text = dataGridView1.Rows[e.RowIndex].Cells["MaHangVin"].Value.ToString();
            tbMaSp.Text = dataGridView1.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
            tbTenSP.Text = dataGridView1.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
            tbDonVi.Text = dataGridView1.Rows[e.RowIndex].Cells["DVT"].Value.ToString();
            tbGiaNhap.Text = dataGridView1.Rows[e.RowIndex].Cells["DonGiaNhap"].Value.ToString();
            tbGiaBan.Text = dataGridView1.Rows[e.RowIndex].Cells["DonGiaBan"].Value.ToString();
            tbKM.Text = dataGridView1.Rows[e.RowIndex].Cells["KhuyenMai"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["HanSuDung"].Value.ToString());
            tbSL.Text = dataGridView1.Rows[e.RowIndex].Cells["Sl_SP"].Value.ToString();

            tbMaSp.Enabled = false;
            tbMaHV.Enabled = false;


        }

        //clear input
        private void clearDataInput()
        {
            tbMaHV.Clear();
            tbMaSp.Clear();
            tbTenSP.Clear();
            tbDonVi.Clear();
            tbGiaNhap.Clear();
            tbGiaBan.Clear();
            tbKM.Clear();
            dateTimePicker1.Value = DateTime.Now;
            tbSL.Clear();
        }

        private void gdSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string tenSP = tbTenSP.Text;
            string donVi = tbDonVi.Text;
            decimal giaNhap = Convert.ToDecimal(tbGiaNhap.Text);
            string kM = tbKM.Text;
            DateTime hsd = dateTimePicker1.Value;
            int sl = Convert.ToInt32(tbSL.Text);

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

                SqlCommand cmd = new SqlCommand("spChkSP", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Them cac tham so
                cmd.Parameters.Add(new SqlParameter("@tensp", tenSP));
                cmd.Parameters.Add(new SqlParameter("@DVT", donVi));
                cmd.Parameters.Add(new SqlParameter("@DonGiaNhap", giaNhap));
                cmd.Parameters.Add(new SqlParameter("@khuyenMai", kM));
                cmd.Parameters.Add(new SqlParameter("@hanSuDung", hsd));
                cmd.Parameters.Add(new SqlParameter("@sl_sp", sl));


                //Tham số output
                // Khai báo đối tượng parameter với SqlParameter 
                SqlParameter kqParam = new SqlParameter("@kq", SqlDbType.Int);
                kqParam.Direction = ParameterDirection.Output;

                // Them tham số output vào cmd
                cmd.Parameters.Add(kqParam);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }

                int result = Convert.ToInt32(kqParam.Value);
                if (result == 1)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    //Thêm dữ liệu trực tiếp vào DataGridView
                    LoadData();
                    clearDataInput();

                    tbMaHV.Enabled = false;
                    tbMaSp.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công!",
                    "Thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string maHV = tbMaHV.Text;
            string maSP = tbMaSp.Text;
            string tenSP = tbTenSP.Text;
            string donVi = tbDonVi.Text;
            decimal giaNhap = Convert.ToDecimal(tbGiaNhap.Text);
            decimal giaBan = Convert.ToDecimal(tbGiaBan.Text);
            string kM = tbKM.Text;
            DateTime hsd = dateTimePicker1.Value;
            int sl = Convert.ToInt32(tbSL.Text);

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

                
                SqlCommand cmd = new SqlCommand("spUpdateSP", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Them cac tham so
                cmd.Parameters.Add(new SqlParameter("@maHV", maHV));
                cmd.Parameters.Add(new SqlParameter("@maSP", maSP));
                cmd.Parameters.Add(new SqlParameter("@tensp", tenSP));
                cmd.Parameters.Add(new SqlParameter("@DVT", donVi));
                cmd.Parameters.Add(new SqlParameter("@DonGiaNhap", giaNhap));
                cmd.Parameters.Add(new SqlParameter("@DonGiaBan", giaBan));
                cmd.Parameters.Add(new SqlParameter("@khuyenMai", kM));
                cmd.Parameters.Add(new SqlParameter("@hanSuDung", hsd));
                cmd.Parameters.Add(new SqlParameter("@sl_sp", sl));


                //Tham số output
                // Khai báo đối tượng parameter với SqlParameter 
                SqlParameter kqParam = new SqlParameter("@kq", SqlDbType.Int);
                kqParam.Direction = ParameterDirection.Output;

                // Them tham số output vào cmd
                cmd.Parameters.Add(kqParam);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }

                int result = Convert.ToInt32(kqParam.Value);
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    //Thêm dữ liệu trực tiếp vào DataGridView
                    LoadData();

                    tbMaHV.Enabled = false;
                    tbMaSp.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Cập nhật sản phẩm không thành công!",
                    "Thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                    string maHV = tbMaHV.Text.Trim();
                    string maSP = tbMaSp.Text.Trim();
                    string query = "Delete SANPHAM where MaHangVin = @maHV and maSP = @maSP";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    //Them cac tham so
                    cmd.Parameters.Add(new SqlParameter("@maHV", maHV));
                    cmd.Parameters.Add(new SqlParameter("@maSP", maSP));


                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Xóa sản phẩm thành công!",
                            "Thành công",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                            //cap nhat dữ liệu trực tiếp vào DataGridView
                            LoadData();

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

        private void button5_Click(object sender, EventArgs e)
        {
            gdKhachHang khachHang = new gdKhachHang();
            khachHang.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            displayData(e);
        }

        private void button13_huy_Click(object sender, EventArgs e)
        {
            clearDataInput();
            LoadData();
        }

        private void textBox1_search_KeyDown(object sender, KeyEventArgs e)
        {
            string tkTenSp = textBox1_search.Text.Trim();
            if (e.KeyCode == Keys.Enter)
            {

                string sQuery = "Select * from SANPHAM where TenSP like @tenSP";
                using (SqlConnection conn = new SqlConnection(sCon))
                {
                    try
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand(sQuery, conn);
                        cmd.Parameters.AddWithValue("@tenSP", "%" + tkTenSp + "%");


                        //lay du lieu ve
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        DataSet ds = new DataSet();

                        adapter.Fill(ds, "SANPHAM");
                        dataGridView1.DataSource = ds.Tables["SANPHAM"];
                        dataGridView1.ReadOnly = true;

                        tbMaHV.Enabled = false;
                        tbMaSp.Enabled = false;
                        textBox1_search.Text = tkTenSp;

                        if (ds.Tables["SANPHAM"].Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm tên sản phẩm.");
                            LoadData();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Co loi xay ra");
                    }
                }
            }
        }

        private string placeholderText = "Tìm kiếm tên sản phẩm";
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

        private void button3_Click(object sender, EventArgs e)
        {
            gdKhachHang kh = new gdKhachHang();
            kh.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gdNCC ncc = new gdNCC();
            ncc.Show();
            this.Hide();
        }
    }
}
