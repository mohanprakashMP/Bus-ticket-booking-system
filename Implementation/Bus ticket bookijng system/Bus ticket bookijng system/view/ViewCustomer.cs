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
    public partial class ViewCustomer : Form
    {
        public int UserId = 0;
        public ViewCustomer()
        {
            InitializeComponent();
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            CustomerController cc = new CustomerController();
            cc.customerview(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string command = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if (command.ToLower() == "delete")
            {
                try
                {

                    string query = "delete from [Customer] where Customer_id='" + id + "'";
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
                    string query = "select * from[Customer] where Customer_id=" + id;
                    SQLConnection con = new SQLConnection();
                    DataTable dt = con.GetData(query);
                    if (dt.Rows.Count > 0)
                    {
                        Customer c = new Customer();
                        c.id = (int)(dt.Rows[0]["Customer_id"]);
                        c.name = (string)dt.Rows[0]["Customer_name"];
                        c.email = (string)dt.Rows[0]["Customer_email"];
                        c.phone = (string)dt.Rows[0]["Customer_phone"];
                        c.address = (string)dt.Rows[0]["Customer_address"];
                        c.userid = (int)dt.Rows[0]["User_id"];
                        Add_customer ac = new Add_customer(c);
                        ac.UserId = this.UserId;
                        ac.Show();
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
