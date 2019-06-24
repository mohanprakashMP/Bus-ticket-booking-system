using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_ticket_bookijng_system.view
{
    public partial class Dashboard : Form
    {
        public int UserId = 0;
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_bus ad = new Add_bus(null);
            ad.Show();
        }

        private void openToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Add_customer ad = new Add_customer(null);
            ad.UserId = this.UserId;
            ad.Show();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Add_Booking ad = new Add_Booking();
            ad.Show();
        }

        private void openToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Register r = new Register(null);
            r.UserId = this.UserId;
            r.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBus vs = new ViewBus();
            vs.Show();
        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ViewCustomer vc = new ViewCustomer();
            vc.UserId = this.UserId;
            vc.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewBooking vb = new ViewBooking();
            vb.Show();
        }

        private void openToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ViewUser vu = new ViewUser();
            vu.UserId = this.UserId;
            vu.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
