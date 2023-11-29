
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL_QuanLiKTX
{
    public partial class FormQuanLiThietBi : Form
    {
        ProcessDataBase dtBase = new ProcessDataBase();
        public FormQuanLiThietBi()
        {
            InitializeComponent();
        }

        private void btnQanLiPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLiPhong Obj = new FormQuanLiPhong();
            Obj.ShowDialog();
            this.Close();
        }

        

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void changeColumnsName()
        {
            dgvQLTB.Columns[0].HeaderText = "Mã phòng";
            dgvQLTB.Columns[1].HeaderText = "Mã thiết bị";
            dgvQLTB.Columns[2].HeaderText = "Số lượng";
            dgvQLTB.Columns[3].HeaderText = "Tình trạng";
            dgvQLTB.Columns[4].HeaderText = "Tên thiết bị";
            dgvQLTB.Columns[5].HeaderText = "Giá trị";


        }
        private void FormQuanLiThietBi_Load(object sender, EventArgs e)
        {
            dgvQLTB.DataSource = dtBase.DocBang("SELECT dbo.ThietBiPhong.*,dbo.Thietbi.Tenthietbi,dbo.Thietbi.Giatri FROM dbo.ThietBiPhong join dbo.Thietbi on dbo.ThietBiPhong.Mathietbi = dbo.Thietbi.Mathietbi");
            changeColumnsName();
            cbbTinhTrang.Items.Add("Đang sử dụng");
            cbbTinhTrang.Items.Add("Đã hỏng");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbtnTimKiem_Click(object sender, EventArgs e)
        {
            if (rbtnMaThietBi.Checked == true)
            {
                dgvQLTB.DataSource = dtBase.DocBang("SELECT dbo.ThietBiPhong.*,dbo.Thietbi.Tenthietbi,dbo.Thietbi.Giatri FROM dbo.ThietBiPhong inner join dbo.Thietbi on dbo.ThietBiPhong.Mathietbi = dbo.Thietbi.Mathietbi WHERE dbo.ThietBiPhong.Mathietbi= '" + txtTimKiem.Text.Trim() + "' ");
            }
            else if (rbtnMaPhong.Checked)
            {
                dgvQLTB.DataSource = dtBase.DocBang("SELECT dbo.ThietBiPhong.*,dbo.Thietbi.Tenthietbi,dbo.Thietbi.Giatri FROM dbo.ThietBiPhong inner join dbo.Thietbi on dbo.ThietBiPhong.Mathietbi = dbo.Thietbi.Mathietbi WHERE dbo.ThietBiPhong.MaPhong= '" + txtTimKiem.Text.Trim()+"' ");
            }


        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbtnTaiLai_Click(object sender, EventArgs e)
        {
            dgvQLTB.DataSource = dtBase.DocBang("SELECT dbo.ThietBiPhong.*,dbo.Thietbi.Tenthietbi,dbo.Thietbi.Giatri FROM dbo.ThietBiPhong join dbo.Thietbi on dbo.ThietBiPhong.Mathietbi = dbo.Thietbi.Mathietbi");
        }

        private void dgvQLTB_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbtnThem_Click(object sender, EventArgs e)
        {
            if(txtMaPhong.Text.Trim() =="" || txtMaThietBi.Text.Trim() == "")
            {
                MessageBox.Show("Mã phòng và mã thiết bị không được để trống!");
            }
            else
            {
                DataTable dataTable = dtBase.DocBang("SELECT * FROM dbo.ThietBiPhong WHERE MaPhong='"+txtMaPhong.Text.Trim()+"' and Mathietbi='"+txtMaThietBi.Text.Trim()+"' ");
                if (dataTable.Rows.Count == 0)
                {
                    dtBase.CapNhat("INSERT INTO dbo.ThietBiPhong (MaPhong,Mathietbi,soluong,Tinhtrang) VALUES('" + txtMaPhong.Text + "','" + txtMaThietBi.Text + "','" + txtSoLuong.Text + "',N'" + cbbTinhTrang.SelectedItem.ToString() + "')    ");
                    dtBase.CapNhat("INSERT INTO dbo.Thietbi (Mathietbi,Tenthietbi,Giatri) VALUES ('" + txtMaThietBi.Text + "',N'" + txtTenThietBi.Text + "','" + txtGiaTri.Text + "')");
                    dgvQLTB.DataSource = dtBase.DocBang("SELECT dbo.ThietBiPhong.*,dbo.Thietbi.Tenthietbi,dbo.Thietbi.Giatri FROM dbo.ThietBiPhong join dbo.Thietbi on dbo.ThietBiPhong.Mathietbi = dbo.Thietbi.Mathietbi");

                }
                else MessageBox.Show("Mã thiết bị hoặc mã phòng đã tồn tại!");
            }
        }
        // đặt tên sai, đây là nút sửa nhé các bạn

        private void gbtnThem_Click_1(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Trim() != "" && txtMaThietBi.Text.Trim() != "")
            {
                string mathietbi = dgvQLTB.CurrentRow.Cells[1].Value.ToString();
                dtBase.CapNhat("UPDATE dbo.ThietBiPhong SET MaPhong ='"+txtMaPhong.Text+"', Mathietbi='"+txtMaThietBi.Text+"',soluong='"+txtSoLuong.Text+"',Tinhtrang=N'"+cbbTinhTrang.SelectedItem.ToString()+"' WHERE Mathietbi='"+txtMaThietBi.Text+"'           ");
                dtBase.CapNhat("UPDATE dbo.ThietBi SET Mathietbi='"+txtMaThietBi.Text+"',Tenthietbi=N'"+txtTenThietBi.Text+"',Giatri = '"+txtGiaTri.Text+"' WHERE Mathietbi='"+txtMaThietBi.Text+"'   ");
                MessageBox.Show("Đã cập nhật dữ liệu!");
                dgvQLTB.DataSource = dtBase.DocBang("SELECT dbo.ThietBiPhong.*,dbo.Thietbi.Tenthietbi,dbo.Thietbi.Giatri FROM dbo.ThietBiPhong join dbo.Thietbi on dbo.ThietBiPhong.Mathietbi = dbo.Thietbi.Mathietbi");

            }
            else MessageBox.Show("Mã thiết bị và mã phòng không được để trống!");
        }

        private void gbtnXoa_Click(object sender, EventArgs e)
        {
            string mathietbi = null;
            mathietbi = dgvQLTB.CurrentRow.Cells[1].Value.ToString();
            
            DialogResult dr;
            if ((dr = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) == DialogResult.Yes)
            {
                dtBase.CapNhat("DELETE dbo.ThietBiPhong WHERE Mathietbi ='" + mathietbi + "' ");
                dtBase.CapNhat("DELETE dbo.Thietbi WHERE Mathietbi = '" + mathietbi + "' ");
                dgvQLTB.DataSource = dtBase.DocBang("SELECT dbo.ThietBiPhong.*,dbo.Thietbi.Tenthietbi,dbo.Thietbi.Giatri FROM dbo.ThietBiPhong join dbo.Thietbi on dbo.ThietBiPhong.Mathietbi = dbo.Thietbi.Mathietbi");

            }


        }

        private void dgvQLTB_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhong.Text = dgvQLTB.CurrentRow.Cells[0].Value.ToString();
            txtMaThietBi.Text = dgvQLTB.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = dgvQLTB.CurrentRow.Cells[2].Value.ToString();
            cbbTinhTrang.SelectedIndex = 1;
            cbbTinhTrang.SelectedItem = dgvQLTB.CurrentRow.Cells[3].Value.ToString();
            txtTenThietBi.Text = dgvQLTB.CurrentRow.Cells[4].Value.ToString();
            txtGiaTri.Text = dgvQLTB.CurrentRow.Cells[5].Value.ToString();
            
        }
    }
}
