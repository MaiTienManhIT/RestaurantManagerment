using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaiTienManh_3404_DACN
{
    public partial class frm_DangNhap : Form
    {
        LOPDUNGCHUNG lopdungchung = new LOPDUNGCHUNG();

        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_dn_Click(object sender, EventArgs e)
        {

            string sql = "select COUNT(*) from TAIKHOAN where TENTAIKHOAN = '"+txt_TK.Text+"' and MATKHAU = '"+txt_MK.Text+"'";
            int kq = Convert.ToInt32(lopdungchung.ExecuteScalar(sql));
            if(kq >=1l) {
                frm_Main form1 = new frm_Main();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu!");
                txt_TK.Clear();
                txt_MK.Clear();

            } 
          
        }
    }
}
