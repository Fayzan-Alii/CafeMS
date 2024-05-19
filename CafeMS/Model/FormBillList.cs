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
    public partial class FormBillList : SampleAdd
    {
        public FormBillList()
        {
            InitializeComponent();
        }
        public int MainID = 0;
        private void FormBillList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string qry = @"select orderID,status,total from orders ";

            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTotal);

            MainClass.LoadData(qry, gunaDataGridView1, lb);
        }

        private void gunaDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in gunaDataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                
                MainID = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
               this.Close();
                
            }
        }

    }
}
