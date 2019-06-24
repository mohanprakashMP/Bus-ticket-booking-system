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
    public partial class Add_bus : Form
    {
        Bus oldb = new Bus();
        public Add_bus(Bus b)
        {
            oldb = b;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bus b = new Bus();
            b.number = txtbusno.Text;
            b.type = txtbustype.Text;
            b.route = txtbusroute.Text;
            b.description = txtbusdesc.Text;
            BusController bc = new BusController();
            bc.BusCont(b.number, b.type, b.description, b.route,oldb);
            if(oldb!=null)
            {
                ViewBus vb = new ViewBus();
                vb.Show();
                this.Close();
            }
        }

        private void Add_bus_Load(object sender, EventArgs e)
        {
            if (oldb != null)
            {
                txtbusno.Text = oldb.number;
                txtbusroute.Text = oldb.route;
                txtbustype.Text = oldb.type;
                txtbusdesc.Text = oldb.description;
            }
        }
    }
}
