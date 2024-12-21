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
    public partial class FormQLBH : Form
    {
        string sCon = "Data Source=DESKTOP-UJM6TJ3;Initial Catalog=QuanlybanhangWinMart;Integrated Security=True";
        public FormQLBH()
        {
            InitializeComponent();
        }

        private void FormQLBH_Load(object sender, EventArgs e)
        {
            LoadData();
            tb_hienthitg.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            DisplayNewIDBan();
        }
        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Lấy dữ liệu từ bảng BAN
                    string queryBAN = "SELECT TOP (50) [MaHDB], [NgayBan], [PTTT], [MaNV], [MaKH] FROM [QuanlybanhangWinMart].[dbo].[BAN]";
                    SqlDataAdapter adapterBAN = new SqlDataAdapter(queryBAN, con);
                    DataSet dsBAN = new DataSet();
                    adapterBAN.Fill(dsBAN, "BAN");
                    dataGridView2.DataSource = dsBAN.Tables["BAN"];


                    string queryBAN_CHITIET = "SELECT [MaHDB], [MaHangVin], [SL_Ban] FROM [QuanlybanhangWinMart].[dbo].[BAN_CHITIET]";
                    SqlDataAdapter adapterBAN_CHITIET = new SqlDataAdapter(queryBAN_CHITIET, con);
                    DataSet dsBAN_CHITIET = new DataSet();
                    adapterBAN_CHITIET.Fill(dsBAN_CHITIET, "BAN_CHITIET");
                    dataGridView1.DataSource = dsBAN_CHITIET.Tables["BAN_CHITIET"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        private void LoadBanChiTietData(string maHDB)
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Truy vấn để lấy dữ liệu từ bảng BAN_CHITIET dựa trên mã hóa đơn bán
                    string query = "SELECT [MaHDB], [MaHangVin], [SL_Ban] FROM [QuanlybanhangWinMart].[dbo].[BAN_CHITIET] WHERE [MaHDB] = @MaHDB";

                    // Sử dụng SqlCommand để thực thi truy vấn với tham số hóa
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Thêm tham số cho câu lệnh SQL
                        cmd.Parameters.AddWithValue("@MaHDB", maHDB);

                        // Sử dụng SqlDataAdapter để đổ dữ liệu vào DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Gắn DataTable làm nguồn dữ liệu cho DataGridView
                        dataGridView1.DataSource = dt;


                        dataGridView1.ReadOnly = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi tải dữ liệu từ bảng BAN_CHITIET: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DisplayNewIDBan()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(sCon))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.getNewIDBan()", con))
                    {
                        con.Open();
                        string newIDBan = cmd.ExecuteScalar()?.ToString();
                        tb_maHDB.Text = string.IsNullOrEmpty(newIDBan) ? "Không thể tạo mã mới" : newIDBan;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy mã hóa đơn bán mới: " + ex.Message);
            }
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            try
            {
                // Xác định PTTT từ các radio button 
                string spttt = "";
                if (radioButton1.Checked) spttt = "Tiền mặt";
                else if (radioButton2.Checked) spttt = "QR";
                else if (radioButton3.Checked) spttt = "ATM";

                // Lấy các giá trị từ giao diện
                string manv = tb_maNV.Text;
                string makh = tb_maKH.Text;

                // Gọi thủ tục kiểm tra dữ liệu trước 
                using (SqlConnection con = new SqlConnection(sCon))
                {
                    using (SqlCommand cmd = new SqlCommand("spChkBan", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Truyền tham số vào thủ tục
                        cmd.Parameters.AddWithValue("@ngayban", tb_hienthitg.Text);
                        cmd.Parameters.AddWithValue("@PTTT", spttt);
                        cmd.Parameters.AddWithValue("@manv", manv);
                        cmd.Parameters.AddWithValue("@maKH", makh);

                        // Thêm tham số OUT để nhận kết quả
                        SqlParameter kqParam = new SqlParameter("@kq", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(kqParam);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        // Kiểm tra kết quả trả về
                        bool isValid = Convert.ToBoolean(kqParam.Value);

                        if (isValid)
                        {
                            MessageBox.Show("Thêm hoá đơn bán thành công");
                            LoadData(); // Refresh dữ liệu sau khi lưu
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu không hợp lệ, vui lòng kiểm tra lại.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu hóa đơn: " + ex.Message);
            }
            tb_maHDB.ReadOnly = false;
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            tb_maHDB.ReadOnly = false;

            string mahdB = tb_maHDB.Text;

            if (string.IsNullOrEmpty(mahdB))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string thongbao = "";

                try
                {
                    using (SqlConnection con = new SqlConnection(sCon))
                    {
                        using (SqlCommand cmd = new SqlCommand("tDeleteHDB", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;


                            cmd.Parameters.AddWithValue("@mahdB", mahdB);


                            SqlParameter thongbaoParam = new SqlParameter("@thongbao", SqlDbType.NVarChar, 100)
                            {
                                Direction = ParameterDirection.Output
                            };
                            cmd.Parameters.Add(thongbaoParam);

                            // Mở kết nối và thực thi thủ tục
                            con.Open();
                            cmd.ExecuteNonQuery();

                            // Lấy thông báo trả về
                            thongbao = thongbaoParam.Value.ToString();

                            if (!string.IsNullOrEmpty(thongbao))
                            {
                                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Hóa đơn đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Cập nhật lại dữ liệu trên DataGridView
                                LoadData();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Sau khi hoàn tất, bật lại chế độ ReadOnly để tránh chỉnh sửa ngoài ý muốn
                    tb_maHDB.ReadOnly = true;
                }
            }
            else
            {
                // Người dùng chọn "No", không thực hiện xóa
                MessageBox.Show("Hóa đơn không được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void bt_tk_Click(object sender, EventArgs e)
        {
            string mahdB = tx_tk.Text.Trim(); // Lấy mã hóa đơn từ TextBox

            if (string.IsNullOrEmpty(mahdB))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(sCon))
                {
                    con.Open();
                    tb_mhdct.Clear();
                    tb_mh.Clear();
                    tx_sl.Clear();
                    // Câu truy vấn tìm kiếm hóa đơn
                    string query = "SELECT [MaHDB], [NgayBan], [PTTT], [MaNV], [MaKH] " +
                                   "FROM [QuanlybanhangWinMart].[dbo].[BAN] " +
                                   "WHERE [MaHDB] = @mahdB";


                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@mahdB", mahdB);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Nếu tìm thấy hóa đơn
                            {
                                // Hiển thị thông tin hóa đơn
                                tb_maHDB.Text = reader["MaHDB"].ToString();
                                tb_hienthitg.Text = Convert.ToDateTime(reader["NgayBan"]).ToString("dd/MM/yyyy HH:mm:ss");

                                string pttt = reader["PTTT"].ToString();
                                if (pttt == "Tiền mặt")
                                {
                                    radioButton1.Checked = true;
                                }
                                else if (pttt == "QR")
                                {
                                    radioButton2.Checked = true;
                                }
                                else if (pttt == "ATM")
                                {
                                    radioButton3.Checked = true;
                                }

                                tb_maNV.Text = reader["MaNV"].ToString();
                                tb_maKH.Text = reader["MaKH"].ToString();
                                LoadBanChiTietData(mahdB);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy hóa đơn với mã: " + mahdB, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ClearInputFields();
                                return;
                            }
                        }

                    }

                    // Gọi hàm getTotalHD để lấy tổng tiền
                    string totalQuery = "SELECT dbo.getTotalHDB(@mahdb)";
                    using (SqlCommand cmdTotal = new SqlCommand(totalQuery, con))
                    {
                        cmdTotal.Parameters.AddWithValue("@mahdB", mahdB);

                        // Thực thi câu lệnh và lấy giá trị trả về
                        object result = cmdTotal.ExecuteScalar();
                        if (result != null)
                        {
                            lb_tongtien.Text = Convert.ToDecimal(result).ToString("N2") + " VND";
                        }
                        else
                        {
                            lb_tongtien.Text = "0 VND";
                        }
                    }

                    MessageBox.Show("Tìm thấy hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputFields()
        {
            tb_maHDB.Text = string.Empty;
            tb_hienthitg.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            tb_maNV.Text = string.Empty;
            tb_maKH.Text = string.Empty;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem dòng được nhấp có hợp lệ hay không
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView2.Rows.Count)
            {
                // Lấy thông tin từ dòng được chọn
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];

                // Lấy các giá trị từ cột tương ứng
                string maHDB = selectedRow.Cells["MaHDB"].Value?.ToString();
                string ngayBan = selectedRow.Cells["NgayBan"].Value?.ToString();
                string pttt = selectedRow.Cells["PTTT"].Value?.ToString();
                string maNV = selectedRow.Cells["MaNV"].Value?.ToString();
                string maKH = selectedRow.Cells["MaKH"].Value?.ToString();

                // Hiển thị thông tin vào các TextBox
                tb_maHDB.Text = maHDB;
                tb_hienthitg.Text = ngayBan;
                tb_maNV.Text = maNV;
                tb_maKH.Text = maKH;

                // Đặt trạng thái của các RadioButton dựa trên PTTT
                if (pttt == "Tiền mặt")
                {
                    radioButton1.Checked = true;
                }
                else if (pttt == "QR")
                {
                    radioButton2.Checked = true;
                }
                else if (pttt == "ATM")
                {
                    radioButton3.Checked = true;
                }

                // Gọi phương thức để tải dữ liệu chi tiết hóa đơn từ bảng BAN_CHITIET
                if (!string.IsNullOrEmpty(maHDB))
                {
                    LoadBanChiTietData(maHDB);
                }

                // Hiển thị tổng tiền của hóa đơn nếu có hàm getTotalHDB
                try
                {
                    using (SqlConnection con = new SqlConnection(sCon))
                    {
                        string query = "SELECT dbo.getTotalHDB(@maHDB)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@maHDB", maHDB);
                            con.Open();
                            object result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                lb_tongtien.Text = Convert.ToDecimal(result).ToString("N2") + " VND";
                            }
                            else
                            {
                                lb_tongtien.Text = "0 VND";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tính tổng tiền hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Dòng được chọn không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                // Hiển thị mã hóa đơn mới lên TextBox
                DisplayNewIDBan(); // Sử dụng phương thức để lấy mã hóa đơn mới

                // Làm sạch các TextBox còn lại
                tb_maNV.Text = string.Empty;
                tb_maKH.Text = string.Empty;
                tb_hienthitg.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                // Làm sạch DataGridView1
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                // Set lại giá trị lb_tongtien về 0
                lb_tongtien.Text = "0 VND";

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi làm mới thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ giao diện
            string maHDB = tb_mhdct.Text.Trim();
            string maHangVin = tb_mh.Text.Trim();
            int soLuongBanMoi;

            // Kiểm tra số lượng bán hợp lệ
            if (!int.TryParse(tx_sl.Text.Trim(), out soLuongBanMoi) || soLuongBanMoi <= 0)
            {
                MessageBox.Show("Số lượng bán phải là số nguyên dương.");
                return;
            }

            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Gọi stored procedure sp_capnhatslsp
                    string sQuery = "Update Ban_CHitiet set Sl_Ban = @slban where MaHangVin = @mahangvin and MaHDB = @mahdb";
                    using (SqlCommand cmd = new SqlCommand(sQuery, con))
                    {

                        cmd.Parameters.AddWithValue("@mahdb", maHDB);
                        cmd.Parameters.AddWithValue("@mahangvin", maHangVin);
                        cmd.Parameters.AddWithValue("@slban", soLuongBanMoi);


                        // Thêm tham số đầu ra cho kết quả

                        // Thực thi stored procedure
                        int rows = cmd.ExecuteNonQuery();

                       

                        if (rows > 0)
                        {
                            MessageBox.Show("Cập nhật số lượng sản phẩm thành công!");
                            // Cập nhật lại tổng tiền sau khi cập nhật số lượng bán
                            UpdateTotal(maHDB);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi cập nhật số lượng sản phẩm. Vui lòng kiểm tra lại.");
                        }
                   }
                }
                catch (SqlException ex)
                {
                    // Xử lý lỗi nếu trigger ROLLBACK do vi phạm số lượng tồn
                    if (ex.Message.Contains("Số lượng bán lớn hơn số lượng sản phẩm đang có"))
                    {
                        MessageBox.Show("Lỗi: Số lượng bán lớn hơn số lượng tồn kho!");
                    }
                    else
                    {
                        MessageBox.Show("Xảy ra lỗi khi cập nhật: " + ex.Message);
                    }
                }
            }
        }

        private void bt_themct_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ giao diện
            string maHDB = tb_maHDB.Text.Trim();
            string maHangVin = tb_mh.Text.Trim();
            string maNV = tb_maNV.Text.Trim();
            string maKH =tb_maKH.Text.Trim();
            string ngayBan = tb_hienthitg.Text.Trim();
            int soLuongBan;

            if (!int.TryParse(tx_sl.Text.Trim(), out soLuongBan) || soLuongBan <= 0)
            {
                MessageBox.Show("Số lượng bán phải là số nguyên dương.");
                return;
            }

            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Gọi stored procedure kiểm tra và thêm vào bảng BÁN_CHI_TIẾT
                    using (SqlCommand cmd = new SqlCommand("spChkBan", con))
                    {

                        // Thêm tham số đầu vào
                        cmd.Parameters.Add(new SqlParameter("@ngayban", ngayBan));
                        cmd.Parameters.Add(new SqlParameter("@PTTT", ngayBan));
                        cmd.Parameters.Add(new SqlParameter("@ngayban", ngayBan));
                        cmd.Parameters.Add(new SqlParameter("@ngayban", ngayBan));
                        cmd.Parameters.Add(new SqlParameter("@ngayban", ngayBan));

                        cmd.Parameters.AddWithValue("@mahdb", maHDB);
                        cmd.Parameters.AddWithValue("@mahangvin", maHangVin);
                        cmd.Parameters.AddWithValue("@sl_ban", soLuongBan);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Thêm thành công!");

                            // Cập nhật lại tổng tiền sau khi thêm vào
                            UpdateTotal(maHDB);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại. Kiểm tra lại dữ liệu nhập.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi: " + ex.Message);
                }
            }
        }
        private void UpdateTotal(string maHDB)
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Gọi hàm để lấy tổng tiền
                    string sQuery = "SELECT dbo.getTotalHDB(@maHDB)";

                    using (SqlCommand cmd = new SqlCommand(sQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@maHDB", maHDB);

                        // Lấy tổng tiền
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            decimal total = Convert.ToDecimal(result);
                            lb_tongtien.Text = total.ToString("N0"); // Hiển thị tổng tiền theo định dạng
                        }
                        else
                        {
                            MessageBox.Show("Không thể lấy tổng tiền cho hóa đơn này.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi cập nhật tổng tiền: " + ex.Message);
                }
            }
        }
        private void bt_kt_Click(object sender, EventArgs e)
        {
            tx_tk.Clear();
            tb_maHDB.Clear();
            tb_maHDB.ReadOnly = false;
            tb_maNV.Clear();
            tb_maKH.Clear();
            lb_tongtien.Text = "0 VND";
            tb_mhdct.Clear();
            tb_mh.Clear();
            tx_sl.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

        }

        private void bt_qldh_Click(object sender, EventArgs e)
        {
            gdDatHang dh = new gdDatHang();
            dh.Show();
            this.Close();
        }

        private void bt_qlkh_Click(object sender, EventArgs e)
        {
            gdKhachHang kh = new gdKhachHang();
            kh.Show();

            this.Close();
        }

        private void bt_qlnv_Click(object sender, EventArgs e)
        {
            FormNV nv = new FormNV();
            nv.Show();
            this.Close();
        }

        private void bt_qlsp_Click(object sender, EventArgs e)
        {
            gdSanPham sp = new gdSanPham();
            sp.Show();
            this.Close();
        }

        private void bt_qlncc_Click(object sender, EventArgs e)
        {
            gdNCC ncc = new gdNCC();
            ncc.Show();
            this.Close();
        }

        private void bt_qldvvc_Click(object sender, EventArgs e)
        {
            FormDVVC dvvc = new FormDVVC();
            dvvc.Show();
            this.Close();
        }
    }


}
