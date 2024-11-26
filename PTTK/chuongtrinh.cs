using PTTK.BanHang;
using PTTK.ChuCuaHang;
using PTTK.ThuNgan;
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
    public partial class chuongtrinh : Form
    {
        public bool isThoat = true;
        public chuongtrinh()
        {
            InitializeComponent();
        }
        public event EventHandler Dangxuat;
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            //Dangxuat(this, new EventArgs());
            dangnhap f = new dangnhap();
            f.Show();
            this.Hide();
        }

        private void btn_thoat1_Click(object sender, EventArgs e)
        {
            if(isThoat)
                Application.Exit();
        }

        private void chuongtrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isThoat)
            {
                if (MessageBox.Show("Ban chac chu","Canh bao",MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }    
        }
        void PhanQuyen()
        {
          switch(Const.TaiKhoan.Loaitaikhoan)
            {
                case TaiKhoan.LoaiTK.kho:
                    btn_qltaikhoan.Enabled = false;
                    btn_khachhang.Enabled = false;
                    btn_laphoadon.Enabled = false;
                    btn_baocao.Enabled = false;
                    btn_chitra.Enabled = false;
                    
                    break;
                case TaiKhoan.LoaiTK.thungan:
                    btn_qltaikhoan.Enabled = false;
                    btn_khachhang.Enabled = false;
                    btn_laphoadon.Enabled = false;
                    btn_ktsoluong.Enabled = false;
                    btn_themsach.Enabled = false;
                    break;
                case TaiKhoan.LoaiTK.banhang:
                    btn_qltaikhoan.Enabled = false;
                    btn_baocao.Enabled = false;
                    btn_chitra.Enabled = false;
                    btn_ktsoluong.Enabled = false;
                    btn_themsach.Enabled = false;
                    break;
            }
            txt_phanquyen.Text = Const.TaiKhoan.TenHienThi;
        }

        private void chuongtrinh_Load(object sender, EventArgs e)
        {
            PhanQuyen();
        }

        private void btn_themsach_Click(object sender, EventArgs e)
        {
            Formkho f = new Formkho();
            f.Show();
            this.Hide();
        }

        private void btn_ktsoluong_Click(object sender, EventArgs e)
        {
            soluongsach f = new soluongsach();
            f.Show();
            this.Hide();
        }

        private void btn_laphoadon_Click(object sender, EventArgs e)
        {
            hadon1 f = new hadon1();
            f.Show();
            this.Hide();
        }

        private void btn_chitra_Click(object sender, EventArgs e)
        {
            ThuNgan1 f = new ThuNgan1();
            f.Show();
            this.Hide();
        }

        private void btn_baocao_Click(object sender, EventArgs e)
        {
            ThuNgan2 f = new ThuNgan2();
            f.Show();
            this.Hide();
        }

        private void btn_qltaikhoan_Click(object sender, EventArgs e)
        {
            nhanvien f = new nhanvien();
            f.Show();
            this.Hide();
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            khachhang f = new khachhang();
            f.Show();
            this.Hide();
        }

        //private void btn_kho_Click(object sender, EventArgs e)
        //{
        //    Formkho f = new Formkho();
        //    f.Show();
        //    this.Hide();
        //}
    }
}
