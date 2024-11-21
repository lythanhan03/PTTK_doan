using PTTK.Ketnoi;
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

namespace PTTK.BanHang
{
    public partial class hadon1 : Form
    {
        public hadon1()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Sach";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_hoadon.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void dgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem chỉ số dòng có hợp lệ hay không
            if (e.RowIndex >= 0) // Đảm bảo không phải click vào tiêu đề cột
            {
                // Lấy thông tin từ dòng đã chọn
                DataGridViewRow row = dgv_hoadon.Rows[e.RowIndex];
                txt_masach.Text = row.Cells["masach"].Value.ToString(); // Thay "masach" bằng tên cột chính xác
                //txt_matheloai.Text = row.Cells["matheloai"].Value.ToString(); // Thay "matheloai" bằng tên cột chính xác
                txt_tensach.Text = row.Cells["tensach"].Value.ToString(); // Thay "tensach" bằng tên cột chính xác
               // txt_tacgia.Text = row.Cells["tacgia"].Value.ToString(); // Thay "tacgia" bằng tên cột chính xác
               // txt_nxb.Text = row.Cells["nhaxuatban"].Value.ToString(); // Thay "nhaxuatban" bằng tên cột chính xác
               // txt_soluong.Text = row.Cells["soluong"].Value.ToString(); // Thay "soluong" bằng tên cột chính xác
                txt_giaban.Text = row.Cells["dgban"].Value.ToString();
            }
        }
        private void dgv_hoadon_Leave(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void dgv_hoadon_MouseLeave(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            txt_masach.Clear();
           // txt_matheloai.Clear();
            txt_tensach.Clear();
           // txt_tacgia.Clear();
           // txt_nxb.Clear();
           // txt_soluong.Clear();
           txt_giaban.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            chuongtrinh f = new chuongtrinh();
            f.Show();
            this.Hide();
        }

       
    }
}
