using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace projectKDW
{
    public partial class change_UserControl : UserControl
    {
        private static change_UserControl _instance;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kings\\source\\repos\\projectKDW\\projectKDW\\kdwdata.mdf;Integrated Security=True");
        SqlCommand cmd;
        public static String user;
        public static change_UserControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new change_UserControl(user);
                }
                return _instance;

            }
        }

        public change_UserControl(String user_id)
        {
            InitializeComponent();
            label01.Enabled = false;
            user =user_id;
            this.ActiveControl = newtextBox;
        }

        private void change_UserControl_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void change_password_button_Click(object sender, EventArgs e)
        {
            String npass, cpass;
            npass = newtextBox.Text.ToString();
            cpass = confirmtextBox.Text.ToString();
            MessageBox.Show(user);
            try
            {
                con.Open();
                if (npass.Equals(cpass))
                {
                    String s = "update Login set password='"+cpass+"' where user_id='"+user+"'";
                    cmd = new SqlCommand(s, con);
                    cmd.ExecuteNonQuery();
                    label01.Enabled = true;
                    label01.Text = "Password Changed!";
                    newtextBox.Clear();
                    confirmtextBox.Clear();
                    con.Close();
                }
                else
                {
                    label01.Enabled = true;
                    label01.Text = "Password Mismatch Re-enter password!";
                    newtextBox.Clear();
                    confirmtextBox.Clear();
                }
            }
            catch(Exception excp)
            {
                MessageBox.Show(excp.ToString());
                con.Close();
            }
        }

        private void newtextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                confirmtextBox.Focus();
            }
        }

        private void confirmtextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                change_password_button_Click(sender, e);
            }
        }
    }
}
