namespace Student_Management
{
    partial class Search
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
            txtSearch = new TextBox();
            btnBack = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            dvg1 = new DataGridView();
            dataGridViewBindingSource1 = new BindingSource(components);
            dataGridViewBindingSource = new BindingSource(components);
            dataGridViewTextBoxEditingControlBindingSource = new BindingSource(components);
            panel1 = new Panel();
            btn_refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dvg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTextBoxEditingControlBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.Location = new Point(665, 24);
            txtSearch.Margin = new Padding(26, 8, 9, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(210, 36);
            txtSearch.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(0, 129, 220);
            btnBack.Location = new Point(554, 489);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(135, 50);
            btnBack.TabIndex = 0;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(0, 129, 220);
            btnDelete.Location = new Point(740, 489);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 50);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.FromArgb(0, 129, 220);
            btnSearch.Location = new Point(931, 24);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(130, 35);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button3_Click;
            // 
            // dvg1
            // 
            dvg1.BackgroundColor = SystemColors.ButtonHighlight;
            dvg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg1.Location = new Point(126, 84);
            dvg1.Margin = new Padding(3, 2, 3, 2);
            dvg1.Name = "dvg1";
            dvg1.RowHeadersWidth = 51;
            dvg1.RowTemplate.Height = 29;
            dvg1.Size = new Size(749, 377);
            dvg1.TabIndex = 5;
            dvg1.CellContentClick += dvg1_CellContentClick;
            // 
            // dataGridViewBindingSource1
            // 
            dataGridViewBindingSource1.DataSource = typeof(DataGridView);
            // 
            // dataGridViewTextBoxEditingControlBindingSource
            // 
            dataGridViewTextBoxEditingControlBindingSource.DataSource = typeof(DataGridViewTextBoxEditingControl);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 129, 220);
            panel1.Controls.Add(btn_refresh);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(dvg1);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnBack);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1105, 561);
            panel1.TabIndex = 6;
            // 
            // btn_refresh
            // 
            btn_refresh.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_refresh.ForeColor = Color.FromArgb(0, 129, 220);
            btn_refresh.Location = new Point(931, 489);
            btn_refresh.Margin = new Padding(3, 2, 3, 2);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(135, 50);
            btn_refresh.TabIndex = 6;
            btn_refresh.Text = "REFRESH";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1104, 561);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Search";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "S E A R C H ";
            ((System.ComponentModel.ISupportInitialize)dvg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTextBoxEditingControlBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtSearch;
        private Button btnBack;
        private Button btnDelete;
        private Button btnSearch;
        private DataGridView dvg1;
        private BindingSource dataGridViewBindingSource1;
        private BindingSource dataGridViewBindingSource;
        private BindingSource dataGridViewTextBoxEditingControlBindingSource;
        private Panel panel1;
        private Button btn_refresh;
    }
}