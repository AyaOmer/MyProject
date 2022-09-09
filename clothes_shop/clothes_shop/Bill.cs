using clothes_shop.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clothes_shop
{
    public partial class Bill : Form
    { //create object of database
        salesEntities3 db = new salesEntities3();
      
        
        public Bill()
        {
            InitializeComponent();
       
           
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProdID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }
        //list of selected products
        List<Product> pro = new List<Product>();
        
        //sell function
        private void button1_Click(object sender, EventArgs e)
        {//copy the id of text box
            var id = int.Parse(ProdID.Text);
            //copy the raw of the product
          var list =  db.Products.SingleOrDefault(x => x.Code ==id);
            //add select information about product to pro
            pro.Add(list);

            //if the customer sure about buying the product
            var t = MessageBox.Show("DO you want Add? ", "Adding Product", MessageBoxButtons.OKCancel);
            //check the   the choosing button box
            if (t == DialogResult.OK )
            {
                MessageBox.Show("Done");
                //decrease the quantity of select product
                list.Quantity--;
                //save to databse
                db.SaveChanges();

            }
         

            
           //add the selected products to grid
            dataGridView1.DataSource = new List<Product>(pro);
            //showing the  price of selected  item
            setPrice();

            //empty the search for id text box
            ProdID.Text = string.Empty;
        }

        decimal totalprice = 0;
        //calculate the price of selected item
        void setPrice()
        {
            totalprice = 0;
            for (int i = 0; i < pro.Count; i++)
            {
                totalprice += pro[i].Price.Value;
            }
            //passig the result to textbox
            prodPrice.Text = totalprice.ToString();
        }
       // 
        private void serch_but_Click(object sender, EventArgs e)
        {
          //search for the item usig name or parcode or both
           
            if (nameform_tex.Text == "")//if name box is empty
                dataGridView2.DataSource = db.Products.Where(x => x.parcode == parcod_tex.Text ).ToList();
            else
                dataGridView2.DataSource = db.Products.Where(x => x.Name == nameform_tex.Text || x.parcode == parcod_tex.Text).ToList();

            //empty the name for search  box text
            nameform_tex.Text = string.Empty;
            //empty parcode box text for search 
            parcod_tex.Text = string.Empty;
        }

        private void refreh_but_Click(object sender, EventArgs e)
        {//refresh data grid
            dataGridView2.DataSource = db.Products.ToList();
            //empty the name for search  box text
            nameform_tex.Text = string.Empty;
            //empty parcode box text for search 
            parcod_tex.Text = string.Empty;
        }

        private void prodPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameform_tex_TextChanged(object sender, EventArgs e)
        {

        }

        private void par_ctex_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
