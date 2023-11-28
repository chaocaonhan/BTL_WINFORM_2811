namespace BTL_QuanLiKTX
{
	partial class FormDSP
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachPhong)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nhan)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewDanhSachPhong
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dataGridViewDanhSachPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewDanhSachPhong.AutoGenerateColumns = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDanhSachPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewDanhSachPhong.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewDanhSachPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridViewDanhSachPhong.Location = new System.Drawing.Point(12, 12);
			this.dataGridViewDanhSachPhong.Name = "dataGridViewDanhSachPhong";
			this.dataGridViewDanhSachPhong.RowHeadersVisible = false;
			this.dataGridViewDanhSachPhong.RowHeadersWidth = 51;
			this.dataGridViewDanhSachPhong.RowTemplate.Height = 24;
			this.dataGridViewDanhSachPhong.Size = new System.Drawing.Size(1234, 542);
			this.dataGridViewDanhSachPhong.TabIndex = 28;
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
			// FormDSP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1261, 684);
			this.Controls.Add(this.dataGridViewDanhSachPhong);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormDSP";
			this.Text = "FormDSP";
			this.Load += new System.EventHandler(this.FormDSP_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachPhong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nhan)).EndInit();
			this.ResumeLayout(false);

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
	}
}