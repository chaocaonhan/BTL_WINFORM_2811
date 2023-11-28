namespace BTL_QuanLiKTX
{
	partial class FormThemSinhVien
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
			this.errLoi = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.cmbMaLop = new System.Windows.Forms.ComboBox();
			this.cmbMaKhoa = new System.Windows.Forms.ComboBox();
			this.cmbMaQue = new System.Windows.Forms.ComboBox();
			this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.txtTensv = new System.Windows.Forms.TextBox();
			this.txtMasv = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.nhan = new BTL_QuanLiKTX.Nhan();
			this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.khoaTableAdapter = new BTL_QuanLiKTX.NhanTableAdapters.KhoaTableAdapter();
			this.queBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.queTableAdapter = new BTL_QuanLiKTX.NhanTableAdapters.QueTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.errLoi)).BeginInit();
			this.guna2GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nhan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.queBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// errLoi
			// 
			this.errLoi.ContainerControl = this;
			// 
			// btnHuy
			// 
			this.btnHuy.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnHuy.Location = new System.Drawing.Point(556, 501);
			this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(171, 39);
			this.btnHuy.TabIndex = 9;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = false;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnThem.Location = new System.Drawing.Point(323, 501);
			this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(171, 39);
			this.btnThem.TabIndex = 8;
			this.btnThem.Text = "Đăng kí ";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// guna2GroupBox1
			// 
			this.guna2GroupBox1.Controls.Add(this.cmbMaLop);
			this.guna2GroupBox1.Controls.Add(this.cmbMaKhoa);
			this.guna2GroupBox1.Controls.Add(this.cmbMaQue);
			this.guna2GroupBox1.Controls.Add(this.cmbGioiTinh);
			this.guna2GroupBox1.Controls.Add(this.dtpNgaySinh);
			this.guna2GroupBox1.Controls.Add(this.txtTensv);
			this.guna2GroupBox1.Controls.Add(this.txtMasv);
			this.guna2GroupBox1.Controls.Add(this.label7);
			this.guna2GroupBox1.Controls.Add(this.label6);
			this.guna2GroupBox1.Controls.Add(this.label5);
			this.guna2GroupBox1.Controls.Add(this.label4);
			this.guna2GroupBox1.Controls.Add(this.label3);
			this.guna2GroupBox1.Controls.Add(this.label2);
			this.guna2GroupBox1.Controls.Add(this.label1);
			this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.SlateBlue;
			this.guna2GroupBox1.FillColor = System.Drawing.Color.WhiteSmoke;
			this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
			this.guna2GroupBox1.Location = new System.Drawing.Point(16, 15);
			this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.Size = new System.Drawing.Size(1035, 459);
			this.guna2GroupBox1.TabIndex = 7;
			this.guna2GroupBox1.Text = "Thông Tin Sinh Viên";
			// 
			// cmbMaLop
			// 
			this.cmbMaLop.FormattingEnabled = true;
			this.cmbMaLop.Location = new System.Drawing.Point(709, 261);
			this.cmbMaLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbMaLop.Name = "cmbMaLop";
			this.cmbMaLop.Size = new System.Drawing.Size(297, 34);
			this.cmbMaLop.TabIndex = 13;
			// 
			// cmbMaKhoa
			// 
			this.cmbMaKhoa.DataSource = this.khoaBindingSource;
			this.cmbMaKhoa.DisplayMember = "Makhoa";
			this.cmbMaKhoa.FormattingEnabled = true;
			this.cmbMaKhoa.Location = new System.Drawing.Point(709, 169);
			this.cmbMaKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbMaKhoa.Name = "cmbMaKhoa";
			this.cmbMaKhoa.Size = new System.Drawing.Size(297, 34);
			this.cmbMaKhoa.TabIndex = 12;
			this.cmbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbMaKhoa_SelectedIndexChanged_1);
			// 
			// cmbMaQue
			// 
			this.cmbMaQue.DataSource = this.queBindingSource;
			this.cmbMaQue.DisplayMember = "Maque";
			this.cmbMaQue.FormattingEnabled = true;
			this.cmbMaQue.Location = new System.Drawing.Point(709, 80);
			this.cmbMaQue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbMaQue.Name = "cmbMaQue";
			this.cmbMaQue.Size = new System.Drawing.Size(297, 34);
			this.cmbMaQue.TabIndex = 11;
			// 
			// cmbGioiTinh
			// 
			this.cmbGioiTinh.FormattingEnabled = true;
			this.cmbGioiTinh.Location = new System.Drawing.Point(191, 359);
			this.cmbGioiTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbGioiTinh.Name = "cmbGioiTinh";
			this.cmbGioiTinh.Size = new System.Drawing.Size(297, 34);
			this.cmbGioiTinh.TabIndex = 10;
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgaySinh.Location = new System.Drawing.Point(191, 262);
			this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(297, 35);
			this.dtpNgaySinh.TabIndex = 9;
			// 
			// txtTensv
			// 
			this.txtTensv.Location = new System.Drawing.Point(191, 170);
			this.txtTensv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTensv.Name = "txtTensv";
			this.txtTensv.Size = new System.Drawing.Size(297, 35);
			this.txtTensv.TabIndex = 8;
			// 
			// txtMasv
			// 
			this.txtMasv.Location = new System.Drawing.Point(191, 81);
			this.txtMasv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMasv.Name = "txtMasv";
			this.txtMasv.Size = new System.Drawing.Size(297, 35);
			this.txtMasv.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(535, 178);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(117, 26);
			this.label7.TabIndex = 6;
			this.label7.Text = "Mã khoa :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(535, 271);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 26);
			this.label6.TabIndex = 5;
			this.label6.Text = "Mã lớp :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(535, 90);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 26);
			this.label5.TabIndex = 4;
			this.label5.Text = "Mã quê :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(16, 369);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 26);
			this.label4.TabIndex = 3;
			this.label4.Text = "Giới tính :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(16, 271);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 26);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ngày sinh :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(16, 178);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên sinh viên :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(16, 90);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã sinh viên :";
			// 
			// nhan
			// 
			this.nhan.DataSetName = "Nhan";
			this.nhan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// khoaBindingSource
			// 
			this.khoaBindingSource.DataMember = "Khoa";
			this.khoaBindingSource.DataSource = this.nhan;
			// 
			// khoaTableAdapter
			// 
			this.khoaTableAdapter.ClearBeforeFill = true;
			// 
			// queBindingSource
			// 
			this.queBindingSource.DataMember = "Que";
			this.queBindingSource.DataSource = this.nhan;
			// 
			// queTableAdapter
			// 
			this.queTableAdapter.ClearBeforeFill = true;
			// 
			// FormThemSinhVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.guna2GroupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormThemSinhVien";
			this.Text = "FormThemSinhVien";
			this.Load += new System.EventHandler(this.FormThemSinhVien_Load);
			((System.ComponentModel.ISupportInitialize)(this.errLoi)).EndInit();
			this.guna2GroupBox1.ResumeLayout(false);
			this.guna2GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nhan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.queBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ErrorProvider errLoi;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnThem;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
		private System.Windows.Forms.ComboBox cmbMaLop;
		private System.Windows.Forms.ComboBox cmbMaKhoa;
		private System.Windows.Forms.ComboBox cmbMaQue;
		private System.Windows.Forms.ComboBox cmbGioiTinh;
		private System.Windows.Forms.DateTimePicker dtpNgaySinh;
		private System.Windows.Forms.TextBox txtTensv;
		private System.Windows.Forms.TextBox txtMasv;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Nhan nhan;
		private System.Windows.Forms.BindingSource khoaBindingSource;
		private NhanTableAdapters.KhoaTableAdapter khoaTableAdapter;
		private System.Windows.Forms.BindingSource queBindingSource;
		private NhanTableAdapters.QueTableAdapter queTableAdapter;
	}
}