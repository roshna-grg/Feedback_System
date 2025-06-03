namespace Cw1
{
    partial class Admin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminPageL = new System.Windows.Forms.Label();
            this.serviceNameL = new System.Windows.Forms.Label();
            this.serviceNameCB = new System.Windows.Forms.ComboBox();
            this.criteriaNameTB = new System.Windows.Forms.TextBox();
            this.criteriaNameL = new System.Windows.Forms.Label();
            this.addB = new System.Windows.Forms.Button();
            this.updateB = new System.Windows.Forms.Button();
            this.idL = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.deleteB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.criteriaLU = new System.Windows.Forms.Label();
            this.serviceUCB = new System.Windows.Forms.ComboBox();
            this.criteriaUTB = new System.Windows.Forms.TextBox();
            this.serviceNTB = new System.Windows.Forms.Label();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Location = new System.Drawing.Point(136, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1050, 4);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // adminPageL
            // 
            this.adminPageL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminPageL.AutoSize = true;
            this.adminPageL.Font = new System.Drawing.Font("Broadway", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPageL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adminPageL.Location = new System.Drawing.Point(147, 50);
            this.adminPageL.Name = "adminPageL";
            this.adminPageL.Size = new System.Drawing.Size(226, 32);
            this.adminPageL.TabIndex = 1;
            this.adminPageL.Text = "Admin Panel";
            // 
            // serviceNameL
            // 
            this.serviceNameL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serviceNameL.AutoSize = true;
            this.serviceNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNameL.Location = new System.Drawing.Point(95, 55);
            this.serviceNameL.Name = "serviceNameL";
            this.serviceNameL.Size = new System.Drawing.Size(129, 24);
            this.serviceNameL.TabIndex = 2;
            this.serviceNameL.Text = "Service Name";
            // 
            // serviceNameCB
            // 
            this.serviceNameCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serviceNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceNameCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNameCB.FormattingEnabled = true;
            this.serviceNameCB.Items.AddRange(new object[] {
            "Service 1",
            "Service 2"});
            this.serviceNameCB.Location = new System.Drawing.Point(265, 52);
            this.serviceNameCB.Name = "serviceNameCB";
            this.serviceNameCB.Size = new System.Drawing.Size(223, 32);
            this.serviceNameCB.TabIndex = 3;
            // 
            // criteriaNameTB
            // 
            this.criteriaNameTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.criteriaNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criteriaNameTB.Location = new System.Drawing.Point(683, 55);
            this.criteriaNameTB.Name = "criteriaNameTB";
            this.criteriaNameTB.Size = new System.Drawing.Size(203, 29);
            this.criteriaNameTB.TabIndex = 7;
            // 
            // criteriaNameL
            // 
            this.criteriaNameL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.criteriaNameL.AutoSize = true;
            this.criteriaNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criteriaNameL.Location = new System.Drawing.Point(545, 55);
            this.criteriaNameL.Name = "criteriaNameL";
            this.criteriaNameL.Size = new System.Drawing.Size(124, 24);
            this.criteriaNameL.TabIndex = 6;
            this.criteriaNameL.Text = "Criteria Name";
            // 
            // addB
            // 
            this.addB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addB.Location = new System.Drawing.Point(265, 127);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(101, 32);
            this.addB.TabIndex = 8;
            this.addB.Text = "Add";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // updateB
            // 
            this.updateB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateB.Location = new System.Drawing.Point(749, 140);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(135, 32);
            this.updateB.TabIndex = 9;
            this.updateB.Text = "Update";
            this.updateB.UseVisualStyleBackColor = true;
            this.updateB.Click += new System.EventHandler(this.UpdateB_Click);
            // 
            // idL
            // 
            this.idL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idL.AutoSize = true;
            this.idL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idL.Location = new System.Drawing.Point(545, 62);
            this.idL.Name = "idL";
            this.idL.Size = new System.Drawing.Size(95, 24);
            this.idL.TabIndex = 4;
            this.idL.Text = "Service ID";
            // 
            // idTB
            // 
            this.idTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTB.Location = new System.Drawing.Point(683, 59);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(202, 29);
            this.idTB.TabIndex = 5;
            // 
            // deleteB
            // 
            this.deleteB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteB.Location = new System.Drawing.Point(387, 127);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(101, 32);
            this.deleteB.TabIndex = 10;
            this.deleteB.Text = "Delete";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.criteriaLU);
            this.panel1.Controls.Add(this.updateB);
            this.panel1.Controls.Add(this.serviceUCB);
            this.panel1.Controls.Add(this.criteriaUTB);
            this.panel1.Controls.Add(this.serviceNTB);
            this.panel1.Controls.Add(this.idTB);
            this.panel1.Controls.Add(this.idL);
            this.panel1.Location = new System.Drawing.Point(153, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 235);
            this.panel1.TabIndex = 11;
            // 
            // criteriaLU
            // 
            this.criteriaLU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.criteriaLU.AutoSize = true;
            this.criteriaLU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criteriaLU.Location = new System.Drawing.Point(95, 148);
            this.criteriaLU.Name = "criteriaLU";
            this.criteriaLU.Size = new System.Drawing.Size(124, 24);
            this.criteriaLU.TabIndex = 14;
            this.criteriaLU.Text = "Criteria Name";
            // 
            // serviceUCB
            // 
            this.serviceUCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serviceUCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceUCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceUCB.FormattingEnabled = true;
            this.serviceUCB.Items.AddRange(new object[] {
            "Service 1",
            "Service 2"});
            this.serviceUCB.Location = new System.Drawing.Point(265, 59);
            this.serviceUCB.Name = "serviceUCB";
            this.serviceUCB.Size = new System.Drawing.Size(202, 32);
            this.serviceUCB.TabIndex = 13;
            // 
            // criteriaUTB
            // 
            this.criteriaUTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.criteriaUTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criteriaUTB.Location = new System.Drawing.Point(265, 145);
            this.criteriaUTB.Name = "criteriaUTB";
            this.criteriaUTB.Size = new System.Drawing.Size(202, 29);
            this.criteriaUTB.TabIndex = 15;
            // 
            // serviceNTB
            // 
            this.serviceNTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serviceNTB.AutoSize = true;
            this.serviceNTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNTB.Location = new System.Drawing.Point(95, 62);
            this.serviceNTB.Name = "serviceNTB";
            this.serviceNTB.Size = new System.Drawing.Size(129, 24);
            this.serviceNTB.TabIndex = 12;
            this.serviceNTB.Text = "Service Name";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(903, 655);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(135, 32);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(1051, 655);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(135, 32);
            this.exitBtn.TabIndex = 14;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addB);
            this.panel2.Controls.Add(this.serviceNameL);
            this.panel2.Controls.Add(this.serviceNameCB);
            this.panel2.Controls.Add(this.criteriaNameTB);
            this.panel2.Controls.Add(this.deleteB);
            this.panel2.Controls.Add(this.criteriaNameL);
            this.panel2.Location = new System.Drawing.Point(153, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1033, 202);
            this.panel2.TabIndex = 15;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminPageL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label adminPageL;
        private System.Windows.Forms.Label serviceNameL;
        private System.Windows.Forms.ComboBox serviceNameCB;
        private System.Windows.Forms.TextBox criteriaNameTB;
        private System.Windows.Forms.Label criteriaNameL;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Button updateB;
        private System.Windows.Forms.Label idL;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label criteriaLU;
        private System.Windows.Forms.ComboBox serviceUCB;
        private System.Windows.Forms.TextBox criteriaUTB;
        private System.Windows.Forms.Label serviceNTB;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel2;
    }
}