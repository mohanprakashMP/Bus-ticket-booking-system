using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Bus_ticket_bookijng_system.view;
using Bus_ticket_bookijng_system.Model;

namespace Bus_ticket_bookijng_system.Controller
{
   public class UserController
    {
        public void usrctrl(string firstname,string lastname,string email,string phone,string username,string password,User u)
        {
            try
            {
                if (u!= null)
                {
                    string query = "Update [User] set Firstname='" + firstname +"', Lastname='" + lastname +
                        "',Email='" + email +"',Phone='" + phone +"',Username='" + username 
                        + "',Password='" + password + "' where User_id='" + u.id + "'";
                    SQLConnection sc = new SQLConnection();
                    sc.Executequery(query);
                    MessageBox.Show("User account updated successfully");

                }
                else
                {
                    string qur = "insert into [User] values('" + firstname + "','" + lastname
                        + "','" + email + "','" + phone + "','" + username + "','" + password + "')";
                    SQLConnection con = new SQLConnection();
                    con.Executequery(qur);
                    MessageBox.Show("Successfully Registered");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }


        public void userview(DataGridView dgv,int id)
        {
            string query = "select * from [User] where User_id='" + id + "'";
            SQLConnection con = new SQLConnection();
            DataTable dt = con.GetData(query);
            dgv.DataSource = dt;
        }
    }
}
