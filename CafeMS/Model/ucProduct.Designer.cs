namespace CafeMS.Model
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.txtImage = new Guna.UI.WinForms.GunaPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.panel1);
            this.gunaShadowPanel1.Controls.Add(this.txtImage);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(3, 6);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(172, 157);
            this.gunaShadowPanel1.TabIndex = 0;
            this.gunaShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaShadowPanel1_Paint);
            // 
            // txtImage
            // 
            this.txtImage.BaseColor = System.Drawing.Color.White;
            this.txtImage.Image = global::CafeMS.Properties.Resources._8101140_indian_food_biryani_png_download;
            this.txtImage.Location = new System.Drawing.Point(50, 13);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(74, 68);
            this.txtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImage.TabIndex = 0;
            this.txtImage.TabStop = false;
            this.txtImage.Click += new System.EventHandler(this.txtImage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaSeparator1);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 56);
            this.panel1.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(164, 45);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Product Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(5, 0);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(164, 10);
            this.gunaSeparator1.TabIndex = 2;
            this.gunaSeparator1.Thickness = 3;
            this.gunaSeparator1.Click += new System.EventHandler(this.gunaSeparator1_Click);
            // 
            // ucProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(177, 163);
            this.gunaShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaPictureBox txtImage;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Label lblName;
    }
}
