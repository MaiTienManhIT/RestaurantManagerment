using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaiTienManh_3404_DACN
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_MonAn form1 = new frm_MonAn();
            form1.Show();
            this.Hide();
        }

        private void thêmDanhMụcMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DanhMuc form1 = new frm_DanhMuc();
            form1.Show();
            this.Hide();

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frm_DatBan form1 = new frm_DatBan();
            form1.Show();
            this.Hide(); ;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_HoaDon form1 = new frm_HoaDon();
            form1.Show();
            this.Hide(); ;
        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_DangNhap form1 = new frm_DangNhap();
            form1.Show();
            this.Hide(); ;
        }
    }
}
