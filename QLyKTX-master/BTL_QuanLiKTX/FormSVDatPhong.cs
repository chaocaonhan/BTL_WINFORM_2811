
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
	public partial class FormSVDatPhong : Form
	{
		ProcessDataBase pd = new ProcessDataBase();
		public FormSVDatPhong()
		{
			InitializeComponent();
		}

		private void FormSVDatPhong_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'nhan.Khoa' table. You can move, or remove it, as needed.
			this.khoaTableAdapter.Fill(this.nhan.Khoa);
			cmbMaSV.Text = "";
			cmbMaKhoa.Text = "";
			cmbMaKhoa.SelectedIndex = -1;
			cmbMaLop.Text = "";
			cmbMaLop.Enabled = false;
			cmbMaSV.Enabled = false;
			cmbMaPhong.Enabled = false;
			txtGioitinh.Enabled = false;
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
			txtGioitinh.Text = "";
			txtTienThue.Text = "";
			txtDango.Text = "";
			txtToiDa.Text = "";
			cmbMaSV.Enabled = false;
			cmbMaPhong.Enabled = false;
			cmbMaLop.SelectedIndex = -1;
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
			cmbMaSV.Enabled = true;
			cmbMaSV.Text = "";
			cmbMaSV.SelectedIndex = -1;
			txtGioitinh.Text = "";
			txtTienThue.Text = "";
			txtDango.Text = "";
			txtToiDa.Text = "";
			cmbMaPhong.Enabled = false;
		}

		private void cmbMaSV_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sql = "";
			pd.KetNoi();
			sql = @"Select SinhVien.Gioitinh
				    From SinhVien 
				    Where SinhVien.Masinhvien = N'" + cmbMaSV.Text + @"'";
			pd.CapNhat(sql);
			DataTable result = pd.DocBang(sql);
			if (result.Rows.Count > 0)
			{
				txtGioitinh.Text = result.Rows[0][0].ToString();
			}

			sql = @"Select SinhVien.Gioitinh, Phong.MaPhong
				    From SinhVien join Phong on SinhVien.Gioitinh = Phong.Loaiphong
				    Where SinhVien.Gioitinh = N'" + txtGioitinh.Text + @"'
						  AND Phong.Songuoidango < Phong.Songuoitoida
					Group by SinhVien.Gioitinh, Phong.MaPhong";
			pd.CapNhat(sql);
			DataTable table = pd.DocBang(sql);
			cmbMaPhong.DataSource = table;
			cmbMaPhong.DisplayMember = "MaPhong"; // Chọn cột dữ liệu để hiển thị trong ComboBox
			cmbMaPhong.ValueMember = "MaPhong"; // Chọn cột dữ liệu để làm giá trị thực của mỗi mục trong ComboBox
			cmbMaPhong.Enabled = true;
			cmbMaPhong.Text = "";
			cmbMaPhong.SelectedIndex = -1;
			txtTienThue.Text = "";
			txtDango.Text = "";
			txtToiDa.Text = "";
		}

		private void cmbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sql = "";
			pd.KetNoi();
			sql = @"Select Phong.Songuoidango
				    From Phong
				    Where Phong.MaPhong = N'" + cmbMaPhong.Text + @"'";
			pd.CapNhat(sql);
			DataTable result = pd.DocBang(sql);
			if (result.Rows.Count > 0)
			{
				txtDango.Text = result.Rows[0][0].ToString();
			}

			sql = @"Select Phong.Songuoitoida
				    From Phong
				    Where Phong.MaPhong = N'" + cmbMaPhong.Text + @"'";
			pd.CapNhat(sql);
			result = pd.DocBang(sql);
			if (result.Rows.Count > 0)
			{
				txtToiDa.Text = result.Rows[0][0].ToString();
			}

			sql = @"Select Phong.Tienthue
				    From Phong
				    Where Phong.MaPhong = N'" + cmbMaPhong.Text + @"'";
			pd.CapNhat(sql);
			result = pd.DocBang(sql);
			if (result.Rows.Count > 0)
			{
				txtTienThue.Text = result.Rows[0][0].ToString();
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn đăng kí không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				string sql = "";
				pd.KetNoi();

				if (cmbMaKhoa.SelectedIndex == -1) { errLoi.SetError(cmbMaKhoa, "Bạn phải chọn một lựa chọn!"); return; } else { errLoi.Clear(); }
				if (cmbMaLop.SelectedIndex == -1) { errLoi.SetError(cmbMaLop, "Bạn phải chọn một lựa chọn!"); return; } else { errLoi.Clear(); }
				if (cmbMaSV.SelectedIndex == -1) { errLoi.SetError(cmbMaSV, "Bạn phải chọn một lựa chọn!"); return; } else { errLoi.Clear(); }
				if (cmbMaPhong.SelectedIndex == -1) { errLoi.SetError(cmbMaPhong, "Bạn phải chọn một lựa chọn!"); return; } else { errLoi.Clear(); }
				if (dtpNgayBĐ.Value > dtpNgayKT.Value) { errLoi.SetError(dtpNgayBĐ, "Ngày bắt đầu phải trước ngày kết thúc!"); return; } else { errLoi.Clear(); }
				if (txtMathue.Text.Trim() == "") { errLoi.SetError(txtTienThue, "Bạn không được để trống mã số thuê!"); return; }
				else
				{
					sql = "Select Masothue From Thuephong Where Masothue =N'" + txtMathue.Text + "'";
					pd.DocBang(sql);
					if (pd.DocBang(sql).Rows.Count > 0)
					{
						errLoi.SetError(txtMathue, "Mã số thuê trùng trong cơ sở dữ liệu");
						return;
					}
					errLoi.Clear();
				}

				sql = "INSERT INTO Thuephong(Masothue,Masv,Maphong,NgayBdau,Ngaykt,Ghichu)VALUES (";
				sql += "N'" + txtMathue.Text.Trim()
					+ "',N'" + cmbMaSV.Text
					+ "',N'" + cmbMaPhong.Text
					+ "',N'" + dtpNgayBĐ.Value.Date.ToString("MM/dd/yyyy")
					+ "',N'" + dtpNgayKT.Value.Date.ToString("MM/dd/yyyy")
					+ "',N'" + txtGhiChu.Text.Trim() + "')";
				pd.CapNhat(sql);

				sql = @"Update Phong set Songuoidango = Songuoidango + 1 
					Where Phong.MaPhong = N'" + cmbMaPhong.Text + @"'";
				pd.CapNhat(sql);

				this.Close();
			}
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn hủy không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Close();
			}
		}
	}
}
