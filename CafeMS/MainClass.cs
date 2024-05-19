using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMS
{
    internal class MainClass
    {
        public static readonly string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\OneDrive\\Documents\\Cafe.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection connection = new SqlConnection(connectionstring);


        public static bool IsValidUser(string user, string pass, string usertype)
        {
            bool isValid = false;

            // string query = @"select * from [User] where username  = '" + user + "' and upass ='" + pass + "'  ";
            string query = @"select * from users where username  = '" + user + "' and password ='" + pass + "' and usertype ='" + usertype + "'  ";
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
            }

            return isValid;
        }
        
        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(qry, connection);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                res = cmd.ExecuteNonQuery();
                if (connection.State == ConnectionState.Open) { connection.Close(); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }


            return res;
        }


        public static void LoadData(string qry, DataGridView gv, ListBox lb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(qry, connection);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colName1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colName1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }


        public static void CBFill(string qry, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(qry, connection);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);


            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }


    }
}
