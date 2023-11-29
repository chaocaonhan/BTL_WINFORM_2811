namespace BTL_QuanLiKTX
{
	partial class FormMainQLSV
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tìmKiếmSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sinhViênĐặtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sinhViênTrảPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xuấtExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbChucNangHienTai = new System.Windows.Forms.Label();
			this.loadChucNangSV = new Guna.UI2.WinForms.Guna2Panel();
			this.loadFunctionSV = new Guna.UI2.WinForms.Guna2Panel();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1288, 30);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// chứcNăngToolStripMenuItem
			// 
			this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmSinhViênToolStripMenuItem,
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.sinhViênĐặtPhòngToolStripMenuItem,
            this.sinhViênTrảPhòngToolStripMenuItem,
            this.xuấtExcelToolStripMenuItem});
			this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
			this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
			this.chứcNăngToolStripMenuItem.Text = "Chức năng";
			// 
			// tìmKiếmSinhViênToolStripMenuItem
			// 
			this.tìmKiếmSinhViênToolStripMenuItem.Name = "tìmKiếmSinhViênToolStripMenuItem";
			this.tìmKiếmSinhViênToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
			this.tìmKiếmSinhViênToolStripMenuItem.Text = "Tìm kiếm sinh viên";
			this.tìmKiếmSinhViênToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmSinhViênToolStripMenuItem_Click);
			// 
			// thêmToolStripMenuItem
			// 
			this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
			this.thêmToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
			this.thêmToolStripMenuItem.Text = "Thêm Sinh Viên";
			this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
			// 
			// sửaToolStripMenuItem
			// 
			this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
			this.sửaToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
			this.sửaToolStripMenuItem.Text = "Sửa Thông Tin Sinh Viên";
			this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
			// 
			// sinhViênĐặtPhòngToolStripMenuItem
			// 
			this.sinhViênĐặtPhòngToolStripMenuItem.Name = "sinhViênĐặtPhòngToolStripMenuItem";
			this.sinhViênĐặtPhòngToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
			this.sinhViênĐặtPhòngToolStripMenuItem.Text = "Sinh Viên Đặt Phòng";
			this.sinhViênĐặtPhòngToolStripMenuItem.Click += new System.EventHandler(this.sinhViênĐặtPhòngToolStripMenuItem_Click);
			// 
			// sinhViênTrảPhòngToolStripMenuItem
			// 
			this.sinhViênTrảPhòngToolStripMenuItem.Name = "sinhViênTrảPhòngToolStripMenuItem";
			this.sinhViênTrảPhòngToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
			this.sinhViênTrảPhòngToolStripMenuItem.Text = "Sinh Viên Trả Phòng";
			this.sinhViênTrảPhòngToolStripMenuItem.Click += new System.EventHandler(this.sinhViênTrảPhòngToolStripMenuItem_Click);
			// 
			// xuấtExcelToolStripMenuItem
			// 
			this.xuấtExcelToolStripMenuItem.Name = "xuấtExcelToolStripMenuItem";
			this.xuấtExcelToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
			this.xuấtExcelToolStripMenuItem.Text = "Xuất Excel DS Sinh Viên";
			this.xuấtExcelToolStripMenuItem.Click += new System.EventHandler(this.xuấtExcelToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.lbChucNangHienTai);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 30);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1288, 61);
			this.panel1.TabIndex = 10;
			// 
			// lbChucNangHienTai
			// 
			this.lbChucNangHienTai.AutoSize = true;
			this.lbChucNangHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbChucNangHienTai.ForeColor = System.Drawing.Color.White;
			this.lbChucNangHienTai.Location = new System.Drawing.Point(409, 15);
			this.lbChucNangHienTai.Name = "lbChucNangHienTai";
			this.lbChucNangHienTai.Size = new System.Drawing.Size(313, 46);
			this.lbChucNangHienTai.TabIndex = 0;
			this.lbChucNangHienTai.Text = "Quản lí sinh viên";
			// 
			// loadChucNangSV
			// 
			this.loadChucNangSV.Location = new System.Drawing.Point(0, 0);
			this.loadChucNangSV.Name = "loadChucNangSV";
			this.loadChucNangSV.Size = new System.Drawing.Size(200, 100);
			this.loadChucNangSV.TabIndex = 0;
			// 
			// loadFunctionSV
			// 
			this.loadFunctionSV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.loadFunctionSV.Location = new System.Drawing.Point(0, 91);
			this.loadFunctionSV.Name = "loadFunctionSV";
			this.loadFunctionSV.Size = new System.Drawing.Size(1288, 659);
			this.loadFunctionSV.TabIndex = 11;
			this.loadFunctionSV.Paint += new System.Windows.Forms.PaintEventHandler(this.loadFunctionSV_Paint);
			// 
			// FormMainQLSV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1288, 750);
			this.Controls.Add(this.loadFunctionSV);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormMainQLSV";
			this.Text = "FormMainQLSV";
			this.Load += new System.EventHandler(this.FormMainQLSV_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tìmKiếmSinhViênToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xuấtExcelToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbChucNangHienTai;
		private System.Windows.Forms.ToolStripMenuItem sinhViênĐặtPhòngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sinhViênTrảPhòngToolStripMenuItem;
		private Guna.UI2.WinForms.Guna2Panel loadChucNangSV;
		private Guna.UI2.WinForms.Guna2Panel loadFunctionSV;
	}
}