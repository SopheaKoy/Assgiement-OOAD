namespace Student_Management
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            label3 = new Label();
            btn_login = new Button();
            panel1 = new Panel();
            btnCancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 129, 220);
            label1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(85, 116);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 0;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 129, 220);
            label2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(85, 188);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 1;
            label2.Text = "password";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.Location = new Point(224, 114);
            txt_username.Margin = new Padding(3, 2, 3, 2);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(198, 36);
            txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(224, 185);
            txt_password.Margin = new Padding(3, 2, 3, 2);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(198, 36);
            txt_password.TabIndex = 3;
            txt_password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 129, 220);
            label3.Font = new Font("Poppins SemiBold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(97, 23);
            label3.Name = "label3";
            label3.Size = new Size(312, 62);
            label3.TabIndex = 4;
            label3.Text = "L O G I N   F O R M";
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.FromArgb(0, 129, 220);
            btn_login.Location = new Point(287, 296);
            btn_login.Margin = new Padding(3, 2, 3, 2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(135, 50);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 129, 220);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_login);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 435);
            panel1.TabIndex = 6;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(85, 296);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(135, 50);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 435);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Enter += button1_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label3;
        private Button btn_login;
        private Panel panel1;
        private Button btnCancel;
    }
}
