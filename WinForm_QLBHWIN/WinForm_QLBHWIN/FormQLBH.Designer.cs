namespace WinForm_QLBHWIN
{
    partial class FormQLBH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_themct = new System.Windows.Forms.Button();
            this.tx_sl = new System.Windows.Forms.TextBox();
            this.lb_sl = new System.Windows.Forms.Label();
            this.tb_mh = new System.Windows.Forms.TextBox();
            this.lb_mh = new System.Windows.Forms.Label();
            this.tb_mhdct = new System.Windows.Forms.TextBox();
            this.lb_mhdbct = new System.Windows.Forms.Label();
            this.bt_update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHangVin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL_Ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_kt = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.tb_hienthitg = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lb_pttt = new System.Windows.Forms.Label();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.tb_maKH = new System.Windows.Forms.TextBox();
            this.tb_maNV = new System.Windows.Forms.TextBox();
            this.tb_maHDB = new System.Windows.Forms.TextBox();
            this.lb_tt = new System.Windows.Forms.Label();
            this.lb_mkh = new System.Windows.Forms.Label();
            this.lb_mnv = new System.Windows.Forms.Label();
            this.lb_ngayban = new System.Windows.Forms.Label();
            this.lb_hdb = new System.Windows.Forms.Label();
            this.lb_qlhdb = new System.Windows.Forms.Label();
            this.bt_tk = new System.Windows.Forms.Button();
            this.tx_tk = new System.Windows.Forms.TextBox();
            this.bt_qldvvc = new System.Windows.Forms.Button();
            this.bt_qlncc = new System.Windows.Forms.Button();
            this.bt_qldh = new System.Windows.Forms.Button();
            this.bt_qlsp = new System.Windows.Forms.Button();
            this.bt_qlnv = new System.Windows.Forms.Button();
            this.bt_qlkh = new System.Windows.Forms.Button();
            this.bt_qlbh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lb_qlhdb);
            this.panel1.Controls.Add(this.bt_tk);
            this.panel1.Controls.Add(this.tx_tk);
            this.panel1.Location = new System.Drawing.Point(247, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1291, 590);
            this.panel1.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_themct);
            this.groupBox3.Controls.Add(this.tx_sl);
            this.groupBox3.Controls.Add(this.lb_sl);
            this.groupBox3.Controls.Add(this.tb_mh);
            this.groupBox3.Controls.Add(this.lb_mh);
            this.groupBox3.Controls.Add(this.tb_mhdct);
            this.groupBox3.Controls.Add(this.lb_mhdbct);
            this.groupBox3.Controls.Add(this.bt_update);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(4, 306);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(697, 247);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết ";
            // 
            // bt_themct
            // 
            this.bt_themct.Location = new System.Drawing.Point(475, 204);
            this.bt_themct.Margin = new System.Windows.Forms.Padding(4);
            this.bt_themct.Name = "bt_themct";
            this.bt_themct.Size = new System.Drawing.Size(103, 36);
            this.bt_themct.TabIndex = 10;
            this.bt_themct.Text = "Thêm";
            this.bt_themct.UseVisualStyleBackColor = true;
            this.bt_themct.Click += new System.EventHandler(this.bt_themct_Click);
            // 
            // tx_sl
            // 
            this.tx_sl.Location = new System.Drawing.Point(479, 161);
            this.tx_sl.Margin = new System.Windows.Forms.Padding(4);
            this.tx_sl.Name = "tx_sl";
            this.tx_sl.Size = new System.Drawing.Size(177, 22);
            this.tx_sl.TabIndex = 9;
            // 
            // lb_sl
            // 
            this.lb_sl.AutoSize = true;
            this.lb_sl.Location = new System.Drawing.Point(475, 142);
            this.lb_sl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_sl.Name = "lb_sl";
            this.lb_sl.Size = new System.Drawing.Size(63, 16);
            this.lb_sl.TabIndex = 18;
            this.lb_sl.Text = "Số lượng ";
            // 
            // tb_mh
            // 
            this.tb_mh.Location = new System.Drawing.Point(479, 105);
            this.tb_mh.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mh.Name = "tb_mh";
            this.tb_mh.Size = new System.Drawing.Size(177, 22);
            this.tb_mh.TabIndex = 8;
            // 
            // lb_mh
            // 
            this.lb_mh.AutoSize = true;
            this.lb_mh.Location = new System.Drawing.Point(475, 85);
            this.lb_mh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mh.Name = "lb_mh";
            this.lb_mh.Size = new System.Drawing.Size(62, 16);
            this.lb_mh.TabIndex = 16;
            this.lb_mh.Text = "Mã hàng ";
            // 
            // tb_mhdct
            // 
            this.tb_mhdct.Location = new System.Drawing.Point(479, 50);
            this.tb_mhdct.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mhdct.Name = "tb_mhdct";
            this.tb_mhdct.Size = new System.Drawing.Size(177, 22);
            this.tb_mhdct.TabIndex = 7;
            // 
            // lb_mhdbct
            // 
            this.lb_mhdbct.AutoSize = true;
            this.lb_mhdbct.Location = new System.Drawing.Point(475, 23);
            this.lb_mhdbct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mhdbct.Name = "lb_mhdbct";
            this.lb_mhdbct.Size = new System.Drawing.Size(58, 16);
            this.lb_mhdbct.TabIndex = 16;
            this.lb_mhdbct.Text = "Mã HDB";
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(587, 204);
            this.bt_update.Margin = new System.Windows.Forms.Padding(4);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(103, 36);
            this.bt_update.TabIndex = 10;
            this.bt_update.Text = "Cập nhật";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDB,
            this.MaHangVin,
            this.SL_Ban});
            this.dataGridView1.Location = new System.Drawing.Point(8, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(459, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // MaHDB
            // 
            this.MaHDB.DataPropertyName = "MaHDB";
            this.MaHDB.HeaderText = "Mã HDB";
            this.MaHDB.MinimumWidth = 6;
            this.MaHDB.Name = "MaHDB";
            this.MaHDB.Width = 125;
            // 
            // MaHangVin
            // 
            this.MaHangVin.DataPropertyName = "MaHangVin";
            this.MaHangVin.HeaderText = "Mã hàng";
            this.MaHangVin.MinimumWidth = 6;
            this.MaHangVin.Name = "MaHangVin";
            this.MaHangVin.Width = 125;
            // 
            // SL_Ban
            // 
            this.SL_Ban.DataPropertyName = "SL_Ban";
            this.SL_Ban.HeaderText = "Số lượng bán ";
            this.SL_Ban.MinimumWidth = 6;
            this.SL_Ban.Name = "SL_Ban";
            this.SL_Ban.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(709, 64);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(572, 511);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hoá đơn bán ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 30);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(552, 474);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_kt);
            this.groupBox1.Controls.Add(this.bt_them);
            this.groupBox1.Controls.Add(this.lb_tongtien);
            this.groupBox1.Controls.Add(this.tb_hienthitg);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.lb_pttt);
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.bt_luu);
            this.groupBox1.Controls.Add(this.tb_maKH);
            this.groupBox1.Controls.Add(this.tb_maNV);
            this.groupBox1.Controls.Add(this.tb_maHDB);
            this.groupBox1.Controls.Add(this.lb_tt);
            this.groupBox1.Controls.Add(this.lb_mkh);
            this.groupBox1.Controls.Add(this.lb_mnv);
            this.groupBox1.Controls.Add(this.lb_ngayban);
            this.groupBox1.Controls.Add(this.lb_hdb);
            this.groupBox1.Location = new System.Drawing.Point(4, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(697, 223);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hoá đơn ";
            // 
            // bt_kt
            // 
            this.bt_kt.Location = new System.Drawing.Point(513, 172);
            this.bt_kt.Margin = new System.Windows.Forms.Padding(4);
            this.bt_kt.Name = "bt_kt";
            this.bt_kt.Size = new System.Drawing.Size(103, 36);
            this.bt_kt.TabIndex = 6;
            this.bt_kt.Text = "Khởi tạo ";
            this.bt_kt.UseVisualStyleBackColor = true;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(97, 172);
            this.bt_them.Margin = new System.Windows.Forms.Padding(4);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(103, 36);
            this.bt_them.TabIndex = 6;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Location = new System.Drawing.Point(525, 117);
            this.lb_tongtien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(14, 16);
            this.lb_tongtien.TabIndex = 14;
            this.lb_tongtien.Text = "0";
            // 
            // tb_hienthitg
            // 
            this.tb_hienthitg.Location = new System.Drawing.Point(141, 71);
            this.tb_hienthitg.Margin = new System.Windows.Forms.Padding(4);
            this.tb_hienthitg.Name = "tb_hienthitg";
            this.tb_hienthitg.Size = new System.Drawing.Size(177, 22);
            this.tb_hienthitg.TabIndex = 2;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(259, 146);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 20);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ATM";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(187, 146);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 20);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "QR";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(85, 146);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tiền mặt ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lb_pttt
            // 
            this.lb_pttt.AutoSize = true;
            this.lb_pttt.Location = new System.Drawing.Point(21, 117);
            this.lb_pttt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pttt.Name = "lb_pttt";
            this.lb_pttt.Size = new System.Drawing.Size(147, 16);
            this.lb_pttt.TabIndex = 12;
            this.lb_pttt.Text = "Phương thức thanh toán ";
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(375, 172);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(103, 36);
            this.bt_xoa.TabIndex = 6;
            this.bt_xoa.Text = "Xoá ";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(237, 172);
            this.bt_luu.Margin = new System.Windows.Forms.Padding(4);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(103, 36);
            this.bt_luu.TabIndex = 6;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // tb_maKH
            // 
            this.tb_maKH.Location = new System.Drawing.Point(479, 71);
            this.tb_maKH.Margin = new System.Windows.Forms.Padding(4);
            this.tb_maKH.Name = "tb_maKH";
            this.tb_maKH.Size = new System.Drawing.Size(177, 22);
            this.tb_maKH.TabIndex = 5;
            // 
            // tb_maNV
            // 
            this.tb_maNV.Location = new System.Drawing.Point(479, 28);
            this.tb_maNV.Margin = new System.Windows.Forms.Padding(4);
            this.tb_maNV.Name = "tb_maNV";
            this.tb_maNV.Size = new System.Drawing.Size(177, 22);
            this.tb_maNV.TabIndex = 4;
            // 
            // tb_maHDB
            // 
            this.tb_maHDB.Location = new System.Drawing.Point(141, 28);
            this.tb_maHDB.Margin = new System.Windows.Forms.Padding(4);
            this.tb_maHDB.Name = "tb_maHDB";
            this.tb_maHDB.ReadOnly = true;
            this.tb_maHDB.Size = new System.Drawing.Size(177, 22);
            this.tb_maHDB.TabIndex = 1;
            // 
            // lb_tt
            // 
            this.lb_tt.AutoSize = true;
            this.lb_tt.Location = new System.Drawing.Point(356, 117);
            this.lb_tt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tt.Name = "lb_tt";
            this.lb_tt.Size = new System.Drawing.Size(63, 16);
            this.lb_tt.TabIndex = 4;
            this.lb_tt.Text = "Tổng tiền";
            // 
            // lb_mkh
            // 
            this.lb_mkh.AutoSize = true;
            this.lb_mkh.Location = new System.Drawing.Point(356, 75);
            this.lb_mkh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mkh.Name = "lb_mkh";
            this.lb_mkh.Size = new System.Drawing.Size(101, 16);
            this.lb_mkh.TabIndex = 3;
            this.lb_mkh.Text = "Mã khách hàng ";
            // 
            // lb_mnv
            // 
            this.lb_mnv.AutoSize = true;
            this.lb_mnv.Location = new System.Drawing.Point(356, 32);
            this.lb_mnv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mnv.Name = "lb_mnv";
            this.lb_mnv.Size = new System.Drawing.Size(89, 16);
            this.lb_mnv.TabIndex = 2;
            this.lb_mnv.Text = "Mã nhân viên ";
            // 
            // lb_ngayban
            // 
            this.lb_ngayban.AutoSize = true;
            this.lb_ngayban.Location = new System.Drawing.Point(21, 75);
            this.lb_ngayban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ngayban.Name = "lb_ngayban";
            this.lb_ngayban.Size = new System.Drawing.Size(72, 16);
            this.lb_ngayban.TabIndex = 1;
            this.lb_ngayban.Text = "Ngày bán  ";
            // 
            // lb_hdb
            // 
            this.lb_hdb.AutoSize = true;
            this.lb_hdb.Location = new System.Drawing.Point(21, 32);
            this.lb_hdb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_hdb.Name = "lb_hdb";
            this.lb_hdb.Size = new System.Drawing.Size(107, 16);
            this.lb_hdb.TabIndex = 0;
            this.lb_hdb.Text = "Mã hoá đơn bán ";
            // 
            // lb_qlhdb
            // 
            this.lb_qlhdb.AutoSize = true;
            this.lb_qlhdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qlhdb.Location = new System.Drawing.Point(241, 43);
            this.lb_qlhdb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_qlhdb.Name = "lb_qlhdb";
            this.lb_qlhdb.Size = new System.Drawing.Size(259, 29);
            this.lb_qlhdb.TabIndex = 2;
            this.lb_qlhdb.Text = "Quản lý hoá đơn bán ";
            // 
            // bt_tk
            // 
            this.bt_tk.Location = new System.Drawing.Point(247, 14);
            this.bt_tk.Margin = new System.Windows.Forms.Padding(4);
            this.bt_tk.Name = "bt_tk";
            this.bt_tk.Size = new System.Drawing.Size(100, 27);
            this.bt_tk.TabIndex = 1;
            this.bt_tk.Text = "Tìm kiếm ";
            this.bt_tk.UseVisualStyleBackColor = true;
            this.bt_tk.Click += new System.EventHandler(this.bt_tk_Click);
            // 
            // tx_tk
            // 
            this.tx_tk.Location = new System.Drawing.Point(19, 15);
            this.tx_tk.Margin = new System.Windows.Forms.Padding(4);
            this.tx_tk.Name = "tx_tk";
            this.tx_tk.Size = new System.Drawing.Size(219, 22);
            this.tx_tk.TabIndex = 0;
            this.tx_tk.Text = "Tìm kiếm mã hoá đơn ";
            // 
            // bt_qldvvc
            // 
            this.bt_qldvvc.Location = new System.Drawing.Point(15, 409);
            this.bt_qldvvc.Margin = new System.Windows.Forms.Padding(4);
            this.bt_qldvvc.Name = "bt_qldvvc";
            this.bt_qldvvc.Size = new System.Drawing.Size(224, 55);
            this.bt_qldvvc.TabIndex = 14;
            this.bt_qldvvc.Text = "Quản lý đơn vị vận chuyển";
            this.bt_qldvvc.UseVisualStyleBackColor = true;
            this.bt_qldvvc.Click += new System.EventHandler(this.bt_qldvvc_Click);
            // 
            // bt_qlncc
            // 
            this.bt_qlncc.Location = new System.Drawing.Point(15, 344);
            this.bt_qlncc.Margin = new System.Windows.Forms.Padding(4);
            this.bt_qlncc.Name = "bt_qlncc";
            this.bt_qlncc.Size = new System.Drawing.Size(224, 55);
            this.bt_qlncc.TabIndex = 13;
            this.bt_qlncc.Text = "Quản lý nhà cung cấp";
            this.bt_qlncc.UseVisualStyleBackColor = true;
            this.bt_qlncc.Click += new System.EventHandler(this.bt_qlncc_Click);
            // 
            // bt_qldh
            // 
            this.bt_qldh.Location = new System.Drawing.Point(15, 279);
            this.bt_qldh.Margin = new System.Windows.Forms.Padding(4);
            this.bt_qldh.Name = "bt_qldh";
            this.bt_qldh.Size = new System.Drawing.Size(224, 55);
            this.bt_qldh.TabIndex = 12;
            this.bt_qldh.Text = "Quản lý đặt hàng ";
            this.bt_qldh.UseVisualStyleBackColor = true;
            this.bt_qldh.Click += new System.EventHandler(this.bt_qldh_Click);
            // 
            // bt_qlsp
            // 
            this.bt_qlsp.Location = new System.Drawing.Point(15, 213);
            this.bt_qlsp.Margin = new System.Windows.Forms.Padding(4);
            this.bt_qlsp.Name = "bt_qlsp";
            this.bt_qlsp.Size = new System.Drawing.Size(224, 55);
            this.bt_qlsp.TabIndex = 11;
            this.bt_qlsp.Text = "Quản lý sản phẩm";
            this.bt_qlsp.UseVisualStyleBackColor = true;
            this.bt_qlsp.Click += new System.EventHandler(this.bt_qlsp_Click);
            // 
            // bt_qlnv
            // 
            this.bt_qlnv.Location = new System.Drawing.Point(15, 148);
            this.bt_qlnv.Margin = new System.Windows.Forms.Padding(4);
            this.bt_qlnv.Name = "bt_qlnv";
            this.bt_qlnv.Size = new System.Drawing.Size(224, 55);
            this.bt_qlnv.TabIndex = 10;
            this.bt_qlnv.Text = "Quản lý nhân viên ";
            this.bt_qlnv.UseVisualStyleBackColor = true;
            this.bt_qlnv.Click += new System.EventHandler(this.bt_qlnv_Click);
            // 
            // bt_qlkh
            // 
            this.bt_qlkh.Location = new System.Drawing.Point(15, 83);
            this.bt_qlkh.Margin = new System.Windows.Forms.Padding(4);
            this.bt_qlkh.Name = "bt_qlkh";
            this.bt_qlkh.Size = new System.Drawing.Size(224, 55);
            this.bt_qlkh.TabIndex = 9;
            this.bt_qlkh.Text = "Quản lý khách hàng";
            this.bt_qlkh.UseVisualStyleBackColor = true;
            this.bt_qlkh.Click += new System.EventHandler(this.bt_qlkh_Click);
            // 
            // bt_qlbh
            // 
            this.bt_qlbh.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_qlbh.Location = new System.Drawing.Point(15, 18);
            this.bt_qlbh.Margin = new System.Windows.Forms.Padding(4);
            this.bt_qlbh.Name = "bt_qlbh";
            this.bt_qlbh.Size = new System.Drawing.Size(224, 55);
            this.bt_qlbh.TabIndex = 8;
            this.bt_qlbh.Text = "Quản lý bán hàng";
            this.bt_qlbh.UseVisualStyleBackColor = false;
            // 
            // FormQLBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_qldvvc);
            this.Controls.Add(this.bt_qlncc);
            this.Controls.Add(this.bt_qldh);
            this.Controls.Add(this.bt_qlsp);
            this.Controls.Add(this.bt_qlnv);
            this.Controls.Add(this.bt_qlkh);
            this.Controls.Add(this.bt_qlbh);
            this.Name = "FormQLBH";
            this.Text = "FormQLBH";
            this.Load += new System.EventHandler(this.FormQLBH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_themct;
        private System.Windows.Forms.TextBox tx_sl;
        private System.Windows.Forms.Label lb_sl;
        private System.Windows.Forms.TextBox tb_mh;
        private System.Windows.Forms.Label lb_mh;
        private System.Windows.Forms.TextBox tb_mhdct;
        private System.Windows.Forms.Label lb_mhdbct;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHangVin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_Ban;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_kt;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Label lb_tongtien;
        private System.Windows.Forms.TextBox tb_hienthitg;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lb_pttt;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.TextBox tb_maKH;
        private System.Windows.Forms.TextBox tb_maNV;
        private System.Windows.Forms.TextBox tb_maHDB;
        private System.Windows.Forms.Label lb_tt;
        private System.Windows.Forms.Label lb_mkh;
        private System.Windows.Forms.Label lb_mnv;
        private System.Windows.Forms.Label lb_ngayban;
        private System.Windows.Forms.Label lb_hdb;
        private System.Windows.Forms.Label lb_qlhdb;
        private System.Windows.Forms.Button bt_tk;
        private System.Windows.Forms.TextBox tx_tk;
        private System.Windows.Forms.Button bt_qldvvc;
        private System.Windows.Forms.Button bt_qlncc;
        private System.Windows.Forms.Button bt_qldh;
        private System.Windows.Forms.Button bt_qlsp;
        private System.Windows.Forms.Button bt_qlnv;
        private System.Windows.Forms.Button bt_qlkh;
        private System.Windows.Forms.Button bt_qlbh;
    }
}