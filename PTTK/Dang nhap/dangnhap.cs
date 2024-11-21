using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK
{
    public partial class dangnhap : Form
    {
        List<TaiKhoan> listTaiKhoan = DanhSachTaiKhoan.Instance.ListTaiKhoan;
        public dangnhap()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if(KiemTraDangNhap(txt_tendangnhap.Text, txt_matkhau.Text))
            {
                chuongtrinh f = new chuongtrinh();
                f.Show();
                this.Hide();
                f.Dangxuat += F_Dangxuat;
            }
            else
            {
                    MessageBox.Show("sai ten tai khoan hoac mat khau", "loi");
                txt_tendangnhap.Focus();
            }
           
        }

        private void F_Dangxuat(object sender, EventArgs e)
        {
            (sender as chuongtrinh).isThoat = false;
            (sender as chuongtrinh).Close();
            this.Show();
        }
        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            for(int i = 0; i < listTaiKhoan.Count; i++)
            {
                if (tentaikhoan == listTaiKhoan[i].Tentaikhoan && matkhau == listTaiKhoan[i].Matkhau)
                {
                    Const.TaiKhoan = listTaiKhoan[i];
                    return true;
                }
                
            }
            return false;
        }
    }
}
