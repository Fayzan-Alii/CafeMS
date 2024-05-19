namespace CafeMS
{
    partial class SampleAdd
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.CloseBtn = new Guna.UI.WinForms.GunaButton();
            this.SaveBtn = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(963, 129);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(175, 54);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(69, 25);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Header";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gunaPanel2.Controls.Add(this.CloseBtn);
            this.gunaPanel2.Controls.Add(this.SaveBtn);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 492);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(963, 104);
            this.gunaPanel2.TabIndex = 1;
            // 
            // CloseBtn
            // 
            this.CloseBtn.AnimationHoverSpeed = 0.07F;
            this.CloseBtn.AnimationSpeed = 0.03F;
            this.CloseBtn.BaseColor = System.Drawing.Color.Crimson;
            this.CloseBtn.BorderColor = System.Drawing.Color.Transparent;
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseBtn.FocusedColor = System.Drawing.Color.Empty;
            this.CloseBtn.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Image = null;
            this.CloseBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.CloseBtn.Location = new System.Drawing.Point(219, 35);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.CloseBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CloseBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.CloseBtn.OnHoverImage = null;
            this.CloseBtn.OnPressedColor = System.Drawing.Color.Black;
            this.CloseBtn.Size = new System.Drawing.Size(160, 42);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "CLOSE";
            this.CloseBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.AnimationHoverSpeed = 0.07F;
            this.SaveBtn.AnimationSpeed = 0.03F;
            this.SaveBtn.BaseColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveBtn.BorderColor = System.Drawing.Color.Transparent;
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveBtn.FocusedColor = System.Drawing.Color.Empty;
            this.SaveBtn.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Image = null;
            this.SaveBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.SaveBtn.Location = new System.Drawing.Point(28, 35);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.OnHoverBaseColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SaveBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.SaveBtn.OnHoverImage = null;
            this.SaveBtn.OnPressedColor = System.Drawing.Color.Black;
            this.SaveBtn.Size = new System.Drawing.Size(160, 42);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(28, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(116, 104);
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // SampleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 596);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SampleAdd";
            this.Text = "Category";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI.WinForms.GunaPanel gunaPanel1;
        public Guna.UI.WinForms.GunaPanel gunaPanel2;
        public Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        public Guna.UI.WinForms.GunaButton SaveBtn;
        public Guna.UI.WinForms.GunaButton CloseBtn;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}