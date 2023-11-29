
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BTL_QuanLiKTX
{
	public partial class FormMainQLSV : Form
	{
		ProcessDataBase pd = new ProcessDataBase();
		FormDSSV dssv = new FormDSSV();
		public FormMainQLSV()
		{
			InitializeComponent();
		}	

		private void FormMainQLSV_Load(object sender, EventArgs e)
		{
			loadFunction(new FormDSSV());
		}
		public void loadFunction(object Form)
		{
			if (this.loadFunctionSV.Controls.Count > 0)
				this.loadFunctionSV.Controls.RemoveAt(0);

			Form f = Form as Form;
			f.TopLevel = false;
			f.Dock = DockStyle.Fill;
			this.loadFunctionSV.Controls.Add(f);
			this.loadFunctionSV.Tag = f;
			f.Show();
		}
		private void tìmKiếmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadFunction(new FormTimKiem());
			lbChucNangHienTai.Text = "Tìm kiếm sinh viên";
		}

		private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadFunction(new FormThemSinhVien());
			lbChucNangHienTai.Text = "Thêm sinh viên";
		}
		private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadFunction(new FormEditSV());
			lbChucNangHienTai.Text = "Sửa thông tin sinh viên";
		}
		private void sinhViênĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadFunction(new FormSVDatPhong());
			lbChucNangHienTai.Text = "Sinh viên đặt phòng ";
		}
		private void sinhViênTrảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadFunction(new FormSVTraPhong());
			lbChucNangHienTai.Text = "Sinh viên trả phòng";
		}
		private void xuấtExcelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn xuất file excel danh sách sinh viên không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Excel.Application exApp = new Excel.Application();
				Excel.Workbook exBook =
				exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
				Excel.Worksheet exSheet =
					(Excel.Worksheet)exBook.Worksheets[1];
				Excel.Range tenvung = (Excel.Range)exSheet.Cells[1, 1];
				tenvung.Font.Name = "Arial"; tenvung.Font.Size = 16;
				tenvung.Font.Color = Color.Blue;
				tenvung.Value = "Danh sách sinh viên";
				exSheet.get_Range("A1: H1").Merge(true);
				exSheet.get_Range("A2:H2").Font.Size = 15;
				exSheet.get_Range("A2:H2").ColumnWidth = 16;
				exSheet.get_Range("D2").ColumnWidth = 20;
				exSheet.get_Range("A2:H2").Font.Bold = true;
				exSheet.get_Range("A:H").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				exSheet.get_Range("A2").Value = "STT";
				exSheet.get_Range("B2").Value = "Mã sinh viên";
				exSheet.get_Range("C2").Value = "Tên sinh viên";
				exSheet.get_Range("D2").Value = "Ngày sinh";
				exSheet.get_Range("E2").Value = "Giới tính";
				exSheet.get_Range("F2").Value = "Mã quê";
				exSheet.get_Range("G2").Value = "Mã khoa";
				exSheet.get_Range("H2").Value = "Mã lớp";
				int k = dssv.dgvDSSinhVien.Rows.Count - 1;
				exSheet.get_Range("A2:H" + (k + 2).ToString()).
					Borders.LineStyle
					= Excel.XlLineStyle.xlDouble;//.Borders( true);
				for (int i = 0; i < dssv.dgvDSSinhVien.Rows.Count - 1; i++)
				{
					exSheet.get_Range("A" + (3 + i).ToString()).Value =
						(i + 1).ToString();
					exSheet.get_Range("B" + (3 + i).ToString()).Value =
						dssv.dgvDSSinhVien.Rows[i].Cells[0].Value.ToString();
					exSheet.get_Range("C" + (3 + i).ToString()).Value =
						dssv.dgvDSSinhVien.Rows[i].Cells[1].Value.ToString();
					exSheet.get_Range("D" + (3 + i).ToString()).Value =
						dssv.dgvDSSinhVien.Rows[i].Cells[2].Value.ToString();
					exSheet.get_Range("E" + (3 + i).ToString()).Value =
						dssv.dgvDSSinhVien.Rows[i].Cells[3].Value.ToString();
					exSheet.get_Range("F" + (3 + i).ToString()).Value =
						dssv.dgvDSSinhVien.Rows[i].Cells[4].Value.ToString();
					exSheet.get_Range("G" + (3 + i).ToString()).Value =
						dssv.dgvDSSinhVien.Rows[i].Cells[5].Value.ToString();
					exSheet.get_Range("H" + (3 + i).ToString()).Value =
						dssv.dgvDSSinhVien.Rows[i].Cells[6].Value.ToString();
				}
				exBook.Activate();
				SaveFileDialog svf = new SaveFileDialog();
				svf.Title = "Chọn đường dẫn và đặt tên tệp lưu dl ";
				svf.ShowDialog();
				string filename = svf.FileName;
				if (filename == "")
				{
					MessageBox.Show("Bạn chưa đặt tên file");
				}
				exBook.SaveAs(filename);
				exApp.Quit();
			}

		}

		private void loadFunctionSV_Paint(object sender, PaintEventArgs e)
		{
			if (this.loadFunctionSV.Controls.Count == 0) loadFunction(new FormDSSV());
		}

	
	}
}
