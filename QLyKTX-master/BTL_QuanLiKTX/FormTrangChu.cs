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
	public partial class FormTrangChu : Form
	{
		ProcessDataBase pd=new ProcessDataBase();
		public FormTrangChu()
		{
			InitializeComponent();
		}
		
		public void loadFunction(object Form)
		{
			if (this.loadContent.Controls.Count > 0)
				this.loadContent.Controls.RemoveAt(0);

			Form f = Form as Form;
			f.TopLevel = false;
			f.Dock = DockStyle.Fill;
			this.loadContent.Controls.Add(f);
			this.loadContent.Tag = f;
			f.Show();
		}
		public void setColor(string colorPhong, string colorSV, string colorHD, string colorTB)
		{
			// Set the text color of btnQLPhong to yellow or white
			if (colorPhong.ToLower() == "yellow")
			{
				btnQanLiPhong.ForeColor = Color.Yellow;
			}
			else if (colorPhong.ToLower() == "white")
			{
				btnQanLiPhong.ForeColor = Color.White;
			}

			if (colorSV.ToLower() == "yellow")
			{
				btnQuanLiSV.ForeColor = Color.Yellow;
			}
			else if (colorSV.ToLower() == "white")
			{
				btnQuanLiSV.ForeColor = Color.White;
			}

			if (colorHD.ToLower() == "yellow")
			{
				btnQuanLiHoaDon.ForeColor = Color.Yellow;
			}
			else if (colorHD.ToLower() == "white")
			{
				btnQuanLiHoaDon.ForeColor = Color.White;
			}

			if (colorTB.ToLower() == "yellow")
			{
				btnQuanLiThietBi.ForeColor = Color.Yellow;
			}
			else if (colorTB.ToLower() == "white")
			{
				btnQuanLiThietBi.ForeColor = Color.White;
			}
		}
		private void btnQuanLiSV_Click(object sender, EventArgs e)
		{
			setColor("white", "yellow", "white", "white");
			panel1.Hide();
			loadFunction(new FormMainQLSV());
		}

		private void btnQuanLiHoaDon_Click(object sender, EventArgs e)
		{
			setColor("white",  "white", "yellow", "white");
			panel1.Hide();
			loadFunction(new FormQLHoaDon());
		}

		private void btnQanLiPhong_Click(object sender, EventArgs e)
		{
			setColor("yellow", "white",  "white", "white");
			panel1.Hide();
			loadFunction(new FormQuanLiPhong());
		}

		private void btnCloseForm_Click(object sender, EventArgs e)
		{

			this.Close();
		}

		private void btnQuanLiThietBi_Click(object sender, EventArgs e)
		{
			setColor("white", "white", "white", "yellow");
			panel1.Hide();
			loadFunction(new FormQuanLiThietBi());
		}

		private void loadContent_Paint(object sender, PaintEventArgs e)
		{

		}
		public void demSL(Label label,string query)
		{
			DataTable resultTable = pd.DocBang(query);


			// Check if the DataTable has any rows
			if (resultTable.Rows.Count > 0)
			{
				// Get the count value from the first row and first column
				int recordCount = Convert.ToInt32(resultTable.Rows[0][0]);

				// Display the count in the label
				label.Text = recordCount.ToString();
			}
			else
			{
				// No records found
				label.Text = "0";
			}
		}
		
		private void FormTrangChu_Load_1(object sender, EventArgs e)
		{
			demSL(lbCountPhong, "select count(*) from Phong");
			demSL(lbCountSinhVien, "select count(*) from SinhVien");
			demSL(lbCountThietBi, "select count(*) from ThietBi");
			demSL(lbCountHoaDon, "select count(*) from ThuePhong");

		}
	}
}
