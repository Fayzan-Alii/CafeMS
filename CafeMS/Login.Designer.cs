namespace CafeMS
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernametxt = new Guna.UI.WinForms.GunaTextBox();
            this.passwordtxt = new Guna.UI.WinForms.GunaTextBox();
            this.LoginBtn = new Guna.UI.WinForms.GunaButton();
            this.ExitBtn = new Guna.UI.WinForms.GunaButton();
            this.cbUsertype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // usernametxt
            // 
            this.usernametxt.BaseColor = System.Drawing.Color.White;
            this.usernametxt.BorderColor = System.Drawing.Color.Silver;
            this.usernametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametxt.FocusedBaseColor = System.Drawing.Color.White;
            this.usernametxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.usernametxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.usernametxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernametxt.Location = new System.Drawing.Point(52, 324);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.PasswordChar = '\0';
            this.usernametxt.SelectedText = "";
            this.usernametxt.Size = new System.Drawing.Size(363, 45);
            this.usernametxt.TabIndex = 7;
            // 
            // passwordtxt
            // 
            this.passwordtxt.BaseColor = System.Drawing.Color.White;
            this.passwordtxt.BorderColor = System.Drawing.Color.Silver;
            this.passwordtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtxt.FocusedBaseColor = System.Drawing.Color.White;
            this.passwordtxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.passwordtxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordtxt.Location = new System.Drawing.Point(51, 429);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '\0';
            this.passwordtxt.SelectedText = "";
            this.passwordtxt.Size = new System.Drawing.Size(364, 47);
            this.passwordtxt.TabIndex = 8;
            // 
            // LoginBtn
            // 
            this.LoginBtn.AnimationHoverSpeed = 0.07F;
            this.LoginBtn.AnimationSpeed = 0.03F;
            this.LoginBtn.BaseColor = System.Drawing.Color.SeaGreen;
            this.LoginBtn.BorderColor = System.Drawing.Color.Black;
            this.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginBtn.FocusedColor = System.Drawing.Color.Empty;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Image = null;
            this.LoginBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.LoginBtn.Location = new System.Drawing.Point(52, 625);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.LoginBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoginBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.LoginBtn.OnHoverImage = null;
            this.LoginBtn.OnPressedColor = System.Drawing.Color.Black;
            this.LoginBtn.Size = new System.Drawing.Size(160, 42);
            this.LoginBtn.TabIndex = 9;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click_1);
            // 
            // ExitBtn
            // 
            this.ExitBtn.AnimationHoverSpeed = 0.07F;
            this.ExitBtn.AnimationSpeed = 0.03F;
            this.ExitBtn.BaseColor = System.Drawing.Color.Crimson;
            this.ExitBtn.BorderColor = System.Drawing.Color.Black;
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExitBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Image = null;
            this.ExitBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.ExitBtn.Location = new System.Drawing.Point(255, 625);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ExitBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ExitBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ExitBtn.OnHoverImage = null;
            this.ExitBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ExitBtn.Size = new System.Drawing.Size(160, 42);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // cbUsertype
            // 
            this.cbUsertype.FormattingEnabled = true;
            this.cbUsertype.Items.AddRange(new object[] {
            "Customer",
            "Manager"});
            this.cbUsertype.Location = new System.Drawing.Point(51, 544);
            this.cbUsertype.Name = "cbUsertype";
            this.cbUsertype.Size = new System.Drawing.Size(364, 28);
            this.cbUsertype.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "User Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please enter user information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.gunaPictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 240);
            this.panel1.TabIndex = 0;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::CafeMS.Properties.Resources.login;
            this.gunaPictureBox1.Location = new System.Drawing.Point(160, 27);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(149, 159);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 3;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(344, 700);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(71, 24);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Signup";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(494, 795);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbUsertype);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox usernametxt;
        private Guna.UI.WinForms.GunaTextBox passwordtxt;
        private Guna.UI.WinForms.GunaButton LoginBtn;
        private Guna.UI.WinForms.GunaButton ExitBtn;
        private System.Windows.Forms.ComboBox cbUsertype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

