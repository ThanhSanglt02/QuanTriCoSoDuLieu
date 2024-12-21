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
    public partial class FormDVVC : Form
    {
        string sCon = "Data Source=DESKTOP-UJM6TJ3;Initial Catalog=QuanlybanhangWinMart;Integrated Security=True";
        public FormDVVC()
        {
            InitializeComponent();
        }

        private void FormDVVC_Load(object sender, EventArgs e)
        {
            LoadData();
            tb_ngh.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(sCon))
            {
                try
                {
                    connection.Open();

                    // Gọi thủ tục sp_giaimaDVVC mà không truyền tham số (NULL)
                    SqlCommand cmd = new SqlCommand("sp_giaimaDVVC", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Đặt lại tên cột trong DataGridView
                    dataGridView1.Columns["MaDVVC"].HeaderText = "Mã Đơn Vị Vận Chuyển";
                    dataGridView1.Columns["TenNVC"].HeaderText = "Tên Đơn Vị Vận Chuyển";
                    dataGridView1.Columns["NgayGiaoHang"].HeaderText = "Ngày Giao Hàng";
                    dataGridView1.Columns["decryptedSDT_NVC"].HeaderText = "Số Điện Thoại";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCon))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT dbo.fGetNewIDDVVC()", connection);
                    string newID = cmd.ExecuteScalar().ToString();
                    tx_mdvvc.Text = newID;
                    tx_mdvvc.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi tạo mã DVVC: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void bt_khoitao_Click(object sender, EventArgs e)
        {
            tx_mdvvc.Clear();
            tx_sdt.Clear();
            tx_tdvvc.Clear();
            tx_mdvvc.ReadOnly = false;
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            tx_mdvvc.Clear();
            tx_sdt.Clear();
            tx_tdvvc.Clear();
            tx_mdvvc.ReadOnly = false;
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            string tenNVC = tx_tdvvc.Text.Trim();
            string ngayGiaoHang = tb_ngh.Text.Trim();
            string sdtNVC = tx_sdt.Text.Trim();

            // Kiểm tra tính hợp lệ của dữ liệu nhập vào
            if (string.IsNullOrEmpty(tenNVC) || string.IsNullOrEmpty(sdtNVC))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (sdtNVC.Length != 10)  // Kiểm tra số điện thoại
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo kết nối và gọi thủ tục SQL
            using (SqlConnection connection = new SqlConnection(sCon))
            {
                try
                {
                    connection.Open();

                    // Tạo SqlCommand để gọi thủ tục sp_themdvvc
                    SqlCommand cmd = new SqlCommand("sp_themdvvc", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số vào thủ tục
                    cmd.Parameters.AddWithValue("@tennvc", tenNVC);
                    cmd.Parameters.AddWithValue("@ngaygiaohang", ngayGiaoHang);
                    cmd.Parameters.AddWithValue("@SDT_NVC", sdtNVC);

                    // Thực thi thủ tục
                    cmd.ExecuteNonQuery();

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Đơn vị vận chuyển đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset các TextBox sau khi thêm thành công
                    tx_tdvvc.Text = "";
                    tx_sdt.Text = "";
                    tb_ngh.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                }
                catch (Exception ex)
                {
                    // Hiển thị lỗi nếu có
                    MessageBox.Show("Lỗi khi thêm đơn vị vận chuyển: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void bt_qlbh_Click(object sender, EventArgs e)
        {
            FormQLBH bh = new FormQLBH();
            bh.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gdKhachHang kh = new gdKhachHang();
            kh.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNV nv =new FormNV();
            nv.Show();
            this.Close();
        }

        private void bt_qlsp_Click(object sender, EventArgs e)
        {
            gdSanPham sp = new gdSanPham();
            sp.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gdDatHang dh = new gdDatHang();
            dh.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gdNCC ncc = new gdNCC();
            ncc.Show();
            this.Close();
        }
    }
}
