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
	public partial class ChiTietPhong : Form
	{
		public ChiTietPhong()
		{
			InitializeComponent();
		}

		private void ChiTietPhong_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'nhan.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.nhan.SinhVien);

        }
    }
}
