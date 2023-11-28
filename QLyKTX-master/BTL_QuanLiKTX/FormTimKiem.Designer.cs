namespace BTL_QuanLiKTX
{
	partial class FormTimKiem
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
			this.dgvDSSinhVien = new Guna.UI2.WinForms.Guna2DataGridView();
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbMaKhoaTK = new System.Windows.Forms.ComboBox();
			this.cmbMaLopTK = new System.Windows.Forms.ComboBox();
			this.cmbMaPhongTK = new System.Windows.Forms.ComboBox();
			this.cmbGioiTinhTK = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.errLoi = new System.Windows.Forms.ErrorProvider(this.components);
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
			this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.khoaTableAdapter = new BTL_QuanLiKTX.NhanTableAdapters.KhoaTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVien)).BeginInit();
			this.guna2GroupBox1.SuspendLayout();
			this.guna2GroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errLoi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nhan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDSSinhVien
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.dgvDSSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvDSSinhVien.AutoGenerateColumns = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDSSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvDSSinhVien.ColumnHeadersHeight = 15;
			this.dgvDSSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvDSSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masinhvienDataGridViewTextBoxColumn,
            this.tensinhvienDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewTextBoxColumn,
            this.maqueDataGridViewTextBoxColumn,
            this.makhoaDataGridViewTextBoxColumn,
            this.malopDataGridViewTextBoxColumn});
			this.dgvDSSinhVien.DataSource = this.sinhVienBindingSource;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDSSinhVien.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvDSSinhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvDSSinhVien.Location = new System.Drawing.Point(16, 300);
			this.dgvDSSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvDSSinhVien.Name = "dgvDSSinhVien";
			this.dgvDSSinhVien.RowHeadersVisible = false;
			this.dgvDSSinhVien.RowHeadersWidth = 51;
			this.dgvDSSinhVien.Size = new System.Drawing.Size(1035, 230);
			this.dgvDSSinhVien.TabIndex = 2;
			this.dgvDSSinhVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvDSSinhVien.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvDSSinhVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvDSSinhVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvDSSinhVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvDSSinhVien.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvDSSinhVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvDSSinhVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvDSSinhVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvDSSinhVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvDSSinhVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvDSSinhVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvDSSinhVien.ThemeStyle.HeaderStyle.Height = 15;
			this.dgvDSSinhVien.ThemeStyle.ReadOnly = false;
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.Height = 22;
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// btnHuy
			// 
			this.btnHuy.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnHuy.Location = new System.Drawing.Point(567, 226);
			this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(171, 39);
			this.btnHuy.TabIndex = 6;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = false;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnTimKiem.Location = new System.Drawing.Point(340, 226);
			this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(171, 39);
			this.btnTimKiem.TabIndex = 7;
			this.btnTimKiem.Text = "Tìm kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = false;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(20, 62);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(117, 26);
			this.label7.TabIndex = 9;
			this.label7.Text = "Mã khoa :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(20, 116);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 26);
			this.label6.TabIndex = 8;
			this.label6.Text = "Mã lớp :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(21, 116);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 26);
			this.label1.TabIndex = 10;
			this.label1.Text = "Mã Phòng :";
			// 
			// cmbMaKhoaTK
			// 
			this.cmbMaKhoaTK.DataSource = this.khoaBindingSource;
			this.cmbMaKhoaTK.DisplayMember = "Makhoa";
			this.cmbMaKhoaTK.FormattingEnabled = true;
			this.cmbMaKhoaTK.Location = new System.Drawing.Point(153, 60);
			this.cmbMaKhoaTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbMaKhoaTK.Name = "cmbMaKhoaTK";
			this.cmbMaKhoaTK.Size = new System.Drawing.Size(316, 34);
			this.cmbMaKhoaTK.TabIndex = 11;
			this.cmbMaKhoaTK.SelectedIndexChanged += new System.EventHandler(this.cmbMaKhoaTK_SelectedIndexChanged);
			// 
			// cmbMaLopTK
			// 
			this.cmbMaLopTK.FormattingEnabled = true;
			this.cmbMaLopTK.Location = new System.Drawing.Point(153, 114);
			this.cmbMaLopTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbMaLopTK.Name = "cmbMaLopTK";
			this.cmbMaLopTK.Size = new System.Drawing.Size(316, 34);
			this.cmbMaLopTK.TabIndex = 12;
			// 
			// cmbMaPhongTK
			// 
			this.cmbMaPhongTK.FormattingEnabled = true;
			this.cmbMaPhongTK.Location = new System.Drawing.Point(169, 116);
			this.cmbMaPhongTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbMaPhongTK.Name = "cmbMaPhongTK";
			this.cmbMaPhongTK.Size = new System.Drawing.Size(291, 34);
			this.cmbMaPhongTK.TabIndex = 13;
			// 
			// cmbGioiTinhTK
			// 
			this.cmbGioiTinhTK.FormattingEnabled = true;
			this.cmbGioiTinhTK.Location = new System.Drawing.Point(169, 62);
			this.cmbGioiTinhTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbGioiTinhTK.Name = "cmbGioiTinhTK";
			this.cmbGioiTinhTK.Size = new System.Drawing.Size(291, 34);
			this.cmbGioiTinhTK.TabIndex = 15;
			this.cmbGioiTinhTK.SelectedIndexChanged += new System.EventHandler(this.cmbGioiTinhTK_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(21, 62);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 26);
			this.label2.TabIndex = 14;
			this.label2.Text = "Giới Tính :";
			// 
			// guna2GroupBox1
			// 
			this.guna2GroupBox1.Controls.Add(this.label7);
			this.guna2GroupBox1.Controls.Add(this.cmbMaKhoaTK);
			this.guna2GroupBox1.Controls.Add(this.label6);
			this.guna2GroupBox1.Controls.Add(this.cmbMaLopTK);
			this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.SlateBlue;
			this.guna2GroupBox1.FillColor = System.Drawing.Color.WhiteSmoke;
			this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
			this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
			this.guna2GroupBox1.Location = new System.Drawing.Point(16, 15);
			this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.Size = new System.Drawing.Size(495, 172);
			this.guna2GroupBox1.TabIndex = 16;
			this.guna2GroupBox1.Text = "Tìm Kiếm Theo Lớp";
			// 
			// guna2GroupBox2
			// 
			this.guna2GroupBox2.Controls.Add(this.label2);
			this.guna2GroupBox2.Controls.Add(this.label1);
			this.guna2GroupBox2.Controls.Add(this.cmbMaPhongTK);
			this.guna2GroupBox2.Controls.Add(this.cmbGioiTinhTK);
			this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.SlateBlue;
			this.guna2GroupBox2.FillColor = System.Drawing.Color.WhiteSmoke;
			this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
			this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
			this.guna2GroupBox2.Location = new System.Drawing.Point(567, 15);
			this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.guna2GroupBox2.Name = "guna2GroupBox2";
			this.guna2GroupBox2.Size = new System.Drawing.Size(484, 172);
			this.guna2GroupBox2.TabIndex = 17;
			this.guna2GroupBox2.Text = "Tìm Kiếm Theo Phòng";
			// 
			// errLoi
			// 
			this.errLoi.ContainerControl = this;
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
			// khoaBindingSource
			// 
			this.khoaBindingSource.DataMember = "Khoa";
			this.khoaBindingSource.DataSource = this.nhan;
			// 
			// khoaTableAdapter
			// 
			this.khoaTableAdapter.ClearBeforeFill = true;
			// 
			// FormTimKiem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.guna2GroupBox2);
			this.Controls.Add(this.guna2GroupBox1);
			this.Controls.Add(this.btnTimKiem);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.dgvDSSinhVien);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormTimKiem";
			this.Text = "FormTimKiem";
			this.Load += new System.EventHandler(this.FormTimKiem_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVien)).EndInit();
			this.guna2GroupBox1.ResumeLayout(false);
			this.guna2GroupBox1.PerformLayout();
			this.guna2GroupBox2.ResumeLayout(false);
			this.guna2GroupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errLoi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nhan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2DataGridView dgvDSSinhVien;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbMaKhoaTK;
		private System.Windows.Forms.ComboBox cmbMaLopTK;
		private System.Windows.Forms.ComboBox cmbMaPhongTK;
		private System.Windows.Forms.ComboBox cmbGioiTinhTK;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
		private System.Windows.Forms.ErrorProvider errLoi;
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
		private System.Windows.Forms.BindingSource khoaBindingSource;
		private NhanTableAdapters.KhoaTableAdapter khoaTableAdapter;
	}
}