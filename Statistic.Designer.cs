namespace Student_Management
{
    partial class Statistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btn_export = new Button();
            btn_export_pdf = new Button();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(10, 9);
            chart.Margin = new Padding(3, 2, 3, 2);
            chart.Name = "chart";
            chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(435, 487);
            chart.TabIndex = 0;
            chart.Text = "chart";
            // 
            // btn_export
            // 
            btn_export.BackColor = SystemColors.Window;
            btn_export.FlatAppearance.BorderSize = 0;
            btn_export.FlatStyle = FlatStyle.Popup;
            btn_export.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_export.ForeColor = Color.FromArgb(0, 129, 220);
            btn_export.Location = new Point(903, 421);
            btn_export.Margin = new Padding(9, 8, 9, 8);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(161, 57);
            btn_export.TabIndex = 6;
            btn_export.Text = "Export To Excel";
            btn_export.UseVisualStyleBackColor = false;
            btn_export.Click += btn_export_Click;
            // 
            // btn_export_pdf
            // 
            btn_export_pdf.BackColor = SystemColors.Window;
            btn_export_pdf.FlatAppearance.BorderSize = 0;
            btn_export_pdf.FlatStyle = FlatStyle.Popup;
            btn_export_pdf.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_export_pdf.ForeColor = Color.FromArgb(0, 129, 220);
            btn_export_pdf.Location = new Point(903, 326);
            btn_export_pdf.Margin = new Padding(9, 8, 9, 8);
            btn_export_pdf.Name = "btn_export_pdf";
            btn_export_pdf.Size = new Size(161, 57);
            btn_export_pdf.TabIndex = 7;
            btn_export_pdf.Text = "Export To PDF";
            btn_export_pdf.UseVisualStyleBackColor = false;
            // 
            // Statistic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1104, 505);
            Controls.Add(btn_export_pdf);
            Controls.Add(btn_export);
            Controls.Add(chart);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Statistic";
            Text = "Statistic";
            Load += Statistic_Load_1;
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Button btn_export;
        private Button btn_export_pdf;
    }
}