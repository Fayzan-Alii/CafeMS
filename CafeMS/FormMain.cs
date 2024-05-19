using CafeMS.Model;
using CafeMS.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public void AddControls(Form f)
        {
            //FormMain frm=new FormMain();
            CentralPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CentralPanel.Controls.Add(f);
            f.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            AddControls(new FormHome());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            AddControls(new FormHome());
        }

        private void PosBtn_Click(object sender, EventArgs e)
        {
            FormFeedbackView form = new FormFeedbackView();
            form.Show();
        }

        private void CategoriesBtn_Click(object sender, EventArgs e)
        {
            AddControls(new FormCategoryView());
        }

        private void StaffBtn_Click(object sender, EventArgs e)
        {
            AddControls(new FormStaffView());
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            AddControls(new FormProductView());
        }

        private void CentralPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
