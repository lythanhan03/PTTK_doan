using PTTK.Ketnoi; 
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PTTK
{
    public partial class themtheloai : Form
    {
        public themtheloai()
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
                    string query = "SELECT * FROM TheLoai";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_theloaii.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }

        private void btn_them_the_loai_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO TheLoai (matheloai, tentheloai) VALUES (@matheloai, @tentheloai)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@matheloai", SqlDbType.VarChar).Value = txt_matheloai.Text;
                        cmd.Parameters.Add("@tentheloai", SqlDbType.VarChar).Value = txt_tentheloai.Text;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm thể loại thành công!");
                    LoadData(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm thể loại: " + ex.Message);
                }
            }
        }

        private void btn_sua_the_loai_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE TheLoai SET tentheloai=@tentheloai WHERE matheloai=@matheloai";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@matheloai", SqlDbType.VarChar).Value = txt_matheloai.Text;
                        cmd.Parameters.Add("@tentheloai", SqlDbType.VarChar).Value = txt_tentheloai.Text;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Sửa thể loại thành công!");
                    LoadData(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa thể loại: " + ex.Message);
                }
            }
        }

        private void btn_xoa_the_loai_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM TheLoai WHERE matheloai=@matheloai";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@matheloai", SqlDbType.VarChar).Value = txt_matheloai.Text;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Xóa thể loại thành công!");
                    LoadData(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa thể loại: " + ex.Message);
                }
            }
        }

        private void themtheloai_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }

        private void btn_thoat_theloaisach_Click(object sender, EventArgs e)
        {
            Formkho k = new Formkho();
            k.Show();
            this.Hide();
        }

        private void dgv_theloaii_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0) 
            {
                
                DataGridViewRow row = dgv_theloaii.Rows[e.RowIndex];
                txt_matheloai.Text = row.Cells["matheloai"].Value.ToString(); 
                txt_tentheloai.Text = row.Cells["tentheloai"].Value.ToString(); 
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
            txt_matheloai.Clear();
            txt_tentheloai.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
