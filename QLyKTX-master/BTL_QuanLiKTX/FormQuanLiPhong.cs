
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLiKTX
{
	public partial class FormQuanLiPhong : Form
	{
		ProcessDataBase pd = new ProcessDataBase();
		SqlCommand cmd;
		string SqlConnection;
		public FormQuanLiPhong()
		{
			InitializeComponent();
		}

		private void FormQuanLiPhong_Load(object sender, EventArgs e)
		{
			loadFunction(new FormDSP());
		}


		public void loadFunction(object Form)
		{
			if (this.loadFunctionPhong.Controls.Count > 0)
				this.loadFunctionPhong.Controls.RemoveAt(0);

			Form f = Form as Form;
			f.TopLevel = false;
			f.Dock = DockStyle.Fill;
			this.loadFunctionPhong.Controls.Add(f);
			this.loadFunctionPhong.Tag = f;
			f.Show();
		}

		/*private void tấtCảCácPhòngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			lbTieuDe.Text = "Danh sách phòng ";
			(dataGridViewDanhSachPhong.DataSource as DataTable).DefaultView.RowFilter = null;
		}

		private void phòngTrốngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			lbTieuDe.Text = "Danh sách phòng còn trống";
			(dataGridViewDanhSachPhong.DataSource as DataTable).DefaultView.RowFilter = "songuoidango < songuoitoida";
		}

		private void tìmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string sql = " select Phong.* from Phong JOIN Thuephong on Phong.MaPhong=Thuephong.Maphong Join SinhVien on Thuephong.Masv=SinhVien.Masinhvien where SinhVien.Tensinhvien like N'%" + txtTenSVCanTim.Text + @"%'";
			dataGridViewDanhSachPhong.DataSource = pd.DocBang(sql);
		}*/

		

		/*private void btnXoaPhong_Click(object sender, EventArgs e)
		{
			string sql = "";
			sql = "delete from Phong where MaPhong = '" + txtMaPhong.Text + "'  ";
			pd.CapNhat(sql);
			dataGridViewDanhSachPhong.DataSource = pd.DocBang("select * from Phong");
		}*/

		/*private void dataGridViewDanhSachPhong_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dataGridViewDanhSachPhong.ReadOnly = true;
			btnSuaPhong.Enabled = true;
			btnXoaPhong.Enabled = true;
			btnThemPhong.Enabled = false;
			btnHuy.Enabled = true;

			txtMaPhong.Text = dataGridViewDanhSachPhong[0, e.RowIndex].Value.ToString();
			txtTenPhong.Text = dataGridViewDanhSachPhong[1, e.RowIndex].Value.ToString();
			cmbMaNha.Text = dataGridViewDanhSachPhong[2, e.RowIndex].Value.ToString();
			cmbLoaiPhong.Text = dataGridViewDanhSachPhong[3, e.RowIndex].Value.ToString();
			txtSoNguoiDangO.Text = dataGridViewDanhSachPhong[5, e.RowIndex].Value.ToString();
			txtSoNguoiToiDa.Text = dataGridViewDanhSachPhong[4, e.RowIndex].Value.ToString();
			txtTienThue.Text = dataGridViewDanhSachPhong[6, e.RowIndex].Value.ToString();
			txtGhiChu.Text = dataGridViewDanhSachPhong[7, e.RowIndex].Value.ToString();
			

		}*/

		/*private void btnLuu_Click(object sender, EventArgs e)
		{
			string sql = "Update Phong SET ";
			sql += "Tenphong = N'" + txtTenPhong.Text.Trim() + "',";
			sql += " Manha= '" + cmbMaNha.Text.Trim() + "',";
			sql += "Loaiphong = N'" + cmbLoaiPhong.Text.Trim() + "',";
			sql += "Songuoitoida = N'" + txtSoNguoiToiDa.Text.Trim() + "',";
			sql += "Songuoidango = '" + txtSoNguoiDangO.Text.Trim() + "',";
			sql += "Tienthue = '" + txtTienThue.Text.Trim() + "',";
			sql += "GhiChu = N'" + txtGhiChu.Text.Trim() + "' ";
			sql += "Where MaPhong = N'" + txtMaPhong.Text.Trim() + "'";

			pd.CapNhat(sql);
			dataGridViewDanhSachPhong.DataSource = pd.DocBang("Select * from Phong");
		}*/

		/*private void btnSuaPhong_Click(object sender, EventArgs e)
		{
			btnLuu.Visible = true;
			btnHuy.Visible = true;
			btnLuu.Enabled = true;
			btnHuy.Enabled = true;
		}*/

		private void btnThemPhong_Click(object sender, EventArgs e)
		{
			lbTieuDe.Text = "Thêm phòng mới";
			loadFunction(new FormThemPhong());
		}

		private void loadFunctionPhong_Paint(object sender, PaintEventArgs e)
		{
				if (this.loadFunctionPhong.Controls.Count == 0)
			{
				loadFunction(new FormDSP());
			}

		}

		private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			lbTieuDe.Text = "Tìm kiếm phòng";
			loadFunction(new TimKiemPhong());
		}

		private void tấtCảCácPhòngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadFunction(new FormDSP());
		}
	}
}
