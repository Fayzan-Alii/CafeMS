using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMS.View
{
    public partial class FormFeedbackView : SampleView
    {
        public FormFeedbackView()
        {
            InitializeComponent();
        }



        public void GetData()
        {
            string qry = "select f.fId,f.feedback,f.username,f.fDate from users u inner join feedback f on f.username=u.username where u.username like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvfd);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvDate);
            //lb.Items.Add(dgvQty);
            //lb.Items.Add(dgvcatID);
            //lb.Items.Add(dgvcat);

            MainClass.LoadData(qry, gunaDataGridView1, lb);
        }

        private void FormFeedbackView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
