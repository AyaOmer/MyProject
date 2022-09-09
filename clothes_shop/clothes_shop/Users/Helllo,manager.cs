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

namespace clothes_shop.Users
{
    public partial class Helllo_manager : Form
    {
        public Helllo_manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(fn);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void fn()
        {
            Application.Run(new New_Users());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(x);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        void x()
        {
            Application.Run(new products.products());
        }
        void y()
        {
            Application.Run(new products.product_list());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(y);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }


    }
}
