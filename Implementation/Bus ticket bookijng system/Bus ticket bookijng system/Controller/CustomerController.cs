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
    public class CustomerController
    {
        public void custcontrol(string name, string address, string email, string phone,int id,Customer c)
        {
            try
            {
                if (name == "")
                {
                    MessageBox.Show(" please enter the name ");

                }
                else if (address == "")
                {
                    MessageBox.Show("please enter the address");

                }
                else if (email == "")
                {
                    MessageBox.Show("please enter the email");
                }
                else if (phone == "")
                {
                    MessageBox.Show(" please enter the phone ");
                }
                else if(c!=null)
                {
                    string query = "Update [Customer] set Customer_name='" + name + "',Customer_address='" +
                        address + "',Customer_phone='" + phone + "',Customer_email='" + email + "',User_id='" + id +
                        "' where Customer_id='" + c.id + "'";
                    SQLConnection sc = new SQLConnection();
                    sc.Executequery(query);
                    MessageBox.Show("Customer details updated successfully");
                }
                else
                {
                    string query = "Insert into Customer values('" + name + "','" + address + "','" + phone + "','" +
                        email + "','" + id + "')";
                    SQLConnection scon = new SQLConnection();
                    scon.Executequery(query);
                    MessageBox.Show("Customer information added successfully");
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void customerview(DataGridView dv)
        {
            string query = "Select * from [Customer]";
            SQLConnection sc = new SQLConnection();
            DataTable dt=sc.GetData(query);
            dv.DataSource = dt;
        }
    }
}
