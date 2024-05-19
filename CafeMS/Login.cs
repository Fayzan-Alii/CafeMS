using CafeMS.Model;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        //private void ExitBtn_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        //private void LoginBtn_Click(object sender, EventArgs e)
        //{
        //    if (MainClass.IsValidUser(usernametxt.Text, passwordtxt.Text) == false)
        //    {
        //        MessageBox.Show("Invalid Username or Password.");
        //        return;
        //    }
        //    else
        //    {
        //        this.Hide();
        //        FormMain formMain = new FormMain();
        //        formMain.Show();
        //    }
        //}

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            if (MainClass.IsValidUser(usernametxt.Text, passwordtxt.Text,cbUsertype.Text) == false)
            {
                MessageBox.Show("Invalid Username or Password.");
                return;
            }
            else
            {
                if (cbUsertype.Text == "Customer")
                {
                    this.Hide();
                    FormCustomerMain form = new FormCustomerMain();
                    form.Show();
                }
                else
                {
                    this.Hide();
                    FormMain formMain = new FormMain();
                    formMain.Show();
                }
            }
        }

        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Signup form = new Signup();
            form.Show();
        }

        //private void loginBtn_Click_1(object sender, EventArgs e)
        //{
        //    if (MainClass.IsValidUser(usernametxt.Text, passwordtxt.Text) == false)
        //    {
        //        MessageBox.Show("Invalid Username or Password.");
        //        return;
        //    }
        //    else
        //    {
        //        this.Hide();
        //        FormMain formMain = new FormMain();
        //        formMain.Show();
        //    }
        //}

        //private void exitBtn_Click_1(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}
    }
}
