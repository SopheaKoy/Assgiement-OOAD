using ClosedXML.Excel;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using DocumentFormat.OpenXml.Wordprocessing;


namespace Student_Management
{
    public partial class Statistic : Form
    {

        public string connectionSql = ("Data Source=DESKTOP-SC4FQ10\\SQLEXPRESS;Initial Catalog=students;Integrated Security=True");

        // public string connectionSql = ("Data Source=PANHA\\SQLEXPRESS;Initial Catalog=db_student;Integrated Security=True;Persist Security Info=False;Pooling=False;");

        public Statistic()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        public void ChartStatisticsClick(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionSql))
            {
                connection.Open();

                string query = "SELECT stu_gender, COUNT(*) AS RecordCount FROM students GROUP BY stu_gender";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                chart.DataSource = dataTable;

                chart.Series["Series1"].Points.DataBindXY(dataTable.Rows, "stu_gender", dataTable.Rows, "RecordCount");

                //chart.Series["Series1"].IsValueShownAsLabel = true;
            }
        }

        private void Statistic_Load_1(object sender, EventArgs e)
        {
            ChartStatisticsClick(sender, e);
        }


        // export as pdf
        //private void btn_export_pdf_Click(object sender, EventArgs e)
        //{

        //    iTextSharp.text.Document document = new iTextSharp.text.Document();

        //    document.

        //}

        // export as excel
        private void btn_export_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel WorkBook|*.xlsx", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            IXLWorksheet worksheet = wb.Worksheets.Add("StudentData");

                            // Export student data to the worksheet
                            ExportStudentDataToExcel(worksheet);

                            // Save the workbook to the specified file
                            wb.SaveAs(sfd.FileName);

                            MessageBox.Show("Export successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ExportStudentDataToExcel(IXLWorksheet worksheet)
        {
            using (SqlConnection connection = new SqlConnection(connectionSql))
            {
                connection.Open();

                string query = "SELECT stu_id, stu_name, stu_gender, stu_phone, stu_province, stu_dob FROM students";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Write column headers to the worksheet
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    worksheet.Cell(1, col + 1).Value = dataTable.Columns[col].ColumnName;
                }

                // Write data rows to the worksheet
                for (int row = 0; row < dataTable.Rows.Count; row++)
                {
                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        worksheet.Cell(row + 2, col + 1).Value = dataTable.Rows[row][col].ToString();
                    }
                }
            }
        }


    }

}

