using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bus_ticket_bookijng_system.Controller;
using Bus_ticket_bookijng_system.Model;

namespace Bus_ticket_bookijng_system.view
{
    public partial class Register : Form
    {
        public int UserId = 0;
        User oldu = new User();
        public Register(User u)
        {
            oldu = u;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtfirstname.Text =="")
            {
                MessageBox.Show("Enter the firstname");
            }
            else if(txtlastname.Text =="")
            {
                MessageBox.Show("Enter the lastname");
            }
            else if(txtemail.Text =="")
            {
                MessageBox.Show("Enter the email");
            }
            else if(txtphone.Text == "")
            {
                MessageBox.Show("Enter the phone no");
            }
            else if(txtusrname.Text == "")
            {
                MessageBox.Show("Enter the username");
            }
            else if(txtpassword.Text == "")
            {
                MessageBox.Show("Enter the password");
            }
     
            else
            {
                User u = new User();
                u.firstname = txtfirstname.Text;
                u.Lastname = txtlastname.Text;
                u.email = txtemail.Text;
                u.phone = txtphone.Text;
                u.username = txtusrname.Text;
                u.password = txtpassword.Text;

                UserController uc = new UserController();
                uc.usrctrl(u.firstname, u.Lastname, u.email, u.phone, u.username, u.password,oldu);
                if(oldu!=null)
                {
                    this.Close();
                    ViewUser vu = new ViewUser();
                    vu.UserId = this.UserId;
                    vu.Show();
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            
        }

        private void Register_Load(object sender, EventArgs e)
        {
            if(oldu!=null)
            {
                txtfirstname.Text = oldu.firstname;
                txtlastname.Text = oldu.Lastname;
                txtemail.Text = oldu.email;
                txtphone.Text = oldu.phone;
                txtusrname.Text = oldu.username;
                txtpassword.Text = oldu.password;
            }
        }
    }
}
