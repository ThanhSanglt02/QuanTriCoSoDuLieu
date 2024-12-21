using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_QLBHWIN
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;  // Thiết lập form cha là MDI container
        }

        private void CloseAllChildForms()
        {
            // Đóng tất cả các form con
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            FormQLBH bh = new FormQLBH();
            bh.MdiParent = this;

            bh.StartPosition = FormStartPosition.Manual; // Bắt buộc phải đặt Manual để dùng Location
            bh.Location = new Point(12, 41);

            bh.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();

            gdKhachHang kh = new gdKhachHang();
            kh.MdiParent = this;

            kh.StartPosition = FormStartPosition.Manual; // Bắt buộc phải đặt Manual để dùng Location
            kh.Location = new Point(12, 41);
            kh.Show();
        }

        private void quảnLýBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();

            FormQLBH bh = new FormQLBH();
            bh.MdiParent = this;

            bh.StartPosition = FormStartPosition.Manual; // Bắt buộc phải đặt Manual để dùng Location
            bh.Location = new Point(12, 41);
            bh.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();

            FormNV nv = new FormNV();
            nv.MdiParent = this;
            nv.StartPosition = FormStartPosition.Manual; // Bắt buộc phải đặt Manual để dùng Location
            nv.Location = new Point(12, 41);
            nv.Show();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();

            gdSanPham sp = new gdSanPham();
            sp.MdiParent = this;
            sp.StartPosition = FormStartPosition.Manual; // Bắt buộc phải đặt Manual để dùng Location
            sp.Location = new Point(12, 41);
            sp.Show();
        }

        private void quảnLýĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            gdDatHang dh = new gdDatHang();
            dh.MdiParent = this;
            dh.StartPosition = FormStartPosition.Manual; // Bắt buộc phải đặt Manual để dùng Location
            dh.Location = new Point(12, 41);
            dh.Show();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            gdNCC ncc = new gdNCC();
            ncc.MdiParent = this;
            ncc.StartPosition = FormStartPosition.Manual; // Bắt buộc phải đặt Manual để dùng Location
            ncc.Location = new Point(12, 41);
            ncc.Show();
        }

        private void quảnLýĐơnViVậnChuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();

            FormDVVC dvvc = new FormDVVC();
            dvvc.MdiParent = this;
            dvvc.StartPosition = FormStartPosition.Manual; // Bắt buộc phải đặt Manual để dùng Location
            dvvc.Location = new Point(12, 41);
            dvvc.Show();
        }
    }
}
