using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using WinForm_QLBHWIN;

namespace WinForm_QLBHWIN
{
    public partial class LoginForm : Form
    {
        string sCon = "Data Source=DESKTOP-UJM6TJ3;Initial Catalog=QuanlybanhangWinMart;Integrated Security=True";
        public LoginForm()
        {
            InitializeComponent();
        }
       

        //btn-login_Form
        private void button1_Click(object sender, EventArgs e)
        {

            string tk = tentkBox.Text;
            string password = matkhauBox.Text;

            using (SqlConnection connection = new SqlConnection(sCon))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo SqlCommand để gọi stored procedure
                    using (SqlCommand command = new SqlCommand("spPreventSqlInjection", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        command.Parameters.Add(new SqlParameter("@tenTk", tk));
                        command.Parameters.Add(new SqlParameter("@MatKhau", password));


                        // Thêm tham số đầu ra @tb
                        SqlParameter paramOut = new SqlParameter("@tb", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(paramOut);

                        // Thực thi stored procedure
                        command.ExecuteNonQuery();

                        int kq = Convert.ToInt32(paramOut.Value);
                        if (kq == 1)
                        {
                            FormMain main = new FormMain();
                            main.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

        } 
        
    

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Have a good day");
        }
    }
}
