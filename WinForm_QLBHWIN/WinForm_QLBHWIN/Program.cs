using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinForm_QLBHWIN
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(true);
            Application.EnableVisualStyles();
            LoginForm form = new LoginForm();
            gdKhachHang kh = new gdKhachHang();
            gdDatHang datHang = new gdDatHang();
            gdSanPham sp = new gdSanPham();
            gdNCC ncc = new gdNCC();
            FormQLBH bh = new FormQLBH();
            Application.Run(bh);


        }
    }
}
