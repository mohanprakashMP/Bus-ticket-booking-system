using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bus_ticket_bookijng_system.Model;
using System.Data;
using Bus_ticket_bookijng_system.view;
using System.Windows.Forms;

namespace Bus_ticket_bookijng_system.Controller
{
    public class LoginControl
    {
        public void logcontrol(string usr,string pass)
        {
            try
            {
                string query = "Select * from [User] where Username='" + usr + "' and Password='" + pass + "'";
                SQLConnection sqc = new SQLConnection();
                DataTable dt = sqc.GetData(query);
                if (dt.Rows.Count > 0)
                {
                    Dashboard ds = new Dashboard();
                    ds.UserId = Convert.ToInt32(dt.Rows[0]["User_id"]);
                    ds.Show();
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
