using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bus_ticket_bookijng_system.Model;
using Bus_ticket_bookijng_system.Controller;

namespace Bus_ticket_bookijng_system.view
{
    public partial class Add_customer : Form
    {
        public int UserId = 0;
        Customer olc = new Customer();
        public Add_customer(Customer cc)
        {
            olc = cc;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.name = txtcuname.Text;
            c.address = txtcuaddress.Text;
            c.email = txtcuemail.Text;
            c.phone = txtcuphone.Text;

            CustomerController cc = new CustomerController();
            cc.custcontrol(c.name, c.address, c.email, c.phone, UserId,olc);
            if(olc!=null)
            {
                ViewCustomer vc = new ViewCustomer();
                vc.UserId = this.UserId;
                vc.Show();
                this.Close();
            }
        }

        private void Add_customer_Load(object sender, EventArgs e)
        {
            if(olc!=null)
            {
                txtcuname.Text = olc.name;
                txtcuaddress.Text = olc.address;
                txtcuemail.Text = olc.email;
                txtcuphone.Text = olc.phone;
            }
        }
    }
}
