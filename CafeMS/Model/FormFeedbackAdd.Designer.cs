namespace CafeMS.Model
{
    partial class FormFeedbackAdd
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new Guna.UI.WinForms.GunaTextBox();
            this.txtfeed = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaPanel1.Size = new System.Drawing.Size(963, 155);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Location = new System.Drawing.Point(0, 471);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaPanel2.Size = new System.Drawing.Size(963, 125);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Image = global::CafeMS.Properties.Resources.feedback;
            this.gunaPictureBox1.Location = new System.Drawing.Point(34, 4);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaPictureBox1.Size = new System.Drawing.Size(142, 125);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // SaveBtn
            // 
            this.SaveBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SaveBtn.Location = new System.Drawing.Point(34, 42);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveBtn.Size = new System.Drawing.Size(196, 50);
            this.SaveBtn.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click_1);
            // 
            // CloseBtn
            // 
            this.CloseBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CloseBtn.Location = new System.Drawing.Point(268, 42);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseBtn.Size = new System.Drawing.Size(196, 50);
            this.CloseBtn.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click_1);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(214, 65);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Size = new System.Drawing.Size(117, 27);
            this.gunaLabel1.Text = "Feedback";
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.BaseColor = System.Drawing.Color.White;
            this.txtname.BorderColor = System.Drawing.Color.Silver;
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.FocusedBaseColor = System.Drawing.Color.White;
            this.txtname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtname.Location = new System.Drawing.Point(28, 203);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.SelectedText = "";
            this.txtname.Size = new System.Drawing.Size(265, 48);
            this.txtname.TabIndex = 3;
            // 
            // txtfeed
            // 
            this.txtfeed.BaseColor = System.Drawing.Color.White;
            this.txtfeed.BorderColor = System.Drawing.Color.Silver;
            this.txtfeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfeed.FocusedBaseColor = System.Drawing.Color.White;
            this.txtfeed.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtfeed.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtfeed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtfeed.Location = new System.Drawing.Point(28, 345);
            this.txtfeed.Name = "txtfeed";
            this.txtfeed.PasswordChar = '\0';
            this.txtfeed.SelectedText = "";
            this.txtfeed.Size = new System.Drawing.Size(482, 119);
            this.txtfeed.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Feeback";
            // 
            // FormFeedbackAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.ClientSize = new System.Drawing.Size(963, 596);
            this.Controls.Add(this.txtfeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormFeedbackAdd";
            this.Controls.SetChildIndex(this.gunaPanel1, 0);
            this.Controls.SetChildIndex(this.gunaPanel2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtname, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtfeed, 0);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtFeedback;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtname;
        private Guna.UI.WinForms.GunaTextBox txtfeed;
        private System.Windows.Forms.Label label4;
    }
}