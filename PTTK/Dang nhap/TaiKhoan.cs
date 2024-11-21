using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK
{
    public class TaiKhoan
    {
        private string tentaikhoan;

        public string Tentaikhoan
        {
            get => tentaikhoan;
            set => tentaikhoan = value;
        }


        private string matkhau;
        public string Matkhau
        {
            get => matkhau;
            set => matkhau = value;
        }

        public enum LoaiTK
        {
            chu,
            kho,
            thungan,
            banhang


        }

        private LoaiTK loaitaikhoan;
        public  LoaiTK Loaitaikhoan 
        { 
            get { return loaitaikhoan;} 
            set => loaitaikhoan = value; 
        }

        

        private string tenHienThi;
        public string TenHienThi 
        {
            get
            {
                switch (loaitaikhoan)
                {
                    case LoaiTK.chu:
                        TenHienThi = " Chu cua hang";
                        break;
                        case LoaiTK.kho:
                        TenHienThi = "Bo phan kho";
                        break;
                        case LoaiTK.thungan:
                        TenHienThi = "Bo phan thu ngan";
                        break;
                    default:
                        TenHienThi = " Bo phan ban hang";
                        break;
                }
                return tenHienThi;
            }
            set => tenHienThi = value; 
        }

        public TaiKhoan(string tentaikhoan, string matkhau, LoaiTK loaitaikhoan)
        {
            this.tentaikhoan = tentaikhoan;
            this.Matkhau = matkhau;
            this.loaitaikhoan = loaitaikhoan;
           
        }
    }
}
