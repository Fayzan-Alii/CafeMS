namespace CafeMS.Model
{
    partial class FormPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnCheckout = new Guna.UI.WinForms.GunaButton();
            this.lblTotal = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.btnKot = new Guna.UI.WinForms.GunaButton();
            this.btnBill = new Guna.UI.WinForms.GunaButton();
            this.btnNew = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnExit = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ucProduct3 = new CafeMS.Model.ucProduct();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvproID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.gunaPanel1.Controls.Add(this.btnCheckout);
            this.gunaPanel1.Controls.Add(this.lblTotal);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 627);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1512, 106);
            this.gunaPanel1.TabIndex = 0;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckout.AnimationHoverSpeed = 0.07F;
            this.btnCheckout.AnimationSpeed = 0.03F;
            this.btnCheckout.BaseColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCheckout.BorderColor = System.Drawing.Color.Transparent;
            this.btnCheckout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCheckout.FocusedColor = System.Drawing.Color.Empty;
            this.btnCheckout.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Image = null;
            this.btnCheckout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCheckout.Location = new System.Drawing.Point(1048, 26);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.OnHoverBaseColor = System.Drawing.Color.SeaGreen;
            this.btnCheckout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCheckout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCheckout.OnHoverImage = null;
            this.btnCheckout.OnPressedColor = System.Drawing.Color.Black;
            this.btnCheckout.Size = new System.Drawing.Size(160, 42);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Transparent;
            this.lblTotal.Location = new System.Drawing.Point(1358, 26);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(97, 49);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "0.00";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Location = new System.Drawing.Point(1252, 30);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(100, 44);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Total";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.SteelBlue;
            this.gunaPanel2.Controls.Add(this.btnKot);
            this.gunaPanel2.Controls.Add(this.btnBill);
            this.gunaPanel2.Controls.Add(this.btnNew);
            this.gunaPanel2.Controls.Add(this.gunaLabel1);
            this.gunaPanel2.Controls.Add(this.btnExit);
            this.gunaPanel2.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1512, 104);
            this.gunaPanel2.TabIndex = 1;
            // 
            // btnKot
            // 
            this.btnKot.AnimationHoverSpeed = 0.07F;
            this.btnKot.AnimationSpeed = 0.03F;
            this.btnKot.BaseColor = System.Drawing.Color.SkyBlue;
            this.btnKot.BorderColor = System.Drawing.Color.Black;
            this.btnKot.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnKot.FocusedColor = System.Drawing.Color.Empty;
            this.btnKot.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKot.ForeColor = System.Drawing.Color.Black;
            this.btnKot.Image = global::CafeMS.Properties.Resources.chef;
            this.btnKot.ImageSize = new System.Drawing.Size(20, 20);
            this.btnKot.Location = new System.Drawing.Point(558, 12);
            this.btnKot.Name = "btnKot";
            this.btnKot.OnHoverBaseColor = System.Drawing.Color.OrangeRed;
            this.btnKot.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnKot.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnKot.OnHoverImage = null;
            this.btnKot.OnPressedColor = System.Drawing.Color.Black;
            this.btnKot.Size = new System.Drawing.Size(109, 80);
            this.btnKot.TabIndex = 2;
            this.btnKot.Text = "    Place Order";
            this.btnKot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnKot.Click += new System.EventHandler(this.btnKot_Click);
            // 
            // btnBill
            // 
            this.btnBill.AnimationHoverSpeed = 0.07F;
            this.btnBill.AnimationSpeed = 0.03F;
            this.btnBill.BaseColor = System.Drawing.Color.SkyBlue;
            this.btnBill.BorderColor = System.Drawing.Color.Black;
            this.btnBill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBill.FocusedColor = System.Drawing.Color.Empty;
            this.btnBill.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.Black;
            this.btnBill.Image = global::CafeMS.Properties.Resources.history;
            this.btnBill.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBill.Location = new System.Drawing.Point(404, 12);
            this.btnBill.Name = "btnBill";
            this.btnBill.OnHoverBaseColor = System.Drawing.Color.OrangeRed;
            this.btnBill.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBill.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnBill.OnHoverImage = null;
            this.btnBill.OnPressedColor = System.Drawing.Color.Black;
            this.btnBill.Size = new System.Drawing.Size(80, 80);
            this.btnBill.TabIndex = 2;
            this.btnBill.Text = "    Bill List";
            this.btnBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnNew
            // 
            this.btnNew.AnimationHoverSpeed = 0.07F;
            this.btnNew.AnimationSpeed = 0.03F;
            this.btnNew.BaseColor = System.Drawing.Color.SkyBlue;
            this.btnNew.BorderColor = System.Drawing.Color.Black;
            this.btnNew.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNew.FocusedColor = System.Drawing.Color.Empty;
            this.btnNew.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Image = global::CafeMS.Properties.Resources.billing;
            this.btnNew.ImageSize = new System.Drawing.Size(22, 22);
            this.btnNew.Location = new System.Drawing.Point(253, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.OnHoverBaseColor = System.Drawing.Color.OrangeRed;
            this.btnNew.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNew.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnNew.OnHoverImage = null;
            this.btnNew.OnPressedColor = System.Drawing.Color.Black;
            this.btnNew.Size = new System.Drawing.Size(80, 80);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "    New";
            this.btnNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Location = new System.Drawing.Point(98, 31);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(82, 41);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "POS";
            // 
            // btnExit
            // 
            this.btnExit.BaseColor = System.Drawing.Color.White;
            this.btnExit.Image = global::CafeMS.Properties.Resources._switch;
            this.btnExit.Location = new System.Drawing.Point(1190, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 80);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::CafeMS.Properties.Resources.sign;
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 11);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(80, 80);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoryPanel.AutoScroll = true;
            this.CategoryPanel.Location = new System.Drawing.Point(12, 167);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(161, 454);
            this.CategoryPanel.TabIndex = 2;
            this.CategoryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CategoryPanel_Paint);
            // 
            // ProductPanel
            // 
            this.ProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPanel.AutoScroll = true;
            this.ProductPanel.Controls.Add(this.ucProduct3);
            this.ProductPanel.Location = new System.Drawing.Point(175, 152);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(898, 469);
            this.ProductPanel.TabIndex = 3;
            // 
            // ucProduct3
            // 
            this.ucProduct3.id = 0;
            this.ucProduct3.Location = new System.Drawing.Point(3, 3);
            this.ucProduct3.Name = "ucProduct3";
            this.ucProduct3.PCategory = null;
            this.ucProduct3.PImage = ((System.Drawing.Image)(resources.GetObject("ucProduct3.PImage")));
            this.ucProduct3.PName = "Product Name";
            this.ucProduct3.PPrice = null;
            this.ucProduct3.Size = new System.Drawing.Size(8, 8);
            this.ucProduct3.TabIndex = 2;
            // 
            // gunaDataGridView1
            // 
            this.gunaDataGridView1.AllowUserToAddRows = false;
            this.gunaDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.gunaDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.gunaDataGridView1.ColumnHeadersHeight = 40;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvid,
            this.dgvproID,
            this.dgvName,
            this.dgvQty,
            this.dgvPrice,
            this.dgvAmount});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle24;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(884, 152);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.ReadOnly = true;
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 62;
            this.gunaDataGridView1.RowTemplate.Height = 35;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(616, 469);
            this.gunaDataGridView1.TabIndex = 9;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = true;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 35;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            this.gunaDataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gunaDataGridView1_CellFormatting);
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.FillWeight = 70F;
            this.dgvSno.Frozen = true;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 70;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            this.dgvSno.Width = 70;
            // 
            // dgvid
            // 
            this.dgvid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvid.FillWeight = 70F;
            this.dgvid.Frozen = true;
            this.dgvid.HeaderText = "id";
            this.dgvid.MinimumWidth = 70;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Width = 70;
            // 
            // dgvproID
            // 
            this.dgvproID.HeaderText = "ProductID";
            this.dgvproID.MinimumWidth = 8;
            this.dgvproID.Name = "dgvproID";
            this.dgvproID.ReadOnly = true;
            this.dgvproID.Visible = false;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 8;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvQty
            // 
            this.dgvQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvQty.FillWeight = 50F;
            this.dgvQty.HeaderText = "Qty";
            this.dgvQty.MinimumWidth = 50;
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            this.dgvQty.Width = 50;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPrice.FillWeight = 50F;
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.MinimumWidth = 50;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 50;
            // 
            // dgvAmount
            // 
            this.dgvAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvAmount.FillWeight = 60F;
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.MinimumWidth = 60;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            this.dgvAmount.Width = 60;
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
            this.txtSearch.Location = new System.Drawing.Point(295, 110);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(290, 36);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::CafeMS.Properties.Resources.search;
            this.gunaPictureBox2.Location = new System.Drawing.Point(240, 110);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(49, 36);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 11;
            this.gunaPictureBox2.TabStop = false;
            // 
            // FormPOS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1512, 733);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.CategoryPanel);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPOS";
            this.Text = "FormPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPOS_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ProductPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton btnNew;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnBill;
        private Guna.UI.WinForms.GunaPictureBox btnExit;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private ucProduct ucProduct3;
        public Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        public Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaLabel lblTotal;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnKot;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvproID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public Guna.UI.WinForms.GunaButton btnCheckout;
    }
}