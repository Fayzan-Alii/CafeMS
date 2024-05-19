using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CafeMS.Model
{
    public partial class FormPOS : Form
    {
        public FormPOS()
        {
            InitializeComponent();
        }

        public int MainID = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPOS_Load(object sender, EventArgs e)
        {
            gunaDataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();

            ProductPanel.Controls.Clear();
            LoadProducts();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void AddCategory()
        {
            string qry = "select * from category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CategoryPanel.Controls.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Button b = new Button();
                    b.BackColor = Color.SteelBlue;
                    b.Size = new Size(142, 45);
                    b.Text = row["catName"].ToString();

                    b.Click += new EventHandler(_Click);

                    CategoryPanel.Controls.Add(b);
                }
            }
        }


        private void _Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }


        private void AddItems(string id,string proID,string name,string cat,string price,Image pimage)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(proID)
            };


            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;

                foreach(DataGridViewRow item in gunaDataGridView1.Rows)
                {
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value)==wdg.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                        double.Parse(item.Cells["dgvPrice"].Value.ToString());

                        return;
                    }

                }

                gunaDataGridView1.Rows.Add(new object[] { 0, 0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                GetTotal();
            };


        }


        private void LoadProducts()
        {
            string qry = "select * from products inner join category on catID = CategoryID";
            SqlCommand cmd = new SqlCommand(qry, MainClass.connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);


            foreach(DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["pImage"];
                byte[] imagebytearray = imagearray;

                AddItems("0",item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(),
                    item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach(var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }

        private void gunaDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach(DataGridViewRow row in gunaDataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }


        private void GetTotal()
        {
            double tot = 0;
            lblTotal.Text = "";
            foreach(DataGridViewRow item in gunaDataGridView1.Rows)
            {
                tot += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }

            lblTotal.Text = tot.ToString("N2");
        }

        private void CategoryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            gunaDataGridView1.Rows.Clear();
            MainID = 0;
            lblTotal.Text = "0.00";
        }


        private bool CheckProductQuantity(int productID, int quantityOrdered)
        {
            // Add code here to retrieve the current quantity of the product from the "products" table
            // You can use a SELECT query to get the quantity and compare it with the ordered quantity
            // If there is sufficient quantity, return true; otherwise, return false.

            // Example query (replace it with your actual query):
            string selectQuantityQuery = "SELECT pquantity FROM products WHERE pID = @productID";

            using (SqlCommand cmd = new SqlCommand(selectQuantityQuery, MainClass.connection))
            {
                cmd.Parameters.AddWithValue("@productID", productID);

                if (MainClass.connection.State == ConnectionState.Closed) { MainClass.connection.Open(); }
                int availableQuantity = Convert.ToInt32(cmd.ExecuteScalar());
                if (MainClass.connection.State == ConnectionState.Open) { MainClass.connection.Close(); }

                return availableQuantity >= quantityOrdered;
            }
        }

        private void btnKot_Click(object sender, EventArgs e)
        {
            string qry1 = "";
            string qry2 = "";

            int detailID = 0;

            if(MainID == 0)
            {
                qry1 = @"insert into orders values(@aDate,@aTime,@status,@total,@received,@change);
                              select SCOPE_IDENTITY()";
            }
            else
            {
                qry1 = @"update orders set status = @status , total = @total , received = @received , change = @change where orderID = @ID";
            }



            SqlCommand cmd = new SqlCommand(qry1, MainClass.connection);

            cmd.Parameters.AddWithValue("@ID",MainID);
            cmd.Parameters.AddWithValue("@aDate",Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime",DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@status","Pending");
            cmd.Parameters.AddWithValue("@total",Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@received",Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change",Convert.ToDouble(0));


            if(MainClass.connection.State == ConnectionState.Closed) { MainClass.connection.Open(); }
            if(MainID==0) { MainID=Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }
            if(MainClass.connection.State==ConnectionState.Open) { MainClass.connection.Close(); }

            foreach (DataGridViewRow row in gunaDataGridView1.Rows)
            {
                int productID = Convert.ToInt32(row.Cells["dgvproID"].Value);
                int quantityOrdered = Convert.ToInt32(row.Cells["dgvQty"].Value);

                // Check product quantity in the products table
                if (!CheckProductQuantity(productID, quantityOrdered))
                {
                    // Insufficient quantity, show a message and stop further processing
                    MessageBox.Show($"Insufficient quantity for product ID {productID}");
                    return; // Stop further processing
                }
            }

            foreach (DataGridViewRow row in gunaDataGridView1.Rows )
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if(detailID==0)
                {
                    qry2 = @"insert into orderDetails values(@orderID,@proID,@qty,@price,@amount)";
                }
                else
                {
                    qry2 = @"update orderDetails set proId = @proID , qty = @qty , price = @price , amount = @amount
                            where DetailID = @ID";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.connection);

                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@orderID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (MainClass.connection.State == ConnectionState.Closed) { MainClass.connection.Open(); }
                cmd2.ExecuteNonQuery(); 
                if (MainClass.connection.State == ConnectionState.Open) { MainClass.connection.Close(); }

            }
            MessageBox.Show("Saved successfully");
            MainID = 0;
            detailID = 0;
            gunaDataGridView1.Rows.Clear();
            lblTotal.Text = "0.00";
        }
        public int id = 0;
        private void btnBill_Click(object sender, EventArgs e)
        {
            FormBillList form = new FormBillList();
            form.ShowDialog();

            if (form.MainID > 0)
            {
                id = form.MainID;
                LoadEnteries();
            }
        }

        private void LoadEnteries()
        {
            string qry = @"select * from orders o
                            inner join orderDetails od on o.orderID = od.orderID
                            inner join products p on p.pID = od.proID
                                where o.orderID = " + id + "";
            SqlCommand cmd = new SqlCommand(qry, MainClass.connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            gunaDataGridView1.Rows.Clear ();


            foreach (DataRow item in dt.Rows)
            {
                string detailID = item["DetailID"].ToString();
                string proName = item["pName"].ToString();
                string proID = item["proID"].ToString();
                string qty = item["qty"].ToString();
                string price = item["price"].ToString();
                string amount = item["amount"].ToString();

                object[] obj = { 0,detailID,proID,proName,qty,price,amount };
                gunaDataGridView1.Rows.Add(obj);
            }
            GetTotal();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            FormCheckout form = new FormCheckout();
            form.MainId = id;
            form.amt = Convert.ToDouble(lblTotal.Text);
            form.ShowDialog();
            MainID = 0;
            gunaDataGridView1.Rows.Clear();
            lblTotal.Text = "0.00";
        }
    }
}
