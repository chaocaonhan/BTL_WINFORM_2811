namespace BTL_QuanLiKTX
{
	partial class ChiTietPhong
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbMaNha = new System.Windows.Forms.ComboBox();
			this.cmbLoaiPhong = new System.Windows.Forms.ComboBox();
			this.txtGhiChu = new System.Windows.Forms.RichTextBox();
			this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
			this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
			this.txtTienThue = new System.Windows.Forms.TextBox();
			this.txtTenPhong = new System.Windows.Forms.TextBox();
			this.txtSoNguoiDangO = new System.Windows.Forms.TextBox();
			this.txtSoNguoiToiDa = new System.Windows.Forms.TextBox();
			this.txtMaPhong = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSuaThongTinPhong = new Guna.UI2.WinForms.Guna2Button();
			this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
			this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
			this.nhan = new BTL_QuanLiKTX.Nhan();
			this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sinhVienTableAdapter = new BTL_QuanLiKTX.NhanTableAdapters.SinhVienTableAdapter();
			this.masinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tensinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.makhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nhan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(822, 120);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(90, 25);
			this.label8.TabIndex = 24;
			this.label8.Text = "Ghi chú :";
			// 
			// cmbMaNha
			// 
			this.cmbMaNha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbMaNha.FormattingEnabled = true;
			this.cmbMaNha.Location = new System.Drawing.Point(917, 63);
			this.cmbMaNha.Name = "cmbMaNha";
			this.cmbMaNha.Size = new System.Drawing.Size(150, 33);
			this.cmbMaNha.TabIndex = 23;
			// 
			// cmbLoaiPhong
			// 
			this.cmbLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbLoaiPhong.FormattingEnabled = true;
			this.cmbLoaiPhong.Location = new System.Drawing.Point(188, 117);
			this.cmbLoaiPhong.Name = "cmbLoaiPhong";
			this.cmbLoaiPhong.Size = new System.Drawing.Size(150, 33);
			this.cmbLoaiPhong.TabIndex = 22;
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.Location = new System.Drawing.Point(826, 156);
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new System.Drawing.Size(241, 71);
			this.txtGhiChu.TabIndex = 21;
			this.txtGhiChu.Text = "";
			// 
			// btnThoat
			// 
			this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnThoat.FillColor = System.Drawing.Color.SlateBlue;
			this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.ForeColor = System.Drawing.Color.White;
			this.btnThoat.Location = new System.Drawing.Point(602, 415);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(180, 45);
			this.btnThoat.TabIndex = 20;
			this.btnThoat.Text = "Thoát";
			// 
			// btnLuu
			// 
			this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnLuu.FillColor = System.Drawing.Color.SlateBlue;
			this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.ForeColor = System.Drawing.Color.White;
			this.btnLuu.Location = new System.Drawing.Point(343, 415);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(180, 45);
			this.btnLuu.TabIndex = 19;
			this.btnLuu.Text = "Lưu";
			// 
			// txtTienThue
			// 
			this.txtTienThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTienThue.Location = new System.Drawing.Point(540, 60);
			this.txtTienThue.Name = "txtTienThue";
			this.txtTienThue.Size = new System.Drawing.Size(242, 30);
			this.txtTienThue.TabIndex = 17;
			// 
			// txtTenPhong
			// 
			this.txtTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenPhong.Location = new System.Drawing.Point(188, 185);
			this.txtTenPhong.Name = "txtTenPhong";
			this.txtTenPhong.Size = new System.Drawing.Size(150, 30);
			this.txtTenPhong.TabIndex = 18;
			// 
			// txtSoNguoiDangO
			// 
			this.txtSoNguoiDangO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoNguoiDangO.Location = new System.Drawing.Point(614, 197);
			this.txtSoNguoiDangO.Name = "txtSoNguoiDangO";
			this.txtSoNguoiDangO.Size = new System.Drawing.Size(167, 30);
			this.txtSoNguoiDangO.TabIndex = 16;
			// 
			// txtSoNguoiToiDa
			// 
			this.txtSoNguoiToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoNguoiToiDa.Location = new System.Drawing.Point(614, 129);
			this.txtSoNguoiToiDa.Name = "txtSoNguoiToiDa";
			this.txtSoNguoiToiDa.Size = new System.Drawing.Size(167, 30);
			this.txtSoNguoiToiDa.TabIndex = 15;
			// 
			// txtMaPhong
			// 
			this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaPhong.Location = new System.Drawing.Point(188, 46);
			this.txtMaPhong.Name = "txtMaPhong";
			this.txtMaPhong.Size = new System.Drawing.Size(150, 30);
			this.txtMaPhong.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(429, 60);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 25);
			this.label7.TabIndex = 12;
			this.label7.Text = "Tiền thuê";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(432, 197);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(166, 25);
			this.label6.TabIndex = 11;
			this.label6.Text = "Số người đang ở :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(429, 134);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(169, 25);
			this.label5.TabIndex = 10;
			this.label5.Text = "Số người ở tối đa :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(45, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 25);
			this.label4.TabIndex = 9;
			this.label4.Text = "Loại phòng :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(822, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 25);
			this.label3.TabIndex = 8;
			this.label3.Text = "Mã nhà :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(47, 185);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 25);
			this.label2.TabIndex = 13;
			this.label2.Text = "Tên phòng :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(47, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "Mã phòng :";
			// 
			// btnSuaThongTinPhong
			// 
			this.btnSuaThongTinPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSuaThongTinPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSuaThongTinPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSuaThongTinPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSuaThongTinPhong.FillColor = System.Drawing.Color.SlateBlue;
			this.btnSuaThongTinPhong.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSuaThongTinPhong.ForeColor = System.Drawing.Color.White;
			this.btnSuaThongTinPhong.Location = new System.Drawing.Point(78, 415);
			this.btnSuaThongTinPhong.Name = "btnSuaThongTinPhong";
			this.btnSuaThongTinPhong.Size = new System.Drawing.Size(180, 45);
			this.btnSuaThongTinPhong.TabIndex = 19;
			this.btnSuaThongTinPhong.Text = "Sửa";
			// 
			// btnXoa
			// 
			this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnXoa.FillColor = System.Drawing.Color.SlateBlue;
			this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.Color.White;
			this.btnXoa.Location = new System.Drawing.Point(849, 415);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(180, 45);
			this.btnXoa.TabIndex = 20;
			this.btnXoa.Text = "Xóa";
			// 
			// guna2DataGridView1
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.guna2DataGridView1.AutoGenerateColumns = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masinhvienDataGridViewTextBoxColumn,
            this.tensinhvienDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewTextBoxColumn,
            this.maqueDataGridViewTextBoxColumn,
            this.makhoaDataGridViewTextBoxColumn,
            this.malopDataGridViewTextBoxColumn});
			this.guna2DataGridView1.DataSource = this.sinhVienBindingSource;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
			this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView1.Location = new System.Drawing.Point(52, 245);
			this.guna2DataGridView1.Name = "guna2DataGridView1";
			this.guna2DataGridView1.RowHeadersVisible = false;
			this.guna2DataGridView1.RowHeadersWidth = 51;
			this.guna2DataGridView1.RowTemplate.Height = 24;
			this.guna2DataGridView1.Size = new System.Drawing.Size(1015, 150);
			this.guna2DataGridView1.TabIndex = 26;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 18;
			this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// nhan
			// 
			this.nhan.DataSetName = "Nhan";
			this.nhan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sinhVienBindingSource
			// 
			this.sinhVienBindingSource.DataMember = "SinhVien";
			this.sinhVienBindingSource.DataSource = this.nhan;
			// 
			// sinhVienTableAdapter
			// 
			this.sinhVienTableAdapter.ClearBeforeFill = true;
			// 
			// masinhvienDataGridViewTextBoxColumn
			// 
			this.masinhvienDataGridViewTextBoxColumn.DataPropertyName = "Masinhvien";
			this.masinhvienDataGridViewTextBoxColumn.HeaderText = "Masinhvien";
			this.masinhvienDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.masinhvienDataGridViewTextBoxColumn.Name = "masinhvienDataGridViewTextBoxColumn";
			// 
			// tensinhvienDataGridViewTextBoxColumn
			// 
			this.tensinhvienDataGridViewTextBoxColumn.DataPropertyName = "Tensinhvien";
			this.tensinhvienDataGridViewTextBoxColumn.HeaderText = "Tensinhvien";
			this.tensinhvienDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.tensinhvienDataGridViewTextBoxColumn.Name = "tensinhvienDataGridViewTextBoxColumn";
			// 
			// ngaysinhDataGridViewTextBoxColumn
			// 
			this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "Ngaysinh";
			this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "Ngaysinh";
			this.ngaysinhDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
			// 
			// gioitinhDataGridViewTextBoxColumn
			// 
			this.gioitinhDataGridViewTextBoxColumn.DataPropertyName = "Gioitinh";
			this.gioitinhDataGridViewTextBoxColumn.HeaderText = "Gioitinh";
			this.gioitinhDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.gioitinhDataGridViewTextBoxColumn.Name = "gioitinhDataGridViewTextBoxColumn";
			// 
			// maqueDataGridViewTextBoxColumn
			// 
			this.maqueDataGridViewTextBoxColumn.DataPropertyName = "Maque";
			this.maqueDataGridViewTextBoxColumn.HeaderText = "Maque";
			this.maqueDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.maqueDataGridViewTextBoxColumn.Name = "maqueDataGridViewTextBoxColumn";
			// 
			// makhoaDataGridViewTextBoxColumn
			// 
			this.makhoaDataGridViewTextBoxColumn.DataPropertyName = "Makhoa";
			this.makhoaDataGridViewTextBoxColumn.HeaderText = "Makhoa";
			this.makhoaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.makhoaDataGridViewTextBoxColumn.Name = "makhoaDataGridViewTextBoxColumn";
			// 
			// malopDataGridViewTextBoxColumn
			// 
			this.malopDataGridViewTextBoxColumn.DataPropertyName = "Malop";
			this.malopDataGridViewTextBoxColumn.HeaderText = "Malop";
			this.malopDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.malopDataGridViewTextBoxColumn.Name = "malopDataGridViewTextBoxColumn";
			// 
			// ChiTietPhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1089, 500);
			this.Controls.Add(this.guna2DataGridView1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.cmbMaNha);
			this.Controls.Add(this.cmbLoaiPhong);
			this.Controls.Add(this.txtGhiChu);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnSuaThongTinPhong);
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ChiTietPhong";
			this.Text = "ChiTietPhong";
			this.Load += new System.EventHandler(this.ChiTietPhong_Load);
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nhan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbMaNha;
		private System.Windows.Forms.ComboBox cmbLoaiPhong;
		private System.Windows.Forms.RichTextBox txtGhiChu;
		private Guna.UI2.WinForms.Guna2Button btnThoat;
		private Guna.UI2.WinForms.Guna2Button btnLuu;
		private System.Windows.Forms.TextBox txtTienThue;
		private System.Windows.Forms.TextBox txtTenPhong;
		private System.Windows.Forms.TextBox txtSoNguoiDangO;
		private System.Windows.Forms.TextBox txtSoNguoiToiDa;
		private System.Windows.Forms.TextBox txtMaPhong;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2Button btnSuaThongTinPhong;
		private Guna.UI2.WinForms.Guna2Button btnXoa;
		private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
		private Nhan nhan;
		private System.Windows.Forms.BindingSource sinhVienBindingSource;
		private NhanTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn masinhvienDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tensinhvienDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn maqueDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn makhoaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
	}
}