namespace CafeMS.Model
{
    partial class FormCheckout
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
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.txtBillAmount = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReceived = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChange = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaControlBox1);
            this.gunaPanel1.Size = new System.Drawing.Size(869, 129);
            this.gunaPanel1.Controls.SetChildIndex(this.gunaPictureBox1, 0);
            this.gunaPanel1.Controls.SetChildIndex(this.gunaLabel1, 0);
            this.gunaPanel1.Controls.SetChildIndex(this.gunaControlBox1, 0);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Location = new System.Drawing.Point(0, 472);
            this.gunaPanel2.Size = new System.Drawing.Size(869, 100);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Image = global::CafeMS.Properties.Resources.list;
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
            this.gunaLabel1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Size = new System.Drawing.Size(167, 37);
            this.gunaLabel1.Text = "Check Out";
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(783, 36);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Crimson;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 2;
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.BaseColor = System.Drawing.Color.White;
            this.txtBillAmount.BorderColor = System.Drawing.Color.Silver;
            this.txtBillAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBillAmount.Enabled = false;
            this.txtBillAmount.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBillAmount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBillAmount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBillAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBillAmount.Location = new System.Drawing.Point(28, 203);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.PasswordChar = '\0';
            this.txtBillAmount.SelectedText = "";
            this.txtBillAmount.Size = new System.Drawing.Size(351, 55);
            this.txtBillAmount.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bill Amount";
            // 
            // txtReceived
            // 
            this.txtReceived.BaseColor = System.Drawing.Color.White;
            this.txtReceived.BorderColor = System.Drawing.Color.Silver;
            this.txtReceived.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReceived.FocusedBaseColor = System.Drawing.Color.White;
            this.txtReceived.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtReceived.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReceived.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReceived.Location = new System.Drawing.Point(477, 203);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.PasswordChar = '\0';
            this.txtReceived.SelectedText = "";
            this.txtReceived.Size = new System.Drawing.Size(351, 55);
            this.txtReceived.TabIndex = 8;
            this.txtReceived.TextChanged += new System.EventHandler(this.txtReceived_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Payment Received";
            // 
            // txtChange
            // 
            this.txtChange.BaseColor = System.Drawing.Color.White;
            this.txtChange.BorderColor = System.Drawing.Color.Silver;
            this.txtChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChange.Enabled = false;
            this.txtChange.FocusedBaseColor = System.Drawing.Color.White;
            this.txtChange.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtChange.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChange.Location = new System.Drawing.Point(28, 360);
            this.txtChange.Name = "txtChange";
            this.txtChange.PasswordChar = '\0';
            this.txtChange.SelectedText = "";
            this.txtChange.Size = new System.Drawing.Size(351, 55);
            this.txtChange.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Change";
            // 
            // FormCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 572);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBillAmount);
            this.Controls.Add(this.label1);
            this.Name = "FormCheckout";
            this.Text = "FormCheckout";
            this.Load += new System.EventHandler(this.FormCheckout_Load);
            this.Controls.SetChildIndex(this.gunaPanel1, 0);
            this.Controls.SetChildIndex(this.gunaPanel2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtBillAmount, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtReceived, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtChange, 0);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        public Guna.UI.WinForms.GunaTextBox txtBillAmount;
        private System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaTextBox txtReceived;
        private System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaTextBox txtChange;
        private System.Windows.Forms.Label label3;
    }
}