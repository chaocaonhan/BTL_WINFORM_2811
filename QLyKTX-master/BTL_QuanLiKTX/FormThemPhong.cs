
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLiKTX
{
	public partial class FormThemPhong : Form
	{
		ProcessDataBase pd = new ProcessDataBase();
		string SqlConnection;
		public FormThemPhong()
		{
			InitializeComponent();
		}


		private void FormThemPhong_Load(object sender, EventArgs e)
		{
			cmbLoaiPhong.Items.Add("Nam");
			cmbLoaiPhong.Items.Add("Nữ");
			cmbMaNha.DataSource = pd.DocBang("select Manha from Nha");
			cmbMaNha.ValueMember = "Manha";
			cmbMaNha.SelectedIndex = -1;
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string sql = "";
			pd.KetNoi();
			sql = "Insert into Phong(MaPhong,Tenphong,Manha,Loaiphong,Songuoitoida,Songuoidango,Tienthue,Ghichu) VALUES (";
			sql += "N'" + txtMaPhong.Text.Trim()
					+ "',N'" + txtTenPhong.Text.Trim()
					+ "',N'" + cmbMaNha.Text.Trim()
					+ "',N'" + cmbLoaiPhong.Text.Trim()
					+ "',N'" + txtSoNguoiToiDa.Text.Trim()
					+ "',N'" + txtSoNguoiDangO.Text.Trim()
					+ "',N'" + txtTienThue.Text.Trim()
					+ "',N'" + txtGhiChu.Text.Trim() + "')";
			pd.CapNhat(sql);

			this.Close();

		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
