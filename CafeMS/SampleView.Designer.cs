namespace CafeMS
{
    partial class SampleView
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.AddBtn = new Guna.UI.WinForms.GunaImageButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(644, 59);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(68, 24);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Search";
            // 
            // AddBtn
            // 
            this.AddBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddBtn.Image = global::CafeMS.Properties.Resources.addition;
            this.AddBtn.ImageSize = new System.Drawing.Size(64, 64);
            this.AddBtn.Location = new System.Drawing.Point(82, 59);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.OnHoverImage = null;
            this.AddBtn.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.AddBtn.Size = new System.Drawing.Size(64, 64);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(692, 86);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(290, 36);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::CafeMS.Properties.Resources.search;
            this.gunaPictureBox1.Location = new System.Drawing.Point(648, 86);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(49, 36);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 4;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Transparent;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox2.Location = new System.Drawing.Point(82, 12);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.SelectedText = "";
            this.gunaTextBox2.Size = new System.Drawing.Size(160, 38);
            this.gunaTextBox2.TabIndex = 5;
            this.gunaTextBox2.Text = "Header Text";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(82, 162);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(900, 16);
            this.gunaSeparator1.TabIndex = 6;
            // 
            // SampleView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 609);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.gunaTextBox2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SampleView";
            this.Text = "View";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI.WinForms.GunaTextBox txtSearch;
        public Guna.UI.WinForms.GunaImageButton AddBtn;
        public Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        public Guna.UI.WinForms.GunaSeparator gunaSeparator1;
    }
}