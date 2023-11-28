
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
	public partial class FormEditSV : Form
	{
		ProcessDataBase pd = new ProcessDataBase();
		public FormEditSV()
		{
			InitializeComponent();
		}

		private void FormEditSV_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'nhan.Khoa' table. You can move, or remove it, as needed.
			this.khoaTableAdapter.Fill(this.nhan.Khoa);
			// TODO: This line of code loads data into the 'nhan.Que' table. You can move, or remove it, as needed.
			this.queTableAdapter.Fill(this.nhan.Que);
			// TODO: This line of code loads data into the 'nhan.SinhVien' table. You can move, or remove it, as needed.
			this.sinhVienTableAdapter.Fill(this.nhan.SinhVien);
			// TODO: This line of code loads data into the 'nhan.Khoa' table. You can move, or remove it, as needed.
			this.khoaTableAdapter.Fill(this.nhan.Khoa);
            // TODO: This line of code loads data into the 'nhan.Que' table. You can move, or remove it, as needed.
            this.queTableAdapter.Fill(this.nhan.Que);
            // TODO: This line of code loads data into the 'nhan.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.nhan.SinhVien);
			cmbGioiTinh.Items.Add("Nữ");
			cmbGioiTinh.Text = "";
			cmbMaQue.Text = "";
			cmbMaKhoa.Text = "";
			cmbMaLop.Text = "";
			btnSua.Enabled = false;
		}

		private void dgvDSSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			btnSua.Enabled = true;
			try
			{
				txtMasv.Text = dgvDSSinhVien[0, e.RowIndex].Value.ToString();
				txtTensv.Text = dgvDSSinhVien[1, e.RowIndex].Value.ToString();
				dtpNgaySinh.Value = (DateTime)dgvDSSinhVien[2, e.RowIndex].Value;
				cmbGioiTinh.Text = dgvDSSinhVien[3, e.RowIndex].Value.ToString();
				cmbMaQue.Text = dgvDSSinhVien[4, e.RowIndex].Value.ToString();
				cmbMaKhoa.Text = dgvDSSinhVien[5, e.RowIndex].Value.ToString();
				cmbMaLop.Text = dgvDSSinhVien[6, e.RowIndex].Value.ToString();
			}
			catch (Exception ex)
			{
			}
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
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn sửa thông tin không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				string sql = "";
				sql = "Update SinhVien SET ";
				sql += "Tensinhvien = N'" + txtTensv.Text.Trim() + "',";
				sql += "Ngaysinh = '" + dtpNgaySinh.Value.Date.ToString("MM/dd/yyyy") + "',";
				sql += "Gioitinh = N'" + cmbGioiTinh.Text + "',";
				sql += "Maque = N'" + cmbMaQue.Text + "',";
				sql += "Makhoa = '" + cmbMaKhoa.Text + "',";
				sql += "Malop = N'" + cmbMaLop.Text + "' ";
				sql += "Where Masinhvien = N'" + txtMasv.Text.Trim() + "'";
				pd.CapNhat(sql);
				dgvDSSinhVien.DataSource = pd.DocBang("Select * from SinhVien");
			}
			txtMasv.Text = "";
			txtTensv.Text = "";
			dtpNgaySinh.Value = DateTime.Now;
			cmbGioiTinh.Text = "";
			cmbMaQue.Text = "";
			cmbMaKhoa.Text = "";
			cmbMaLop.Text = "";
			cmbMaLop.Enabled = false;
			btnSua.Enabled = false;
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn hủy không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
