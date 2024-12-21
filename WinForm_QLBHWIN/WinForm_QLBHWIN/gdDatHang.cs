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
    public partial class gdDatHang : Form
    {
        string sCon = "Data Source=DESKTOP-UJM6TJ3;Initial Catalog=QuanlybanhangWinMart;Integrated Security=True";
        DataTable dtDat;
        DataTable dtDat_ChiTiet;

        public gdDatHang()
        {
            InitializeComponent();
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
            string sQuery1 = "select * from Dat";
            string sQuery2 = "select * from Dat_ChiTiet";
            SqlDataAdapter adapter1 = new SqlDataAdapter(sQuery1, con);
            SqlDataAdapter adapter2 = new SqlDataAdapter(sQuery2, con);

            DataSet ds = new DataSet();
            
            //data Dat table
            adapter1.Fill(ds, "Dat");
            dtDat = ds.Tables["Dat"];
            dataGridView1.DataSource = dtDat;

            //data Dat_chitiet table
            adapter2.Fill(ds, "Dat_ChiTiet");
            dtDat_ChiTiet = ds.Tables["Dat_ChiTiet"];
            dataGridView2.DataSource = dtDat_ChiTiet;
            dataGridView2.ReadOnly = true;

            tbMaHDN.Enabled = false;
            tbMaHDNChiTiet.Enabled = false;


            //Buoc 3: Dong ket noi
            con.Close();
        }

        
        
        //clear input
        private void clearInput()
        {
            tbMaHDN.Clear();
            tbGhiChu.Clear();
            tbMaDVVC.Clear();
            tbMaHV.Clear();
            tbMaHDNChiTiet.Clear();
            tbNgayDat.Value = DateTime.Now;
            tbMaNCC.Clear();
            tbMaNV.Clear();
            tbSL.Clear();
            tbTongTien.Clear();
            tbGiaBan.Clear();
        }

        //tinh tong tien
        private decimal getTotal(string maHDN)
        {
            decimal total = 0;
            using (SqlConnection conn = new SqlConnection(sCon))
            {
                try
                {
                    conn.Open();
                    string Squery = "Select dbo.getTotalHDN(@maHD)";

                    using (SqlCommand cmd = new SqlCommand(Squery, conn))
                    {
                        cmd.Parameters.AddWithValue("@maHD", maHDN);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            total = Convert.ToDecimal(result);
                        }
                        else
                        {
                            MessageBox.Show($"Không tìm thấy tổng tiền cho hóa đơn {maHDN}.");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }

            };
            return total;
        }

        //get Gia Nhap cua SP
        private decimal getGiaNhap(string maHV)
        {
            decimal giaNhap = 0;
            using (SqlConnection conn = new SqlConnection(sCon))
            {
                try
                {
                    conn.Open();
                    string Squery = "Select DonGiaNhap from SanPham where MaHangVin = @maHV";

                    using (SqlCommand cmd = new SqlCommand(Squery, conn))
                    {
                        cmd.Parameters.AddWithValue("@maHV", maHV);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            giaNhap = Convert.ToDecimal(result);
                        }
                        else
                        {
                            MessageBox.Show($"Không tìm thấy tổng tiền cho hóa đơn {maHV}.");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }

            };

            return giaNhap;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string maHDN = tbMaHDN.Text.Trim();
            int slNhap = Convert.ToInt32(tbSL.Text.Trim());
            string maHV = tbMaHV.Text.Trim();
            DateTime ngayDat = tbNgayDat.Value;
            string ghiChu = tbGhiChu.Text.Trim();
            string maNCC = tbMaNCC.Text.Trim();
            string maNV = tbMaNV.Text.Trim();
            string maDVVC = tbMaDVVC.Text.Trim();

            int kq = 0;

            using (SqlConnection conn = new SqlConnection(sCon))
            {
                try
                {
                    conn.Open();

                    //Dat
                    using (SqlCommand cmd1 = new SqlCommand("sp_updateDat", conn))
                    {
                        cmd1.CommandType = CommandType.StoredProcedure;

                        //parameter input
                        cmd1.Parameters.Add(new SqlParameter("@maHDN", maHDN));
                        cmd1.Parameters.Add(new SqlParameter("@maNCC", maNCC));
                        cmd1.Parameters.Add(new SqlParameter("@maNV", maNV));
                        cmd1.Parameters.Add(new SqlParameter("@maDVVC", maDVVC));
                        cmd1.Parameters.Add(new SqlParameter("@ngayDat", ngayDat));
                        cmd1.Parameters.Add(new SqlParameter("@ghiChu", ghiChu));



                        //parameter output
                        SqlParameter paramOut = new SqlParameter("@kq", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd1.Parameters.Add(paramOut);

                        //thuc thi
                        cmd1.ExecuteNonQuery();

                        int ret = Convert.ToInt32(paramOut.Value);
                        if (ret == 1)
                        {
                            kq = 1;

                        }
                        else
                        {
                            kq = 0;
                        }
                        
                    }

                    //Dat Chi tiet
                    string sQuery = "update DAT_CHITIET set Sl_Nhap = @sl_nhap where MaHDN = @maHDN and MaHangVin = @maHV ";
                    using (SqlCommand cmd = new SqlCommand(sQuery, conn))
                    {

                        //Them cac tham so
                        cmd.Parameters.AddWithValue("@maHDN", maHDN);
                        cmd.Parameters.AddWithValue("@maHV", maHV);
                        cmd.Parameters.AddWithValue("@sl_nhap", slNhap);

                        int rows = cmd.ExecuteNonQuery();
                        
                        if (rows > 0)
                        {
                            kq = 1;

                        }
                        else
                        {
                            kq = 0;
                            
                        }
                    }
                    if (kq == 1)
                    {
                        MessageBox.Show("Sửa hóa đơn thành công!",
                            "Thành công",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Sửa hóa đơn không thành công!",
                            "Thất bại",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                } catch (Exception ex)
                {
                    MessageBox.Show("Co loi xay ra" + ex.Message);
                }
                
            }
            decimal total = getTotal(maHDN);
            tbTongTien.Text = total.ToString("F2");
        }

        private void gdDatHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //return gia tri ma hang vin dua vao ma hoa don
        private string getMaHV(string maHDN)
        {
            string maHV = "";
            using (SqlConnection conn = new SqlConnection(sCon))
            {
                try
                {
                    conn.Open();
                    string Squery = "Select MaHangVin from Dat_ChiTiet where MaHDN = @maHDN";

                    using (SqlCommand cmd = new SqlCommand(Squery, conn))
                    {
                        cmd.Parameters.AddWithValue("@maHDN", maHDN);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            maHV = reader["MaHangVin"].ToString();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
                
            };
            return maHV;

        }

        //return gia tri so luong nhap duaj vao ma hoa don
        private int getSlNhap(string maHDN, string maHV)
        {
            int slNhap = 0;
            using (SqlConnection conn = new SqlConnection(sCon))
            {
                try
                {
                    conn.Open();
                    string Squery = "Select Sl_Nhap from Dat_ChiTiet where MaHDN = @maHDN and MaHangVin = @maHV";

                    using (SqlCommand cmd = new SqlCommand(Squery, conn))
                    {
                        cmd.Parameters.AddWithValue("@maHDN", maHDN);
                        cmd.Parameters.AddWithValue("@maHV", maHV);


                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            slNhap = Convert.ToInt32(reader["Sl_Nhap"]);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }

            };
            return slNhap;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaHDN.Text = dataGridView1.Rows[e.RowIndex].Cells["MaHDN"].Value.ToString();
            tbNgayDat.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgayDat"].Value);
            tbGhiChu.Text = dataGridView1.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();
            tbMaNCC.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNCC"].Value.ToString();
            tbMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            tbMaDVVC.Text = dataGridView1.Rows[e.RowIndex].Cells["MaDVVC"].Value.ToString();
            tbMaHV.Text = getMaHV(dataGridView1.Rows[e.RowIndex].Cells["MaHDN"].Value.ToString());
            tbSL.Text = getSlNhap(dataGridView1.Rows[e.RowIndex].Cells["MaHDN"].Value.ToString(), getMaHV(dataGridView1.Rows[e.RowIndex].Cells["MaHDN"].Value.ToString())).ToString();

            decimal total = getTotal(dataGridView1.Rows[e.RowIndex].Cells["MaHDN"].Value.ToString());
            tbTongTien.Text = total.ToString("F2");

            decimal giaNhap = getGiaNhap(getMaHV(dataGridView1.Rows[e.RowIndex].Cells["MaHDN"].Value.ToString()));
            tbGiaBan.Text = giaNhap.ToString("F2");

            tbMaHDNChiTiet.Text = tbMaHDN.Text.Trim();
            tbMaHDN.Enabled = false;
            tbMaHDNChiTiet.Enabled = false;

            using (SqlConnection conn = new SqlConnection(sCon))
            {
                try
                {
                    conn.Open();

                    //Buoc 2: Lay du lieu ve
                    string sQuery = "select * from Dat_ChiTiet where maHDN = @maHDN";
                    SqlCommand cmd = new SqlCommand(sQuery, conn);
                    cmd.Parameters.AddWithValue("@maHDN", tbMaHDN.Text.Trim());
                  
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    //data Dat_chitiet table
                    adapter.Fill(ds, "Dat_ChiTiet");
                    dataGridView2.DataSource = ds.Tables["Dat_ChiTiet"]; 
                    dataGridView2.ReadOnly = true;

                    tbMaHDN.Enabled = false;
                    tbMaHDNChiTiet.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Co loi xay ra");
                }
            }

        }
        //lay ra danh sach maHDN
        private List<string> GetMaHDNList()
        {
            List<string> maHDNList = new List<string>();

            // Bước 1: Tạo kết nối
            using (SqlConnection conn = new SqlConnection(sCon))
            {
                try
                {
                    conn.Open();

                    // Bước 2: Viết câu truy vấn
                    string query = "SELECT MaHDN FROM Dat";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Bước 3: Sử dụng SqlDataReader để đọc dữ liệu
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Đọc giá trị từ cột "MaHDN"
                                string maHDN = reader["MaHDN"].ToString();
                                maHDNList.Add(maHDN); // Thêm vào danh sách
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return maHDNList;
        }
        //
        //kiem tra insert
        private int ProcessMaHDNList(string maHD)
        {
            int kq = 0;
            // Gọi hàm lấy danh sách mã hóa đơn
            List<string> maHDNList = GetMaHDNList();

            // Vòng lặp qua từng mã hóa đơn
            foreach (string maHDN in maHDNList)
            {
                if (maHD == maHDN)
                {
                    kq = 1;
                }
                else if (maHD == "" || maHD != maHDN)
                {
                    kq = 0;
                }
            }
            return kq;
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            DateTime ngayDat = tbNgayDat.Value;
            string ghiChu = tbGhiChu.Text.Trim();
            string maNCC = tbMaNCC.Text.Trim();
            string maNV = tbMaNV.Text.Trim();
            string maDVVC = tbMaDVVC.Text.Trim();
            int slNhap = Convert.ToInt32(tbSL.Text.Trim());

            int kq = ProcessMaHDNList(tbMaHDN.Text.Trim());

            int ret = 0;

            using (SqlConnection conn = new SqlConnection(sCon))
            {
                try
                {
                    conn.Open();
                    if (kq == 0)
                    {
                        using (SqlCommand cmd = new SqlCommand("spChkDat", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            //parameter input
                            cmd.Parameters.Add(new SqlParameter("@ngaydat", ngayDat));
                            cmd.Parameters.Add(new SqlParameter("@Ghichu", ghiChu));
                            cmd.Parameters.Add(new SqlParameter("@mancc", maNCC));
                            cmd.Parameters.Add(new SqlParameter("@manv", maNV));
                            cmd.Parameters.Add(new SqlParameter("@madvvc", maDVVC));

                            //parameter output
                            SqlParameter paramOut = new SqlParameter("@kq", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.Output
                            };
                            cmd.Parameters.Add(paramOut);

                            //thuc thi
                            cmd.ExecuteNonQuery();

                            int a = Convert.ToInt32(paramOut.Value);
                            if (a == 1)
                            {
                                ret = 1;

                                LoadData();
                            }
                            else
                            {
                                ret = 0;
                            }
                        }

                        //dat chit iet
                        string maHV = tbMaHV.Text.Trim();
                        //string maHDN = tbMaHDN.Text.Trim();
                        tbMaHDNChiTiet.Text = tbMaHDN.Text.Trim();

                        string sQuery = "Insert into Dat_ChiTiet(MaHDN, MaHangVin, Sl_Nhap) Values (@MaHDN, @MaHV, @slNhap) ";
                        using (SqlCommand cmd = new SqlCommand(sQuery, conn))
                        {

                            //parameter input
                            cmd.Parameters.AddWithValue("@MaHDN", GetMaHDNList().Last());
                            cmd.Parameters.AddWithValue("@MaHV", maHV);
                            cmd.Parameters.AddWithValue("@slNhap", slNhap);

                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                ret = 1;
                                LoadData();

                            }
                            else
                            {
                                ret = 0;
                                
                            }
                        };                    
                    }

                    else
                    {
                        string maHV = tbMaHV.Text.Trim();
                        string maHDN = tbMaHDN.Text.Trim();

                        string sQuery = "Insert into Dat_ChiTiet(MaHDN, MaHangVin, Sl_Nhap) Values (@MaHDN, @MaHV, @slNhap) ";
                        using (SqlCommand cmd = new SqlCommand(sQuery, conn))
                        {

                            //parameter input
                            cmd.Parameters.AddWithValue("@MaHDN", maHDN);
                            cmd.Parameters.AddWithValue("@MaHV", maHV);
                            cmd.Parameters.AddWithValue("@slNhap", slNhap);

                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                ret = 1;
                                LoadData();

                            }
                            else
                            {
                                ret = 0;
                            }
                        };
                    }
                    if (ret == 1)
                    {
                        MessageBox.Show("Thêm đơn đặt hàng thành công!",
                            "Thành công",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Thêm đơn đặt hàng không thành công!",
                            "Thất bại",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}\n{ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void tbNgayDat_ValueChanged(object sender, EventArgs e)
        {

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
                    string maHDN = tbMaHDN.Text.Trim();
                    string query = "Delete Dat where maHDN = @maHDN";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    //Them cac tham so
                    cmd.Parameters.Add(new SqlParameter("@maHDN", maHDN));

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

                            clearInput();
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

        private void button8_reset_Click(object sender, EventArgs e)
        {
            clearInput();
            LoadData();
        }

        //get list ghiChu, NgayDat, MaNcc, maNV, maDVVC cua bang Dat dua vao maHDN
        private List<string> getListDat(string maHDN)
        {
            List<string> datTableList = new List<string>();

            // Bước 1: Tạo kết nối
            using (SqlConnection conn = new SqlConnection(sCon))
            {
                try
                {
                    conn.Open();

                    // Bước 2: Viết câu truy vấn
                    string query = "SELECT NgayDat, GhiChu, MaNCC, MaNV, MaDVVC FROM Dat where MaHDN = @maHDN";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@maHDN", maHDN);

                        // Bước 3: Sử dụng SqlDataReader để đọc dữ liệu
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Đọc giá trị từ cột "MaHDN"
                                DateTime ngayDat = Convert.ToDateTime(reader["NgayDat"]);
                                string GhiChu = reader["GhiChu"].ToString();
                                string MaNCC = reader["MaNCC"].ToString();
                                string MaNV = reader["MaNV"].ToString();
                                string MaDVVC = reader["MaDVVC"].ToString();

                                datTableList.Add(ngayDat.ToString("dd/MM/yyyy")); // Định dạng ngày
                                datTableList.Add(GhiChu);
                                datTableList.Add(MaNCC);
                                datTableList.Add(MaNV);
                                datTableList.Add(MaDVVC); // Thêm vào danh sách
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return datTableList;
        }


        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //lay danh sach bang Dat
            List<string> datTableList = new List<string>();
            datTableList = getListDat(dataGridView2.Rows[e.RowIndex].Cells["MaHDN"].Value.ToString());

            //Hien thi
            tbMaHDNChiTiet.Text = dataGridView2.Rows[e.RowIndex].Cells["MaHDN"].Value.ToString();
            tbMaHV.Text = dataGridView2.Rows[e.RowIndex].Cells["MaHangVin"].Value.ToString();
            tbSL.Text = dataGridView2.Rows[e.RowIndex].Cells["Sl_Nhap"].Value.ToString();
            tbMaHDN.Text = dataGridView2.Rows[e.RowIndex].Cells["MaHDN"].Value.ToString();
            tbNgayDat.Value = Convert.ToDateTime(datTableList[0]);
            tbGhiChu.Text = datTableList[1];
            tbMaNCC.Text = datTableList[2];
            tbMaNV.Text = datTableList[3];
            tbMaDVVC.Text = datTableList[4];

            decimal giaNhap = getGiaNhap(dataGridView2.Rows[e.RowIndex].Cells["MaHangVin"].Value.ToString());
            tbGiaBan.Text = giaNhap.ToString("F2");

            tbMaHDN.Enabled = false;
            tbMaHDNChiTiet.Enabled = false;
            datTableList.Clear();
        }

        private void textBox1_search_KeyDown(object sender, KeyEventArgs e)
        {
            string timKiem = textBox1_search.Text.Trim();
            DateTime thoiGian = dateTimePicker1.Value;
            if (e.KeyCode == Keys.Enter)
            {
                int thang = thoiGian.Month;
                int nam = thoiGian.Year;

                string sQuery = "Select * from Dat where maHDN like @maHDN and MONTH(ngayDat) = @thang and YEAR(ngayDat) = @nam";
                using (SqlConnection conn = new SqlConnection(sCon))
                {
                    try
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand(sQuery, conn);
                        cmd.Parameters.AddWithValue("@maHDN", "%" + timKiem + "%");
                        cmd.Parameters.AddWithValue("@thang", thang);
                        cmd.Parameters.AddWithValue("@nam", nam);


                        //lay du lieu ve
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        DataSet ds = new DataSet();

                        adapter.Fill(ds, "Dat");
                        dataGridView1.DataSource = ds.Tables["Dat"];
                        dataGridView1.ReadOnly = true;

                        tbMaHDN.Enabled = false;
                        textBox1_search.Text = timKiem;
                        if (ds.Tables["Dat"].Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy mã hóa đơn.");
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

        private string placeholderText = "Tìm kiếm đơn đặt hàng";

      
        private void textBox1_search_Enter_1(object sender, EventArgs e)
        {
            //Chỉ xóa placeholder nếu TextBox đang chứa placeholder
            if (textBox1_search.Text == placeholderText)
            {
                textBox1_search.Text = ""; // Xóa placeholder
                textBox1_search.ForeColor = Color.Black; // Đổi màu chữ về màu bình thường
            }
        }

        private void textBox1_search_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1_search.Text))
            {
                textBox1_search.Text = placeholderText; // Khôi phục placeholder nếu không nhập gì
                textBox1_search.ForeColor = Color.Gray;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gdKhachHang khachHang = new gdKhachHang();
            khachHang.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gdSanPham sp = new gdSanPham();
            sp.Show();
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
