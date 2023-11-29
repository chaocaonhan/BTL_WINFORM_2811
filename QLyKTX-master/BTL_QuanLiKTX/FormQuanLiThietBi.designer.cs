namespace BTL_QuanLiKTX
{
    partial class FormQuanLiThietBi
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gbtnThem = new Guna.UI2.WinForms.Guna2Button();
			this.gbtnXoa = new Guna.UI2.WinForms.Guna2Button();
			this.gbtnSua = new Guna.UI2.WinForms.Guna2Button();
			this.lblTimKim = new System.Windows.Forms.Label();
			this.gbtnTimKiem = new Guna.UI2.WinForms.Guna2Button();
			this.grbTimKiem = new System.Windows.Forms.GroupBox();
			this.rbtnMaThietBi = new System.Windows.Forms.RadioButton();
			this.rbtnMaPhong = new System.Windows.Forms.RadioButton();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.gbtnTaiLai = new Guna.UI2.WinForms.Guna2Button();
			this.lblMaPhong = new System.Windows.Forms.Label();
			this.lblMaThietBi = new System.Windows.Forms.Label();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.lblSoLuong = new System.Windows.Forms.Label();
			this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
			this.lblTinhTrang = new System.Windows.Forms.Label();
			this.lblGiaTri = new System.Windows.Forms.Label();
			this.txtGiaTri = new System.Windows.Forms.TextBox();
			this.lblTenThietBi = new System.Windows.Forms.Label();
			this.txtTenThietBi = new System.Windows.Forms.TextBox();
			this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.txtMaPhong = new System.Windows.Forms.TextBox();
			this.txtMaThietBi = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvQLTB = new Guna.UI2.WinForms.Guna2DataGridView();
			this.grbTimKiem.SuspendLayout();
			this.guna2GradientPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvQLTB)).BeginInit();
			this.SuspendLayout();
			// 
			// gbtnThem
			// 
			this.gbtnThem.BackColor = System.Drawing.Color.Azure;
			this.gbtnThem.BorderColor = System.Drawing.SystemColors.ControlLight;
			this.gbtnThem.BorderRadius = 20;
			this.gbtnThem.BorderThickness = 2;
			this.gbtnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.gbtnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.gbtnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.gbtnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.gbtnThem.FillColor = System.Drawing.Color.CornflowerBlue;
			this.gbtnThem.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbtnThem.ForeColor = System.Drawing.Color.White;
			this.gbtnThem.Location = new System.Drawing.Point(355, 612);
			this.gbtnThem.Name = "gbtnThem";
			this.gbtnThem.Size = new System.Drawing.Size(126, 62);
			this.gbtnThem.TabIndex = 10;
			this.gbtnThem.Text = "Thêm";
			this.gbtnThem.Click += new System.EventHandler(this.gbtnThem_Click);
			// 
			// gbtnXoa
			// 
			this.gbtnXoa.BackColor = System.Drawing.Color.Azure;
			this.gbtnXoa.BorderColor = System.Drawing.SystemColors.ControlLight;
			this.gbtnXoa.BorderRadius = 20;
			this.gbtnXoa.BorderThickness = 2;
			this.gbtnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.gbtnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.gbtnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.gbtnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.gbtnXoa.FillColor = System.Drawing.Color.CornflowerBlue;
			this.gbtnXoa.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbtnXoa.ForeColor = System.Drawing.Color.White;
			this.gbtnXoa.Location = new System.Drawing.Point(582, 612);
			this.gbtnXoa.Name = "gbtnXoa";
			this.gbtnXoa.Size = new System.Drawing.Size(132, 62);
			this.gbtnXoa.TabIndex = 11;
			this.gbtnXoa.Text = "Xóa";
			this.gbtnXoa.Click += new System.EventHandler(this.gbtnXoa_Click);
			// 
			// gbtnSua
			// 
			this.gbtnSua.BackColor = System.Drawing.Color.Azure;
			this.gbtnSua.BorderColor = System.Drawing.SystemColors.ControlLight;
			this.gbtnSua.BorderRadius = 20;
			this.gbtnSua.BorderThickness = 2;
			this.gbtnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.gbtnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.gbtnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.gbtnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.gbtnSua.FillColor = System.Drawing.Color.CornflowerBlue;
			this.gbtnSua.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbtnSua.ForeColor = System.Drawing.Color.White;
			this.gbtnSua.Location = new System.Drawing.Point(116, 612);
			this.gbtnSua.Name = "gbtnSua";
			this.gbtnSua.Size = new System.Drawing.Size(138, 62);
			this.gbtnSua.TabIndex = 12;
			this.gbtnSua.Text = "Sửa";
			this.gbtnSua.Click += new System.EventHandler(this.gbtnThem_Click_1);
			// 
			// lblTimKim
			// 
			this.lblTimKim.AutoSize = true;
			this.lblTimKim.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimKim.Location = new System.Drawing.Point(34, 25);
			this.lblTimKim.Name = "lblTimKim";
			this.lblTimKim.Size = new System.Drawing.Size(108, 26);
			this.lblTimKim.TabIndex = 13;
			this.lblTimKim.Text = "Tìm kiếm:";
			// 
			// gbtnTimKiem
			// 
			this.gbtnTimKiem.BackColor = System.Drawing.Color.Azure;
			this.gbtnTimKiem.BorderColor = System.Drawing.SystemColors.ControlLight;
			this.gbtnTimKiem.BorderRadius = 20;
			this.gbtnTimKiem.BorderThickness = 2;
			this.gbtnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.gbtnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.gbtnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.gbtnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.gbtnTimKiem.FillColor = System.Drawing.Color.CornflowerBlue;
			this.gbtnTimKiem.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbtnTimKiem.ForeColor = System.Drawing.Color.White;
			this.gbtnTimKiem.Location = new System.Drawing.Point(88, 190);
			this.gbtnTimKiem.Name = "gbtnTimKiem";
			this.gbtnTimKiem.Size = new System.Drawing.Size(129, 62);
			this.gbtnTimKiem.TabIndex = 15;
			this.gbtnTimKiem.Text = "Tìm kiếm";
			this.gbtnTimKiem.Click += new System.EventHandler(this.gbtnTimKiem_Click);
			// 
			// grbTimKiem
			// 
			this.grbTimKiem.BackColor = System.Drawing.Color.CornflowerBlue;
			this.grbTimKiem.Controls.Add(this.rbtnMaThietBi);
			this.grbTimKiem.Controls.Add(this.rbtnMaPhong);
			this.grbTimKiem.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbTimKiem.Location = new System.Drawing.Point(39, 74);
			this.grbTimKiem.Name = "grbTimKiem";
			this.grbTimKiem.Size = new System.Drawing.Size(398, 106);
			this.grbTimKiem.TabIndex = 16;
			this.grbTimKiem.TabStop = false;
			this.grbTimKiem.Text = "Tìm kiếm theo";
			// 
			// rbtnMaThietBi
			// 
			this.rbtnMaThietBi.AutoSize = true;
			this.rbtnMaThietBi.Location = new System.Drawing.Point(184, 41);
			this.rbtnMaThietBi.Name = "rbtnMaThietBi";
			this.rbtnMaThietBi.Size = new System.Drawing.Size(139, 30);
			this.rbtnMaThietBi.TabIndex = 1;
			this.rbtnMaThietBi.TabStop = true;
			this.rbtnMaThietBi.Text = "Mã thiết bị";
			this.rbtnMaThietBi.UseVisualStyleBackColor = true;
			// 
			// rbtnMaPhong
			// 
			this.rbtnMaPhong.AutoSize = true;
			this.rbtnMaPhong.Location = new System.Drawing.Point(6, 39);
			this.rbtnMaPhong.Name = "rbtnMaPhong";
			this.rbtnMaPhong.Size = new System.Drawing.Size(130, 30);
			this.rbtnMaPhong.TabIndex = 0;
			this.rbtnMaPhong.TabStop = true;
			this.rbtnMaPhong.Text = "Mã phòng";
			this.rbtnMaPhong.UseVisualStyleBackColor = true;
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimKiem.Location = new System.Drawing.Point(148, 22);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(214, 34);
			this.txtTimKiem.TabIndex = 19;
			// 
			// gbtnTaiLai
			// 
			this.gbtnTaiLai.BackColor = System.Drawing.Color.Azure;
			this.gbtnTaiLai.BorderColor = System.Drawing.SystemColors.ControlLight;
			this.gbtnTaiLai.BorderRadius = 20;
			this.gbtnTaiLai.BorderThickness = 2;
			this.gbtnTaiLai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.gbtnTaiLai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.gbtnTaiLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.gbtnTaiLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.gbtnTaiLai.FillColor = System.Drawing.Color.CornflowerBlue;
			this.gbtnTaiLai.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbtnTaiLai.ForeColor = System.Drawing.Color.White;
			this.gbtnTaiLai.Location = new System.Drawing.Point(282, 190);
			this.gbtnTaiLai.Name = "gbtnTaiLai";
			this.gbtnTaiLai.Size = new System.Drawing.Size(129, 62);
			this.gbtnTaiLai.TabIndex = 20;
			this.gbtnTaiLai.Text = "Tải lại";
			this.gbtnTaiLai.Click += new System.EventHandler(this.gbtnTaiLai_Click);
			// 
			// lblMaPhong
			// 
			this.lblMaPhong.AutoSize = true;
			this.lblMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaPhong.Location = new System.Drawing.Point(77, 447);
			this.lblMaPhong.Name = "lblMaPhong";
			this.lblMaPhong.Size = new System.Drawing.Size(82, 20);
			this.lblMaPhong.TabIndex = 22;
			this.lblMaPhong.Text = "Mã phòng";
			// 
			// lblMaThietBi
			// 
			this.lblMaThietBi.AutoSize = true;
			this.lblMaThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaThietBi.Location = new System.Drawing.Point(77, 492);
			this.lblMaThietBi.Name = "lblMaThietBi";
			this.lblMaThietBi.Size = new System.Drawing.Size(87, 20);
			this.lblMaThietBi.TabIndex = 24;
			this.lblMaThietBi.Text = "Mã thiết bị";
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoLuong.Location = new System.Drawing.Point(526, 444);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(207, 30);
			this.txtSoLuong.TabIndex = 25;
			// 
			// lblSoLuong
			// 
			this.lblSoLuong.AutoSize = true;
			this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSoLuong.Location = new System.Drawing.Point(407, 449);
			this.lblSoLuong.Name = "lblSoLuong";
			this.lblSoLuong.Size = new System.Drawing.Size(74, 20);
			this.lblSoLuong.TabIndex = 26;
			this.lblSoLuong.Text = "Số lượng";
			// 
			// cbbTinhTrang
			// 
			this.cbbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbTinhTrang.FormattingEnabled = true;
			this.cbbTinhTrang.Location = new System.Drawing.Point(181, 537);
			this.cbbTinhTrang.Name = "cbbTinhTrang";
			this.cbbTinhTrang.Size = new System.Drawing.Size(167, 33);
			this.cbbTinhTrang.TabIndex = 27;
			// 
			// lblTinhTrang
			// 
			this.lblTinhTrang.AutoSize = true;
			this.lblTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTinhTrang.Location = new System.Drawing.Point(77, 541);
			this.lblTinhTrang.Name = "lblTinhTrang";
			this.lblTinhTrang.Size = new System.Drawing.Size(84, 20);
			this.lblTinhTrang.TabIndex = 28;
			this.lblTinhTrang.Text = "Tình trạng";
			// 
			// lblGiaTri
			// 
			this.lblGiaTri.AutoSize = true;
			this.lblGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGiaTri.Location = new System.Drawing.Point(407, 543);
			this.lblGiaTri.Name = "lblGiaTri";
			this.lblGiaTri.Size = new System.Drawing.Size(55, 20);
			this.lblGiaTri.TabIndex = 30;
			this.lblGiaTri.Text = "Giá trị";
			// 
			// txtGiaTri
			// 
			this.txtGiaTri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGiaTri.Location = new System.Drawing.Point(526, 542);
			this.txtGiaTri.Name = "txtGiaTri";
			this.txtGiaTri.Size = new System.Drawing.Size(207, 30);
			this.txtGiaTri.TabIndex = 29;
			// 
			// lblTenThietBi
			// 
			this.lblTenThietBi.AutoSize = true;
			this.lblTenThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTenThietBi.Location = new System.Drawing.Point(407, 496);
			this.lblTenThietBi.Name = "lblTenThietBi";
			this.lblTenThietBi.Size = new System.Drawing.Size(92, 20);
			this.lblTenThietBi.TabIndex = 32;
			this.lblTenThietBi.Text = "Tên thiết bị";
			// 
			// txtTenThietBi
			// 
			this.txtTenThietBi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTenThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenThietBi.Location = new System.Drawing.Point(526, 493);
			this.txtTenThietBi.Name = "txtTenThietBi";
			this.txtTenThietBi.Size = new System.Drawing.Size(207, 30);
			this.txtTenThietBi.TabIndex = 31;
			// 
			// guna2GradientPanel2
			// 
			this.guna2GradientPanel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.guna2GradientPanel2.Controls.Add(this.gbtnTaiLai);
			this.guna2GradientPanel2.Controls.Add(this.lblTimKim);
			this.guna2GradientPanel2.Controls.Add(this.gbtnTimKiem);
			this.guna2GradientPanel2.Controls.Add(this.grbTimKiem);
			this.guna2GradientPanel2.Controls.Add(this.txtTimKiem);
			this.guna2GradientPanel2.Location = new System.Drawing.Point(793, 422);
			this.guna2GradientPanel2.Name = "guna2GradientPanel2";
			this.guna2GradientPanel2.Size = new System.Drawing.Size(476, 271);
			this.guna2GradientPanel2.TabIndex = 33;
			// 
			// txtMaPhong
			// 
			this.txtMaPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaPhong.Location = new System.Drawing.Point(181, 447);
			this.txtMaPhong.Name = "txtMaPhong";
			this.txtMaPhong.Size = new System.Drawing.Size(167, 30);
			this.txtMaPhong.TabIndex = 34;
			// 
			// txtMaThietBi
			// 
			this.txtMaThietBi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMaThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaThietBi.Location = new System.Drawing.Point(181, 496);
			this.txtMaThietBi.Name = "txtMaThietBi";
			this.txtMaThietBi.Size = new System.Drawing.Size(167, 30);
			this.txtMaThietBi.TabIndex = 35;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1295, 64);
			this.panel1.TabIndex = 36;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(501, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(285, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quản lí thiết bị ";
			// 
			// dgvQLTB
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.dgvQLTB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvQLTB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvQLTB.ColumnHeadersHeight = 4;
			this.dgvQLTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvQLTB.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvQLTB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvQLTB.Location = new System.Drawing.Point(29, 93);
			this.dgvQLTB.Name = "dgvQLTB";
			this.dgvQLTB.RowHeadersVisible = false;
			this.dgvQLTB.RowHeadersWidth = 51;
			this.dgvQLTB.RowTemplate.Height = 24;
			this.dgvQLTB.Size = new System.Drawing.Size(1261, 312);
			this.dgvQLTB.TabIndex = 37;
			this.dgvQLTB.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvQLTB.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvQLTB.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvQLTB.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvQLTB.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvQLTB.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvQLTB.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvQLTB.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvQLTB.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvQLTB.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvQLTB.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvQLTB.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvQLTB.ThemeStyle.HeaderStyle.Height = 4;
			this.dgvQLTB.ThemeStyle.ReadOnly = false;
			this.dgvQLTB.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvQLTB.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvQLTB.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvQLTB.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvQLTB.ThemeStyle.RowsStyle.Height = 24;
			this.dgvQLTB.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvQLTB.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// FormQuanLiThietBi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(1295, 705);
			this.Controls.Add(this.dgvQLTB);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtMaThietBi);
			this.Controls.Add(this.txtMaPhong);
			this.Controls.Add(this.guna2GradientPanel2);
			this.Controls.Add(this.lblTenThietBi);
			this.Controls.Add(this.txtTenThietBi);
			this.Controls.Add(this.lblGiaTri);
			this.Controls.Add(this.txtGiaTri);
			this.Controls.Add(this.lblTinhTrang);
			this.Controls.Add(this.cbbTinhTrang);
			this.Controls.Add(this.lblSoLuong);
			this.Controls.Add(this.txtSoLuong);
			this.Controls.Add(this.lblMaThietBi);
			this.Controls.Add(this.lblMaPhong);
			this.Controls.Add(this.gbtnSua);
			this.Controls.Add(this.gbtnXoa);
			this.Controls.Add(this.gbtnThem);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(1279, 652);
			this.Name = "FormQuanLiThietBi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormQuanLiThietBi";
			this.Load += new System.EventHandler(this.FormQuanLiThietBi_Load);
			this.grbTimKiem.ResumeLayout(false);
			this.grbTimKiem.PerformLayout();
			this.guna2GradientPanel2.ResumeLayout(false);
			this.guna2GradientPanel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvQLTB)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button gbtnThem;
        private Guna.UI2.WinForms.Guna2Button gbtnXoa;
        private Guna.UI2.WinForms.Guna2Button gbtnSua;
        private System.Windows.Forms.Label lblTimKim;
        private Guna.UI2.WinForms.Guna2Button gbtnTimKiem;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.RadioButton rbtnMaThietBi;
        private System.Windows.Forms.RadioButton rbtnMaPhong;
        private System.Windows.Forms.TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2Button gbtnTaiLai;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblMaThietBi;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblGiaTri;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Label lblTenThietBi;
        private System.Windows.Forms.TextBox txtTenThietBi;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtMaThietBi;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2DataGridView dgvQLTB;
	}
}