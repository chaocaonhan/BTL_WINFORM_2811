namespace BTL_QuanLiKTX
{
	partial class FormSVDatPhong
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
			this.components = new System.ComponentModel.Container();
			this.btnHuy = new System.Windows.Forms.Button();
			this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.txtGioitinh = new System.Windows.Forms.TextBox();
			this.txtToiDa = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtDango = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtTienThue = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbMaSV = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbMaLop = new System.Windows.Forms.ComboBox();
			this.cmbMaKhoa = new System.Windows.Forms.ComboBox();
			this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nhan = new BTL_QuanLiKTX.Nhan();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtGhiChu = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbMaPhong = new System.Windows.Forms.ComboBox();
			this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
			this.txtMathue = new System.Windows.Forms.TextBox();
			this.dtpNgayBĐ = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.btnThem = new System.Windows.Forms.Button();
			this.errLoi = new System.Windows.Forms.ErrorProvider(this.components);
			this.khoaTableAdapter = new BTL_QuanLiKTX.NhanTableAdapters.KhoaTableAdapter();
			this.guna2GroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nhan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errLoi)).BeginInit();
			this.SuspendLayout();
			// 
			// btnHuy
			// 
			this.btnHuy.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnHuy.Location = new System.Drawing.Point(616, 555);
			this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(187, 65);
			this.btnHuy.TabIndex = 50;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = false;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// guna2GroupBox2
			// 
			this.guna2GroupBox2.Controls.Add(this.txtGioitinh);
			this.guna2GroupBox2.Controls.Add(this.txtToiDa);
			this.guna2GroupBox2.Controls.Add(this.label14);
			this.guna2GroupBox2.Controls.Add(this.txtDango);
			this.guna2GroupBox2.Controls.Add(this.label13);
			this.guna2GroupBox2.Controls.Add(this.txtTienThue);
			this.guna2GroupBox2.Controls.Add(this.label9);
			this.guna2GroupBox2.Controls.Add(this.label2);
			this.guna2GroupBox2.Controls.Add(this.cmbMaSV);
			this.guna2GroupBox2.Controls.Add(this.label4);
			this.guna2GroupBox2.Controls.Add(this.cmbMaLop);
			this.guna2GroupBox2.Controls.Add(this.cmbMaKhoa);
			this.guna2GroupBox2.Controls.Add(this.label7);
			this.guna2GroupBox2.Controls.Add(this.label6);
			this.guna2GroupBox2.Controls.Add(this.txtGhiChu);
			this.guna2GroupBox2.Controls.Add(this.label1);
			this.guna2GroupBox2.Controls.Add(this.cmbMaPhong);
			this.guna2GroupBox2.Controls.Add(this.dtpNgayKT);
			this.guna2GroupBox2.Controls.Add(this.txtMathue);
			this.guna2GroupBox2.Controls.Add(this.dtpNgayBĐ);
			this.guna2GroupBox2.Controls.Add(this.label8);
			this.guna2GroupBox2.Controls.Add(this.label10);
			this.guna2GroupBox2.Controls.Add(this.label11);
			this.guna2GroupBox2.Controls.Add(this.label12);
			this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.SlateBlue;
			this.guna2GroupBox2.FillColor = System.Drawing.Color.WhiteSmoke;
			this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
			this.guna2GroupBox2.Location = new System.Drawing.Point(40, 58);
			this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.guna2GroupBox2.Name = "guna2GroupBox2";
			this.guna2GroupBox2.Size = new System.Drawing.Size(1172, 459);
			this.guna2GroupBox2.TabIndex = 48;
			this.guna2GroupBox2.Text = "Thông Tin Đăng Ký Phòng Thuê";
			// 
			// txtGioitinh
			// 
			this.txtGioitinh.Location = new System.Drawing.Point(181, 279);
			this.txtGioitinh.Margin = new System.Windows.Forms.Padding(4);
			this.txtGioitinh.Name = "txtGioitinh";
			this.txtGioitinh.Size = new System.Drawing.Size(295, 35);
			this.txtGioitinh.TabIndex = 46;
			// 
			// txtToiDa
			// 
			this.txtToiDa.Enabled = false;
			this.txtToiDa.Location = new System.Drawing.Point(855, 395);
			this.txtToiDa.Margin = new System.Windows.Forms.Padding(4);
			this.txtToiDa.Name = "txtToiDa";
			this.txtToiDa.Size = new System.Drawing.Size(256, 35);
			this.txtToiDa.TabIndex = 45;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(641, 399);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(180, 26);
			this.label14.TabIndex = 44;
			this.label14.Text = "Số người tối đa :";
			// 
			// txtDango
			// 
			this.txtDango.Enabled = false;
			this.txtDango.Location = new System.Drawing.Point(855, 334);
			this.txtDango.Margin = new System.Windows.Forms.Padding(4);
			this.txtDango.Name = "txtDango";
			this.txtDango.Size = new System.Drawing.Size(256, 35);
			this.txtDango.TabIndex = 43;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(641, 337);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(191, 26);
			this.label13.TabIndex = 42;
			this.label13.Text = "Số người đang ở :";
			// 
			// txtTienThue
			// 
			this.txtTienThue.Enabled = false;
			this.txtTienThue.Location = new System.Drawing.Point(821, 273);
			this.txtTienThue.Margin = new System.Windows.Forms.Padding(4);
			this.txtTienThue.Name = "txtTienThue";
			this.txtTienThue.Size = new System.Drawing.Size(289, 35);
			this.txtTienThue.TabIndex = 41;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(641, 277);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(123, 26);
			this.label9.TabIndex = 40;
			this.label9.Text = "Tiền thuê :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(7, 283);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 26);
			this.label2.TabIndex = 38;
			this.label2.Text = "Giới tính :";
			// 
			// cmbMaSV
			// 
			this.cmbMaSV.FormattingEnabled = true;
			this.cmbMaSV.Location = new System.Drawing.Point(181, 202);
			this.cmbMaSV.Margin = new System.Windows.Forms.Padding(4);
			this.cmbMaSV.Name = "cmbMaSV";
			this.cmbMaSV.Size = new System.Drawing.Size(295, 34);
			this.cmbMaSV.TabIndex = 37;
			this.cmbMaSV.SelectedIndexChanged += new System.EventHandler(this.cmbMaSV_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(7, 212);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(157, 26);
			this.label4.TabIndex = 36;
			this.label4.Text = "Mã sinh viên :";
			// 
			// cmbMaLop
			// 
			this.cmbMaLop.FormattingEnabled = true;
			this.cmbMaLop.Location = new System.Drawing.Point(179, 134);
			this.cmbMaLop.Margin = new System.Windows.Forms.Padding(4);
			this.cmbMaLop.Name = "cmbMaLop";
			this.cmbMaLop.Size = new System.Drawing.Size(297, 34);
			this.cmbMaLop.TabIndex = 35;
			this.cmbMaLop.SelectedIndexChanged += new System.EventHandler(this.cmbMaLop_SelectedIndexChanged);
			// 
			// cmbMaKhoa
			// 
			this.cmbMaKhoa.DataSource = this.khoaBindingSource;
			this.cmbMaKhoa.DisplayMember = "Makhoa";
			this.cmbMaKhoa.FormattingEnabled = true;
			this.cmbMaKhoa.Location = new System.Drawing.Point(179, 70);
			this.cmbMaKhoa.Margin = new System.Windows.Forms.Padding(4);
			this.cmbMaKhoa.Name = "cmbMaKhoa";
			this.cmbMaKhoa.Size = new System.Drawing.Size(297, 34);
			this.cmbMaKhoa.TabIndex = 34;
			this.cmbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbMaKhoa_SelectedIndexChanged);
			// 
			// khoaBindingSource
			// 
			this.khoaBindingSource.DataMember = "Khoa";
			this.khoaBindingSource.DataSource = this.nhan;
			// 
			// nhan
			// 
			this.nhan.DataSetName = "Nhan";
			this.nhan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(4, 80);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(117, 26);
			this.label7.TabIndex = 33;
			this.label7.Text = "Mã khoa :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(4, 144);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 26);
			this.label6.TabIndex = 32;
			this.label6.Text = "Mã lớp :";
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.Location = new System.Drawing.Point(821, 179);
			this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
			this.txtGhiChu.Multiline = true;
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new System.Drawing.Size(289, 67);
			this.txtGhiChu.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(641, 206);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 26);
			this.label1.TabIndex = 21;
			this.label1.Text = "Ghi chú :";
			// 
			// cmbMaPhong
			// 
			this.cmbMaPhong.FormattingEnabled = true;
			this.cmbMaPhong.Location = new System.Drawing.Point(188, 395);
			this.cmbMaPhong.Margin = new System.Windows.Forms.Padding(4);
			this.cmbMaPhong.Name = "cmbMaPhong";
			this.cmbMaPhong.Size = new System.Drawing.Size(288, 34);
			this.cmbMaPhong.TabIndex = 14;
			this.cmbMaPhong.SelectedIndexChanged += new System.EventHandler(this.cmbMaPhong_SelectedIndexChanged);
			// 
			// dtpNgayKT
			// 
			this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgayKT.Location = new System.Drawing.Point(821, 126);
			this.dtpNgayKT.Margin = new System.Windows.Forms.Padding(4);
			this.dtpNgayKT.Name = "dtpNgayKT";
			this.dtpNgayKT.Size = new System.Drawing.Size(289, 35);
			this.dtpNgayKT.TabIndex = 15;
			// 
			// txtMathue
			// 
			this.txtMathue.Location = new System.Drawing.Point(187, 335);
			this.txtMathue.Margin = new System.Windows.Forms.Padding(4);
			this.txtMathue.Name = "txtMathue";
			this.txtMathue.Size = new System.Drawing.Size(289, 35);
			this.txtMathue.TabIndex = 14;
			// 
			// dtpNgayBĐ
			// 
			this.dtpNgayBĐ.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgayBĐ.Location = new System.Drawing.Point(821, 68);
			this.dtpNgayBĐ.Margin = new System.Windows.Forms.Padding(4);
			this.dtpNgayBĐ.Name = "dtpNgayBĐ";
			this.dtpNgayBĐ.Size = new System.Drawing.Size(289, 35);
			this.dtpNgayBĐ.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(641, 138);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(168, 26);
			this.label8.TabIndex = 11;
			this.label8.Text = "Ngày kết thúc :";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(7, 405);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(130, 26);
			this.label10.TabIndex = 9;
			this.label10.Text = "Mã phòng :";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(7, 343);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(139, 26);
			this.label11.TabIndex = 8;
			this.label11.Text = "Mã số thuê :";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(641, 74);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(162, 26);
			this.label12.TabIndex = 7;
			this.label12.Text = "Ngày bắt đầu :";
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnThem.Location = new System.Drawing.Point(321, 555);
			this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(179, 65);
			this.btnThem.TabIndex = 49;
			this.btnThem.Text = "Đăng kí ";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// errLoi
			// 
			this.errLoi.ContainerControl = this;
			// 
			// khoaTableAdapter
			// 
			this.khoaTableAdapter.ClearBeforeFill = true;
			// 
			// FormSVDatPhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1250, 684);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.guna2GroupBox2);
			this.Controls.Add(this.btnThem);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormSVDatPhong";
			this.Text = "FormSVDatPhong";
			this.Load += new System.EventHandler(this.FormSVDatPhong_Load);
			this.guna2GroupBox2.ResumeLayout(false);
			this.guna2GroupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nhan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errLoi)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnHuy;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
		private System.Windows.Forms.TextBox txtGioitinh;
		private System.Windows.Forms.TextBox txtToiDa;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtDango;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtTienThue;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbMaSV;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbMaLop;
		private System.Windows.Forms.ComboBox cmbMaKhoa;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtGhiChu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbMaPhong;
		private System.Windows.Forms.DateTimePicker dtpNgayKT;
		private System.Windows.Forms.TextBox txtMathue;
		private System.Windows.Forms.DateTimePicker dtpNgayBĐ;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.ErrorProvider errLoi;
		private Nhan nhan;
		private System.Windows.Forms.BindingSource khoaBindingSource;
		private NhanTableAdapters.KhoaTableAdapter khoaTableAdapter;
	}
}