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
    public partial class SampleAdd : Form
    {
        public SampleAdd()
        {
            InitializeComponent();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public virtual void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void SaveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
