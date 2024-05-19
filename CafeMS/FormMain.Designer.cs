namespace CafeMS
{
    partial class FormMain
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
            this.StaffBtn = new Guna.UI.WinForms.GunaButton();
            this.ProductBtn = new Guna.UI.WinForms.GunaButton();
            this.CategoriesBtn = new Guna.UI.WinForms.GunaButton();
            this.HomeBtn = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.CentralPanel = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.btnExit = new Guna.UI.WinForms.GunaControlBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnFeedback = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Controls.Add(this.StaffBtn);
            this.gunaPanel1.Controls.Add(this.btnFeedback);
            this.gunaPanel1.Controls.Add(this.ProductBtn);
            this.gunaPanel1.Controls.Add(this.CategoriesBtn);
            this.gunaPanel1.Controls.Add(this.HomeBtn);
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(215, 733);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // StaffBtn
            // 
            this.StaffBtn.AnimationHoverSpeed = 0.07F;
            this.StaffBtn.AnimationSpeed = 0.03F;
            this.StaffBtn.BaseColor = System.Drawing.Color.Transparent;
            this.StaffBtn.BorderColor = System.Drawing.Color.Black;
            this.StaffBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.StaffBtn.FocusedColor = System.Drawing.Color.Empty;
            this.StaffBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffBtn.ForeColor = System.Drawing.Color.White;
            this.StaffBtn.Image = null;
            this.StaffBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.StaffBtn.Location = new System.Drawing.Point(0, 402);
            this.StaffBtn.Name = "StaffBtn";
            this.StaffBtn.OnHoverBaseColor = System.Drawing.Color.LightSlateGray;
            this.StaffBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.StaffBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.StaffBtn.OnHoverImage = null;
            this.StaffBtn.OnPressedColor = System.Drawing.Color.Black;
            this.StaffBtn.Size = new System.Drawing.Size(215, 42);
            this.StaffBtn.TabIndex = 6;
            this.StaffBtn.Text = "Staff";
            this.StaffBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StaffBtn.Click += new System.EventHandler(this.StaffBtn_Click);
            // 
            // ProductBtn
            // 
            this.ProductBtn.AnimationHoverSpeed = 0.07F;
            this.ProductBtn.AnimationSpeed = 0.03F;
            this.ProductBtn.BaseColor = System.Drawing.Color.Transparent;
            this.ProductBtn.BorderColor = System.Drawing.Color.Black;
            this.ProductBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ProductBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ProductBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBtn.ForeColor = System.Drawing.Color.White;
            this.ProductBtn.Image = null;
            this.ProductBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.ProductBtn.Location = new System.Drawing.Point(0, 354);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.OnHoverBaseColor = System.Drawing.Color.LightSlateGray;
            this.ProductBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.ProductBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.ProductBtn.OnHoverImage = null;
            this.ProductBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ProductBtn.Size = new System.Drawing.Size(215, 42);
            this.ProductBtn.TabIndex = 6;
            this.ProductBtn.Text = "Products";
            this.ProductBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // CategoriesBtn
            // 
            this.CategoriesBtn.AnimationHoverSpeed = 0.07F;
            this.CategoriesBtn.AnimationSpeed = 0.03F;
            this.CategoriesBtn.BaseColor = System.Drawing.Color.Transparent;
            this.CategoriesBtn.BorderColor = System.Drawing.Color.Black;
            this.CategoriesBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CategoriesBtn.FocusedColor = System.Drawing.Color.Empty;
            this.CategoriesBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesBtn.ForeColor = System.Drawing.Color.White;
            this.CategoriesBtn.Image = null;
            this.CategoriesBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.CategoriesBtn.Location = new System.Drawing.Point(0, 306);
            this.CategoriesBtn.Name = "CategoriesBtn";
            this.CategoriesBtn.OnHoverBaseColor = System.Drawing.Color.LightSlateGray;
            this.CategoriesBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.CategoriesBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.CategoriesBtn.OnHoverImage = null;
            this.CategoriesBtn.OnPressedColor = System.Drawing.Color.Black;
            this.CategoriesBtn.Size = new System.Drawing.Size(215, 42);
            this.CategoriesBtn.TabIndex = 6;
            this.CategoriesBtn.Text = "Categories";
            this.CategoriesBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CategoriesBtn.Click += new System.EventHandler(this.CategoriesBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.AnimationHoverSpeed = 0.07F;
            this.HomeBtn.AnimationSpeed = 0.03F;
            this.HomeBtn.BaseColor = System.Drawing.Color.Transparent;
            this.HomeBtn.BorderColor = System.Drawing.Color.Black;
            this.HomeBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.HomeBtn.FocusedColor = System.Drawing.Color.Empty;
            this.HomeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = null;
            this.HomeBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.HomeBtn.Location = new System.Drawing.Point(0, 258);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.OnHoverBaseColor = System.Drawing.Color.LightSlateGray;
            this.HomeBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.HomeBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.HomeBtn.OnHoverImage = null;
            this.HomeBtn.OnPressedColor = System.Drawing.Color.Black;
            this.HomeBtn.Size = new System.Drawing.Size(215, 42);
            this.HomeBtn.TabIndex = 6;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "CampusBites";
            // 
            // CentralPanel
            // 
            this.CentralPanel.BackColor = System.Drawing.Color.White;
            this.CentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralPanel.Location = new System.Drawing.Point(215, 0);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.Size = new System.Drawing.Size(798, 733);
            this.CentralPanel.TabIndex = 2;
            this.CentralPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CentralPanel_Paint);
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gunaPanel3.Controls.Add(this.gunaControlBox3);
            this.gunaPanel3.Controls.Add(this.gunaControlBox2);
            this.gunaPanel3.Controls.Add(this.btnExit);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel3.Location = new System.Drawing.Point(215, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(798, 55);
            this.gunaPanel3.TabIndex = 3;
            // 
            // gunaControlBox3
            // 
            this.gunaControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox3.AnimationSpeed = 0.03F;
            this.gunaControlBox3.BackColor = System.Drawing.Color.DimGray;
            this.gunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox3.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox3.IconSize = 15F;
            this.gunaControlBox3.Location = new System.Drawing.Point(618, 12);
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox3.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox3.TabIndex = 2;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.BackColor = System.Drawing.Color.DimGray;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(681, 12);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.DimGray;
            this.btnExit.CustomClick = true;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconSize = 15F;
            this.btnExit.Location = new System.Drawing.Point(741, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnExit.OnHoverIconColor = System.Drawing.Color.White;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(45, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::CafeMS.Properties.Resources.coffee;
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(215, 135);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 7;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.AnimationHoverSpeed = 0.07F;
            this.btnFeedback.AnimationSpeed = 0.03F;
            this.btnFeedback.BaseColor = System.Drawing.Color.Transparent;
            this.btnFeedback.BorderColor = System.Drawing.Color.Black;
            this.btnFeedback.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFeedback.FocusedColor = System.Drawing.Color.Empty;
            this.btnFeedback.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.Color.White;
            this.btnFeedback.Image = null;
            this.btnFeedback.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFeedback.Location = new System.Drawing.Point(12, 450);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.OnHoverBaseColor = System.Drawing.Color.LightSlateGray;
            this.btnFeedback.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnFeedback.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnFeedback.OnHoverImage = null;
            this.btnFeedback.OnPressedColor = System.Drawing.Color.Black;
            this.btnFeedback.Size = new System.Drawing.Size(203, 42);
            this.btnFeedback.TabIndex = 6;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFeedback.Click += new System.EventHandler(this.PosBtn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 733);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.CentralPanel);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        public Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        public Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        public Guna.UI.WinForms.GunaControlBox btnExit;
        public System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaButton StaffBtn;
        public Guna.UI.WinForms.GunaButton ProductBtn;
        public Guna.UI.WinForms.GunaButton CategoriesBtn;
        public Guna.UI.WinForms.GunaButton HomeBtn;
        public Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        public Guna.UI.WinForms.GunaPanel CentralPanel;
        public Guna.UI.WinForms.GunaButton btnFeedback;
    }
}