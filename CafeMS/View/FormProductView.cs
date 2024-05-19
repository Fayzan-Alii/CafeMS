using CafeMS.Model;
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

namespace CafeMS.View
{
    public partial class FormProductView : SampleView
    {
        public FormProductView()
        {
            InitializeComponent();
        }

        private void FormProductView_Load(object sender, EventArgs e)
        {
            GetData();
        }


        public void GetData()
        {
            string qry = "select p.pID,p.pName,p.pPrice,p.pquantity,p.CategoryID,c.catName from products p inner join category c on p.CategoryID=c.catID where pName like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvQty);
            lb.Items.Add(dgvcatID);
            lb.Items.Add(dgvcat);
        
            MainClass.LoadData(qry, gunaDataGridView1, lb);
        }


        public override void AddBtn_Click(object sender, EventArgs e)
        {
            FormProductAdd frm = new FormProductAdd();
            frm.ShowDialog();
            GetData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }


        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                FormProductAdd frm = new FormProductAdd();
                frm.id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.cID = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvcatID"].Value);
                
                frm.ShowDialog();
                GetData();
            }
            if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                int id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = "Delete from products where pID= " + id + "";
                Hashtable ht = new Hashtable();
                MainClass.SQL(qry, ht);

                MessageBox.Show("Deleted successfully");
                GetData();
            }
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
