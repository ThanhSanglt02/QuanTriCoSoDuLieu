namespace WinForm_QLBHWIN
{
    partial class FormDVVC
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_ngh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_khoitao = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tx_sdt = new System.Windows.Forms.TextBox();
            this.tx_tdvvc = new System.Windows.Forms.TextBox();
            this.tx_mdvvc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_qlsp = new System.Windows.Forms.Button();
            this.bt_qldvvc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bt_qlbh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 161);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 55);
            this.button1.TabIndex = 46;
            this.button1.Text = "Quản lý nhân viên ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_ngh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.bt_huy);
            this.groupBox1.Controls.Add(this.bt_luu);
            this.groupBox1.Controls.Add(this.bt_khoitao);
            this.groupBox1.Controls.Add(this.bt_them);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.tx_sdt);
            this.groupBox1.Controls.Add(this.tx_tdvvc);
            this.groupBox1.Controls.Add(this.tx_mdvvc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(262, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(779, 512);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn vị vận chuyển";
            // 
            // tb_ngh
            // 
            this.tb_ngh.Location = new System.Drawing.Point(272, 147);
            this.tb_ngh.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ngh.Name = "tb_ngh";
            this.tb_ngh.Size = new System.Drawing.Size(265, 22);
            this.tb_ngh.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày giao hàng";
            // 
            // bt_huy
            // 
            this.bt_huy.Location = new System.Drawing.Point(437, 251);
            this.bt_huy.Margin = new System.Windows.Forms.Padding(4);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(97, 31);
            this.bt_huy.TabIndex = 5;
            this.bt_huy.Text = "Huỷ";
            this.bt_huy.UseVisualStyleBackColor = true;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(272, 251);
            this.bt_luu.Margin = new System.Windows.Forms.Padding(4);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(97, 31);
            this.bt_luu.TabIndex = 5;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_khoitao
            // 
            this.bt_khoitao.Location = new System.Drawing.Point(584, 143);
            this.bt_khoitao.Margin = new System.Windows.Forms.Padding(4);
            this.bt_khoitao.Name = "bt_khoitao";
            this.bt_khoitao.Size = new System.Drawing.Size(97, 31);
            this.bt_khoitao.TabIndex = 0;
            this.bt_khoitao.Text = "Khởi tạo";
            this.bt_khoitao.UseVisualStyleBackColor = true;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(584, 81);
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
            this.dataGridView1.Location = new System.Drawing.Point(27, 316);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(744, 185);
            this.dataGridView1.TabIndex = 6;
            // 
            // tx_sdt
            // 
            this.tx_sdt.Location = new System.Drawing.Point(271, 198);
            this.tx_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.tx_sdt.Name = "tx_sdt";
            this.tx_sdt.Size = new System.Drawing.Size(265, 22);
            this.tx_sdt.TabIndex = 4;
            // 
            // tx_tdvvc
            // 
            this.tx_tdvvc.Location = new System.Drawing.Point(272, 99);
            this.tx_tdvvc.Margin = new System.Windows.Forms.Padding(4);
            this.tx_tdvvc.Name = "tx_tdvvc";
            this.tx_tdvvc.Size = new System.Drawing.Size(265, 22);
            this.tx_tdvvc.TabIndex = 2;
            // 
            // tx_mdvvc
            // 
            this.tx_mdvvc.Location = new System.Drawing.Point(273, 54);
            this.tx_mdvvc.Margin = new System.Windows.Forms.Padding(4);
            this.tx_mdvvc.Name = "tx_mdvvc";
            this.tx_mdvvc.Size = new System.Drawing.Size(265, 22);
            this.tx_mdvvc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đơn vị vận chuyển";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn vị vận chuyển";
            // 
            // bt_qlsp
            // 
            this.bt_qlsp.Location = new System.Drawing.Point(20, 225);
            this.bt_qlsp.Margin = new System.Windows.Forms.Padding(4);
            this.bt_qlsp.Name = "bt_qlsp";
            this.bt_qlsp.Size = new System.Drawing.Size(224, 55);
            this.bt_qlsp.TabIndex = 44;
            this.bt_qlsp.Text = "Quản lý sản phẩm ";
            this.bt_qlsp.UseVisualStyleBackColor = true;
            this.bt_qlsp.Click += new System.EventHandler(this.bt_qlsp_Click);
            // 
            // bt_qldvvc
            // 
            this.bt_qldvvc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt_qldvvc.Location = new System.Drawing.Point(20, 420);
            this.bt_qldvvc.Margin = new System.Windows.Forms.Padding(4);
            this.bt_qldvvc.Name = "bt_qldvvc";
            this.bt_qldvvc.Size = new System.Drawing.Size(224, 55);
            this.bt_qldvvc.TabIndex = 43;
            this.bt_qldvvc.Text = "Quản lý đơn vị vận chuyển";
            this.bt_qldvvc.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 355);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 55);
            this.button2.TabIndex = 42;
            this.button2.Text = "Quản lý nhà cung cấp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 290);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 55);
            this.button3.TabIndex = 41;
            this.button3.Text = "Quản lý đặt hàng ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(20, 94);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(224, 55);
            this.button6.TabIndex = 40;
            this.button6.Text = "Quản lý khách hàng";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bt_qlbh
            // 
            this.bt_qlbh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_qlbh.Location = new System.Drawing.Point(20, 29);
            this.bt_qlbh.Margin = new System.Windows.Forms.Padding(4);
            this.bt_qlbh.Name = "bt_qlbh";
            this.bt_qlbh.Size = new System.Drawing.Size(224, 55);
            this.bt_qlbh.TabIndex = 39;
            this.bt_qlbh.Text = "Quản lý bán hàng";
            this.bt_qlbh.UseVisualStyleBackColor = true;
            this.bt_qlbh.Click += new System.EventHandler(this.bt_qlbh_Click);
            // 
            // FormDVVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_qlsp);
            this.Controls.Add(this.bt_qldvvc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.bt_qlbh);
            this.Name = "FormDVVC";
            this.Text = "FormDVVC";
            this.Load += new System.EventHandler(this.FormDVVC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_ngh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_khoitao;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tx_sdt;
        private System.Windows.Forms.TextBox tx_tdvvc;
        private System.Windows.Forms.TextBox tx_mdvvc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_qlsp;
        private System.Windows.Forms.Button bt_qldvvc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button bt_qlbh;
    }
}