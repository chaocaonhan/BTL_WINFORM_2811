namespace BTL_QuanLiKTX
{
	partial class FormQuanLiPhong
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tấtCảCácPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnThemPhong = new System.Windows.Forms.ToolStripMenuItem();
			this.phongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.nhan = new BTL_QuanLiKTX.Nhan();
			this.phongTableAdapter = new BTL_QuanLiKTX.QLKyTucXaDataSetTableAdapters.PhongTableAdapter();
			this.phongTableAdapter1 = new BTL_QuanLiKTX.NhanTableAdapters.PhongTableAdapter();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbTieuDe = new System.Windows.Forms.Label();
			this.loadFunctionPhong = new Guna.UI2.WinForms.Guna2Panel();
			this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.phongBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nhan)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tấtCảCácPhòngToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.btnThemPhong});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1288, 46);
			this.menuStrip1.TabIndex = 11;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tấtCảCácPhòngToolStripMenuItem
			// 
			this.tấtCảCácPhòngToolStripMenuItem.Name = "tấtCảCácPhòngToolStripMenuItem";
			this.tấtCảCácPhòngToolStripMenuItem.Size = new System.Drawing.Size(240, 42);
			this.tấtCảCácPhòngToolStripMenuItem.Text = "Tất cả các phòng";
			this.tấtCảCácPhòngToolStripMenuItem.Click += new System.EventHandler(this.tấtCảCácPhòngToolStripMenuItem_Click);
			// 
			// tìmKiếmToolStripMenuItem
			// 
			this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
			this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(153, 42);
			this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm ";
			this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
			// 
			// btnThemPhong
			// 
			this.btnThemPhong.Name = "btnThemPhong";
			this.btnThemPhong.Size = new System.Drawing.Size(189, 42);
			this.btnThemPhong.Text = "Thêm phòng";
			this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
			// 
			// phongBindingSource1
			// 
			this.phongBindingSource1.DataMember = "Phong";
			this.phongBindingSource1.DataSource = this.nhan;
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
			// phongTableAdapter1
			// 
			this.phongTableAdapter1.ClearBeforeFill = true;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.lbTieuDe);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 46);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.MinimumSize = new System.Drawing.Size(0, 66);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1288, 66);
			this.panel1.TabIndex = 28;
			// 
			// lbTieuDe
			// 
			this.lbTieuDe.AutoSize = true;
			this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTieuDe.ForeColor = System.Drawing.Color.White;
			this.lbTieuDe.Location = new System.Drawing.Point(420, 17);
			this.lbTieuDe.Name = "lbTieuDe";
			this.lbTieuDe.Size = new System.Drawing.Size(333, 46);
			this.lbTieuDe.TabIndex = 0;
			this.lbTieuDe.Text = "Danh sách phòng";
			// 
			// loadFunctionPhong
			// 
			this.loadFunctionPhong.Dock = System.Windows.Forms.DockStyle.Fill;
			this.loadFunctionPhong.Location = new System.Drawing.Point(0, 112);
			this.loadFunctionPhong.Name = "loadFunctionPhong";
			this.loadFunctionPhong.Size = new System.Drawing.Size(1288, 656);
			this.loadFunctionPhong.TabIndex = 29;
			this.loadFunctionPhong.Paint += new System.Windows.Forms.PaintEventHandler(this.loadFunctionPhong_Paint);
			// 
			// phongBindingSource
			// 
			this.phongBindingSource.DataMember = "Phong";
			// 
			// FormQuanLiPhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(1288, 768);
			this.Controls.Add(this.loadFunctionPhong);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormQuanLiPhong";
			this.Text = "FormQuanLiPhong";
			this.Load += new System.EventHandler(this.FormQuanLiPhong_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.phongBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nhan)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tấtCảCácPhòngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem btnThemPhong;
		private QLKyTucXaDataSetTableAdapters.PhongTableAdapter phongTableAdapter;
		private System.Windows.Forms.BindingSource phongBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn maPhongDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenphongDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn manhaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn loaiphongDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn songuoitoidaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn songuoidangoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tienthueDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ghichuDataGridViewTextBoxColumn;
		private Nhan nhan;
		private System.Windows.Forms.BindingSource phongBindingSource1;
		private NhanTableAdapters.PhongTableAdapter phongTableAdapter1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbTieuDe;
		private Guna.UI2.WinForms.Guna2Panel loadFunctionPhong;
	}
}