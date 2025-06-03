namespace Cw1
{
    partial class StaffLogin
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
            this.loginL = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginB = new System.Windows.Forms.Button();
            this.usernameL = new System.Windows.Forms.Label();
            this.passwordL = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.PictureBox();
            this.userL = new System.Windows.Forms.Label();
            this.userCB = new System.Windows.Forms.ComboBox();
            this.backB = new System.Windows.Forms.Button();
            this.rememberCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            this.SuspendLayout();
            // 
            // loginL
            // 
            this.loginL.AutoSize = true;
            this.loginL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginL.ForeColor = System.Drawing.SystemColors.GrayText;
            this.loginL.Location = new System.Drawing.Point(36, 37);
            this.loginL.Name = "loginL";
            this.loginL.Size = new System.Drawing.Size(102, 32);
            this.loginL.TabIndex = 0;
            this.loginL.Text = "LOGIN";
            // 
            // usernameTB
            // 
            this.usernameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.usernameTB.Location = new System.Drawing.Point(42, 200);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(243, 31);
            this.usernameTB.TabIndex = 4;
            this.usernameTB.TextChanged += new System.EventHandler(this.UsernameTB_TextChanged);
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.passwordTB.Location = new System.Drawing.Point(42, 283);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(243, 31);
            this.passwordTB.TabIndex = 6;
            this.passwordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged);
            // 
            // loginB
            // 
            this.loginB.BackColor = System.Drawing.Color.SteelBlue;
            this.loginB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginB.ForeColor = System.Drawing.Color.White;
            this.loginB.Location = new System.Drawing.Point(42, 360);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(243, 42);
            this.loginB.TabIndex = 8;
            this.loginB.Text = "Login";
            this.loginB.UseVisualStyleBackColor = false;
            this.loginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // usernameL
            // 
            this.usernameL.AutoSize = true;
            this.usernameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameL.ForeColor = System.Drawing.SystemColors.GrayText;
            this.usernameL.Location = new System.Drawing.Point(38, 166);
            this.usernameL.Name = "usernameL";
            this.usernameL.Size = new System.Drawing.Size(97, 24);
            this.usernameL.TabIndex = 3;
            this.usernameL.Text = "Username";
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordL.ForeColor = System.Drawing.SystemColors.GrayText;
            this.passwordL.Location = new System.Drawing.Point(38, 245);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(92, 24);
            this.passwordL.TabIndex = 5;
            this.passwordL.Text = "Password";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.SystemColors.GrayText;
            this.line.Location = new System.Drawing.Point(42, 69);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(243, 2);
            this.line.TabIndex = 6;
            this.line.TabStop = false;
            // 
            // userL
            // 
            this.userL.AutoSize = true;
            this.userL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userL.ForeColor = System.Drawing.SystemColors.GrayText;
            this.userL.Location = new System.Drawing.Point(38, 91);
            this.userL.Name = "userL";
            this.userL.Size = new System.Drawing.Size(49, 24);
            this.userL.TabIndex = 1;
            this.userL.Text = "User";
            // 
            // userCB
            // 
            this.userCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userCB.FormattingEnabled = true;
            this.userCB.Items.AddRange(new object[] {
            "General",
            "Admin"});
            this.userCB.Location = new System.Drawing.Point(42, 122);
            this.userCB.Name = "userCB";
            this.userCB.Size = new System.Drawing.Size(243, 33);
            this.userCB.TabIndex = 2;
            // 
            // backB
            // 
            this.backB.BackColor = System.Drawing.Color.SteelBlue;
            this.backB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backB.ForeColor = System.Drawing.Color.White;
            this.backB.Location = new System.Drawing.Point(42, 429);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(243, 42);
            this.backB.TabIndex = 9;
            this.backB.Text = "Back";
            this.backB.UseVisualStyleBackColor = false;
            this.backB.Click += new System.EventHandler(this.BackB_Click);
            // 
            // rememberCB
            // 
            this.rememberCB.AutoSize = true;
            this.rememberCB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rememberCB.Location = new System.Drawing.Point(43, 329);
            this.rememberCB.Name = "rememberCB";
            this.rememberCB.Size = new System.Drawing.Size(95, 17);
            this.rememberCB.TabIndex = 7;
            this.rememberCB.Text = "Remember Me";
            this.rememberCB.UseVisualStyleBackColor = true;
            this.rememberCB.CheckedChanged += new System.EventHandler(this.RememberCB_CheckedChanged);
            // 
            // StaffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 504);
            this.Controls.Add(this.rememberCB);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.userCB);
            this.Controls.Add(this.userL);
            this.Controls.Add(this.line);
            this.Controls.Add(this.passwordL);
            this.Controls.Add(this.usernameL);
            this.Controls.Add(this.loginB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.loginL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StaffLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Login";
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginL;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button loginB;
        private System.Windows.Forms.Label usernameL;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.Label userL;
        private System.Windows.Forms.ComboBox userCB;
        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.CheckBox rememberCB;
    }
}

