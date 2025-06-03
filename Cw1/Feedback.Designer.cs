namespace Cw1
{
    partial class Feedback
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
            this.nameL = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.emailL = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.dateL = new System.Windows.Forms.Label();
            this.currentD = new System.Windows.Forms.Label();
            this.timeL = new System.Windows.Forms.Label();
            this.currentT = new System.Windows.Forms.Label();
            this.contactL = new System.Windows.Forms.Label();
            this.contactTB = new System.Windows.Forms.TextBox();
            this.logoL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearB = new System.Windows.Forms.Button();
            this.submitB = new System.Windows.Forms.Button();
            this.serviceNameCL = new System.Windows.Forms.Label();
            this.overallL = new System.Windows.Forms.Label();
            this.overallTB = new System.Windows.Forms.TextBox();
            this.dissatisfiedL = new System.Windows.Forms.Label();
            this.averageL = new System.Windows.Forms.Label();
            this.goodL = new System.Windows.Forms.Label();
            this.excellentL = new System.Windows.Forms.Label();
            this.criteriaL = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.criteriaS1 = new System.Windows.Forms.TableLayoutPanel();
            this.sNameCB = new System.Windows.Forms.ComboBox();
            this.headerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.retrieveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameL
            // 
            this.nameL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameL.Location = new System.Drawing.Point(35, 267);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(124, 20);
            this.nameL.TabIndex = 3;
            this.nameL.Text = "Customer Name";
            // 
            // nameTB
            // 
            this.nameTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(37, 293);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(283, 26);
            this.nameTB.TabIndex = 4;
            this.nameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // emailL
            // 
            this.emailL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailL.AutoSize = true;
            this.emailL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailL.Location = new System.Drawing.Point(35, 339);
            this.emailL.Name = "emailL";
            this.emailL.Size = new System.Drawing.Size(48, 20);
            this.emailL.TabIndex = 7;
            this.emailL.Text = "Email";
            // 
            // emailTB
            // 
            this.emailTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTB.Location = new System.Drawing.Point(37, 362);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(595, 26);
            this.emailTB.TabIndex = 8;
            this.emailTB.TextChanged += new System.EventHandler(this.EmailTB_TextChanged);
            // 
            // dateL
            // 
            this.dateL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateL.AutoSize = true;
            this.dateL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateL.Location = new System.Drawing.Point(1160, 59);
            this.dateL.Name = "dateL";
            this.dateL.Size = new System.Drawing.Size(43, 16);
            this.dateL.TabIndex = 9;
            this.dateL.Text = "Date :";
            // 
            // currentD
            // 
            this.currentD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentD.AutoSize = true;
            this.currentD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentD.Location = new System.Drawing.Point(1205, 59);
            this.currentD.Name = "currentD";
            this.currentD.Size = new System.Drawing.Size(0, 16);
            this.currentD.TabIndex = 10;
            // 
            // timeL
            // 
            this.timeL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeL.AutoSize = true;
            this.timeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeL.Location = new System.Drawing.Point(1160, 90);
            this.timeL.Name = "timeL";
            this.timeL.Size = new System.Drawing.Size(45, 16);
            this.timeL.TabIndex = 11;
            this.timeL.Text = "Time :";
            // 
            // currentT
            // 
            this.currentT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentT.AutoSize = true;
            this.currentT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentT.Location = new System.Drawing.Point(1205, 90);
            this.currentT.Name = "currentT";
            this.currentT.Size = new System.Drawing.Size(0, 16);
            this.currentT.TabIndex = 12;
            // 
            // contactL
            // 
            this.contactL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactL.AutoSize = true;
            this.contactL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactL.Location = new System.Drawing.Point(362, 270);
            this.contactL.Name = "contactL";
            this.contactL.Size = new System.Drawing.Size(65, 20);
            this.contactL.TabIndex = 5;
            this.contactL.Text = "Contact";
            // 
            // contactTB
            // 
            this.contactTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTB.Location = new System.Drawing.Point(366, 293);
            this.contactTB.MaxLength = 10;
            this.contactTB.Name = "contactTB";
            this.contactTB.Size = new System.Drawing.Size(267, 26);
            this.contactTB.TabIndex = 6;
            this.contactTB.TextChanged += new System.EventHandler(this.ContactTB_TextChanged);
            // 
            // logoL
            // 
            this.logoL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoL.AutoSize = true;
            this.logoL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoL.Location = new System.Drawing.Point(75, 59);
            this.logoL.Name = "logoL";
            this.logoL.Size = new System.Drawing.Size(458, 40);
            this.logoL.TabIndex = 0;
            this.logoL.Text = "Customer Feedback Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(42, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1261, 4);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // clearB
            // 
            this.clearB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearB.Location = new System.Drawing.Point(1181, 653);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(122, 33);
            this.clearB.TabIndex = 11;
            this.clearB.Text = "Clear";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // submitB
            // 
            this.submitB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitB.Location = new System.Drawing.Point(1015, 653);
            this.submitB.Name = "submitB";
            this.submitB.Size = new System.Drawing.Size(122, 33);
            this.submitB.TabIndex = 10;
            this.submitB.Text = "Submit";
            this.submitB.UseVisualStyleBackColor = true;
            this.submitB.Click += new System.EventHandler(this.SubmitB_Click);
            // 
            // serviceNameCL
            // 
            this.serviceNameCL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serviceNameCL.AutoSize = true;
            this.serviceNameCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNameCL.Location = new System.Drawing.Point(33, 181);
            this.serviceNameCL.Name = "serviceNameCL";
            this.serviceNameCL.Size = new System.Drawing.Size(107, 20);
            this.serviceNameCL.TabIndex = 1;
            this.serviceNameCL.Text = "Service Name";
            // 
            // overallL
            // 
            this.overallL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.overallL.AutoSize = true;
            this.overallL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallL.Location = new System.Drawing.Point(35, 409);
            this.overallL.Name = "overallL";
            this.overallL.Size = new System.Drawing.Size(203, 20);
            this.overallL.TabIndex = 9;
            this.overallL.Text = "Overall feedback for service";
            // 
            // overallTB
            // 
            this.overallTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.overallTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallTB.Location = new System.Drawing.Point(37, 441);
            this.overallTB.Name = "overallTB";
            this.overallTB.Size = new System.Drawing.Size(594, 26);
            this.overallTB.TabIndex = 10;
            this.overallTB.TextChanged += new System.EventHandler(this.OverallTB_TextChanged);
            // 
            // dissatisfiedL
            // 
            this.dissatisfiedL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dissatisfiedL.AutoSize = true;
            this.dissatisfiedL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dissatisfiedL.Location = new System.Drawing.Point(534, 40);
            this.dissatisfiedL.Name = "dissatisfiedL";
            this.dissatisfiedL.Size = new System.Drawing.Size(91, 20);
            this.dissatisfiedL.TabIndex = 40;
            this.dissatisfiedL.Text = "Dissatisfied";
            this.dissatisfiedL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageL
            // 
            this.averageL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.averageL.AutoSize = true;
            this.averageL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageL.Location = new System.Drawing.Point(439, 40);
            this.averageL.Name = "averageL";
            this.averageL.Size = new System.Drawing.Size(68, 20);
            this.averageL.TabIndex = 33;
            this.averageL.Text = "Average";
            this.averageL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goodL
            // 
            this.goodL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goodL.AutoSize = true;
            this.goodL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodL.Location = new System.Drawing.Point(343, 40);
            this.goodL.Name = "goodL";
            this.goodL.Size = new System.Drawing.Size(49, 20);
            this.goodL.TabIndex = 26;
            this.goodL.Text = "Good";
            this.goodL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // excellentL
            // 
            this.excellentL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.excellentL.AutoSize = true;
            this.excellentL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excellentL.Location = new System.Drawing.Point(226, 40);
            this.excellentL.Name = "excellentL";
            this.excellentL.Size = new System.Drawing.Size(73, 20);
            this.excellentL.TabIndex = 19;
            this.excellentL.Text = "Excellent";
            this.excellentL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // criteriaL
            // 
            this.criteriaL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.criteriaL.AutoSize = true;
            this.criteriaL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criteriaL.Location = new System.Drawing.Point(76, 40);
            this.criteriaL.Name = "criteriaL";
            this.criteriaL.Size = new System.Drawing.Size(59, 20);
            this.criteriaL.TabIndex = 12;
            this.criteriaL.Text = "Criteria";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Location = new System.Drawing.Point(-63, -1);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(202, 24);
            this.menuStrip2.TabIndex = 55;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // criteriaS1
            // 
            this.criteriaS1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.criteriaS1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.criteriaS1.ColumnCount = 5;
            this.criteriaS1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.criteriaS1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.criteriaS1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.criteriaS1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.criteriaS1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.criteriaS1.Location = new System.Drawing.Point(668, 242);
            this.criteriaS1.Name = "criteriaS1";
            this.criteriaS1.RowCount = 1;
            this.criteriaS1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.criteriaS1.Size = new System.Drawing.Size(635, 385);
            this.criteriaS1.TabIndex = 56;
            // 
            // sNameCB
            // 
            this.sNameCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sNameCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sNameCB.FormattingEnabled = true;
            this.sNameCB.Items.AddRange(new object[] {
            "Service 1",
            "Service 2"});
            this.sNameCB.Location = new System.Drawing.Point(37, 215);
            this.sNameCB.MaxDropDownItems = 2;
            this.sNameCB.Name = "sNameCB";
            this.sNameCB.Size = new System.Drawing.Size(283, 28);
            this.sNameCB.TabIndex = 2;
            this.sNameCB.SelectedIndexChanged += new System.EventHandler(this.SNameCB_SelectedIndexChanged);
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.headerPanel.ColumnCount = 5;
            this.headerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.32667F));
            this.headerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66833F));
            this.headerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66833F));
            this.headerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66833F));
            this.headerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66833F));
            this.headerPanel.Controls.Add(this.dissatisfiedL, 4, 0);
            this.headerPanel.Controls.Add(this.criteriaL, 0, 0);
            this.headerPanel.Controls.Add(this.averageL, 3, 0);
            this.headerPanel.Controls.Add(this.goodL, 2, 0);
            this.headerPanel.Controls.Add(this.excellentL, 1, 0);
            this.headerPanel.Location = new System.Drawing.Point(668, 143);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.RowCount = 1;
            this.headerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.headerPanel.Size = new System.Drawing.Size(635, 100);
            this.headerPanel.TabIndex = 57;
            // 
            // retrieveBtn
            // 
            this.retrieveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.retrieveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrieveBtn.Location = new System.Drawing.Point(37, 503);
            this.retrieveBtn.Name = "retrieveBtn";
            this.retrieveBtn.Size = new System.Drawing.Size(122, 33);
            this.retrieveBtn.TabIndex = 58;
            this.retrieveBtn.Text = "Retrieve";
            this.retrieveBtn.UseVisualStyleBackColor = true;
            this.retrieveBtn.Click += new System.EventHandler(this.RetrieveBtn_Click);
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.retrieveBtn);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sNameCB);
            this.Controls.Add(this.criteriaS1);
            this.Controls.Add(this.overallTB);
            this.Controls.Add(this.overallL);
            this.Controls.Add(this.serviceNameCL);
            this.Controls.Add(this.submitB);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logoL);
            this.Controls.Add(this.contactTB);
            this.Controls.Add(this.contactL);
            this.Controls.Add(this.currentT);
            this.Controls.Add(this.timeL);
            this.Controls.Add(this.currentD);
            this.Controls.Add(this.dateL);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.emailL);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Feedback";
            this.Text = "Feedback Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label emailL;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label dateL;
        private System.Windows.Forms.Label currentD;
        private System.Windows.Forms.Label timeL;
        private System.Windows.Forms.Label currentT;
        private System.Windows.Forms.Label contactL;
        private System.Windows.Forms.TextBox contactTB;
        private System.Windows.Forms.Label logoL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Button submitB;
        private System.Windows.Forms.Label serviceNameCL;
        private System.Windows.Forms.Label overallL;
        private System.Windows.Forms.TextBox overallTB;
        private System.Windows.Forms.Label dissatisfiedL;
        private System.Windows.Forms.Label averageL;
        private System.Windows.Forms.Label goodL;
        private System.Windows.Forms.Label excellentL;
        private System.Windows.Forms.Label criteriaL;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel criteriaS1;
        private System.Windows.Forms.ComboBox sNameCB;
        private System.Windows.Forms.TableLayoutPanel headerPanel;
        private System.Windows.Forms.Button retrieveBtn;
    }
}