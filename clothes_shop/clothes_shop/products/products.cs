using clothes_shop.DB;
using clothes_shop.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clothes_shop.products
{
    public partial class products : Form
    {
        string path="";
       //create object of database
        salesEntities3 db = new salesEntities3();
        public products()
        {
            InitializeComponent();
        }

       
        //creat new product
        private void button1_Click(object sender, EventArgs e)
        {
            clothes_shop.DB.Product p = new Product()
          
             {//add name product
                 Name = name_tex.Text,
                 //add quantity of the product
                 Quantity = int.Parse(quan_tex.Text), //add price product
                 Price = decimal.Parse(price_tex.Text),
        
                 Image=path
             };
            //add product to database
            db.Products.Add(p);
            //save changes to database
            db.SaveChanges();

            MessageBox.Show("saved");
        
        
          


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //selsect photo of product 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                path = dialog.FileName;
                product_photo.ImageLocation = dialog.FileName;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public static object product_list { get; set; }
        //when click to the button go to new users
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(fn);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        //when click to the button go to products
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(x);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        // method help to pass to new user 
        void fn()
        {
            Application.Run(new New_Users());
        }
        // method help to pass to products
        void x()
        {
            Application.Run(new products());
        }
        // method help to pass to products list
        void y()
        {
            Application.Run(new product_list());
        }
        //when click to the button go to product list

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(y);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

    }
}
