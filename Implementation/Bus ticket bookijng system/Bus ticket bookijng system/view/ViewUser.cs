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
    public partial class ViewUser : Form
    {
        public int UserId = 0;
        public ViewUser()
        {
            InitializeComponent();
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            UserController uc = new UserController();
            uc.userview(dataGridView1,UserId);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string command = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if (command.ToLower() == "delete")
            {
                try
                {

                    string query = "delete from [User] where User_id='" + id + "'";
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
                    string query = "select * from[User] where User_id=" + id;
                    SQLConnection con = new SQLConnection();
                    DataTable dt = con.GetData(query);
                    if (dt.Rows.Count > 0)
                    {
                        User u = new User();
                        u.id = (int)(dt.Rows[0]["User_id"]);
                        u.firstname = (string)dt.Rows[0]["Firstname"];
                        u.email = (string)dt.Rows[0]["Email"];
                        u.username = (string)dt.Rows[0]["Username"];
                        u.password = (string)dt.Rows[0]["Password"];
                        u.Lastname = (string)dt.Rows[0]["Lastname"];
                        u.phone = (string)dt.Rows[0]["Phone"];
                        Register rg = new Register(u);
                        rg.UserId = this.UserId;
                        rg.Show();
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
