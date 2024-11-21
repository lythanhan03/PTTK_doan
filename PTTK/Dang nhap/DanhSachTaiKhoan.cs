using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK
{
    public class DanhSachTaiKhoan
    {
        private static DanhSachTaiKhoan instance;

        public static DanhSachTaiKhoan Instance 
        {
            get 
            { 
                if(instance == null)
                    instance = new DanhSachTaiKhoan();
                return instance; 
            }
            set => instance = value; 
        }
        List<TaiKhoan> listTaiKhoan;

        public List<TaiKhoan> ListTaiKhoan 
        {
            get => listTaiKhoan; 
            set => listTaiKhoan = value; 
        }
        

        DanhSachTaiKhoan()
        {
            listTaiKhoan = new List<TaiKhoan>();
            listTaiKhoan.Add(new TaiKhoan("thanhan","123456",TaiKhoan.LoaiTK.chu));
            listTaiKhoan.Add(new TaiKhoan("kho", "123", TaiKhoan.LoaiTK.kho));
            listTaiKhoan.Add(new TaiKhoan("thungan", "123", TaiKhoan.LoaiTK.thungan));
            listTaiKhoan.Add(new TaiKhoan("banhang", "123", TaiKhoan.LoaiTK.banhang));
        }
    }
}
