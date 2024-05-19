using CafeMS.Model;
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
    public partial class FormCustomerMain : Form

    {
        public FormCustomerMain()
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

        private void CentralPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCustomerMain_Load(object sender, EventArgs e)
        {
           // AddControls(new FormHome());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            //AddControls(new FormHome());
            this.Hide();
            FormCustomerMain form = new FormCustomerMain();
            form.Show();
        }

        private void PosBtn_Click(object sender, EventArgs e)
        {
            FormPOS form = new FormPOS();
            form.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            FormFeedbackAdd form = new FormFeedbackAdd();
            form.Show();
        }
    }
}
