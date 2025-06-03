
namespace Cw1
{
    partial class Import
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.uploadTB = new System.Windows.Forms.TextBox();
            this.uploadL = new System.Windows.Forms.Label();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.generalViewL = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.uploadTB);
            this.panel1.Controls.Add(this.uploadL);
            this.panel1.Controls.Add(this.uploadBtn);
            this.panel1.Location = new System.Drawing.Point(32, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 100);
            this.panel1.TabIndex = 20;
            // 
            // uploadTB
            // 
            this.uploadTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uploadTB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uploadTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadTB.Location = new System.Drawing.Point(149, 36);
            this.uploadTB.Name = "uploadTB";
            this.uploadTB.ReadOnly = true;
            this.uploadTB.Size = new System.Drawing.Size(430, 26);
            this.uploadTB.TabIndex = 27;
            // 
            // uploadL
            // 
            this.uploadL.AutoSize = true;
            this.uploadL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadL.Location = new System.Drawing.Point(45, 39);
            this.uploadL.Name = "uploadL";
            this.uploadL.Size = new System.Drawing.Size(89, 20);
            this.uploadL.TabIndex = 26;
            this.uploadL.Text = "Upload File";
            // 
            // uploadBtn
            // 
            this.uploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.Location = new System.Drawing.Point(605, 31);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(107, 36);
            this.uploadBtn.TabIndex = 25;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Location = new System.Drawing.Point(32, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 4);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // generalViewL
            // 
            this.generalViewL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generalViewL.AutoSize = true;
            this.generalViewL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalViewL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.generalViewL.Location = new System.Drawing.Point(43, 36);
            this.generalViewL.Name = "generalViewL";
            this.generalViewL.Size = new System.Drawing.Size(182, 32);
            this.generalViewL.TabIndex = 28;
            this.generalViewL.Text = "Import Panel";
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(694, 320);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(94, 37);
            this.exitBtn.TabIndex = 30;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(578, 320);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 37);
            this.clearBtn.TabIndex = 31;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ImportBulkData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 408);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.generalViewL);
            this.MaximizeBox = false;
            this.Name = "ImportBulkData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox uploadTB;
        private System.Windows.Forms.Label uploadL;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label generalViewL;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}