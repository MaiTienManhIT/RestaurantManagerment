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
    public partial class frm_DanhMuc : Form
    {
        LOPDUNGCHUNG lopdungchung = new LOPDUNGCHUNG();
        public frm_DanhMuc()
        {
            InitializeComponent();
            LoadDM();
        }
        public void LoadDM()
        {
            string sql = "select * from DANHMUCMONAN";
            dgv_danhmuc.DataSource = lopdungchung.LoadDL(sql);
        }

        private void frm_DanhMuc_Load(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "insert into DANHMUCMONAN values ('" + txt_madanhmuc.Text + "', N'" + txt_tendanhmuc.Text + "')";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thất bại!");
            LoadDM();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update DANHMUCMONAN set TENDANHMUC = N'" + txt_tendanhmuc.Text + "' where MADANHMUC = '" + txt_madanhmuc.Text + "'";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Đã sửa!");
            else MessageBox.Show("Thất bại!");
            LoadDM();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete DANHMUCMONAN where MADANHMUC ='" + txt_madanhmuc.Text + "'";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Đã xóa!");
            else MessageBox.Show("Thất bại!");
            LoadDM();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            frm_Main form1 = new frm_Main();
            form1.Show();
            this.Hide();
        }

        private void dgv_danhmuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_madanhmuc.Text = dgv_danhmuc.CurrentRow.Cells[0].Value.ToString();
            txt_tendanhmuc.Text = dgv_danhmuc.CurrentRow.Cells["TENDANHMUC"].Value.ToString();
        }
    }
}
