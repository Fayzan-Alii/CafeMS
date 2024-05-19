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
using System.Xml.Linq;

namespace CafeMS.Model
{
    public partial class FormCategoryAdd : SampleAdd
    {
        public FormCategoryAdd()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }


        public int id = 0;
        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into category values(@Name)";
            }
            else
            {
                qry = "Update category Set catName = @Name where catID = @id ";
            }
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }

        }

        private void FormCategoryAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
