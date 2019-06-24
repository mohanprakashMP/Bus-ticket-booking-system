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

namespace Bus_ticket_bookijng_system.view
{
    public partial class logincs : Form
    {
        public logincs()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            LoginControl lc = new LoginControl();
            lc.logcontrol(txtusername.Text, txtpassword.Text);
            txtusername.Text = "";
            txtpassword.Text = "";
        }
    }
}
