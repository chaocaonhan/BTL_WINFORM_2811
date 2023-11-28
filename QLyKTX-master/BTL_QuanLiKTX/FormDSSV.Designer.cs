namespace BTL_QuanLiKTX
{
	partial class FormDSSV
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnAll = new System.Windows.Forms.Button();
			this.btnLivingKTX = new System.Windows.Forms.Button();
			this.dgvDSSinhVien = new Guna.UI2.WinForms.Guna2DataGridView();
			this.masinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tensinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.makhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nhan = new BTL_QuanLiKTX.Nhan();
			this.sinhVienTableAdapter = new BTL_QuanLiKTX.NhanTableAdapters.SinhVienTableAdapter();
			this.btnXuatExcel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVien)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nhan)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAll
			// 
			this.btnAll.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnAll.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAll.Location = new System.Drawing.Point(235, 592);
			this.btnAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAll.Name = "btnAll";
			this.btnAll.Size = new System.Drawing.Size(171, 39);
			this.btnAll.TabIndex = 15;
			this.btnAll.Text = "Tất Cả";
			this.btnAll.UseVisualStyleBackColor = false;
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// btnLivingKTX
			// 
			this.btnLivingKTX.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnLivingKTX.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLivingKTX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnLivingKTX.Location = new System.Drawing.Point(482, 592);
			this.btnLivingKTX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnLivingKTX.Name = "btnLivingKTX";
			this.btnLivingKTX.Size = new System.Drawing.Size(171, 39);
			this.btnLivingKTX.TabIndex = 14;
			this.btnLivingKTX.Text = "Đang ở KTX";
			this.btnLivingKTX.UseVisualStyleBackColor = false;
			this.btnLivingKTX.Click += new System.EventHandler(this.btnLivingKTX_Click);
			// 
			// dgvDSSinhVien
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvDSSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDSSinhVien.AutoGenerateColumns = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDSSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDSSinhVien.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvDSSinhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvDSSinhVien.Location = new System.Drawing.Point(13, 13);
			this.dgvDSSinhVien.Margin = new System.Windows.Forms.Padding(4);
			this.dgvDSSinhVien.Name = "dgvDSSinhVien";
			this.dgvDSSinhVien.RowHeadersVisible = false;
			this.dgvDSSinhVien.RowHeadersWidth = 51;
			this.dgvDSSinhVien.Size = new System.Drawing.Size(1262, 559);
			this.dgvDSSinhVien.TabIndex = 13;
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
			// sinhVienBindingSource
			// 
			this.sinhVienBindingSource.DataMember = "SinhVien";
			this.sinhVienBindingSource.DataSource = this.nhan;
			// 
			// nhan
			// 
			this.nhan.DataSetName = "Nhan";
			this.nhan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sinhVienTableAdapter
			// 
			this.sinhVienTableAdapter.ClearBeforeFill = true;
			// 
			// btnXuatExcel
			// 
			this.btnXuatExcel.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnXuatExcel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXuatExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnXuatExcel.Location = new System.Drawing.Point(702, 592);
			this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnXuatExcel.Name = "btnXuatExcel";
			this.btnXuatExcel.Size = new System.Drawing.Size(203, 39);
			this.btnXuatExcel.TabIndex = 16;
			this.btnXuatExcel.Text = "Xuất file Excel";
			this.btnXuatExcel.UseVisualStyleBackColor = false;
			this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
			// 
			// FormDSSV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1288, 658);
			this.Controls.Add(this.btnXuatExcel);
			this.Controls.Add(this.btnAll);
			this.Controls.Add(this.btnLivingKTX);
			this.Controls.Add(this.dgvDSSinhVien);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormDSSV";
			this.Text = "FormDSSV";
			this.Load += new System.EventHandler(this.FormDSSV_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVien)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nhan)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.Button btnLivingKTX;
		public Guna.UI2.WinForms.Guna2DataGridView dgvDSSinhVien;
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
		private System.Windows.Forms.Button btnXuatExcel;
	}
}