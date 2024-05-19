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
    public partial class FormStaffView : SampleView
    {
        public FormStaffView()
        {
            InitializeComponent();
        }

        private void FormStaffView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string qry = "select * from staff where sName like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvRole);
            lb.Items.Add(dgvAge);

            MainClass.LoadData(qry, gunaDataGridView1, lb);
        }


        public override void AddBtn_Click(object sender, EventArgs e)
        {
            FormStaffAdd frm = new FormStaffAdd();
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
                FormStaffAdd frm = new FormStaffAdd();
                frm.id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.txtName.Text = Convert.ToString(gunaDataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.txtPhone.Text = Convert.ToString(gunaDataGridView1.CurrentRow.Cells["dgvPhone"].Value);
                frm.cbRole.Text = Convert.ToString(gunaDataGridView1.CurrentRow.Cells["dgvRole"].Value);
                frm.txtAge.Text = Convert.ToString(gunaDataGridView1.CurrentRow.Cells["dgvAge"].Value);
                frm.ShowDialog();
                GetData();
            }
            if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                int id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = "Delete from staff where staffID= " + id + "";
                Hashtable ht = new Hashtable();
                MainClass.SQL(qry, ht);

                MessageBox.Show("Deleted successfully");
                GetData();
            }
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
