using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_QLBHWIN
{
    public partial class gdNCC : Form
    {
        string sCon = "Data Source=DESKTOP-UJM6TJ3;Initial Catalog=QuanlybanhangWinMart;Integrated Security=True;Encrypt=False";
        DataTable dtNCC;
        public gdNCC()
        {
            InitializeComponent();
        }

        //loaddata
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
            SqlCommand cmd = new SqlCommand("sp_giaimaNCC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;

            tbMaNCC.Enabled = false;
            // Đặt lại tên cột trong DataGridView
            dataGridView1.Columns["MaNCC"].HeaderText = "Mã Nhà Cung Cấp";
            dataGridView1.Columns["TenNCC"].HeaderText = "Tên Nhà Cung Cấp";
            dataGridView1.Columns["DiaChiNCC"].HeaderText = "Địa chỉ";
            dataGridView1.Columns["decryptedSDT_NCC"].HeaderText = "Số Điện Thoại";

            //Buoc 3: Dong ket noi
            con.Close();
        }

        //clear input
        private void clearDataInput()
        {
            tbMaNCC.Clear();
            tbDiaChi.Clear();
            tbSDT.Clear();
            tbTenNCC.Clear();
        }
        private void gdNCC_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button11_insert_Click(object sender, EventArgs e)
        {
            string tenNCC = tbTenNCC.Text.Trim();
            string diaChi = tbDiaChi.Text.Trim();
            string sdt = tbSDT.Text.Trim();

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

                SqlCommand cmd = new SqlCommand("sp_themncc", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Them cac tham so
                cmd.Parameters.Add(new SqlParameter("@tenncc", tenNCC));
                cmd.Parameters.Add(new SqlParameter("@diachiNCC", diaChi));
                cmd.Parameters.Add(new SqlParameter("@SDT_NCC", sdt));

                
                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm nhà cung cấp thành công thành công!",
                        "Thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        LoadData();
                        clearDataInput();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhà cung cấp không thành công!",
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

        private void button13_huy_Click(object sender, EventArgs e)
        {
            clearDataInput();
        }

        private void button9_update_Click(object sender, EventArgs e)
        {
            string maNCC = tbMaNCC.Text.Trim();
            string tenNCC = tbTenNCC.Text.Trim();
            string diaChi = tbDiaChi.Text.Trim();
            string sdt = tbSDT.Text.Trim();
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

                SqlCommand cmd = new SqlCommand("sp_updateNCC", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Them cac tham so
                cmd.Parameters.Add(new SqlParameter("@maNCC", maNCC));
                cmd.Parameters.Add(new SqlParameter("@tenncc", tenNCC));
                cmd.Parameters.Add(new SqlParameter("@diachiNCC", diaChi));
                cmd.Parameters.Add(new SqlParameter("@sdt_ncc", sdt));

               

                try
                {
                    int result =  cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Cập nhật nhà cung cấp thành công thành công!",
                        "Thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật nhà cung cấp không thành công!",
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

        private void button10_delete_Click(object sender, EventArgs e)
        {
            string maNCC = tbMaNCC.Text.Trim();
            DialogResult ret = MessageBox.Show("Có chắc chắn xóa hay không ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
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
                    string sQuery = "Delete NHACUNGCAP where MaNCC = @maNCC";
                    SqlCommand cmd = new SqlCommand(sQuery, con);

                    //Them cac tham so
                    cmd.Parameters.AddWithValue("@maNCC", maNCC);

                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Xóa nhà cung cấp thành công!",
                            "Thành công",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                            //cap nhat dữ liệu trực tiếp vào DataGridView
                            LoadData();
                            clearDataInput();
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhà cung cấp không thành công!",
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
        }

        private void textBox1_search_KeyDown(object sender, KeyEventArgs e)
        {
            string sdtMaNCC = textBox1_search.Text.Trim();
            if (e.KeyCode == Keys.Enter)
            {

                string sQuery = "SearchNCC";
                using (SqlConnection conn = new SqlConnection(sCon))
                {
                    try
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand(sQuery, conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@Keyword", SqlDbType.NVarChar, 50)).Value = sdtMaNCC;


                        //lay du lieu ve
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();

                        adapter.Fill(ds, "NHACUNGCAP");
                        dataGridView1.DataSource = ds.Tables["NHACUNGCAP"];
                        dataGridView1.ReadOnly = true;

                        tbMaNCC.Enabled = false;
                        textBox1_search.Text = sdtMaNCC;

                        // Kiểm tra kết quả
                        if (ds.Tables["NHACUNGCAP"].Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy nhà cung cấp");
                            LoadData(); // Hàm nạp lại dữ liệu mặc định
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Co loi xay ra", ex.Message);
                    }
                }
            }
        }
        private string placeholderText = "Tìm kiếm nhà cung cấp theo số điện thoại hoặc mã nhà cung cấp";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaNCC.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNCC"].Value.ToString();
            tbTenNCC.Text = dataGridView1.Rows[e.RowIndex].Cells["TenNCC"].Value.ToString();
            tbDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChiNCC"].Value.ToString();
            tbSDT.Text = dataGridView1.Rows[e.RowIndex].Cells["decryptedSDT_NCC"].Value.ToString();


            //enable input maKh
            tbMaNCC.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gdDatHang dh = new gdDatHang();
            dh.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gdKhachHang kh = new gdKhachHang();
            kh.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gdSanPham sp = new gdSanPham();
            sp.Show();
            this.Hide();
        }
    }
}
