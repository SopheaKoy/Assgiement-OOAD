namespace Student_Management
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnReg = new Button();
            btnSearch = new Button();
            btnStatistics = new Button();
            lab_register = new Label();
            lab_statistics = new Label();
            lab_search = new Label();
            printDialog1 = new PrintDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 129, 220);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 63);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter Medium", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(245, 14);
            label1.Name = "label1";
            label1.Size = new Size(569, 36);
            label1.TabIndex = 0;
            label1.Text = "STUDENT MANAGEMENTS  SYSTEM";
            label1.Click += label1_Click_1;
            // 
            // btnReg
            // 
            btnReg.BackColor = SystemColors.ButtonHighlight;
            btnReg.FlatStyle = FlatStyle.Popup;
            btnReg.Image = (Image)resources.GetObject("btnReg.Image");
            btnReg.Location = new Point(243, 134);
            btnReg.Margin = new Padding(3, 2, 3, 2);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(197, 145);
            btnReg.TabIndex = 1;
            btnReg.UseVisualStyleBackColor = false;
            btnReg.Click += btnReg_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ButtonHighlight;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(450, 312);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(197, 145);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.BackColor = SystemColors.ButtonHighlight;
            btnStatistics.FlatStyle = FlatStyle.Popup;
            btnStatistics.Image = (Image)resources.GetObject("btnStatistics.Image");
            btnStatistics.Location = new Point(657, 134);
            btnStatistics.Margin = new Padding(3, 2, 3, 2);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(197, 145);
            btnStatistics.TabIndex = 3;
            btnStatistics.UseVisualStyleBackColor = false;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // lab_register
            // 
            lab_register.AutoSize = true;
            lab_register.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_register.Location = new Point(262, 287);
            lab_register.Name = "lab_register";
            lab_register.Size = new Size(153, 19);
            lab_register.TabIndex = 4;
            lab_register.Text = "Register Student";
            // 
            // lab_statistics
            // 
            lab_statistics.AutoSize = true;
            lab_statistics.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_statistics.Location = new Point(648, 287);
            lab_statistics.Name = "lab_statistics";
            lab_statistics.Size = new Size(206, 19);
            lab_statistics.TabIndex = 5;
            lab_statistics.Text = "Statistics Management";
            // 
            // lab_search
            // 
            lab_search.AutoSize = true;
            lab_search.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_search.Location = new Point(472, 467);
            lab_search.Name = "lab_search";
            lab_search.Size = new Size(141, 19);
            lab_search.TabIndex = 6;
            lab_search.Text = "Search Student";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1104, 561);
            Controls.Add(lab_search);
            Controls.Add(lab_statistics);
            Controls.Add(lab_register);
            Controls.Add(btnStatistics);
            Controls.Add(btnSearch);
            Controls.Add(btnReg);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "D A S H B O A R D";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnReg;
        private Button btnSearch;
        private Button btnStatistics;
        private Label lab_register;
        private Label lab_statistics;
        private Label lab_search;
        private PrintDialog printDialog1;
    }
}