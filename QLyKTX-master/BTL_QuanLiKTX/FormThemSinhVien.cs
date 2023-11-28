
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
	public partial class FormThemSinhVien : Form
	{
		ProcessDataBase pd = new ProcessDataBase();
		public FormThemSinhVien()
		{
			InitializeComponent();
		}

		private void FormThemSinhVien_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'nhan.Que' table. You can move, or remove it, as needed.
			this.queTableAdapter.Fill(this.nhan.Que);
			// TODO: This line of code loads data into the 'nhan.Khoa' table. You can move, or remove it, as needed.
			this.khoaTableAdapter.Fill(this.nhan.Khoa);

			cmbGioiTinh.Items.Add("Nam");
			cmbGioiTinh.Items.Add("Nữ");
			cmbGioiTinh.Text = "";
			cmbMaQue.Text = "";
			cmbMaKhoa.Text = "";
			cmbMaLop.Text = "";
			cmbMaLop.Enabled = false;
		}

		private void cmbMaKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
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
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			string sql = "";
			pd.KetNoi();

			if (txtMasv.Text.Trim() == "") { errLoi.SetError(txtMasv, "Bạn không được để trống mã sinh viên!"); return; } else { errLoi.Clear(); }
			if (txtTensv.Text.Trim() == "") { errLoi.SetError(txtTensv, "Bạn không được để trống tên sinh viên!"); return; } else { errLoi.Clear(); }
			if (dtpNgaySinh.Value > DateTime.Now) { errLoi.SetError(dtpNgaySinh, "Ngày sinh không hợp lệ!"); return; } else { errLoi.Clear(); }
			if (cmbGioiTinh.SelectedIndex == -1) { errLoi.SetError(cmbGioiTinh, "Bạn phải chọn một lựa chọn!"); return; } else { errLoi.Clear(); }
			if (cmbMaQue.SelectedIndex == -1) { errLoi.SetError(cmbMaQue, "Bạn phải chọn một lựa chọn!"); return; } else { errLoi.Clear(); }
			if (cmbMaKhoa.SelectedIndex == -1) { errLoi.SetError(cmbMaKhoa, "Bạn phải chọn một lựa chọn!"); return; } else { errLoi.Clear(); }
			if (cmbMaLop.SelectedIndex == -1) { errLoi.SetError(cmbMaLop, "Bạn phải chọn một lựa chọn!"); return; } else { errLoi.Clear(); }

			if (txtMasv.Text.Trim() == "") { errLoi.SetError(txtMasv, "Bạn không được để trống mã sinh viên!"); return; }
			else
			{
				sql = "Select Masinhvien From SinhVien Where Masinhvien =N'" + txtMasv.Text + "'";
				pd.DocBang(sql);
				if (pd.DocBang(sql).Rows.Count > 0)
				{
					errLoi.SetError(txtMasv, "Mã sinh viên trùng trong cơ sở dữ liệu");
					return;
				}
				errLoi.Clear();
			}
			sql = "INSERT INTO SinhVien(Masinhvien,Tensinhvien,Ngaysinh,Gioitinh,Maque,Makhoa,Malop)VALUES (";
			sql += "N'" + txtMasv.Text.Trim()
				+ "',N'" + txtTensv.Text.Trim()
				+ "','" + dtpNgaySinh.Value.Date.ToString("MM/dd/yyyy")
				+ "',N'" + cmbGioiTinh.Text
				+ "',N'" + cmbMaQue.Text
				+ "',N'" + cmbMaKhoa.Text
				+ "',N'" + cmbMaLop.Text + "')";
			pd.CapNhat(sql);

			this.Close();
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
