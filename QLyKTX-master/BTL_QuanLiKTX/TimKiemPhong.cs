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
	public partial class TimKiemPhong : Form
	{
		ProcessDataBase pd = new ProcessDataBase();
		public TimKiemPhong()
		{
			InitializeComponent();
		}

		private void TimKiemPhong_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'nhan.Phong' table. You can move, or remove it, as needed.
			this.phongTableAdapter.Fill(this.nhan.Phong);
			dataGridViewDanhSachPhong.DataSource = pd.DocBang("select * from phong");
			cmbGioiTinh.Items.Add("Chọn giới tính");
			cmbGioiTinh.Items.Add("Nam");
			cmbGioiTinh.Items.Add("Nữ");
			cmbGioiTinh.SelectedIndex = 0;
			txtTenSVCanTim.Text = "Nhập tên cần tìm";
			txtTenSVCanTim.ForeColor = System.Drawing.SystemColors.GrayText; // Màu chữ khi không focus
		}


		private void txtTenSVCanTim_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtTenSVCanTim.Text))
			{
				txtTenSVCanTim.Text = "Nhập tên cần tìm";
				txtTenSVCanTim.ForeColor = System.Drawing.SystemColors.GrayText; // Màu chữ khi không focus
			}
		}

		private void txtTenSVCanTim_Click(object sender, EventArgs e)
		{
			if (txtTenSVCanTim.Text == "Nhập tên cần tìm")
			{
				txtTenSVCanTim.Text = "";
				txtTenSVCanTim.ForeColor = System.Drawing.SystemColors.WindowText;
			}
		}
		/*private void btnTim_Click(object sender, EventArgs e)
		{
			if (cmbGioiTinh.SelectedIndex != 0 && !checkBoxPhongTrong.Checked)
			{
				string dk = "Loaiphong = '"; // Bắt đầu điều kiện lọc
				dk += cmbGioiTinh.SelectedItem.ToString(); // Lấy giá trị đã chọn từ ComboBox
				(dataGridViewDanhSachPhong.DataSource as DataTable).DefaultView.RowFilter = dk;
			}
		}*/
		private void btnTim_Click(object sender, EventArgs e)
		{
			if (cmbGioiTinh.SelectedIndex != 0 && !checkBoxPhongTrong.Checked)
			{
				string dk = "Loaiphong = '";
				dk += cmbGioiTinh.SelectedItem.ToString().Replace("'", "''"); // Thay thế ký tự nháy đơn

				dk += "'";

				(dataGridViewDanhSachPhong.DataSource as DataTable).DefaultView.RowFilter = dk;
			}
			if (cmbGioiTinh.SelectedIndex == 0 && checkBoxPhongTrong.Checked)
			{
				string dk = "songuoidango < songuoitoida";

				(dataGridViewDanhSachPhong.DataSource as DataTable).DefaultView.RowFilter = dk;
			}

			if (cmbGioiTinh.SelectedIndex != 0 && checkBoxPhongTrong.Checked)
			{
				string dk = "Loaiphong = '";
				dk += cmbGioiTinh.SelectedItem.ToString().Replace("'", "''");
				dk += "' AND songuoidango < songuoitoida";

				(dataGridViewDanhSachPhong.DataSource as DataTable).DefaultView.RowFilter = dk;
			}
			if (txtTenSVCanTim.Text.Length > 0)
			{
				string sql = " select Phong.* from Phong JOIN Thuephong on Phong.MaPhong=Thuephong.Maphong Join SinhVien on Thuephong.Masv=SinhVien.Masinhvien where SinhVien.Tensinhvien like N'%" + txtTenSVCanTim.Text + @"%'";
				dataGridViewDanhSachPhong.DataSource = pd.DocBang(sql);
			}
		}

	}
}