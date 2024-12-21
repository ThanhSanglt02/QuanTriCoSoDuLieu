namespace WinForm_QLBHWIN
{
    partial class gdSanPham
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button10_delete = new System.Windows.Forms.Button();
            this.tbKM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button9_update = new System.Windows.Forms.Button();
            this.button13_huy = new System.Windows.Forms.Button();
            this.button11_insert = new System.Windows.Forms.Button();
            this.tbGiaBan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGiaNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDonVi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaSp = new System.Windows.Forms.TextBox();
            this.tbTenSP = new System.Windows.Forms.TextBox();
            this.textBox1_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaHV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 497);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(904, 227);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(17, 414);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(185, 55);
            this.button7.TabIndex = 16;
            this.button7.Text = "Quản lý đơn vị vận chuyển";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(17, 219);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(185, 55);
            this.button6.TabIndex = 15;
            this.button6.Text = "Quản lý nhân viên";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(17, 283);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 55);
            this.button5.TabIndex = 14;
            this.button5.Text = "Quản lý đặt hàng";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(17, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 55);
            this.button4.TabIndex = 13;
            this.button4.Text = "Quản lý nhà cung cấp";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(17, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 55);
            this.button3.TabIndex = 12;
            this.button3.Text = "Quản lý khách hàng";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(17, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 55);
            this.button2.TabIndex = 11;
            this.button2.Text = "Quản lý sản phẩm";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button10_delete);
            this.groupBox1.Controls.Add(this.tbKM);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button9_update);
            this.groupBox1.Controls.Add(this.button13_huy);
            this.groupBox1.Controls.Add(this.button11_insert);
            this.groupBox1.Controls.Add(this.tbGiaBan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbGiaNhap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbDonVi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbSL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbMaSp);
            this.groupBox1.Controls.Add(this.tbTenSP);
            this.groupBox1.Controls.Add(this.textBox1_search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbMaHV);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(227, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 451);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(268, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Hạn sử dụng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(272, 331);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Khuyến mãi";
            // 
            // button10_delete
            // 
            this.button10_delete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button10_delete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10_delete.Location = new System.Drawing.Point(760, 184);
            this.button10_delete.Name = "button10_delete";
            this.button10_delete.Size = new System.Drawing.Size(120, 31);
            this.button10_delete.TabIndex = 9;
            this.button10_delete.Text = "Xóa";
            this.button10_delete.UseVisualStyleBackColor = false;
            this.button10_delete.Click += new System.EventHandler(this.button10_delete_Click);
            // 
            // tbKM
            // 
            this.tbKM.Location = new System.Drawing.Point(43, 331);
            this.tbKM.Name = "tbKM";
            this.tbKM.Size = new System.Drawing.Size(197, 30);
            this.tbKM.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(270, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Đơn giá bán";
            // 
            // button9_update
            // 
            this.button9_update.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button9_update.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9_update.Location = new System.Drawing.Point(760, 114);
            this.button9_update.Name = "button9_update";
            this.button9_update.Size = new System.Drawing.Size(120, 31);
            this.button9_update.TabIndex = 8;
            this.button9_update.Text = "Sửa";
            this.button9_update.UseVisualStyleBackColor = false;
            this.button9_update.Click += new System.EventHandler(this.button9_Click);
            // 
            // button13_huy
            // 
            this.button13_huy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button13_huy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13_huy.Location = new System.Drawing.Point(478, 397);
            this.button13_huy.Name = "button13_huy";
            this.button13_huy.Size = new System.Drawing.Size(102, 31);
            this.button13_huy.TabIndex = 6;
            this.button13_huy.Text = "Hủy";
            this.button13_huy.UseVisualStyleBackColor = false;
            this.button13_huy.Click += new System.EventHandler(this.button13_huy_Click);
            // 
            // button11_insert
            // 
            this.button11_insert.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button11_insert.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11_insert.Location = new System.Drawing.Point(298, 400);
            this.button11_insert.Name = "button11_insert";
            this.button11_insert.Size = new System.Drawing.Size(100, 31);
            this.button11_insert.TabIndex = 5;
            this.button11_insert.Text = "Lưu";
            this.button11_insert.UseVisualStyleBackColor = false;
            this.button11_insert.Click += new System.EventHandler(this.button11_Click);
            // 
            // tbGiaBan
            // 
            this.tbGiaBan.Location = new System.Drawing.Point(272, 260);
            this.tbGiaBan.Name = "tbGiaBan";
            this.tbGiaBan.Size = new System.Drawing.Size(197, 30);
            this.tbGiaBan.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Đơn giá nhập";
            // 
            // tbGiaNhap
            // 
            this.tbGiaNhap.Location = new System.Drawing.Point(45, 260);
            this.tbGiaNhap.Name = "tbGiaNhap";
            this.tbGiaNhap.Size = new System.Drawing.Size(197, 30);
            this.tbGiaNhap.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(499, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Đơn vị tính";
            // 
            // tbDonVi
            // 
            this.tbDonVi.Location = new System.Drawing.Point(501, 260);
            this.tbDonVi.Name = "tbDonVi";
            this.tbDonVi.Size = new System.Drawing.Size(197, 30);
            this.tbDonVi.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(499, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Số lượng ";
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(501, 115);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(197, 30);
            this.tbSL.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã sản phẩm";
            // 
            // tbMaSp
            // 
            this.tbMaSp.Location = new System.Drawing.Point(270, 115);
            this.tbMaSp.Name = "tbMaSp";
            this.tbMaSp.Size = new System.Drawing.Size(197, 30);
            this.tbMaSp.TabIndex = 13;
            // 
            // tbTenSP
            // 
            this.tbTenSP.Location = new System.Drawing.Point(43, 184);
            this.tbTenSP.Name = "tbTenSP";
            this.tbTenSP.Size = new System.Drawing.Size(655, 30);
            this.tbTenSP.TabIndex = 11;
            // 
            // textBox1_search
            // 
            this.textBox1_search.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_search.ForeColor = System.Drawing.Color.Gray;
            this.textBox1_search.Location = new System.Drawing.Point(39, 33);
            this.textBox1_search.Name = "textBox1_search";
            this.textBox1_search.Size = new System.Drawing.Size(229, 27);
            this.textBox1_search.TabIndex = 10;
            this.textBox1_search.Text = "Tìm kiếm tên sản phẩm";
            this.textBox1_search.Enter += new System.EventHandler(this.textBox1_search_Enter);
            this.textBox1_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_search_KeyDown);
            this.textBox1_search.Leave += new System.EventHandler(this.textBox1_search_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hàng vin";
            // 
            // tbMaHV
            // 
            this.tbMaHV.Location = new System.Drawing.Point(43, 114);
            this.tbMaHV.Name = "tbMaHV";
            this.tbMaHV.Size = new System.Drawing.Size(197, 30);
            this.tbMaHV.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Quản lý bán hàng";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // gdSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 726);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "gdSanPham";
            this.Text = "gdSanPham";
            this.Load += new System.EventHandler(this.gdSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1_search;
        private System.Windows.Forms.Button button13_huy;
        private System.Windows.Forms.Button button11_insert;
        private System.Windows.Forms.Button button10_delete;
        private System.Windows.Forms.Button button9_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaHV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaSp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbKM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbGiaBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGiaNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDonVi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenSP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}