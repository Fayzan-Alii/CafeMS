namespace CafeMS.Model
{
    partial class FormCategoryAdd
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
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Size = new System.Drawing.Size(552, 129);
            this.gunaPanel1.TabIndex = 3;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Location = new System.Drawing.Point(0, 332);
            this.gunaPanel2.Size = new System.Drawing.Size(552, 104);
            this.gunaPanel2.TabIndex = 2;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Image = global::CafeMS.Properties.Resources.menu;
            this.gunaPictureBox1.Location = new System.Drawing.Point(28, 21);
            this.gunaPictureBox1.Size = new System.Drawing.Size(101, 83);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // SaveBtn
            // 
            this.SaveBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SaveBtn.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // CloseBtn
            // 
            this.CloseBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CloseBtn.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(149, 52);
            this.gunaLabel1.Size = new System.Drawing.Size(164, 27);
            this.gunaLabel1.Text = "Add Category";
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.Location = new System.Drawing.Point(42, 198);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(438, 55);
            this.txtName.TabIndex = 0;
            // 
            // FormCategoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 436);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "FormCategoryAdd";
            this.Text = "FormCategoryAdd";
            this.Load += new System.EventHandler(this.FormCategoryAdd_Load);
            this.Controls.SetChildIndex(this.gunaPanel1, 0);
            this.Controls.SetChildIndex(this.gunaPanel2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaTextBox txtName;
    }
}