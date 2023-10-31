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
    public partial class frm_MonAn : Form
    {
        LOPDUNGCHUNG lopdungchung = new LOPDUNGCHUNG();
        public frm_MonAn()
        {
            InitializeComponent();
            LoadMA();
        }
        public void LoadMA()
        {
            string sql = "select * from MONAN";
            dgv_danhsach.DataSource = lopdungchung.LoadDL(sql);
        }

        private void frm_MonAn_Load(object sender, EventArgs e)
        {
            string sql = "select * from DANHMUCMONAN";
            cb_danhmuc.DataSource = lopdungchung.LoadDL(sql);
            cb_danhmuc.DisplayMember = "TENDANHMUC";
            cb_danhmuc.ValueMember = "MADANHMUC";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "insert into MONAN values ('" + txt_mamon.Text + "', N'" + txt_tenmon.Text + "', '" + cb_danhmuc.SelectedValue + "', '"+txt_dongia.Text+"')";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thất bại!");
            LoadMA();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update MONAN set TENMON = '" + txt_tenmon.Text + "',MADANHMUC = '" + cb_danhmuc.SelectedValue +"', GIA = '"+txt_dongia.Text+"' where MAMON = '" + txt_mamon.Text + "'";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Đã sửa!");
            else MessageBox.Show("Thất bại!");
            LoadMA();
        }

        private void dgv_danhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mamon.Text = dgv_danhsach.CurrentRow.Cells[0].Value.ToString();
            txt_tenmon.Text = dgv_danhsach.CurrentRow.Cells["TENMON"].Value.ToString();
            cb_danhmuc.SelectedValue = dgv_danhsach.CurrentRow.Cells["MADANHMUC"].Value.ToString();
            txt_dongia.Text = dgv_danhsach.CurrentRow.Cells["GIA"].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete MONAN where MAMON ='" + txt_mamon.Text + "'";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Đã xóa!");
            else MessageBox.Show("Thất bại!");
            LoadMA();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            frm_Main form1 = new frm_Main();
            form1.Show();
            this.Hide();
        }

        private void dgv_danhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_danhsach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_danhsach.ForeColor = Color.Black;
        }
    }
}
