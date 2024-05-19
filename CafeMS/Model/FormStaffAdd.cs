using CafeMS;
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
    public partial class FormStaffAdd : SampleAdd
    {
        public FormStaffAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into staff values(@Name,@phone,@role,@age)";
            }
            else
            {
                qry = "Update staff Set sName = @Name , sPhone = @phone , sRole = @role, age = @age where staffID = @id ";
            }
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@phone", txtPhone.Text);
            ht.Add("@role", cbRole.Text);
            ht.Add("@age", txtAge.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully");
                id = 0;
                txtName.Text = "";
                txtPhone.Text = "";
                cbRole.SelectedIndex = -1;
                txtAge.Text = "";
                txtName.Focus();
            }

        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
