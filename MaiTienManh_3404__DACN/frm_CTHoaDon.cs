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
    public partial class frm_CTHoaDon : Form
    {
        LOPDUNGCHUNG lopdungchung = new LOPDUNGCHUNG();
        public frm_CTHoaDon()
        {
            InitializeComponent();
            LoadHD();
        }
        public void LoadHD()
        {
            string sql = "select * from CTHOADON";
            dgv_cthd.DataSource = lopdungchung.LoadDL(sql);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void num_sl_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "insert into CTHOADON values ('" + txt_mahd.Text + "', '" + cb_mon.SelectedValue + "', '" + txt_sl.Text + "')";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thất bại!");
            LoadHD();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "UpdateCTHOADON set MAMON = '" + cb_mon.SelectedValue + "', SOLUONG = '"+txt_sl.Text+"' where MAHD = '" + txt_mahd.Text + "'";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Thất bại!");
            LoadHD();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete CTHOADON where MAHD ='" + txt_mahd.Text + "'";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Đã xóa!");
            else MessageBox.Show("Thất bại!");
            LoadHD();
        }

        private void btn_tinhtien_Click(object sender, EventArgs e)
        {

        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            frm_Main form1 = new frm_Main();
            form1.Show();
            this.Hide();
        }

        private void dgv_cthd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahd.Text = dgv_cthd.CurrentRow.Cells[0].Value.ToString();
            cb_mon.SelectedValue = dgv_cthd.CurrentRow.Cells["MAMON"].Value.ToString();
            txt_sl.Text = dgv_cthd.CurrentRow.Cells["SOLUONG"].Value.ToString();
        }

        private void frm_CTHoaDon_Load(object sender, EventArgs e)
        {
            string sql = "select * from MONAN";
            cb_mon.DataSource = lopdungchung.LoadDL(sql);
            cb_mon.DisplayMember = "TENMON";
            cb_mon.ValueMember = "MAMON";
        }
    }
}
