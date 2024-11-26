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
using PTTK.Ketnoi;

namespace PTTK
{
    public partial class Formkho : Form
    {
        public Formkho()
        {
            InitializeComponent();
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
                    dgv_kho1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        //button thêm sách tự động 
        private void button1_Click(object sender, EventArgs e)
        {
            QuetMa g = new QuetMa();
            g.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoatkho_Click(object sender, EventArgs e)
        {
            
            chuongtrinh f = new chuongtrinh();
            f.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            themtheloai g = new themtheloai();
            g.Show();
            this.Hide();
        }

        private void Formkho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nhacungcap  g = new nhacungcap();
            g.Show();
            this.Hide();
        }
        //BUTTON THÊM
        private void btn_them_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Sach (masach, matheloai, tensach, tacgia, nhaxuatban, soluong, dgban) VALUES (@masach, @matheloai, @tensach, @tacgia, @nhaxuatban, @soluong, @dgban)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@masach", txt_masach.Text);
                    cmd.Parameters.AddWithValue("@matheloai", txt_matheloai.Text);
                    cmd.Parameters.AddWithValue("@tensach", txt_tensach.Text);
                    cmd.Parameters.AddWithValue("@tacgia", txt_tacgia.Text);
                    cmd.Parameters.AddWithValue("@nhaxuatban", txt_nxb.Text);
                    cmd.Parameters.AddWithValue("@soluong", int.Parse(txt_soluong.Text));
                    cmd.Parameters.AddWithValue("@dgban", int.Parse(txt_giaban.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        //BUTTON SỬA
        private void btn_sua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Sach SET matheloai=@matheloai, tensach=@tensach, tacgia=@tacgia, nhaxuatban=@nhaxuatban, soluong=@soluong, dgban=@dgban WHERE masach=@masach";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@masach", txt_masach.Text);
                    cmd.Parameters.AddWithValue("@matheloai", txt_matheloai.Text);
                    cmd.Parameters.AddWithValue("@tensach", txt_tensach.Text);
                    cmd.Parameters.AddWithValue("@tacgia", txt_tacgia.Text);
                    cmd.Parameters.AddWithValue("@nhaxuatban", txt_nxb.Text);
                    cmd.Parameters.AddWithValue("@soluong", int.Parse(txt_soluong.Text));
                    cmd.Parameters.AddWithValue("@dgban", int.Parse(txt_giaban.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        //BUTTON XOÁ
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Sach WHERE masach=@masach";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@masach", txt_masach.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

       
        private void dgv_kho1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgv_kho1.Rows[e.RowIndex];
                txt_masach.Text = row.Cells["masach"].Value.ToString(); 
                txt_matheloai.Text = row.Cells["matheloai"].Value.ToString(); 
                txt_tensach.Text = row.Cells["tensach"].Value.ToString(); 
                txt_tacgia.Text = row.Cells["tacgia"].Value.ToString(); 
                txt_nxb.Text = row.Cells["nhaxuatban"].Value.ToString(); 
                txt_soluong.Text = row.Cells["soluong"].Value.ToString(); 
            }
        }
        private void dgv_kho1_Leave(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void dgv_kho1_MouseLeave(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            txt_masach.Clear();
            txt_matheloai.Clear();
            txt_tensach.Clear();
            txt_tacgia.Clear();
            txt_nxb.Clear();
            txt_soluong.Clear();
            txt_giaban.Clear();
        }

    }
}
