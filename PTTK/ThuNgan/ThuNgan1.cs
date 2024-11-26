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

namespace PTTK.ThuNgan
{
    public partial class ThuNgan1 : Form
    {
        public ThuNgan1()
        {
            InitializeComponent();
        }

        private void btn_xemcp_Click(object sender, EventArgs e)
        {
            int thang = dtp_Thangnam.Value.Month;
            int nam = dtp_Thangnam.Value.Year;

            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("BaoCaoChiPhiNhapTheoThang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        
                        cmd.Parameters.AddWithValue("@Thang", thang);
                        cmd.Parameters.AddWithValue("@Nam", nam);

                        
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                       
                        dgv_thungan.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            chuongtrinh f = new chuongtrinh();
            f.Show();
            this.Hide();
        }
        private void LoadKhachHangDoanhThuCao(int minDoanhThu)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))

            
            {
                SqlCommand cmd = new SqlCommand("sp_KhachHangDoanhThuCao", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MinDoanhThu", minDoanhThu);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                conn.Open();
                adapter.Fill(dataTable);
                conn.Close();

                dgv_thungan.DataSource = dataTable;
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(txt_Mindoanhthu.Text, out int minDoanhThu))
            {
               
                LoadKhachHangDoanhThuCao(minDoanhThu);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ cho doanh thu tối thiểu.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
