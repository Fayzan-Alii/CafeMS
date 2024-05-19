namespace CafeMS
{
    partial class Signup
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
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbUsertype = new System.Windows.Forms.ComboBox();
            this.ExitBtn = new Guna.UI.WinForms.GunaButton();
            this.SignupBtn = new Guna.UI.WinForms.GunaButton();
            this.passwordtxt = new Guna.UI.WinForms.GunaTextBox();
            this.usernametxt = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.gunaPictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 240);
            this.panel1.TabIndex = 1;
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please enter user information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "User Type";
            // 
            // cbUsertype
            // 
            this.cbUsertype.FormattingEnabled = true;
            this.cbUsertype.Items.AddRange(new object[] {
            "Customer",
            "Manager"});
            this.cbUsertype.Location = new System.Drawing.Point(52, 514);
            this.cbUsertype.Name = "cbUsertype";
            this.cbUsertype.Size = new System.Drawing.Size(364, 28);
            this.cbUsertype.TabIndex = 19;
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
            this.ExitBtn.Location = new System.Drawing.Point(256, 582);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ExitBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ExitBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ExitBtn.OnHoverImage = null;
            this.ExitBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ExitBtn.Size = new System.Drawing.Size(160, 42);
            this.ExitBtn.TabIndex = 18;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SignupBtn
            // 
            this.SignupBtn.AnimationHoverSpeed = 0.07F;
            this.SignupBtn.AnimationSpeed = 0.03F;
            this.SignupBtn.BaseColor = System.Drawing.Color.SeaGreen;
            this.SignupBtn.BorderColor = System.Drawing.Color.Black;
            this.SignupBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SignupBtn.FocusedColor = System.Drawing.Color.Empty;
            this.SignupBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupBtn.ForeColor = System.Drawing.Color.White;
            this.SignupBtn.Image = null;
            this.SignupBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.SignupBtn.Location = new System.Drawing.Point(53, 582);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.SignupBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SignupBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.SignupBtn.OnHoverImage = null;
            this.SignupBtn.OnPressedColor = System.Drawing.Color.Black;
            this.SignupBtn.Size = new System.Drawing.Size(160, 42);
            this.SignupBtn.TabIndex = 17;
            this.SignupBtn.Text = "Signup";
            this.SignupBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SignupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
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
            this.passwordtxt.Location = new System.Drawing.Point(52, 399);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '\0';
            this.passwordtxt.SelectedText = "";
            this.passwordtxt.Size = new System.Drawing.Size(364, 47);
            this.passwordtxt.TabIndex = 16;
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
            this.usernametxt.Location = new System.Drawing.Point(53, 294);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.PasswordChar = '\0';
            this.usernametxt.SelectedText = "";
            this.usernametxt.Size = new System.Drawing.Size(363, 45);
            this.usernametxt.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Username";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(357, 653);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 24);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 759);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbUsertype);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SignupBtn);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.Text = "Signup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbUsertype;
        private Guna.UI.WinForms.GunaButton ExitBtn;
        private Guna.UI.WinForms.GunaButton SignupBtn;
        private Guna.UI.WinForms.GunaTextBox passwordtxt;
        private Guna.UI.WinForms.GunaTextBox usernametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}