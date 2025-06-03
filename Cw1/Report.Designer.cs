namespace Cw1
{
    partial class Report
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.serviceNameRL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportL = new System.Windows.Forms.Label();
            this.dateFromL = new System.Windows.Forms.Label();
            this.dateToL = new System.Windows.Forms.Label();
            this.tableGV = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceNameTB = new System.Windows.Forms.TextBox();
            this.chartB = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateFromP = new System.Windows.Forms.DateTimePicker();
            this.dateToP = new System.Windows.Forms.DateTimePicker();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGV)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceNameRL
            // 
            this.serviceNameRL.AutoSize = true;
            this.serviceNameRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNameRL.Location = new System.Drawing.Point(50, 132);
            this.serviceNameRL.Name = "serviceNameRL";
            this.serviceNameRL.Size = new System.Drawing.Size(129, 24);
            this.serviceNameRL.TabIndex = 1;
            this.serviceNameRL.Text = "Service Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Location = new System.Drawing.Point(54, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1234, 3);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // reportL
            // 
            this.reportL.AutoSize = true;
            this.reportL.Font = new System.Drawing.Font("Broadway", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reportL.Location = new System.Drawing.Point(70, 44);
            this.reportL.Name = "reportL";
            this.reportL.Size = new System.Drawing.Size(146, 40);
            this.reportL.TabIndex = 0;
            this.reportL.Text = "Report";
            // 
            // dateFromL
            // 
            this.dateFromL.AutoSize = true;
            this.dateFromL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromL.Location = new System.Drawing.Point(50, 211);
            this.dateFromL.Name = "dateFromL";
            this.dateFromL.Size = new System.Drawing.Size(98, 24);
            this.dateFromL.TabIndex = 3;
            this.dateFromL.Text = "Date From";
            // 
            // dateToL
            // 
            this.dateToL.AutoSize = true;
            this.dateToL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToL.Location = new System.Drawing.Point(472, 211);
            this.dateToL.Name = "dateToL";
            this.dateToL.Size = new System.Drawing.Size(76, 24);
            this.dateToL.TabIndex = 5;
            this.dateToL.Text = "Date To";
            // 
            // tableGV
            // 
            this.tableGV.AllowUserToAddRows = false;
            this.tableGV.AllowUserToDeleteRows = false;
            this.tableGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGV.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableGV.Location = new System.Drawing.Point(54, 301);
            this.tableGV.Name = "tableGV";
            this.tableGV.ReadOnly = true;
            this.tableGV.Size = new System.Drawing.Size(756, 274);
            this.tableGV.TabIndex = 7;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // serviceNameTB
            // 
            this.serviceNameTB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serviceNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serviceNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNameTB.Location = new System.Drawing.Point(212, 129);
            this.serviceNameTB.Name = "serviceNameTB";
            this.serviceNameTB.ReadOnly = true;
            this.serviceNameTB.Size = new System.Drawing.Size(226, 29);
            this.serviceNameTB.TabIndex = 2;
            // 
            // chartB
            // 
            this.chartB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartB.Location = new System.Drawing.Point(1188, 598);
            this.chartB.Name = "chartB";
            this.chartB.Size = new System.Drawing.Size(100, 33);
            this.chartB.TabIndex = 9;
            this.chartB.Text = "Chart";
            this.chartB.UseVisualStyleBackColor = true;
            this.chartB.Click += new System.EventHandler(this.ChartB_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(860, 206);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(428, 369);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            this.chart1.Titles.Add(title1);
            // 
            // dateFromP
            // 
            this.dateFromP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromP.Location = new System.Drawing.Point(212, 213);
            this.dateFromP.Name = "dateFromP";
            this.dateFromP.Size = new System.Drawing.Size(226, 22);
            this.dateFromP.TabIndex = 18;
            // 
            // dateToP
            // 
            this.dateToP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToP.Location = new System.Drawing.Point(584, 213);
            this.dateToP.Name = "dateToP";
            this.dateToP.Size = new System.Drawing.Size(226, 22);
            this.dateToP.TabIndex = 19;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.searchBtn.Location = new System.Drawing.Point(710, 252);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(100, 33);
            this.searchBtn.TabIndex = 20;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.dateToP);
            this.Controls.Add(this.dateFromP);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chartB);
            this.Controls.Add(this.serviceNameTB);
            this.Controls.Add(this.tableGV);
            this.Controls.Add(this.dateToL);
            this.Controls.Add(this.dateFromL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reportL);
            this.Controls.Add(this.serviceNameRL);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Report";
            this.Text = "Report Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGV)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serviceNameRL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label reportL;
        private System.Windows.Forms.Label dateFromL;
        private System.Windows.Forms.Label dateToL;
        private System.Windows.Forms.DataGridView tableGV;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TextBox serviceNameTB;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button chartB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker dateFromP;
        private System.Windows.Forms.DateTimePicker dateToP;
        private System.Windows.Forms.Button searchBtn;
    }
}