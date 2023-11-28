
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
	public partial class FormSVTraPhong : Form
	{
		ProcessDataBase pd = new ProcessDataBase();
		public FormSVTraPhong()
		{
			InitializeComponent();
		}

		private void FormSVTraPhong_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'nhan.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.nhan.Khoa);
			cmbMaKhoa.Text = "";
			cmbMaKhoa.SelectedIndex = -1;
			dtpNgayTra.Enabled = false;
			cmbMaLop.Enabled = false;
		}

		private void cmbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sql = "";
			pd.KetNoi();
			sql = @"Select Khoa.Makhoa, Lop.Malop
				    From Khoa inner join Lop on Khoa.Makhoa = Lop.Makhoa
				    Where (Khoa.Makhoa = N'" + cmbMaKhoa.Text + @"')";
			pd.CapNhat(sql);
			DataTable table = pd.DocBang(sql);
			cmbMaLop.DataSource = table;
			cmbMaLop.DisplayMember = "Malop"; // Chọn cột dữ liệu để hiển thị trong ComboBox
			cmbMaLop.ValueMember = "Malop"; // Chọn cột dữ liệu để làm giá trị thực của mỗi mục trong ComboBox
			cmbMaLop.Enabled = true;
			cmbMaLop.Text = "";
			txtMathue.Text = "";
			txtTienThue.Text = "";
			txtDango.Text = "";
			txtToiDa.Text = "";
			txtMaPhong.Text = "";
			cmbMaLop.SelectedIndex = -1;
			cmbMaSV.SelectedIndex = -1;
			cmbMaSV.Enabled = false;
			dtpNgayTra.Enabled = false;
			dtpNgayBĐ.Value = DateTime.Now;
			dtpNgayKT.Value = DateTime.Now;
		}

		private void cmbMaLop_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sql = "";
			pd.KetNoi();
			sql = @"Select Lop.Malop, SinhVien.Masinhvien
				    From SinhVien inner join Lop on SinhVien.Malop = Lop.Malop
				    Where (Lop.Malop = N'" + cmbMaLop.Text + @"')";
			pd.CapNhat(sql);
			DataTable table = pd.DocBang(sql);
			cmbMaSV.DataSource = table;
			cmbMaSV.DisplayMember = "Masinhvien"; // Chọn cột dữ liệu để hiển thị trong ComboBox
			cmbMaSV.ValueMember = "Masinhvien"; // Chọn cột dữ liệu để làm giá trị thực của mỗi mục trong ComboBox			
			dtpNgayTra.Enabled = false;
			cmbMaSV.Text = "";
			txtMathue.Text = "";
			txtMaPhong.Text = "";
			txtTienThue.Text = "";
			txtDango.Text = "";
			txtToiDa.Text = "";
			cmbMaSV.SelectedIndex = -1;
			cmbMaSV.Enabled = true;
			dtpNgayBĐ.Value = DateTime.Now;
			dtpNgayKT.Value = DateTime.Now;
		}

		private void cmbMaSV_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sql = "";
			pd.KetNoi();
			sql = @"Select Thuephong.Masothue
				    From Thuephong
				    Where NOT EXISTS (
										SELECT 1
										FROM Traphong
										WHERE Traphong.Masothue = ThuePhong.Masothue
									) and Thuephong.Masv = N'" + cmbMaSV.Text + @"'";
			DataTable result = pd.DocBang(sql);
			if (result.Rows.Count > 0)
			{
				txtMathue.Text = result.Rows[0][0].ToString();

				sql = @"Select Thuephong.Maphong
				    From Thuephong 
				    Where Thuephong.Masothue = N'" + txtMathue.Text + @"'";
				result = pd.DocBang(sql);
				if (result.Rows.Count > 0)
				{
					txtMaPhong.Text = result.Rows[0][0].ToString();
				}

				sql = @"Select Thuephong.NgayBdau
				    From Thuephong 
				    Where Thuephong.Masothue = N'" + txtMathue.Text + @"'";
				result = pd.DocBang(sql);
				if (result.Rows.Count > 0)
				{
					dtpNgayBĐ.Value = (DateTime)result.Rows[0][0];
				}

				sql = @"Select Thuephong.Ngaykt
				    From Thuephong 
				    Where Thuephong.Masothue = N'" + txtMathue.Text + @"'";
				result = pd.DocBang(sql);
				if (result.Rows.Count > 0)
				{
					dtpNgayKT.Value = (DateTime)result.Rows[0][0];
				}

				sql = @"Select Phong.Songuoidango
				    From Phong
				    Where Phong.MaPhong = N'" + txtMaPhong.Text + @"'";
				pd.CapNhat(sql);
				result = pd.DocBang(sql);
				if (result.Rows.Count > 0)
				{
					txtDango.Text = result.Rows[0][0].ToString();
				}

				sql = @"Select Phong.Songuoitoida
				    From Phong
				    Where Phong.MaPhong = N'" + txtMaPhong.Text + @"'";
				pd.CapNhat(sql);
				result = pd.DocBang(sql);
				if (result.Rows.Count > 0)
				{
					txtToiDa.Text = result.Rows[0][0].ToString();
				}

				sql = @"Select Phong.Tienthue
				    From Phong
				    Where Phong.MaPhong = N'" + txtMaPhong.Text + @"'";
				pd.CapNhat(sql);
				result = pd.DocBang(sql);
				if (result.Rows.Count > 0)
				{
					txtTienThue.Text = result.Rows[0][0].ToString();
				}
				dtpNgayTra.Enabled = true;
			}
		}

		private void dtpNgayTra_ValueChanged(object sender, EventArgs e)
		{
			string sql = "";
			pd.KetNoi();

			if (dtpNgayTra.Value < dtpNgayKT.Value)
			{
				txtTienViPham.Text = "0";
			}
			else
			{
				int SoNgayViPham = (int)(dtpNgayTra.Value - dtpNgayKT.Value).TotalDays;
				int TienPhat = (int)SoNgayViPham * 100000;
				txtTienViPham.Text = TienPhat.ToString();
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn trả phòng không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				string sql = "";
				pd.KetNoi();

				if (cmbMaKhoa.SelectedIndex == -1) { errLoi.SetError(cmbMaKhoa, "Bạn phải chọn một lựa chọn!"); return; } else { errLoi.Clear(); }
				if (cmbMaLop.SelectedIndex == -1) { errLoi.SetError(cmbMaLop, "Bạn phải chọn một lựa chọn!"); return; } else { errLoi.Clear(); }
				if (cmbMaSV.SelectedIndex == -1) { errLoi.SetError(cmbMaSV, "Bạn phải chọn một lựa chọn!"); return; } else { errLoi.Clear(); }

				sql = "Select Masothue From Traphong Where Masothue = N'" + txtMathue.Text + "'";
				pd.DocBang(sql);
				if (pd.DocBang(sql).Rows.Count > 0)
				{
					errLoi.SetError(txtMathue, "Mã số thuê trùng trong cơ sở dữ liệu");
					return;
				}
				errLoi.Clear();
				sql = "INSERT INTO Traphong(Masothue,Ngaytra,Tienvipham)VALUES (";
				sql += "N'" + txtMathue.Text.Trim()
					+ "',N'" + dtpNgayTra.Value.Date.ToString("MM/dd/yyyy")
					+ "',N'" + txtTienViPham.Text.Trim() + "')";
				pd.CapNhat(sql);

				sql = @"Update Phong set Songuoidango = Songuoidango - 1 
					Where Phong.MaPhong = N'" + txtMaPhong.Text + @"'";
				pd.CapNhat(sql);

				this.Hide();
				this.Close();
			}
			
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn hủy không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Hide();
				this.Close();
			}
		}
	}
}
