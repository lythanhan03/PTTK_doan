using PTTK.Ketnoi;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PTTK.BanHang
{
    public partial class khachhang : Form
    {
        public khachhang()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                string query = "SELECT * FROM KhachHang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_khachhang.DataSource = dt;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            chuongtrinh f = new chuongtrinh();
            f.Show();
            this.Hide();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu trước khi thực hiện
                if (string.IsNullOrWhiteSpace(txt_makh.Text) || string.IsNullOrWhiteSpace(txt_tenkh.Text) ||
                    string.IsNullOrWhiteSpace(txt_diachi.Text) || string.IsNullOrWhiteSpace(txt_sdt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_sdt.Text, out int soDienThoai))
                {
                    MessageBox.Show("Số điện thoại phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thực thi thêm dữ liệu
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO KhachHang (makh, tenkh, diachi, dienthoai) VALUES (@makh, @tenkh, @diachi, @dienthoai)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@makh", txt_makh.Text);
                    cmd.Parameters.AddWithValue("@tenkh", txt_tenkh.Text);
                    cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);
                    cmd.Parameters.AddWithValue("@dienthoai", soDienThoai);

                    cmd.ExecuteNonQuery();
                }

                // Tải lại dữ liệu sau khi thêm
                LoadData();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu nhập
                if (string.IsNullOrWhiteSpace(txt_makh.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã khách hàng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_tenkh.Text) || string.IsNullOrWhiteSpace(txt_diachi.Text) ||
                    string.IsNullOrWhiteSpace(txt_sdt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_sdt.Text, out int soDienThoai))
                {
                    MessageBox.Show("Số điện thoại phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thực hiện sửa dữ liệu
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    conn.Open();
                    string query = "UPDATE KhachHang SET tenkh = @tenkh, diachi = @diachi, dienthoai = @dienthoai WHERE makh = @makh";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@makh", txt_makh.Text);
                    cmd.Parameters.AddWithValue("@tenkh", txt_tenkh.Text);
                    cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);
                    cmd.Parameters.AddWithValue("@dienthoai", soDienThoai);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        LoadData();
                        MessageBox.Show("Sửa thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng với mã đã nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu nhập
                if (string.IsNullOrWhiteSpace(txt_makh.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã khách hàng cần xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận xoá
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xoá khách hàng này không?", "Xác nhận xoá",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                // Thực hiện xoá dữ liệu
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM KhachHang WHERE makh = @makh";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@makh", txt_makh.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        LoadData();
                        MessageBox.Show("Xoá khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng với mã đã nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgv_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_khachhang.Rows[e.RowIndex];
                txt_makh.Text = row.Cells["makh"].Value.ToString();
                txt_tenkh.Text = row.Cells["tenkh"].Value.ToString();
                txt_diachi.Text = row.Cells["diachi"].Value.ToString();
                txt_sdt.Text = row.Cells["dienthoai"].Value.ToString();
            }
            

        }
        private void dgv_khachhang_Leave(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void dgv_khachhang_MouseLeave(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            txt_makh.Clear();
            txt_tenkh.Clear();
            txt_diachi.Clear();
            txt_sdt.Clear();
        }

        private void btn_xemalltop_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    conn.Open();
                    string query = "EXEC sp_SapXepKhachHangTheoDoanhThu";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv_khachhang.DataSource = dt; // Hiển thị danh sách khách hàng
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xemtop_Click(object sender, EventArgs e)
        {
             try
            {
                if (string.IsNullOrWhiteSpace(txt_makh1.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    conn.Open();
                    string query = "EXEC sp_TimThuHangKhachHang @makh";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@makh", txt_makh1.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int topRank = reader.IsDBNull(0) ? 0 : Convert.ToInt32(reader[0]);
                            decimal tongDoanhThu = reader.IsDBNull(1) ? 0 : Convert.ToDecimal(reader[1]);

                            MessageBox.Show($"Khách hàng thuộc top {topRank} với tổng doanh thu: {tongDoanhThu:N0} VNĐ.",
                                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
}
