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

namespace PTTK.ChuCuaHang
{
    public partial class PhongBan : Form
    {
        public PhongBan()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM PhongBan";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgv_phongban.DataSource = table;
            }
        }

        private void btb_Thoat_Click(object sender, EventArgs e)
        {
            nhanvien g = new nhanvien();
            g.Show();
            this.Hide();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO PhongBan (maphongban, tenphongban, chucvu, luongcb) VALUES (@maphongban, @tenphongban, @chucvu, @luongcb)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maphongban", txt_mapb.Text);
                cmd.Parameters.AddWithValue("@tenphongban", txt_tenpb.Text);
                cmd.Parameters.AddWithValue("@chucvu", txt_chucvu.Text);
                cmd.Parameters.AddWithValue("@luongcb", int.Parse(txt_luong.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                LoadData();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "UPDATE PhongBan SET tenphongban = @tenphongban, chucvu = @chucvu, luongcb = @luongcb WHERE maphongban = @maphongban";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maphongban", txt_mapb.Text);
                cmd.Parameters.AddWithValue("@tenphongban", txt_tenpb.Text);
                cmd.Parameters.AddWithValue("@chucvu", txt_chucvu.Text);
                cmd.Parameters.AddWithValue("@luongcb", int.Parse(txt_luong.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "DELETE FROM PhongBan WHERE maphongban = @maphongban";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maphongban", txt_mapb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
        }

        
        private void dgv_phongban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_phongban.Rows[e.RowIndex];
                txt_mapb.Text = row.Cells["maphongban"].Value.ToString();
                txt_tenpb.Text = row.Cells["tenphongban"].Value.ToString();
                txt_chucvu.Text = row.Cells["chucvu"].Value.ToString();
                txt_luong.Text = row.Cells["luongcb"].Value.ToString();
            }
        }
        private void dgv_phongban_Leave(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void dgv_phongban_MouseLeave(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            txt_mapb.Clear();
            txt_tenpb.Clear();
            txt_chucvu.Clear();
            txt_luong.Clear();
        }
    }
}
