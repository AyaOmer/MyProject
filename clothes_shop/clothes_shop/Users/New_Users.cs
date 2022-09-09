using clothes_shop.DB;
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

namespace clothes_shop.Users
{
    public partial class New_Users : Form
    {
        //create object from database
        salesEntities3 db =new salesEntities3() ;

        string img;
        public New_Users()
        {
            InitializeComponent();
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            //proceess in addding neww user to the database 
            User u= new User()
        {
            //copy the value of inputs  in the u
            userName = name_tex.Text,
            password = password_tex.Text,
          image=img
        }; 
            // add the u to the database
            db.Users.Add(u);

            //save to changes database 
            db.SaveChanges();
         
            MessageBox.Show("DONE");

            //empty  name text box
            name_tex.Text = string.Empty;
            //empty pasword text box
           password_tex.Text = string.Empty;
    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {//selecting picture
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
               img = dialog.FileName;
                user_photo.ImageLocation =dialog.FileName;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }//

        //method to help in pass to new usetrs form
        void fn()
        {
            Application.Run(new New_Users());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // method help to pass to products
        void x()
        {
            Application.Run(new products.products());
        }
        // method help to pass to products list
        void y()
        {
            Application.Run(new products.product_list());
        }
        //when click to the button go to new users
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(fn);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        //when click to the button go to products
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(x);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        //when click to the button go to product list
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(y);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
