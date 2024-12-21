namespace WinForm_QLBHWIN
{
    partial class FormNV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_khoitao = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tx_sdt = new System.Windows.Forms.TextBox();
            this.tx_nv = new System.Windows.Forms.TextBox();
            this.tx_mnv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_qlsp = new System.Windows.Forms.Button();
            this.bt_qldvvc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_qlnv = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bt_qlbh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_huy);
            this.groupBox1.Controls.Add(this.bt_luu);
            this.groupBox1.Controls.Add(this.bt_khoitao);
            this.groupBox1.Controls.Add(this.bt_them);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.tx_sdt);
            this.groupBox1.Controls.Add(this.tx_nv);
            this.groupBox1.Controls.Add(this.tx_mnv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(265, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(779, 478);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên ";
            // 
            // bt_huy
            // 
            this.bt_huy.Location = new System.Drawing.Point(387, 226);
            this.bt_huy.Margin = new System.Windows.Forms.Padding(4);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(97, 31);
            this.bt_huy.TabIndex = 4;
            this.bt_huy.Text = "Huỷ";
            this.bt_huy.UseVisualStyleBackColor = true;
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(221, 226);
            this.bt_luu.Margin = new System.Windows.Forms.Padding(4);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(97, 31);
            this.bt_luu.TabIndex = 4;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_khoitao
            // 
            this.bt_khoitao.Location = new System.Drawing.Point(581, 114);
            this.bt_khoitao.Margin = new System.Windows.Forms.Padding(4);
            this.bt_khoitao.Name = "bt_khoitao";
            this.bt_khoitao.Size = new System.Drawing.Size(97, 31);
            this.bt_khoitao.TabIndex = 0;
            this.bt_khoitao.Text = "Khởi tạo";
            this.bt_khoitao.UseVisualStyleBackColor = true;
            this.bt_khoitao.Click += new System.EventHandler(this.bt_khoitao_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(581, 53);
            this.bt_them.Margin = new System.Windows.Forms.Padding(4);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(97, 31);
            this.bt_them.TabIndex = 0;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 281);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(744, 185);
            this.dataGridView1.TabIndex = 6;
            // 
            // tx_sdt
            // 
            this.tx_sdt.Location = new System.Drawing.Point(272, 171);
            this.tx_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.tx_sdt.Name = "tx_sdt";
            this.tx_sdt.Size = new System.Drawing.Size(187, 22);
            this.tx_sdt.TabIndex = 3;
            // 
            // tx_nv
            // 
            this.tx_nv.Location = new System.Drawing.Point(272, 111);
            this.tx_nv.Margin = new System.Windows.Forms.Padding(4);
            this.tx_nv.Name = "tx_nv";
            this.tx_nv.Size = new System.Drawing.Size(187, 22);
            this.tx_nv.TabIndex = 2;
            // 
            // tx_mnv
            // 
            this.tx_mnv.Location = new System.Drawing.Point(272, 54);
            this.tx_mnv.Margin = new System.Windows.Forms.Padding(4);
            this.tx_mnv.Name = "tx_mnv";
            this.tx_mnv.Size = new System.Drawing.Size(187, 22);
            this.tx_mnv.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên ";
            // 
            // bt_qlsp
            // 
            this.bt_qlsp.Location = new System.Drawing.Point(22, 237);
            this.bt_qlsp.Margin = new System.Windows.Forms.Padding(4);
            this.bt_qlsp.Name = "bt_qlsp";
            this.bt_qlsp.Size = new System.Drawing.Size(224, 55);
            this.bt_qlsp.TabIndex = 36;
            this.bt_qlsp.Text = "Quản lý sản phẩm ";
            this.bt_qlsp.UseVisualStyleBackColor = true;
            // 
            // bt_qldvvc
            // 
            this.bt_qldvvc.Location = new System.Drawing.Point(22, 433);
            this.bt_qldvvc.Margin = new System.Windows.Forms.Padding(4);
            this.bt_qldvvc.Name = "bt_qldvvc";
            this.bt_qldvvc.Size = new System.Drawing.Size(224, 55);
            this.bt_qldvvc.TabIndex = 35;
            this.bt_qldvvc.Text = "Quản lý đơn vị vận chuyển";
            this.bt_qldvvc.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 368);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 55);
            this.button2.TabIndex = 34;
            this.button2.Text = "Quản lý nhà cung cấp";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 303);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 55);
            this.button3.TabIndex = 33;
            this.button3.Text = "Quản lý đặt hàng ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // bt_qlnv
            // 
            this.bt_qlnv.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt_qlnv.Location = new System.Drawing.Point(22, 172);
            this.bt_qlnv.Margin = new System.Windows.Forms.Padding(4);
            this.bt_qlnv.Name = "bt_qlnv";
            this.bt_qlnv.Size = new System.Drawing.Size(224, 55);
            this.bt_qlnv.TabIndex = 32;
            this.bt_qlnv.Text = "Quản lý nhân viên ";
            this.bt_qlnv.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(22, 107);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(224, 55);
            this.button6.TabIndex = 31;
            this.button6.Text = "Quản lý khách hàng";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // bt_qlbh
            // 
            this.bt_qlbh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_qlbh.Location = new System.Drawing.Point(22, 42);
            this.bt_qlbh.Margin = new System.Windows.Forms.Padding(4);
            this.bt_qlbh.Name = "bt_qlbh";
            this.bt_qlbh.Size = new System.Drawing.Size(224, 55);
            this.bt_qlbh.TabIndex = 30;
            this.bt_qlbh.Text = "Quản lý bán hàng";
            this.bt_qlbh.UseVisualStyleBackColor = true;
            // 
            // FormNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_qlsp);
            this.Controls.Add(this.bt_qldvvc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bt_qlnv);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.bt_qlbh);
            this.Name = "FormNV";
            this.Text = "FormNV";
            this.Load += new System.EventHandler(this.FormNV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_khoitao;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tx_sdt;
        private System.Windows.Forms.TextBox tx_nv;
        private System.Windows.Forms.TextBox tx_mnv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_qlsp;
        private System.Windows.Forms.Button bt_qldvvc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_qlnv;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button bt_qlbh;
    }
}