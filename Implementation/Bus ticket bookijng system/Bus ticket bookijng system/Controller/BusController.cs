using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bus_ticket_bookijng_system.Model;
using System.Windows.Forms;
using System.Data;

namespace Bus_ticket_bookijng_system.Controller
{
    public class BusController
    {
        public void BusCont(string busno, string bustype, string description, string route,Bus b)
        {
            try
            {
                if (busno == "")
                {
                    MessageBox.Show("bus no is empty");
                }
                else if (bustype=="")
                {
                    MessageBox.Show("Bus Type is Empty");
                }
                else if(description=="")
                {
                    MessageBox.Show("Description is Empty");
                }
                else if(route=="")
                {
                    MessageBox.Show("Route is Empty Please Fill It");
                }
                else if(b!=null)
                {

                    string query = "Update [Bus] set Bus_no='" + busno + "',BusRoute ='" + route +
                        "',BusType='" + bustype + "',BusDescription='" + description 
                        + "' where Bus_id='" + b.id + "'";
                    SQLConnection sc = new SQLConnection();
                    sc.Executequery(query);
                    MessageBox.Show("Bus details updated successfully");

                }
                else
                {
                    string query = "Insert into Bus values('" + busno + "','" + route + "','" + bustype + "','" + description + "')";
                    SQLConnection sqc = new SQLConnection();
                    sqc.Executequery(query);
                    MessageBox.Show("Bus added successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void viewbus(DataGridView dgv)
        {
            string query = "select * from [Bus]";
            SQLConnection con = new SQLConnection();
            DataTable dt = con.GetData(query);
            dgv.DataSource = dt;
        }
    }
}
