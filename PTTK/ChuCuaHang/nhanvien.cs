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
    public partial class nhanvien : Form
    {
        public nhanvien()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM NhanVien";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgv_nhanvien.DataSource = table;
            }
        }


        private void btn_phongban_Click(object sender, EventArgs e)
        {
            PhongBan g = new  PhongBan();
            g.Show();
            this.Hide();
        }

        private void nhanvien_Load(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO NhanVien (manv, maphongban, tennv, sdt, email, diachi, ngayvaolam, tinhtrang) VALUES (@manv, @maphongban, @tennv, @sdt, @email, @diachi, @ngayvaolam, @tinhtrang)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@manv", txt_manv.Text);
                cmd.Parameters.AddWithValue("@maphongban", txt_maphongban.Text);
                cmd.Parameters.AddWithValue("@tennv", txt_tennv.Text);
                cmd.Parameters.AddWithValue("@sdt", int.Parse(txt_sdt.Text));
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);
                cmd.Parameters.AddWithValue("@ngayvaolam", int.Parse(txt_ngayvaolam.Text));
                cmd.Parameters.AddWithValue("@tinhtrang", txt_tinhtrang.Text);

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
                string query = "UPDATE NhanVien SET maphongban = @maphongban, tennv = @tennv, sdt = @sdt, email = @email, diachi = @diachi, ngayvaolam = @ngayvaolam, tinhtrang = @tinhtrang WHERE manv = @manv";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@manv", txt_manv.Text);
                cmd.Parameters.AddWithValue("@maphongban", txt_maphongban.Text);
                cmd.Parameters.AddWithValue("@tennv", txt_tennv.Text);
                cmd.Parameters.AddWithValue("@sdt", int.Parse(txt_sdt.Text));
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);
                cmd.Parameters.AddWithValue("@ngayvaolam", int.Parse(txt_ngayvaolam.Text));
                cmd.Parameters.AddWithValue("@tinhtrang", txt_tinhtrang.Text);

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
                string query = "DELETE FROM NhanVien WHERE manv = @manv";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@manv", txt_manv.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_nhanvien.Rows[e.RowIndex];
                txt_manv.Text = row.Cells["manv"].Value.ToString();
                txt_maphongban.Text = row.Cells["maphongban"].Value.ToString();
                txt_tennv.Text = row.Cells["tennv"].Value.ToString();
                txt_sdt.Text = row.Cells["sdt"].Value.ToString();
                txt_email.Text = row.Cells["email"].Value.ToString();
                txt_diachi.Text = row.Cells["diachi"].Value.ToString();
                txt_ngayvaolam.Text = row.Cells["ngayvaolam"].Value.ToString();
                txt_tinhtrang.Text = row.Cells["tinhtrang"].Value.ToString();
            }
        }

        
        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_nhanvien.Rows[e.RowIndex];
                txt_manv.Text = row.Cells["manv"].Value.ToString();
                txt_maphongban.Text = row.Cells["maphongban"].Value.ToString();
                txt_tennv.Text = row.Cells["tennv"].Value.ToString();
                txt_sdt.Text = row.Cells["sdt"].Value.ToString();
                txt_email.Text = row.Cells["email"].Value.ToString();
                txt_diachi.Text = row.Cells["diachi"].Value.ToString();
                txt_ngayvaolam.Text = row.Cells["ngayvaolam"].Value.ToString();
                txt_tinhtrang.Text = row.Cells["tinhtrang"].Value.ToString();
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
           txt_diachi.Clear();
            txt_email.Clear();
            txt_manv.Clear();
            txt_maphongban.Clear();
            txt_tennv.Clear();
            txt_sdt.Clear();
            txt_ngayvaolam.Clear();
            txt_tinhtrang.Clear();


        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            chuongtrinh g = new chuongtrinh();
            g.Show();
            this.Hide();
        }
    }
}
