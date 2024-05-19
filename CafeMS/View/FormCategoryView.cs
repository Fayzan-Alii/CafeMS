using CafeMS.Model;
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

namespace CafeMS.View
{
    public partial class FormCategoryView : SampleView
    {
        public FormCategoryView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "select * from category where catName like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            MainClass.LoadData(qry, gunaDataGridView1, lb);
        }

        public override void AddBtn_Click(object sender, EventArgs e)
        {
            FormCategoryAdd frm = new FormCategoryAdd();
            frm.ShowDialog();
            GetData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void FormCategoryView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                FormCategoryAdd frm = new FormCategoryAdd();
                frm.id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.txtName.Text = Convert.ToString(gunaDataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.ShowDialog();
                GetData();
            }
            if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                int id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = "Delete from category where catID= " + id + "";
                Hashtable ht = new Hashtable();
                MainClass.SQL(qry, ht);

                MessageBox.Show("Deleted successfully");
                GetData();
            }
        }
    }


}
