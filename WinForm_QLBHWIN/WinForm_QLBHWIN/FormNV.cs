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
    public partial class FormNV : Form
    {
        string sCon = "Data Source=DESKTOP-UJM6TJ3;Initial Catalog=QuanlybanhangWinMart;Integrated Security=True;Encrypt=False";

        public FormNV()
        {
            InitializeComponent();
        }
        private void Data_Load()
        {
            using (SqlConnection connection = new SqlConnection(sCon))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("sp_giaimaNV", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@SDT_NV", DBNull.Value); // Truyền giá trị NULL nếu không lọc theo số điện thoại

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;  // Gán dữ liệu vào DataGridView

                    // Thiết lập tiêu đề các cột
                    dataGridView1.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
                    dataGridView1.Columns["TenNV"].HeaderText = "Tên Nhân Viên";
                    dataGridView1.Columns["decryptedSDT_NV"].HeaderText = "Số Điện Thoại";


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải dữ liệu: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
                
        }
        private void FormNV_Load(object sender, EventArgs e)
        {
            
            Data_Load();
        }

        private void bt_khoitao_Click(object sender, EventArgs e)
        {
            tx_nv.Clear();
            tx_sdt.Clear();
            tx_mnv.Clear();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCon))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT dbo.fGetNewIDNV()", connection); // Lấy mã nhân viên mới từ hàm fGetNewIDNV
                    string newID = cmd.ExecuteScalar().ToString();
                    tx_mnv.Text = newID;  // Hiển thị mã nhân viên mới vào TextBox tx_mnv
                    tx_mnv.ReadOnly = true; // Chuyển TextBox thành chỉ đọc
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi tạo mã nhân viên mới: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCon)) {
                try
                {
                    // Lấy dữ liệu từ các TextBox
                    string tenNV = tx_nv.Text.Trim();  // Tên nhân viên
                    string sdtNV = tx_sdt.Text.Trim();  // Số điện thoại nhân viên

                    // Kiểm tra tính hợp lệ của số điện thoại (phải có 10 ký tự)
                    if (string.IsNullOrEmpty(tenNV) || string.IsNullOrEmpty(sdtNV))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (sdtNV.Length != 10)
                    {
                        MessageBox.Show("Số điện thoại phải có đúng 10 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Mở kết nối tới cơ sở dữ liệu
                    connection.Open();

                    // Tạo SqlCommand để gọi thủ tục sp_themnv
                    SqlCommand cmd = new SqlCommand("sp_themnv", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số vào SqlCommand
                    cmd.Parameters.AddWithValue("@tennv", tenNV);
                    cmd.Parameters.AddWithValue("@sdt_nv", sdtNV);

                    // Thực thi thủ tục
                    cmd.ExecuteNonQuery();

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Nhân viên đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset các TextBox sau khi thêm thành công
                    tx_nv.Text = "";
                    tx_sdt.Text = "";

                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có lỗi
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Đảm bảo luôn đóng kết nối sau khi hoàn tất
                    connection.Close();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tx_mnv.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            tx_nv.Text = dataGridView1.Rows[e.RowIndex].Cells["TenNV"].Value.ToString();
            tx_sdt.Text = dataGridView1.Rows[e.RowIndex].Cells["decryptedSDT_NV"].Value.ToString();


            //enable input maKh
            tx_mnv.Enabled = false;
        }
    }
}
