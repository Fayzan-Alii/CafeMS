namespace CafeMS.Model
{
    partial class FormProductAdd
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new Guna.UI.WinForms.GunaButton();
            this.txtImage = new Guna.UI.WinForms.GunaPictureBox();
            this.cbCat = new Guna.UI.WinForms.GunaComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtQty = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Size = new System.Drawing.Size(964, 129);
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Location = new System.Drawing.Point(0, 458);
            this.gunaPanel2.Size = new System.Drawing.Size(964, 104);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Image = global::CafeMS.Properties.Resources.box;
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // SaveBtn
            // 
            this.SaveBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SaveBtn.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click_1);
            // 
            // CloseBtn
            // 
            this.CloseBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CloseBtn.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(162, 54);
            this.gunaLabel1.Size = new System.Drawing.Size(155, 24);
            this.gunaLabel1.Text = "Products Details";
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Category";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BaseColor = System.Drawing.Color.White;
            this.txtPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.Location = new System.Drawing.Point(370, 192);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(289, 35);
            this.txtPrice.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Price";
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
            this.txtName.Location = new System.Drawing.Point(28, 192);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(289, 35);
            this.txtName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AnimationHoverSpeed = 0.07F;
            this.btnBrowse.AnimationSpeed = 0.03F;
            this.btnBrowse.BaseColor = System.Drawing.Color.LightSeaGreen;
            this.btnBrowse.BorderColor = System.Drawing.Color.Black;
            this.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBrowse.FocusedColor = System.Drawing.Color.Empty;
            this.btnBrowse.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Image = null;
            this.btnBrowse.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBrowse.Location = new System.Drawing.Point(741, 339);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.OnHoverBaseColor = System.Drawing.Color.DarkCyan;
            this.btnBrowse.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBrowse.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBrowse.OnHoverImage = null;
            this.btnBrowse.OnPressedColor = System.Drawing.Color.Black;
            this.btnBrowse.Size = new System.Drawing.Size(167, 42);
            this.btnBrowse.TabIndex = 18;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // txtImage
            // 
            this.txtImage.BaseColor = System.Drawing.Color.White;
            this.txtImage.Image = global::CafeMS.Properties.Resources.brand_identity;
            this.txtImage.Location = new System.Drawing.Point(741, 165);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(167, 147);
            this.txtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImage.TabIndex = 19;
            this.txtImage.TabStop = false;
            // 
            // cbCat
            // 
            this.cbCat.BackColor = System.Drawing.Color.Transparent;
            this.cbCat.BaseColor = System.Drawing.Color.White;
            this.cbCat.BorderColor = System.Drawing.Color.Silver;
            this.cbCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat.FocusedColor = System.Drawing.Color.Empty;
            this.cbCat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCat.ForeColor = System.Drawing.Color.Black;
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Items.AddRange(new object[] {
            "Drinks",
            "Meal",
            "Burger"});
            this.cbCat.Location = new System.Drawing.Point(28, 339);
            this.cbCat.Name = "cbCat";
            this.cbCat.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbCat.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbCat.Size = new System.Drawing.Size(289, 35);
            this.cbCat.TabIndex = 20;
            this.cbCat.SelectedIndexChanged += new System.EventHandler(this.cbCat_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity";
            // 
            // txtQty
            // 
            this.txtQty.BaseColor = System.Drawing.Color.White;
            this.txtQty.BorderColor = System.Drawing.Color.Silver;
            this.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQty.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtQty.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQty.Location = new System.Drawing.Point(370, 339);
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.SelectedText = "";
            this.txtQty.Size = new System.Drawing.Size(289, 35);
            this.txtQty.TabIndex = 10;
            // 
            // FormProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 562);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "FormProductAdd";
            this.Text = "FormProductAdd";
            this.Load += new System.EventHandler(this.FormProductAdd_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtPrice, 0);
            this.Controls.SetChildIndex(this.txtQty, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnBrowse, 0);
            this.Controls.SetChildIndex(this.gunaPanel1, 0);
            this.Controls.SetChildIndex(this.gunaPanel2, 0);
            this.Controls.SetChildIndex(this.txtImage, 0);
            this.Controls.SetChildIndex(this.cbCat, 0);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaTextBox txtPrice;
        private System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaTextBox txtName;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnBrowse;
        private Guna.UI.WinForms.GunaPictureBox txtImage;
        public Guna.UI.WinForms.GunaComboBox cbCat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label4;
        public Guna.UI.WinForms.GunaTextBox txtQty;
    }
}