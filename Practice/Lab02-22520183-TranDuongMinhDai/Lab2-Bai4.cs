using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Lab2_22520183_TranDuongMinhDai
{
    public partial class Lab2_Bai4 : Form
    {
        public Lab2_Bai4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhapSV nhapSV = new NhapSV();
            nhapSV.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txtUrl = "F:\\1.UIT\\NT106-Basic Network Programing\\Practice\\Lab2-22520183-TranDuongMinhDai\\input.txt";

            using (StreamReader sr = new StreamReader(txtUrl))
            {
                // Khởi tạo excel
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

                string[] content = sr.ReadToEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                // Ghi header cho file Excel
                string[] headers = { "MSSV", "Họ và tên", "Điện thoại", "Điểm Toán", "Điểm Văn", "Điểm Trung bình" };
                for (int col = 0; col < headers.Length; col++)
                {
                    worksheet.Cells[1, col + 1] = headers[col];
                }

                // Ghi thông tin sinh viên vào file Excel
                for (int row = 0; row < content.Length; row++)
                {
                    string[] studentInfo = content[row].Split(';');
                    for (int col = 0; col < studentInfo.Length; col++)
                    {
                        worksheet.Cells[row + 2, col + 1] = studentInfo[col];
                    }
                    double diemToan = double.Parse(studentInfo[3]);
                    double diemVan = double.Parse(studentInfo[4]);
                    double diemTrungBinh = (diemToan + diemVan) / 2;
                    worksheet.Cells[row + 2, 6] = diemTrungBinh;
                }
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                sfd.FileName = "students.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    workbook.Close();
                    excelApp.Quit();

                    MessageBox.Show("File Excel đã được lưu thành công.");
                }

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string url = ofd.FileName;
                displayExcel(url);


            }

        }
        private void displayExcel(string filePath)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWorkbook = null;
            Excel.Worksheet excelWorksheet = null;
            Excel.Range range = null;

            try
            {
                excelWorkbook = excelApp.Workbooks.Open(filePath);
                excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];
                range = excelWorksheet.UsedRange;

                DataTable dt = new DataTable();

                for (int i = 1; i <= range.Columns.Count; i++)
                {
                    dt.Columns.Add(Convert.ToString((range.Cells[1, i] as Excel.Range).Value));
                }

                for (int i = 2; i <= range.Rows.Count; i++)
                {
                    DataRow row = dt.NewRow();
                    for (int j = 1; j <= range.Columns.Count; j++)
                    {
                        row[j - 1] = Convert.ToString((range.Cells[i, j] as Excel.Range).Value);
                    }
                    dt.Rows.Add(row);
                }

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
                // Clean memory
                Marshal.ReleaseComObject(range);
                Marshal.ReleaseComObject(excelWorksheet);
                excelWorkbook.Close();
                Marshal.ReleaseComObject(excelWorkbook);
                excelApp.Quit();
                Marshal.ReleaseComObject(excelApp);
            
        }
    } 
}
