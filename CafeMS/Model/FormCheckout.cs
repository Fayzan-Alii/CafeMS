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

namespace CafeMS.Model
{
    public partial class FormCheckout : SampleAdd
    {
        public FormCheckout()
        {
            InitializeComponent();
        }

        public double amt;
        public int MainId = 0;
        private void txtReceived_TextChanged(object sender, EventArgs e)
        {
            double amt = 0;
            double receipt = 0;
            double change = 0;

            double.TryParse(txtBillAmount.Text, out amt);
            double.TryParse(txtReceived.Text, out receipt);

            change = Math.Abs(amt - receipt);

            txtChange.Text = change.ToString();


        }

        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            string qry = @"update orders set total = @total, received = @rec, change = @change,
                            status = 'Paid' where orderID = @id";

            Hashtable ht = new Hashtable();
            ht.Add("@id", MainId);
            ht.Add("@total",txtBillAmount.Text);
            ht.Add("@rec",txtReceived.Text);
            ht.Add("@change",txtChange.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully");
                this.Close();
            }
        }

        private void FormCheckout_Load(object sender, EventArgs e)
        {
            txtBillAmount.Text = amt.ToString();
        }
    }
}
