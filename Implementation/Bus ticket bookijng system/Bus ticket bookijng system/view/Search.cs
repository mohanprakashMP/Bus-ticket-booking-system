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

namespace Bus_ticket_bookijng_system.view
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from[Bus] where Bus_No='" + textBox1.Text + "'";
            SQLConnection con = new SQLConnection();
            DataTable dt = con.GetData(query);
            dataGridView1.DataSource = dt;
        }
    }
}
