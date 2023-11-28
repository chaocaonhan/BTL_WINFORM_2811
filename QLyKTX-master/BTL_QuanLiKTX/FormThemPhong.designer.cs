namespace BTL_QuanLiKTX
{
	partial class FormThemPhong
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtMaPhong = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
			this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
			this.txtSoNguoiToiDa = new System.Windows.Forms.TextBox();
			this.txtSoNguoiDangO = new System.Windows.Forms.TextBox();
			this.txtTenPhong = new System.Windows.Forms.TextBox();
			this.txtTienThue = new System.Windows.Forms.TextBox();
			this.cmbLoaiPhong = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbMaNha = new System.Windows.Forms.ComboBox();
			this.txtGhiChu = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã phòng :";
			// 
			// txtMaPhong
			// 
			this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaPhong.Location = new System.Drawing.Point(141, 53);
			this.txtMaPhong.Name = "txtMaPhong";
			this.txtMaPhong.Size = new System.Drawing.Size(150, 30);
			this.txtMaPhong.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(349, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên phòng";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(656, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 25);
			this.label3.TabIndex = 0;
			this.label3.Text = "Mã nhà";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 25);
			this.label4.TabIndex = 0;
			this.label4.Text = "Loại phòng :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(429, 187);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(169, 25);
			this.label5.TabIndex = 0;
			this.label5.Text = "Số người ở tối đa :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(27, 192);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(166, 25);
			this.label6.TabIndex = 0;
			this.label6.Text = "Số người đang ở :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(504, 130);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 25);
			this.label7.TabIndex = 0;
			this.label7.Text = "Tiền thuê";
			// 
			// btnLuu
			// 
			this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.ForeColor = System.Drawing.Color.White;
			this.btnLuu.Location = new System.Drawing.Point(158, 413);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(180, 45);
			this.btnLuu.TabIndex = 3;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnHuy
			// 
			this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.ForeColor = System.Drawing.Color.White;
			this.btnHuy.Location = new System.Drawing.Point(509, 413);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(180, 45);
			this.btnHuy.TabIndex = 3;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// txtSoNguoiToiDa
			// 
			this.txtSoNguoiToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoNguoiToiDa.Location = new System.Drawing.Point(631, 184);
			this.txtSoNguoiToiDa.Name = "txtSoNguoiToiDa";
			this.txtSoNguoiToiDa.Size = new System.Drawing.Size(242, 30);
			this.txtSoNguoiToiDa.TabIndex = 2;
			// 
			// txtSoNguoiDangO
			// 
			this.txtSoNguoiDangO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoNguoiDangO.Location = new System.Drawing.Point(199, 187);
			this.txtSoNguoiDangO.Name = "txtSoNguoiDangO";
			this.txtSoNguoiDangO.Size = new System.Drawing.Size(150, 30);
			this.txtSoNguoiDangO.TabIndex = 2;
			// 
			// txtTenPhong
			// 
			this.txtTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenPhong.Location = new System.Drawing.Point(462, 53);
			this.txtTenPhong.Name = "txtTenPhong";
			this.txtTenPhong.Size = new System.Drawing.Size(150, 30);
			this.txtTenPhong.TabIndex = 2;
			// 
			// txtTienThue
			// 
			this.txtTienThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTienThue.Location = new System.Drawing.Point(631, 127);
			this.txtTienThue.Name = "txtTienThue";
			this.txtTienThue.Size = new System.Drawing.Size(242, 30);
			this.txtTienThue.TabIndex = 2;
			// 
			// cmbLoaiPhong
			// 
			this.cmbLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbLoaiPhong.FormattingEnabled = true;
			this.cmbLoaiPhong.Location = new System.Drawing.Point(158, 127);
			this.cmbLoaiPhong.Name = "cmbLoaiPhong";
			this.cmbLoaiPhong.Size = new System.Drawing.Size(133, 33);
			this.cmbLoaiPhong.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(26, 240);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(90, 25);
			this.label8.TabIndex = 6;
			this.label8.Text = "Ghi chú :";
			// 
			// cmbMaNha
			// 
			this.cmbMaNha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbMaNha.FormattingEnabled = true;
			this.cmbMaNha.Location = new System.Drawing.Point(740, 50);
			this.cmbMaNha.Name = "cmbMaNha";
			this.cmbMaNha.Size = new System.Drawing.Size(133, 33);
			this.cmbMaNha.TabIndex = 5;
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.Location = new System.Drawing.Point(29, 268);
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new System.Drawing.Size(936, 117);
			this.txtGhiChu.TabIndex = 4;
			this.txtGhiChu.Text = "";
			// 
			// FormThemPhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(1089, 500);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.cmbMaNha);
			this.Controls.Add(this.cmbLoaiPhong);
			this.Controls.Add(this.txtGhiChu);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.txtTienThue);
			this.Controls.Add(this.txtTenPhong);
			this.Controls.Add(this.txtSoNguoiDangO);
			this.Controls.Add(this.txtSoNguoiToiDa);
			this.Controls.Add(this.txtMaPhong);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormThemPhong";
			this.ShowIcon = false;
			this.Text = "FormThemPhong";
			this.Load += new System.EventHandler(this.FormThemPhong_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMaPhong;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private Guna.UI2.WinForms.Guna2Button btnLuu;
		private Guna.UI2.WinForms.Guna2Button btnHuy;
		private System.Windows.Forms.TextBox txtSoNguoiToiDa;
		private System.Windows.Forms.TextBox txtSoNguoiDangO;
		private System.Windows.Forms.TextBox txtTenPhong;
		private System.Windows.Forms.TextBox txtTienThue;
		private System.Windows.Forms.ComboBox cmbLoaiPhong;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbMaNha;
		private System.Windows.Forms.RichTextBox txtGhiChu;
	}
}