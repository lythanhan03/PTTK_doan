using PTTK.Ketnoi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string maHoaDon = txt_mahd.Text.Trim();

            if (string.IsNullOrEmpty(maHoaDon))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    conn.Open();

                    // Câu lệnh SQL để tìm kiếm
                    string query = "SELECT * FROM ChiTietHD WHERE mahoadon = @mahoadon";

                    using (SqlCommand command = new SqlCommand(query, conn)) // Đổi từ "connection" thành "conn"
                    {
                        // Thêm tham số
                        command.Parameters.AddWithValue("@mahoadon", maHoaDon);

                        // Đọc dữ liệu từ cơ sở dữ liệu
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Hiển thị dữ liệu lên DataGridView
                        dgv_chitiethd.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDatachitiethd()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM ChiTietHD";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_chitiethd.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void btn_them_CTHD_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO ChiTietHD (machitiethd, mahoadon, masach, soluong) VALUES (@machitiethd, @mahoadon, @masach, @soluong)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@machitiethd", txt_macthd.Text);
                cmd.Parameters.AddWithValue("@mahoadon", txt_mahd.Text);
                cmd.Parameters.AddWithValue("@masach", txt_masach.Text);
                cmd.Parameters.AddWithValue("@soluong", int.Parse(txt_soluong.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                LoadDatachitiethd();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "UPDATE ChiTietHD SET mahoadon = @mahoadon, masach = @masach, soluong = @soluong WHERE machitiethd = @machitiethd";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@machitiethd", txt_macthd.Text);
                cmd.Parameters.AddWithValue("@mahoadon", txt_mahd.Text);
                cmd.Parameters.AddWithValue("@masach", txt_masach.Text);
                cmd.Parameters.AddWithValue("@soluong", int.Parse(txt_soluong.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!");
                LoadDatachitiethd();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "DELETE FROM ChiTietHD WHERE machitiethd = @machitiethd";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@machitiethd", txt_macthd.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                LoadDatachitiethd();
            }
        }

       
        private void dgv_chitiethd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_chitiethd.Rows[e.RowIndex];
                txt_macthd.Text = row.Cells["machitiethd"].Value.ToString();
                txt_mahd.Text = row.Cells["mahoadon"].Value.ToString();
                txt_masach.Text = row.Cells["masach"].Value.ToString();
                txt_soluong.Text = row.Cells["soluong"].Value.ToString();
            }

        }
        private void dgv_chitiethd_Leave(object sender, EventArgs e)
        {
            ClearTextBoxes1();
        }

        private void dgv_chitiethd_MouseLeave(object sender, EventArgs e)
        {
            ClearTextBoxes1();
        }
        private void ClearTextBoxes1()
        {
            txt_macthd.Clear();
            txt_mahd.Clear();
            txt_masach.Clear();
            txt_soluong.Clear();
        }

        private void btn_taohoadon_Click(object sender, EventArgs e)
        {
            string mahoadon = txt_mahd.Text; // Người dùng nhập mã hóa đơn
            string manv = txt_manv.Text; // Nhập mã nhân viên từ người dùng
            string makh = txt_makh.Text; // Nhập mã khách hàng từ người dùng
            DateTime ngaymuahang = DateTime.Now; // Ngày mua hàng tự động lấy ngày giờ hiện tại

            // Kiểm tra xem mã hóa đơn đã tồn tại chưa
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM HoaDon WHERE mahoadon = @mahoadon";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@mahoadon", mahoadon);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại, vui lòng nhập mã khác.");
                }
                else
                {
                    // Thêm dữ liệu vào bảng HoaDon
                    string query = "INSERT INTO HoaDon (mahoadon, manv, makh, ngaymuahang, tongtien) " +
                                   "VALUES (@mahoadon, @manv, @makh, @ngaymuahang, 0)"; // tongtien là 0 khi tạo hóa đơn mới
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@mahoadon", mahoadon);
                    cmd.Parameters.AddWithValue("@manv", manv);
                    cmd.Parameters.AddWithValue("@makh", makh);
                    cmd.Parameters.AddWithValue("@ngaymuahang", ngaymuahang);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo hóa đơn mới thành công!");
                    LoadHoaDonData();
                }
            }
        }

        private void btn_capnhathd_Click(object sender, EventArgs e)
        {
            string mahoadon = txt_mahd.Text; // Lấy mã hóa đơn từ textbox

            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();

                // Gọi stored procedure CalculateTotalAmount
                SqlCommand cmd = new SqlCommand("TongTienHoaDon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahoadon", mahoadon);

                // Thực thi và lấy kết quả trả về (tổng tiền)
                var result = cmd.ExecuteScalar();

                // Kiểm tra nếu có giá trị trả về
                if (result != DBNull.Value)
                {
                    int tongtien = Convert.ToInt32(result);
                    MessageBox.Show("Tổng tiền hóa đơn: " + tongtien.ToString("C"));

                    // Cập nhật lại dữ liệu trên DataGridView nếu cần
                    LoadHoaDonData();
                }
                else
                {
                    MessageBox.Show("Không có chi tiết hóa đơn cho mã hóa đơn này!");
                }
            }
        }
        private void LoadHoaDonData()
        {
            // Tải dữ liệu hóa đơn từ bảng HoaDon và hiển thị lên DataGridView
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM HoaDon";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Gán dữ liệu vào DataGridView
                dgv_hoadon2.DataSource = dt;
            }
        }
    }
}

