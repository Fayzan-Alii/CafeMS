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

namespace CafeMS.Model
{
    public partial class FormProductAdd : SampleAdd
    {
        public FormProductAdd()
        {
            InitializeComponent();
        }


        public int id = 0;
        public int cID = 0;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormProductAdd_Load(object sender, EventArgs e)
        {
            string qry = "select catID 'id' , catName 'name'  from category  ";

            MainClass.CBFill(qry, cbCat);

            if (cID > 0)
            {
                cbCat.SelectedValue = cID;
            }

            if(id>0)
            {
                ForUpdateLoadData();
            }

        }

        string filepath;
        Byte[] imageByteArray;

        


        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into products values(@Name,@price,@cat,@quantity,@img)";
            }
            else
            {
                qry = "Update products Set pName = @Name , pPrice = @price , CategoryID = @cat , pquantity = @quantity, pImage = @img where pID = @id ";
            }

            Image temp = new Bitmap(txtImage.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();


            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@price", txtPrice.Text);
            ht.Add("@cat", Convert.ToInt32(cbCat.SelectedValue));
            ht.Add("@quantity", txtQty.Text);
            ht.Add("@img", imageByteArray);


            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully");
                id = 0;
                cID = 0;
                txtName.Text = "";
                txtPrice.Text = "";
                txtQty.Text = "";
                cbCat.SelectedIndex = 0;
                cbCat.SelectedIndex = -1;
                txtImage.Image = CafeMS.Properties.Resources.brand_identity;
                txtName.Focus();
            }

        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)|* .png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                txtImage.Image = new Bitmap(filepath);
            }
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void ForUpdateLoadData()
        {
            string qry = @"select * from products where pID = "+ id +"";
            SqlCommand cmd = new SqlCommand(qry,MainClass.connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["pName"].ToString();
                txtPrice.Text = dt.Rows[0]["pPrice"].ToString();

                Byte[] imageArray = (byte[])(dt.Rows[0]["pImage"]);
                byte[] imageByteArray = imageArray;
                txtImage.Image= Image.FromStream(new MemoryStream(imageArray));
            }
        }

    }
}
