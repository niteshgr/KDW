using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace projectKDW
{
    public partial class Login : Form
    {
        String user;
        
    
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = userTextBox;
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kings\\source\\repos\\projectKDW\\projectKDW\\kdwdata.mdf;Integrated Security=True");
        SqlCommand cmd, cmd1;
        SqlDataReader dr1, dr2;
       
    
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }     

        private void userTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PassWordtextBox.Focus();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                user = userTextBox.Text;
                String pass = PassWordtextBox.Text;
                con.Open();
                String s = "select count(*) from Login where User_id='" + user + "';";
                cmd = new SqlCommand(s, con);
                dr1 = cmd.ExecuteReader();
                dr1.Read();

                if (dr1[0].Equals(1))
                {

                    dr1.Close();
                    String syn = "select password from Login where User_id='" + user + "';";
                    cmd1 = new SqlCommand(syn, con);
                    dr2 = cmd1.ExecuteReader();
                    dr2.Read();
                    String passdbms = dr2[0].ToString();


                    dr2.Close();

                    if (pass.Equals(passdbms))
                    {


                        // MessageBox.Show("LogIn Succesful");

                        business obj1 = new business(user);
                        this.Hide();
                        obj1.Show();
                    }
                    else
                    {
                        MessageBox.Show("LogIn Failed Invalid credentials");


                    }

                }
                else
                {
                    MessageBox.Show("Invalid User");
                }

                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                con.Close();
            }

        }

        private void PassWordtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(sender, e);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
