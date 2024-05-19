using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CafeMS.Model
{
    public partial class FormFeedbackAdd : SampleAdd
    {
        public FormFeedbackAdd()
        {
            InitializeComponent();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public int id = 0;

        //public override void SaveBtn_Click(object sender, EventArgs e)
        //{
        //    string qry = "";

        //    if (id == 0)
        //    {
        //        qry = "Insert into staff Feedback(@Feedback,@Name,@Date)";
        //    }
        //    else
        //    {
        //        qry = "Update Feedback Set feedback = @Feedback , username = @Name , fDate = @Date where fId = @id ";
        //    }
        //    Hashtable ht = new Hashtable();
        //    ht.Add("@id", id);
        //    ht.Add("@Feedback", txtFeedback.Text);
        //    ht.Add("@Name", txtUsername.Text);
        //    ht.Add("@Date", Convert.ToDateTime(DateTime.Now.Date));
          

        //    if (MainClass.SQL(qry, ht) > 0)
        //    {
        //        MessageBox.Show("Saved successfully");
        //        id = 0;
        //        txtFeedback.Text = "";
        //        txtUsername.Text = "";
                
        //    }

        //}

        //private void SaveBtn_Click_1(object sender, EventArgs e)
        //{
        //    string qry = "";

        //    if (id == 0)
        //    {
        //        qry = "Insert into staff Feedback(@Feedback,@Name,@Date)";
        //    }
        //    else
        //    {
        //        qry = "Update Feedback Set feedback = @Feedback , username = @Name , fDate = @Date where fId = @id ";
        //    }
        //    Hashtable ht = new Hashtable();
        //    ht.Add("@id", id);
        //    ht.Add("@Feedback", txtfeed.Text);
        //    ht.Add("@Name", txtname.Text);
        //    ht.Add("@Date", Convert.ToDateTime(DateTime.Now.Date));


        //    if (MainClass.SQL(qry, ht) > 0)
        //    {
        //        MessageBox.Show("Saved successfully");
        //        id = 0;
        //        txtfeed.Text = "";
        //        txtname.Text = "";
                
        //    }
        //}

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into Feedback (feedback, username, fDate) values (@Feedback, @Name, @Date)";
            }
            else
            {
                qry = "Update Feedback Set feedback = @Feedback, username = @Name, fDate = @Date where fId = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Feedback", txtfeed.Text);
            ht.Add("@Name", txtname.Text);
            ht.Add("@Date", Convert.ToDateTime(DateTime.Now.Date));

            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully");
                id = 0;
                txtfeed.Text = "";
                txtname.Text = "";
            }
        }


        private void CloseBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
