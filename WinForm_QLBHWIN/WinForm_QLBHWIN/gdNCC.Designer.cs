namespace WinForm_QLBHWIN
{
    partial class gdNCC
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
            this.textBox1_search = new System.Windows.Forms.TextBox();
            this.button13_huy = new System.Windows.Forms.Button();
            this.button11_insert = new System.Windows.Forms.Button();
            this.button10_delete = new System.Windows.Forms.Button();
            this.button9_update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaNCC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbTenNCC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(711, 262);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(17, 430);
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
            this.button6.Location = new System.Drawing.Point(17, 235);
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
            this.button5.Location = new System.Drawing.Point(17, 299);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 55);
            this.button5.TabIndex = 14;
            this.button5.Text = "Quản lý đặt hàng";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(17, 365);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 55);
            this.button4.TabIndex = 13;
            this.button4.Text = "Quản lý nhà cung cấp";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(17, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 55);
            this.button3.TabIndex = 12;
            this.button3.Text = "Quản lý khách hàng";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(17, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 55);
            this.button2.TabIndex = 11;
            this.button2.Text = "Quản lý sản phẩm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTenNCC);
            this.groupBox1.Controls.Add(this.textBox1_search);
            this.groupBox1.Controls.Add(this.button13_huy);
            this.groupBox1.Controls.Add(this.button11_insert);
            this.groupBox1.Controls.Add(this.button10_delete);
            this.groupBox1.Controls.Add(this.button9_update);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbSDT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbDiaChi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbMaNCC);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(227, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 308);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // textBox1_search
            // 
            this.textBox1_search.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_search.ForeColor = System.Drawing.Color.Gray;
            this.textBox1_search.Location = new System.Drawing.Point(39, 33);
            this.textBox1_search.Name = "textBox1_search";
            this.textBox1_search.Size = new System.Drawing.Size(472, 27);
            this.textBox1_search.TabIndex = 10;
            this.textBox1_search.Text = "Tìm kiếm nhà cung cấp theo số điện thoại hoặc mã nhà cung cấp";
            this.textBox1_search.Enter += new System.EventHandler(this.textBox1_search_Enter);
            this.textBox1_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_search_KeyDown);
            this.textBox1_search.Leave += new System.EventHandler(this.textBox1_search_Leave);
            // 
            // button13_huy
            // 
            this.button13_huy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button13_huy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13_huy.Location = new System.Drawing.Point(358, 267);
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
            this.button11_insert.Location = new System.Drawing.Point(198, 267);
            this.button11_insert.Name = "button11_insert";
            this.button11_insert.Size = new System.Drawing.Size(100, 31);
            this.button11_insert.TabIndex = 5;
            this.button11_insert.Text = "Lưu";
            this.button11_insert.UseVisualStyleBackColor = false;
            this.button11_insert.Click += new System.EventHandler(this.button11_insert_Click);
            // 
            // button10_delete
            // 
            this.button10_delete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button10_delete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10_delete.Location = new System.Drawing.Point(525, 145);
            this.button10_delete.Name = "button10_delete";
            this.button10_delete.Size = new System.Drawing.Size(120, 31);
            this.button10_delete.TabIndex = 9;
            this.button10_delete.Text = "Xóa";
            this.button10_delete.UseVisualStyleBackColor = false;
            this.button10_delete.Click += new System.EventHandler(this.button10_delete_Click);
            // 
            // button9_update
            // 
            this.button9_update.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button9_update.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9_update.Location = new System.Drawing.Point(524, 88);
            this.button9_update.Name = "button9_update";
            this.button9_update.Size = new System.Drawing.Size(120, 31);
            this.button9_update.TabIndex = 8;
            this.button9_update.Text = "Sửa";
            this.button9_update.UseVisualStyleBackColor = false;
            this.button9_update.Click += new System.EventHandler(this.button9_update_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số điện thoại";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(197, 220);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(262, 30);
            this.tbSDT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(198, 173);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(262, 30);
            this.tbDiaChi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // tbMaNCC
            // 
            this.tbMaNCC.Location = new System.Drawing.Point(198, 88);
            this.tbMaNCC.Name = "tbMaNCC";
            this.tbMaNCC.Size = new System.Drawing.Size(262, 30);
            this.tbMaNCC.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Quản lý bán hàng";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbTenNCC
            // 
            this.tbTenNCC.Location = new System.Drawing.Point(197, 130);
            this.tbTenNCC.Name = "tbTenNCC";
            this.tbTenNCC.Size = new System.Drawing.Size(262, 30);
            this.tbTenNCC.TabIndex = 11;
            // 
            // gdNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 610);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "gdNCC";
            this.Text = "Quản lý nhà cung cấp";
            this.Load += new System.EventHandler(this.gdNCC_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaNCC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbTenNCC;
    }
}