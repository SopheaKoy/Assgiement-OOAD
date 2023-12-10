using DocumentFormat.OpenXml.Spreadsheet;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Student_Management
{
    public partial class Student : Form
    {

        // my connection sophea
        public string connectionSql = ("Data Source=DESKTOP-SC4FQ10\\SQLEXPRESS;Initial Catalog=students;Integrated Security=True");

        // public string connectionSql = ("Data Source=PANHA\\SQLEXPRESS;Initial Catalog=db_student;Integrated Security=True;Persist Security Info=False;Pooling=False;");
        private ErrorProvider errorProvider;
        string gender;
        private Dashboard prevForm;

        public Student()
        {
            InitializeComponent();
            dataGrid_CellContentClick(components, null);
            errorProvider = new ErrorProvider();
            //errorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

            // for prev form
            this.prevForm = prevForm;

            // key press 
            txt_stuid.KeyPress += Student_KeyPress;
            txt_stuname.KeyPress += Student_KeyPress;
            txt_stuphone.KeyPress += Student_KeyPress;
            txt_stupro.KeyPress += Student_KeyPress;
            radio_female.KeyPress += Radio_female_KeyPress;
        }

        private void Radio_female_KeyPress(object? sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void LaodData()
        {
            using (SqlConnection connection = new SqlConnection(connectionSql))
            {
                connection.Open();

                string query = "SELECT * FROM students";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGrid.DataSource = dataTable;
            }
            dataGrid.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        // Finsih on Add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSql))
                {
                    connection.Open();

                    // Retrieve the current maximum stu_id
                    string getMaxIdQuery = "SELECT MAX(ID) FROM students";

                    using (SqlCommand getMaxIdCmd = new SqlCommand(getMaxIdQuery, connection))
                    {
                        object result = getMaxIdCmd.ExecuteScalar();

                        int currentMaxId = result == DBNull.Value ? 0 : Convert.ToInt32(result);

                        // Increment the ID
                        int newStuId = currentMaxId + 1;

                        // Show the newStuId on txt_stuid
                        txt_stuid.Text = newStuId.ToString();



                        string query = "INSERT INTO students (ID, Name, Gender, Phone, Province, Subject, DOB, CreatedAt, Status) " +
               "VALUES (@ID, @Name, @Gender, @Phone, @Province, @Subject, @DOB, GETDATE(), @Status)";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@ID", newStuId);
                            cmd.Parameters.AddWithValue("@Name", txt_stuname.Text);
                            cmd.Parameters.AddWithValue("@Gender", gender); // Assuming 'gender' is already defined
                            cmd.Parameters.AddWithValue("@Phone", txt_stuphone.Text);
                            cmd.Parameters.AddWithValue("@Province", txt_stupro.Text);
                            cmd.Parameters.AddWithValue("@Subject", txt_subject.Text);
                            cmd.Parameters.AddWithValue("@DOB", date_dob.Value);
                            cmd.Parameters.AddWithValue("@Status", "True");

                            cmd.ExecuteNonQuery();
                        }

                    }
                }

                MessageBox.Show("Add student successfully!");
                txt_stuname.Clear();
                txt_stupro.Clear();
                txt_stuphone.Clear();
                txt_subject.Clear();
                date_dob.Value = System.DateTime.Now;
                errorProvider.Clear();
                LaodData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                errorProvider.SetError(txt_stuname, "Student Name is required");
                errorProvider.SetError(txt_stupro, "Student Province is required");
                errorProvider.SetError(txt_stuphone, "Student Phone is required");
            }
        }


        // Button update 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSql))
                {
                    connection.Open();

                    string query = "UPDATE students " +
                                   "SET Name = @Name, " +
                                   "    Gender = @Gender, " +
                                   "    Phone = @Phone, " +
                                   "    Province = @Province, " +
                                   "    Subject = @Subject, " +
                                   "    DOB = @DOB " +
                                   "WHERE ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        int selectedIndex = dataGrid.CurrentCell.RowIndex;

                        // Use the null-conditional operator ?. to prevent null reference exceptions
                        string stuName = dataGrid["Name", selectedIndex].Value?.ToString();
                        string stuGender = dataGrid["Gender", selectedIndex].Value?.ToString();
                        string stuPhone = dataGrid["Phone", selectedIndex].Value?.ToString();
                        string stuProvince = dataGrid["Province", selectedIndex].Value?.ToString();
                        string stuSubject = dataGrid["Subject", selectedIndex].Value?.ToString();
                        int stuId = Convert.ToInt32(dataGrid["ID", selectedIndex].Value);
                        DateTime stuDob = Convert.ToDateTime(dataGrid["DOB", selectedIndex].Value);

                        // Clear any previous error indications
                        errorProvider.Clear();

                        // Set parameters for the update
                        cmd.Parameters.AddWithValue("@ID", stuId);
                        cmd.Parameters.AddWithValue("@Name", txt_stuname.Text);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Phone", txt_stuphone.Text); // Corrected line
                        cmd.Parameters.AddWithValue("@Province", txt_stupro.Text);
                        cmd.Parameters.AddWithValue("@Subject", txt_subject.Text);
                        cmd.Parameters.AddWithValue("@DOB", date_dob.Value);

                        // Debug statement to check the number of rows affected
                        cmd.ExecuteNonQuery();
                       
                        errorProvider.Clear();

                        // Reload data into the DataGridView
                        LaodData(); // Assuming 'LaodData' is a method to reload data into the DataGridView
                    }
                }



                MessageBox.Show("Student updated successfully!", "Success update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void radio_male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radio_female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs? e)
        {
            using (SqlConnection connection = new SqlConnection(connectionSql))
            {
                connection.Open();

                string query = "SELECT * FROM students"; // Replace YourTableName with your actual table name

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGrid.DataSource = dataTable;
            }
        }

        private void date_dob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lab_gender_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard student = new Dashboard();
            student.Show();

            // Show the previous form (DashboardForm)
            if (prevForm != null)
            {
                prevForm.Show();
            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];

                txt_stuid.Text = row.Cells["ID"].Value.ToString();
                txt_stuname.Text = row.Cells["Name"].Value.ToString();
                txt_stupro.Text = row.Cells["Province"].Value.ToString();
                txt_stuphone.Text = row.Cells["Phone"].Value.ToString();
                txt_subject.Text = row.Cells["Subject"].Value.ToString();
            }
        }

        private void Student_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Move to the next control in the tab order
                this.SelectNextControl((System.Windows.Forms.Control)sender, true, true, true, true);
            }
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            txt_stuid.Clear();
            txt_stuname.Clear();
            txt_stupro.Clear();
            txt_stuphone.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
