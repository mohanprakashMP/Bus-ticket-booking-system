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
    public partial class ViewBus : Form
    {
        public ViewBus()
        {
            InitializeComponent();
        }

        private void ViewBus_Load(object sender, EventArgs e)
        {
            BusController bc = new BusController();
            bc.viewbus(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string command = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if (command.ToLower() == "delete")
            {
                try
                {

                    string query = "delete from [Bus] where Bus_id='" + id + "'";
                    SQLConnection con = new SQLConnection();
                    con.Executequery(query);
                    MessageBox.Show("successfully Deleted");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (command.ToLower() == "edit")
            {

                try
                {
                    string query = "select * from[Bus] where Bus_id=" + id;
                    SQLConnection con = new SQLConnection();
                    DataTable dt = con.GetData(query);
                    if (dt.Rows.Count > 0)
                    {
                        Bus b = new Bus();
                        b.id = (int)(dt.Rows[0]["Bus_id"]);
                        b.number = (string)dt.Rows[0]["Bus_No"];
                        b.route = (string)dt.Rows[0]["BusRoute"];
                        b.type = (string)dt.Rows[0]["BusType"];
                        b.description = (string)dt.Rows[0]["BusDescription"];
                      
                        Add_bus ab = new Add_bus(b);
                        ab.Show();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
