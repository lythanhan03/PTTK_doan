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

namespace PTTK
{
    public partial class nhapsach : Form
    {
        public nhapsach()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            soluongsach f = new soluongsach();
            f.Show();
            this.Hide();
        }
        //BUTTON XEM HANG SAP HETS
        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Sachsaphet", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_nhapsach.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void dgv_nhapsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgv_nhapsach.Rows[e.RowIndex];
                txt_masach.Text = row.Cells["masach"].Value.ToString();
                txt_tensach.Text = row.Cells["tensach"].Value.ToString();
               
            }
        }


        private void dgv_theloaii_Leave(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void dgv_theloaii_MouseLeave(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }


        private void ClearTextBoxes()
        {
            txt_masach.Clear();
            txt_tensach.Clear();
        }
        //BTN NHập sách
        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("ThemPhieuNhapSach", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@maphieunhap", txt_maphieunhap.Text); // Đảm bảo txt_maphieunhap có giá trị hợp lệ
                        cmd.Parameters.AddWithValue("@masach", txt_masach.Text);
                        cmd.Parameters.AddWithValue("@slnhap", int.Parse(txt_soluongnhap.Text));
                        cmd.Parameters.AddWithValue("@dgnhap", decimal.Parse(txt_dongianhap.Text));
                        cmd.Parameters.AddWithValue("@mancc", txt_mancc.Text);
                        cmd.Parameters.AddWithValue("@manv", txt_manv.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Nhập sách thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
