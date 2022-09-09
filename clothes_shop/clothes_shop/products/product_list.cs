using clothes_shop.DB;
using clothes_shop.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clothes_shop.products
{
    public partial class product_list : Form
    {// create object of database
        salesEntities3 db = new salesEntities3();
        //string to copy the path of photo 
        string path="";
        //the id of selected product

        int id;
        public product_list()
        {
            InitializeComponent();
            //shoe the all data in products table
            dataGridView1.DataSource = db.Products.ToList();
        }

        private void st()
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
       //search for item
        private void button1_Click(object sender, EventArgs e)
        {
            //if the user dont putt a name but put a parcode
            if (nameform_tex.Text == "")//show the searched item in data grid
                
                dataGridView1.DataSource = db.Products.Where(x => x.parcode == par_ctex.Text).ToList();

            else dataGridView1.DataSource = db.Products.Where(x => x.parcode == par_ctex.Text || x.Name == nameform_tex.Text).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void product_list_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {//to refresh the grid from the searched item
            dataGridView1.DataSource = db.Products.ToList();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //method help to go to new user form
        void fn()
        {
            Application.Run(new New_Users());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //method help to go toproducts form
        void x()
        {
            Application.Run(new products());
        }
           //method help to go to nproducts list form
        void y()
        {
            Application.Run(new  product_list());
        }
        // saved button(for edit the product  )
        private void button3_Click(object sender, EventArgs e)
        {//select id using data grid 
          id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //select the raw of the id
            var result = db.Products.SingleOrDefault(x => x.Code == id);
            //edit   the product
            result.Name = name_tex.Text;
            result.Quantity = int.Parse(qua_tex.Text);
            result.Price = decimal.Parse(price_tex.Text);
        
            result.Image = path;
            //save changes to database
            db.SaveChanges();
            MessageBox.Show("SAVED");
           // refresh_but the dataGridView1
            dataGridView1.DataSource = db.Products.ToList();
            //empty name product text box
            name_tex.Text = string.Empty;
            //empty  quantity  product text box
            qua_tex.Text = string.Empty;
            //empty  price  product text box
            price_tex.Text = string.Empty;
            //empty  price  product text box

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // if there an error dont do anything
            try
            {
                //selsect id from select cell  in data grid
                 id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                //show the value the saved database for selected row in chosen text boxes or pictureboxes
                var result = db.Products.SingleOrDefault(x => x.Code == id);
                name_tex.Text = result.Name;
                qua_tex.Text = result.Quantity.ToString();
                price_tex.Text = result.Price.ToString();
             
                //show the the photo in picture box
                pictureBox1.ImageLocation = result.Image;
            }
            catch { }

      }

        private void pictureBox1_Click(object sender, EventArgs e)
        {//showing photo in the picture box
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog()==DialogResult.OK )
            {
                path = dialog.FileName;
                pictureBox1.ImageLocation = dialog.FileName;
            }
        }

        private void button2_Click_1(object sender, EventArgs e) //delete
        {//delete a product from database
            var r = MessageBox.Show("Do you want to delete", "Are you sure about deleting", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {//select aproduct to deleteby using  id
                var result = db.Products.Find(id);
                //delete product
                db.Products.Remove(result);
                //save that the database
                db.SaveChanges();
                MessageBox.Show("Deleted");//refresh the database
                dataGridView1.DataSource = db.Products.ToList();
                //empty name product text box
                name_tex.Text = string.Empty;
                //empty  quantity  product text box
                qua_tex.Text = string.Empty;
                //empty  price  product text box
                price_tex.Text = string.Empty;
                //empty  price  product text box
            }
        }

      

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }
        // open  product list
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(y);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        // open new user form
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(fn);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        //open product form 
        private void button4_Click(object sender, EventArgs e)
        {
           Close();
        
            Thread th = new Thread(x);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void name_tex_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
