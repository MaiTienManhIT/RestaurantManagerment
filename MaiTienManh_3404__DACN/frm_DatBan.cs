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
    public partial class frm_DatBan : Form
    {
        LOPDUNGCHUNG lopdungchung = new LOPDUNGCHUNG();
        public frm_DatBan()
        {
            InitializeComponent();
            LoadDB();
        }
        public void LoadDB()
        {
            string sql = "select * from SOBAN";
            dgv_datban.DataSource = lopdungchung.LoadDL(sql);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_Main form1 = new frm_Main();
            form1.Show();
            this.Hide();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "insert into SOBAN values ('" + txt_maban.Text + "', N'" + txt_tenban.Text + "',N'"+cb_tt.SelectedItem+"')";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thất bại!");
            LoadDB();
        }

        private void dgv_datban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update SOBAN seT TENBAN = N'" + txt_tenban.Text + "', TRANGTHAI = N'"+cb_tt.SelectedItem+"' where MABAN = '" + txt_maban.Text + "'";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Đã sửa!");
            else MessageBox.Show("Thất bại!");
            LoadDB();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete SOBAN where MABAN ='" + txt_maban.Text + "'";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Đã xóa!");
            else MessageBox.Show("Thất bại!");
            LoadDB();
        }

        private void dgv_datban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maban.Text = dgv_datban.CurrentRow.Cells[0].Value.ToString();
            txt_tenban.Text = dgv_datban.CurrentRow.Cells["TENBAN"].Value.ToString();
            cb_tt.SelectedItem = dgv_datban.CurrentRow.Cells["TRANGTHAI"].Value.ToString();

        }

        private void frm_DatBan_Load(object sender, EventArgs e)
        {

        }
    }
}
