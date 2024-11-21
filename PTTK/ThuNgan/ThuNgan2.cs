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
using Excel = Microsoft.Office.Interop.Excel;


namespace PTTK.ThuNgan
{
    public partial class ThuNgan2 : Form
    {
        public ThuNgan2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(txt_thang.Text);
            int nam = int.Parse(txt_nam.Text);

            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("BaoCaoDoanhThuTheoThang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Thang", thang);
                cmd.Parameters.AddWithValue("@Nam", nam);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgv_thungan2.DataSource = dt;
            }
        }

        private void btn_xuatexcel_Click(object sender, EventArgs e)
        {
            if (dgv_thungan2.Rows.Count > 0)
            {
                Excel.Application excel = new Excel.Application();
                Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = workbook.ActiveSheet;
                worksheet.Name = "Báo cáo doanh thu";

                // Xuất tiêu đề cột
                for (int i = 1; i < dgv_thungan2.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgv_thungan2.Columns[i - 1].HeaderText;
                }

                // Xuất dữ liệu
                for (int i = 0; i < dgv_thungan2.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_thungan2.Columns.Count; j++)
                    {
                        try
                        {
                            var cellValue = dgv_thungan2.Rows[i].Cells[j].Value;
                            worksheet.Cells[i + 2, j + 1] = cellValue == null ? "" : cellValue.ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi xuất dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                // Lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx",
                    Title = "Lưu báo cáo doanh thu"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Xuất báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Đóng Excel
                workbook.Close();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                excel.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btn_thoat_Click(object sender, EventArgs e)
        {
            chuongtrinh f = new chuongtrinh();
            f.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
    
