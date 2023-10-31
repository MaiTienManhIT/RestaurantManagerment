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
    public partial class frm_HoaDon : Form
    {
        LOPDUNGCHUNG lopdungchung = new LOPDUNGCHUNG();
        public frm_HoaDon()
        {
           
            InitializeComponent();
            LoadHD();
        }
        public void LoadHD()
        {
            string sql = "select * from HOADON";
            dgv_hoadon.DataSource = lopdungchung.LoadDL(sql);
        }
        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            string sql = "select * from SOBAN";
            cb_ban.DataSource = lopdungchung.LoadDL(sql);
            cb_ban.DisplayMember = "TENBAN";
            cb_ban.ValueMember = "MABAN";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "insert into HOADON values ('" + txt_mahd.Text + "', '" + dt_vao.Value + "', '" + dt_ra.Value + "', '" + cb_ban.SelectedValue + "')";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thất bại!");
            LoadHD();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update HOADON set NGAYVAO = '" + dt_vao.Value + "',NGAYRA = '" + dt_ra.Value + "', MABAN = '" + cb_ban.SelectedValue + "' where MAHD = '" + txt_mahd.Text + "'";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Đã sửa!");
            else MessageBox.Show("Thất bại!");
            LoadHD();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete HOADON where MAHD ='" + txt_mahd.Text + "'";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Đã xóa!");
            else MessageBox.Show("ERROR!");
            LoadHD();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            frm_Main form1 = new frm_Main();
            form1.Show();
            this.Hide();
        }

        private void btn_tinhtien_Click(object sender, EventArgs e)
        {
            frm_CTHoaDon form1 = new frm_CTHoaDon();
            form1.Show();
            this.Hide();
        }

        private void dgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahd.Text = dgv_hoadon.CurrentRow.Cells[0].Value.ToString();
            cb_ban.SelectedValue = dgv_hoadon.CurrentRow.Cells["MABAN"].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
