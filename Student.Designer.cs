
namespace Student_Management
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnAdd = new Button();
            lab_stuname = new Label();
            lab_stuphone = new Label();
            lab_pro = new Label();
            lab_stuid = new Label();
            lab_dob = new Label();
            lab_gender = new Label();
            txt_stuid = new TextBox();
            txt_stuname = new TextBox();
            txt_stuphone = new TextBox();
            txt_stupro = new TextBox();
            radio_female = new RadioButton();
            radio_male = new RadioButton();
            date_dob = new DateTimePicker();
            btnUpdate = new Button();
            dataGrid = new DataGridView();
            btnBack = new Button();
            dataGridViewBindingSource = new BindingSource(components);
            dataGridViewTextBoxEditingControlBindingSource = new BindingSource(components);
            dataGridViewComboBoxEditingControlBindingSource = new BindingSource(components);
            panel1 = new Panel();
            btn_clean = new Button();
            label1 = new Label();
            txt_subject = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTextBoxEditingControlBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComboBoxEditingControlBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Window;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(0, 129, 220);
            btnAdd.Location = new Point(943, 467);
            btnAdd.Margin = new Padding(9, 8, 9, 8);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 50);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lab_stuname
            // 
            lab_stuname.AutoSize = true;
            lab_stuname.BackColor = Color.FromArgb(0, 129, 220);
            lab_stuname.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lab_stuname.ForeColor = Color.Transparent;
            lab_stuname.Location = new Point(50, 116);
            lab_stuname.Name = "lab_stuname";
            lab_stuname.Size = new Size(177, 34);
            lab_stuname.TabIndex = 10;
            lab_stuname.Text = "Student Name :";
            // 
            // lab_stuphone
            // 
            lab_stuphone.AutoSize = true;
            lab_stuphone.BackColor = Color.FromArgb(0, 129, 220);
            lab_stuphone.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lab_stuphone.ForeColor = Color.Transparent;
            lab_stuphone.Location = new Point(50, 188);
            lab_stuphone.Name = "lab_stuphone";
            lab_stuphone.Size = new Size(181, 34);
            lab_stuphone.TabIndex = 11;
            lab_stuphone.Text = "Phone Number :";
            // 
            // lab_pro
            // 
            lab_pro.AutoSize = true;
            lab_pro.BackColor = Color.FromArgb(0, 129, 220);
            lab_pro.Font = new Font("Inter Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lab_pro.ForeColor = Color.Transparent;
            lab_pro.Location = new Point(55, 261);
            lab_pro.Name = "lab_pro";
            lab_pro.Size = new Size(109, 23);
            lab_pro.TabIndex = 22;
            lab_pro.Text = "Province :";
            // 
            // lab_stuid
            // 
            lab_stuid.AutoSize = true;
            lab_stuid.BackColor = Color.FromArgb(0, 129, 220);
            lab_stuid.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lab_stuid.ForeColor = Color.Transparent;
            lab_stuid.Location = new Point(50, 51);
            lab_stuid.Name = "lab_stuid";
            lab_stuid.Size = new Size(134, 34);
            lab_stuid.TabIndex = 31;
            lab_stuid.Text = "Student ID :";
            // 
            // lab_dob
            // 
            lab_dob.AutoSize = true;
            lab_dob.BackColor = Color.FromArgb(0, 129, 220);
            lab_dob.Font = new Font("Inter Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lab_dob.ForeColor = Color.Transparent;
            lab_dob.Location = new Point(561, 108);
            lab_dob.Name = "lab_dob";
            lab_dob.Size = new Size(149, 23);
            lab_dob.TabIndex = 18;
            lab_dob.Text = "Date of Birth :";
            lab_dob.Click += lab_dob_Click;
            // 
            // lab_gender
            // 
            lab_gender.AutoSize = true;
            lab_gender.BackColor = Color.FromArgb(0, 129, 220);
            lab_gender.Font = new Font("Inter Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lab_gender.ForeColor = Color.Transparent;
            lab_gender.Location = new Point(564, 51);
            lab_gender.Name = "lab_gender";
            lab_gender.Size = new Size(94, 23);
            lab_gender.TabIndex = 32;
            lab_gender.Text = "Gender :";
            lab_gender.Click += lab_gender_Click;
            // 
            // txt_stuid
            // 
            txt_stuid.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_stuid.Location = new Point(243, 47);
            txt_stuid.Margin = new Padding(3, 2, 3, 2);
            txt_stuid.Name = "txt_stuid";
            txt_stuid.Size = new Size(254, 36);
            txt_stuid.TabIndex = 12;
            // 
            // txt_stuname
            // 
            txt_stuname.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_stuname.Location = new Point(243, 116);
            txt_stuname.Margin = new Padding(3, 2, 3, 2);
            txt_stuname.Name = "txt_stuname";
            txt_stuname.Size = new Size(254, 36);
            txt_stuname.TabIndex = 13;
            // 
            // txt_stuphone
            // 
            txt_stuphone.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_stuphone.Location = new Point(243, 184);
            txt_stuphone.Margin = new Padding(3, 2, 3, 2);
            txt_stuphone.Name = "txt_stuphone";
            txt_stuphone.Size = new Size(254, 36);
            txt_stuphone.TabIndex = 14;
            // 
            // txt_stupro
            // 
            txt_stupro.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_stupro.Location = new Point(243, 261);
            txt_stupro.Margin = new Padding(3, 2, 3, 2);
            txt_stupro.Name = "txt_stupro";
            txt_stupro.Size = new Size(254, 36);
            txt_stupro.TabIndex = 15;
            // 
            // radio_female
            // 
            radio_female.AutoSize = true;
            radio_female.BackColor = Color.FromArgb(0, 129, 220);
            radio_female.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radio_female.ForeColor = Color.Transparent;
            radio_female.Location = new Point(793, 50);
            radio_female.Margin = new Padding(3, 2, 3, 2);
            radio_female.Name = "radio_female";
            radio_female.Size = new Size(78, 25);
            radio_female.TabIndex = 17;
            radio_female.TabStop = true;
            radio_female.Text = "Female";
            radio_female.UseVisualStyleBackColor = false;
            radio_female.CheckedChanged += radio_female_CheckedChanged;
            // 
            // radio_male
            // 
            radio_male.AutoSize = true;
            radio_male.BackColor = Color.FromArgb(0, 129, 220);
            radio_male.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radio_male.ForeColor = Color.Transparent;
            radio_male.Location = new Point(700, 49);
            radio_male.Margin = new Padding(3, 2, 3, 2);
            radio_male.Name = "radio_male";
            radio_male.Size = new Size(62, 25);
            radio_male.TabIndex = 16;
            radio_male.TabStop = true;
            radio_male.Text = "Male";
            radio_male.UseVisualStyleBackColor = false;
            radio_male.CheckedChanged += radio_male_CheckedChanged;
            // 
            // date_dob
            // 
            date_dob.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date_dob.Location = new Point(740, 104);
            date_dob.Margin = new Padding(3, 2, 3, 2);
            date_dob.Name = "date_dob";
            date_dob.Size = new Size(329, 29);
            date_dob.TabIndex = 19;
            date_dob.ValueChanged += date_dob_ValueChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Window;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.FromArgb(0, 129, 220);
            btnUpdate.Location = new Point(758, 467);
            btnUpdate.Margin = new Padding(9, 8, 9, 8);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 50);
            btnUpdate.TabIndex = 33;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGrid
            // 
            dataGrid.BackgroundColor = SystemColors.Window;
            dataGrid.ColumnHeadersHeight = 29;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid.Location = new Point(564, 155);
            dataGrid.Margin = new Padding(3, 2, 3, 2);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowTemplate.Height = 29;
            dataGrid.Size = new Size(514, 277);
            dataGrid.TabIndex = 34;
            dataGrid.CellClick += dataGrid_CellClick;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Window;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(0, 129, 220);
            btnBack.Location = new Point(564, 467);
            btnBack.Margin = new Padding(9, 8, 9, 8);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(135, 50);
            btnBack.TabIndex = 35;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // dataGridViewBindingSource
            // 
            dataGridViewBindingSource.DataSource = typeof(DataGridView);
            // 
            // dataGridViewTextBoxEditingControlBindingSource
            // 
            dataGridViewTextBoxEditingControlBindingSource.DataSource = typeof(DataGridViewTextBoxEditingControl);
            // 
            // dataGridViewComboBoxEditingControlBindingSource
            // 
            dataGridViewComboBoxEditingControlBindingSource.DataSource = typeof(DataGridViewComboBoxEditingControl);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 129, 220);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_subject);
            panel1.Controls.Add(btn_clean);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_stuid);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(date_dob);
            panel1.Controls.Add(lab_dob);
            panel1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 562);
            panel1.TabIndex = 36;
            // 
            // btn_clean
            // 
            btn_clean.BackColor = SystemColors.Window;
            btn_clean.FlatAppearance.BorderSize = 0;
            btn_clean.FlatStyle = FlatStyle.Popup;
            btn_clean.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clean.ForeColor = Color.FromArgb(0, 129, 220);
            btn_clean.Location = new Point(943, 45);
            btn_clean.Margin = new Padding(9, 8, 9, 8);
            btn_clean.Name = "btn_clean";
            btn_clean.Size = new Size(126, 36);
            btn_clean.TabIndex = 36;
            btn_clean.Text = "CLEAR";
            btn_clean.UseVisualStyleBackColor = false;
            btn_clean.Click += btn_clean_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(243, 50);
            label1.Name = "label1";
            label1.Size = new Size(0, 34);
            label1.TabIndex = 13;
            // 
            // txt_subject
            // 
            txt_subject.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_subject.Location = new Point(243, 343);
            txt_subject.Margin = new Padding(3, 2, 3, 2);
            txt_subject.Name = "txt_subject";
            txt_subject.Size = new Size(254, 36);
            txt_subject.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 129, 220);
            label2.Font = new Font("Inter Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(50, 351);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 37;
            label2.Text = "Subject :";
            label2.Click += label2_Click;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1104, 561);
            Controls.Add(dataGrid);
            Controls.Add(lab_gender);
            Controls.Add(lab_stuid);
            Controls.Add(lab_pro);
            Controls.Add(lab_stuphone);
            Controls.Add(lab_stuname);
            Controls.Add(radio_female);
            Controls.Add(radio_male);
            Controls.Add(txt_stupro);
            Controls.Add(txt_stuphone);
            Controls.Add(txt_stuname);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "S T U D E N T";
            Load += Student_Load;
            KeyPress += Student_KeyPress;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTextBoxEditingControlBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComboBoxEditingControlBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lab_dob_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion


        private Button btnAdd;
        private Label lab_stuname;
        private Label lab_stuphone;
        private Label lab_pro;
        private Label lab_stuid;
        private Label lab_gender;
        private Label lab_dob;
        private TextBox txt_stupro;
        private TextBox txt_stuid;
        private TextBox txt_stuname;
        private TextBox txt_stuphone;
        private RadioButton radio_male;
        private RadioButton radio_female;
        private DateTimePicker date_dob;
        private Button btnUpdate;
        private DataGridView dataGrid;
        private Button btnBack;
        private BindingSource dataGridViewBindingSource;
        private BindingSource dataGridViewTextBoxEditingControlBindingSource;
        private BindingSource dataGridViewComboBoxEditingControlBindingSource;
        private Panel panel1;
        private Label label1;
        private Button btn_clean;
        private TextBox txt_subject;
        private Label label2;
    }
}