using System.Data;
using System.Data.SqlClient;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSql))
                {
                    connection.Open();

                    // Retrieve the current maximum stu_id
                    string getMaxIdQuery = "SELECT MAX(stu_id) FROM students";

                    using (SqlCommand getMaxIdCmd = new SqlCommand(getMaxIdQuery, connection))
                    {
                        object result = getMaxIdCmd.ExecuteScalar();

                        int currentMaxId = result == DBNull.Value ? 0 : Convert.ToInt32(result);

                        // Increment the ID
                        int newStuId = currentMaxId + 1;

                        // Show the newStuId on txt_stuid
                        txt_stuid.Text = newStuId.ToString();

                        string query = "INSERT INTO students (stu_id, stu_name, stu_gender, stu_phone, stu_province, stu_dob) " +
                                        "VALUES (@stu_id, @stu_name, @stu_gender, @stu_phone, @stu_province, @stu_dob)";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@stu_id", txt_stuid.Text);
                            cmd.Parameters.AddWithValue("@stu_name", txt_stuname.Text);
                            cmd.Parameters.AddWithValue("@stu_gender", gender);
                            cmd.Parameters.AddWithValue("@stu_phone", txt_stuphone.Text);
                            cmd.Parameters.AddWithValue("@stu_province", txt_stupro.Text);
                            cmd.Parameters.AddWithValue("@stu_dob", date_dob.Value);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Add student successfully!");
                txt_stuname.Clear();
                txt_stupro.Clear();
                txt_stuphone.Clear();
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



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSql))
                {
                    connection.Open();
                    string query = "UPDATE students SET stu_name = @stu_name, stu_gender = @stu_gender, stu_phone = @stu_phone, stu_province = @stu_province, stu_dob = @stu_dob WHERE stu_id = @stu_id";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        int selectedIndex = dataGrid.CurrentCell.RowIndex;
                        string stuName = dataGrid["stu_name", selectedIndex].Value.ToString();
                        string stuGender = dataGrid["stu_gender", selectedIndex].Value.ToString();
                        string stuPhone = dataGrid["stu_phone", selectedIndex].Value.ToString();
                        string stuProvince = dataGrid["stu_province", selectedIndex].Value.ToString();
                        int stuId = Convert.ToInt32(dataGrid["stu_id", selectedIndex].Value);
                        DateTime stuDob = Convert.ToDateTime(dataGrid["stu_dob", selectedIndex].Value);

                        cmd.Parameters.AddWithValue("@stu_id", txt_stuid.Text);
                        cmd.Parameters.AddWithValue("@stu_name", txt_stuname.Text);
                        cmd.Parameters.AddWithValue("@stu_gender", gender);
                        cmd.Parameters.AddWithValue("@stu_phone", txt_stuphone.Text);
                        cmd.Parameters.AddWithValue("@stu_province", txt_stupro.Text);
                        cmd.Parameters.AddWithValue("@stu_dob", date_dob.Value);

                        cmd.ExecuteNonQuery();
                        // auto load
                        txt_stuid.Clear();
                        txt_stuname.Clear();
                        txt_stupro.Clear();
                        txt_stuphone.Clear();
                        date_dob.Value = System.DateTime.Now;
                        errorProvider.Clear();
                        LaodData();

                        // Add parameters for other fields (stu_phone, stu_province, stu_dob) as needed
                    }
                }
                MessageBox.Show("Student updated successfully!", "Success update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred : {ex.Message}", "Error update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void radio_male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void radio_female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
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

                txt_stuid.Text = row.Cells["stu_id"].Value.ToString();
                txt_stuname.Text = row.Cells["stu_name"].Value.ToString();
                txt_stupro.Text = row.Cells["stu_province"].Value.ToString();
                txt_stuphone.Text = row.Cells["stu_phone"].Value.ToString();
            }
        }

        private void Student_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Move to the next control in the tab order
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }
    }
}
