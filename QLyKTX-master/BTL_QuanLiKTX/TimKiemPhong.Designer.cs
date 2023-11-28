namespace BTL_QuanLiKTX
{
	partial class TimKiemPhong
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridViewDanhSachPhong = new Guna.UI2.WinForms.Guna2DataGridView();
			this.maPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenphongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.manhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loaiphongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.songuoitoidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.songuoidangoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tienthueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ghichuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nhan = new BTL_QuanLiKTX.Nhan();
			this.phongTableAdapter = new BTL_QuanLiKTX.NhanTableAdapters.PhongTableAdapter();
			this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
			this.txtTenSVCanTim = new Guna.UI2.WinForms.Guna2TextBox();
			this.checkBoxPhongTrong = new Guna.UI2.WinForms.Guna2CheckBox();
			this.btnTim = new Guna.UI2.WinForms.Guna2Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachPhong)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nhan)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewDanhSachPhong
			// 
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
			this.dataGridViewDanhSachPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridViewDanhSachPhong.AutoGenerateColumns = false;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDanhSachPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridViewDanhSachPhong.ColumnHeadersHeight = 18;
			this.dataGridViewDanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dataGridViewDanhSachPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhongDataGridViewTextBoxColumn,
            this.tenphongDataGridViewTextBoxColumn,
            this.manhaDataGridViewTextBoxColumn,
            this.loaiphongDataGridViewTextBoxColumn,
            this.songuoitoidaDataGridViewTextBoxColumn,
            this.songuoidangoDataGridViewTextBoxColumn,
            this.tienthueDataGridViewTextBoxColumn,
            this.ghichuDataGridViewTextBoxColumn});
			this.dataGridViewDanhSachPhong.DataSource = this.phongBindingSource;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewDanhSachPhong.DefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridViewDanhSachPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridViewDanhSachPhong.Location = new System.Drawing.Point(22, 113);
			this.dataGridViewDanhSachPhong.Name = "dataGridViewDanhSachPhong";
			this.dataGridViewDanhSachPhong.RowHeadersVisible = false;
			this.dataGridViewDanhSachPhong.RowHeadersWidth = 51;
			this.dataGridViewDanhSachPhong.RowTemplate.Height = 24;
			this.dataGridViewDanhSachPhong.Size = new System.Drawing.Size(1234, 409);
			this.dataGridViewDanhSachPhong.TabIndex = 29;
			this.dataGridViewDanhSachPhong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dataGridViewDanhSachPhong.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dataGridViewDanhSachPhong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dataGridViewDanhSachPhong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dataGridViewDanhSachPhong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dataGridViewDanhSachPhong.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dataGridViewDanhSachPhong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridViewDanhSachPhong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dataGridViewDanhSachPhong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridViewDanhSachPhong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewDanhSachPhong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dataGridViewDanhSachPhong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dataGridViewDanhSachPhong.ThemeStyle.HeaderStyle.Height = 18;
			this.dataGridViewDanhSachPhong.ThemeStyle.ReadOnly = false;
			this.dataGridViewDanhSachPhong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dataGridViewDanhSachPhong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridViewDanhSachPhong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewDanhSachPhong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dataGridViewDanhSachPhong.ThemeStyle.RowsStyle.Height = 24;
			this.dataGridViewDanhSachPhong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridViewDanhSachPhong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// maPhongDataGridViewTextBoxColumn
			// 
			this.maPhongDataGridViewTextBoxColumn.DataPropertyName = "MaPhong";
			this.maPhongDataGridViewTextBoxColumn.HeaderText = "MaPhong";
			this.maPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.maPhongDataGridViewTextBoxColumn.Name = "maPhongDataGridViewTextBoxColumn";
			// 
			// tenphongDataGridViewTextBoxColumn
			// 
			this.tenphongDataGridViewTextBoxColumn.DataPropertyName = "Tenphong";
			this.tenphongDataGridViewTextBoxColumn.HeaderText = "Tenphong";
			this.tenphongDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.tenphongDataGridViewTextBoxColumn.Name = "tenphongDataGridViewTextBoxColumn";
			// 
			// manhaDataGridViewTextBoxColumn
			// 
			this.manhaDataGridViewTextBoxColumn.DataPropertyName = "Manha";
			this.manhaDataGridViewTextBoxColumn.HeaderText = "Manha";
			this.manhaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.manhaDataGridViewTextBoxColumn.Name = "manhaDataGridViewTextBoxColumn";
			// 
			// loaiphongDataGridViewTextBoxColumn
			// 
			this.loaiphongDataGridViewTextBoxColumn.DataPropertyName = "Loaiphong";
			this.loaiphongDataGridViewTextBoxColumn.HeaderText = "Loaiphong";
			this.loaiphongDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.loaiphongDataGridViewTextBoxColumn.Name = "loaiphongDataGridViewTextBoxColumn";
			// 
			// songuoitoidaDataGridViewTextBoxColumn
			// 
			this.songuoitoidaDataGridViewTextBoxColumn.DataPropertyName = "Songuoitoida";
			this.songuoitoidaDataGridViewTextBoxColumn.HeaderText = "Songuoitoida";
			this.songuoitoidaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.songuoitoidaDataGridViewTextBoxColumn.Name = "songuoitoidaDataGridViewTextBoxColumn";
			// 
			// songuoidangoDataGridViewTextBoxColumn
			// 
			this.songuoidangoDataGridViewTextBoxColumn.DataPropertyName = "Songuoidango";
			this.songuoidangoDataGridViewTextBoxColumn.HeaderText = "Songuoidango";
			this.songuoidangoDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.songuoidangoDataGridViewTextBoxColumn.Name = "songuoidangoDataGridViewTextBoxColumn";
			// 
			// tienthueDataGridViewTextBoxColumn
			// 
			this.tienthueDataGridViewTextBoxColumn.DataPropertyName = "Tienthue";
			this.tienthueDataGridViewTextBoxColumn.HeaderText = "Tienthue";
			this.tienthueDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.tienthueDataGridViewTextBoxColumn.Name = "tienthueDataGridViewTextBoxColumn";
			// 
			// ghichuDataGridViewTextBoxColumn
			// 
			this.ghichuDataGridViewTextBoxColumn.DataPropertyName = "Ghichu";
			this.ghichuDataGridViewTextBoxColumn.HeaderText = "Ghichu";
			this.ghichuDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.ghichuDataGridViewTextBoxColumn.Name = "ghichuDataGridViewTextBoxColumn";
			// 
			// phongBindingSource
			// 
			this.phongBindingSource.DataMember = "Phong";
			this.phongBindingSource.DataSource = this.nhan;
			// 
			// nhan
			// 
			this.nhan.DataSetName = "Nhan";
			this.nhan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// phongTableAdapter
			// 
			this.phongTableAdapter.ClearBeforeFill = true;
			// 
			// cmbGioiTinh
			// 
			this.cmbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbGioiTinh.FormattingEnabled = true;
			this.cmbGioiTinh.Location = new System.Drawing.Point(22, 46);
			this.cmbGioiTinh.Name = "cmbGioiTinh";
			this.cmbGioiTinh.Size = new System.Drawing.Size(217, 37);
			this.cmbGioiTinh.TabIndex = 30;
			// 
			// txtTenSVCanTim
			// 
			this.txtTenSVCanTim.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTenSVCanTim.DefaultText = "";
			this.txtTenSVCanTim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtTenSVCanTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtTenSVCanTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTenSVCanTim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTenSVCanTim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTenSVCanTim.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtTenSVCanTim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTenSVCanTim.Location = new System.Drawing.Point(746, 38);
			this.txtTenSVCanTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtTenSVCanTim.Name = "txtTenSVCanTim";
			this.txtTenSVCanTim.PasswordChar = '\0';
			this.txtTenSVCanTim.PlaceholderText = "";
			this.txtTenSVCanTim.SelectedText = "";
			this.txtTenSVCanTim.Size = new System.Drawing.Size(229, 48);
			this.txtTenSVCanTim.TabIndex = 31;
			this.txtTenSVCanTim.Click += new System.EventHandler(this.txtTenSVCanTim_Click);
			// 
			// checkBoxPhongTrong
			// 
			this.checkBoxPhongTrong.AutoSize = true;
			this.checkBoxPhongTrong.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.checkBoxPhongTrong.CheckedState.BorderRadius = 0;
			this.checkBoxPhongTrong.CheckedState.BorderThickness = 0;
			this.checkBoxPhongTrong.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.checkBoxPhongTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxPhongTrong.Location = new System.Drawing.Point(314, 50);
			this.checkBoxPhongTrong.Name = "checkBoxPhongTrong";
			this.checkBoxPhongTrong.Size = new System.Drawing.Size(166, 33);
			this.checkBoxPhongTrong.TabIndex = 32;
			this.checkBoxPhongTrong.Text = "Phòng trống";
			this.checkBoxPhongTrong.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.checkBoxPhongTrong.UncheckedState.BorderRadius = 0;
			this.checkBoxPhongTrong.UncheckedState.BorderThickness = 0;
			this.checkBoxPhongTrong.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			// 
			// btnTim
			// 
			this.btnTim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnTim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnTim.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTim.ForeColor = System.Drawing.Color.White;
			this.btnTim.Location = new System.Drawing.Point(1077, 41);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(157, 45);
			this.btnTim.TabIndex = 34;
			this.btnTim.Text = "Tìm";
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(600, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 25);
			this.label1.TabIndex = 35;
			this.label1.Text = "Tên sinh viên :";
			// 
			// TimKiemPhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1279, 582);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.checkBoxPhongTrong);
			this.Controls.Add(this.txtTenSVCanTim);
			this.Controls.Add(this.cmbGioiTinh);
			this.Controls.Add(this.dataGridViewDanhSachPhong);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TimKiemPhong";
			this.Text = "TimKiemPhong";
			this.Load += new System.EventHandler(this.TimKiemPhong_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachPhong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nhan)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2DataGridView dataGridViewDanhSachPhong;
		private Nhan nhan;
		private System.Windows.Forms.BindingSource phongBindingSource;
		private NhanTableAdapters.PhongTableAdapter phongTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn maPhongDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenphongDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn manhaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn loaiphongDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn songuoitoidaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn songuoidangoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tienthueDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ghichuDataGridViewTextBoxColumn;
		private System.Windows.Forms.ComboBox cmbGioiTinh;
		private Guna.UI2.WinForms.Guna2TextBox txtTenSVCanTim;
		private Guna.UI2.WinForms.Guna2CheckBox checkBoxPhongTrong;
		private Guna.UI2.WinForms.Guna2Button btnTim;
		private System.Windows.Forms.Label label1;
	}
}