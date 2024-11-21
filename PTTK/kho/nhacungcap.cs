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
    public partial class nhacungcap : Form
    {
        public nhacungcap()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                string query = "SELECT * FROM NhaCungCap";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_ncc.DataSource = dataTable;
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            // btn_thoat_NCC
            Formkho k = new Formkho();
            k.Show();
            this.Hide();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                string query = "INSERT INTO NhaCungCap (mancc, tenncc, diachi, dienthoai) VALUES (@mancc, @tenncc, @diachi, @dienthoai)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mancc", txt_mancc.Text);
                cmd.Parameters.AddWithValue("@tenncc", txt_tenncc.Text);
                cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);
                cmd.Parameters.AddWithValue("@dienthoai", int.Parse(txt_sdt.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadData();
                MessageBox.Show("Thêm thành công!");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                string query = "UPDATE NhaCungCap SET tenncc = @tenncc, diachi = @diachi, dienthoai = @dienthoai WHERE mancc = @mancc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mancc", txt_mancc.Text);
                cmd.Parameters.AddWithValue("@tenncc", txt_tenncc.Text);
                cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);
                cmd.Parameters.AddWithValue("@dienthoai", int.Parse(txt_sdt.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadData();
                MessageBox.Show("Sửa thành công!");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                string query = "DELETE FROM NhaCungCap WHERE mancc = @mancc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mancc", txt_mancc.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadData();
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void dgv_ncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgv_ncc.Rows[e.RowIndex];
                txt_mancc.Text = row.Cells["mancc"].Value.ToString();
                txt_tenncc.Text = row.Cells["tenncc"].Value.ToString();
                txt_sdt.Text = row.Cells["dienthoai"].Value.ToString();
                txt_diachi.Text = row.Cells["diachi"].Value.ToString();
            }
        }
        private void dgv_ncc_Leave(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void dgv_ncc_MouseLeave(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }


        private void ClearTextBoxes()
        {
            txt_mancc.Clear();
            txt_tenncc.Clear();
            txt_sdt.Clear();
            txt_diachi.Clear();
        }
    }
}
