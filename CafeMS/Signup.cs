using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CafeMS
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\OneDrive\\Documents\\Cafe.mdf;Integrated Security=True;Connect Timeout=30");
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (usernametxt.Text != "" && passwordtxt.Text != "" && cbUsertype.Text != "")
                {
                   
                    if (cbUsertype.Text != "Manager")
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("insert into users values(@username,@password,@usertype)", connection);
                        command.Parameters.AddWithValue("@username", usernametxt.Text);
                        command.Parameters.AddWithValue("@password", passwordtxt.Text);
                        command.Parameters.AddWithValue("@usertype", cbUsertype.Text);
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Registered Successfully!");
                        usernametxt.Text = "";
                        passwordtxt.Text = "";
                        cbUsertype.Text = "";
                    }
                    else
                    {
                        int v = check(cbUsertype.Text);
                        if (v > 0)
                        {
                            MessageBox.Show("Cafe has a manager already.");
                        }
                        else
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("insert into users values(@username,@password,@usertype)", connection);
                            command.Parameters.AddWithValue("@username", usernametxt.Text);
                            command.Parameters.AddWithValue("@password", passwordtxt.Text);
                            command.Parameters.AddWithValue("@usertype", cbUsertype.Text);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Registered Successfully!");
                            usernametxt.Text = "";
                            passwordtxt.Text = "";
                            cbUsertype.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Information missing!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        int check(string usertype)
        {
            connection.Open();
            string query = "select count(*) from users where usertype='" + usertype + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }
    }
}
