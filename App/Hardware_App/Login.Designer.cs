namespace Hardware_App
{
    partial class loginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerDatabase = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new XanderUI.XUIButton();
            this.checkBoxShowPassword = new XanderUI.XUICheckBox();
            this.btnExit = new XanderUI.XUIButton();
            this.tbPassword = new Hardware_App.CustomTextbox();
            this.tbUsername = new Hardware_App.CustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label2.Location = new System.Drawing.Point(11, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label3.Location = new System.Drawing.Point(13, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // timerDatabase
            // 
            this.timerDatabase.Enabled = true;
            this.timerDatabase.Interval = 5000000;
            this.timerDatabase.Tick += new System.EventHandler(this.timerDatabase_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Hardware_App.Properties.Resources.MediaBazaar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 53);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnLogin.ButtonImage = null;
            this.btnLogin.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnLogin.ButtonText = "Log in";
            this.btnLogin.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnLogin.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.CornerRadius = 5;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnLogin.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLogin.Location = new System.Drawing.Point(44, 253);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 39);
            this.btnLogin.TabIndex = 30;
            this.btnLogin.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.CheckboxCheckColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxShowPassword.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.checkBoxShowPassword.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.checkBoxShowPassword.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.checkBoxShowPassword.Checked = false;
            this.checkBoxShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.checkBoxShowPassword.Location = new System.Drawing.Point(292, 153);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(56, 20);
            this.checkBoxShowPassword.TabIndex = 29;
            this.checkBoxShowPassword.Text = "Show";
            this.checkBoxShowPassword.TickThickness = 2;
            this.checkBoxShowPassword.CheckedStateChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnExit.ButtonImage = null;
            this.btnExit.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnExit.ButtonText = "Exit";
            this.btnExit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnExit.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.CornerRadius = 5;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnExit.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnExit.Location = new System.Drawing.Point(201, 253);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 39);
            this.btnExit.TabIndex = 31;
            this.btnExit.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbPassword.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.tbPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.tbPassword.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tbPassword.Location = new System.Drawing.Point(92, 151);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Padding = new System.Windows.Forms.Padding(3);
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.ReadOnly = false;
            this.tbPassword.Size = new System.Drawing.Size(194, 27);
            this.tbPassword.TabIndex = 28;
            this.tbPassword.TextColor = System.Drawing.Color.DarkGray;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbUsername.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.tbUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.tbUsername.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tbUsername.Location = new System.Drawing.Point(92, 115);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Padding = new System.Windows.Forms.Padding(3);
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.ReadOnly = false;
            this.tbUsername.Size = new System.Drawing.Size(194, 27);
            this.tbUsername.TabIndex = 27;
            this.tbUsername.TextColor = System.Drawing.Color.DarkGray;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 355);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "loginForm";
            this.Text = "Log in";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.loginForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerDatabase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomTextbox tbUsername;
        private XanderUI.XUIButton btnLogin;
        private XanderUI.XUICheckBox checkBoxShowPassword;
        private CustomTextbox tbPassword;
        private XanderUI.XUIButton btnExit;
    }
}

