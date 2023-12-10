namespace Student_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //btn login
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "admin" && txt_password.Text == "123")
            {
                // navigate to the dashboard form
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            txt_password.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
