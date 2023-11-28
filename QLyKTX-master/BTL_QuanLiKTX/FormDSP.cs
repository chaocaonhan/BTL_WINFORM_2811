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
	public partial class FormDSP : Form
	{
		ProcessDataBase pd = new ProcessDataBase();
		public FormDSP()
		{
			InitializeComponent();
		}

		private void FormDSP_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'nhan.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.nhan.Phong);
			dataGridViewDanhSachPhong.DataSource = pd.DocBang("select * from phong");
        }
    }
}
