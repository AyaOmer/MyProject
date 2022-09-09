using clothes_shop.DB;
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

namespace clothes_shop
{
    public partial class log_in : Form
    {//create object from database
        salesEntities3 db = new salesEntities3();
        public log_in()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        
   
      private void label2_Click(object sender, EventArgs e)
      {

      }

      private void button1_Click_1(object sender, EventArgs e)
      {
     



          // to know the input from textboxesare match to the one of the database 

          var result = db.Users.Where(x => x.userName == name_tex.Text && x.password == password_tex.Text).ToList();

    //      check if the user is manger or user and check he is working in shop or not
                  if (manager_rad.Checked == true && result.Count() > 0)
                  { 
                      //the user is work in shop and a manager so open the manger form


                      this.Close();
                      Thread th = new Thread(fn);
                      th.SetApartmentState(ApartmentState.STA);
                      th.Start();
                  }


                      //to check the user from the user work in shop and is salesman

                  else if (sales_rad.Checked == true && result.Count() > 0)
                  {

                      //the user is working in shop so open the bill
                      MessageBox.Show("Hello , SalesMan");
                      this.Close();
                      Thread th = new Thread(n);
                      th.SetApartmentState(ApartmentState.STA);
                      th.Start();
                  }
              
          else
                      // if the the input of the password or name or both are wrong 
              {
                  MessageBox.Show("Invalid ");
              }
          //empty the name text box
                  name_tex.Text = string.Empty;
       //   empty the password_tex text
                  password_tex.Text = "";
                 
      }
        //function help to open the bill
      void n()
      {
          Application.Run(new Bill());

      }
        //function help to open the  manger form
        void fn()
      {
          Application.Run(new Users.Helllo_manager());
      }
      private void radioButton2_CheckedChanged(object sender, EventArgs e)
      {

      }

      private void radioButton1_CheckedChanged(object sender, EventArgs e)
      {

      }
    }
}
