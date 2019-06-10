using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectKDW
{
    public partial class business : Form
    {
        String User;

        public business(String User)
        {
            InitializeComponent();
            this.ActiveControl = label2;
            this.User = User;
            label3.Text = User.ToUpper();
            change_UserControl obju = new change_UserControl(User);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NAGESH_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutbutton_Click(object sender, EventArgs e)
        {

            if (!content_panel.Controls.Contains(change_UserControl.Instance))
            {
                content_panel.Controls.Add(change_UserControl.Instance);
                change_UserControl.Instance.Dock = DockStyle.Fill;
                change_UserControl.Instance.BringToFront();

            }
            else
            {
                change_UserControl.Instance.BringToFront();
            }

            
            
            
        }

        private void itembutton_Click(object sender, EventArgs e)
        {
            if(! content_panel.Controls.Contains(Item_Price_usercontrol.Instance))
            {
                content_panel.Controls.Add(Item_Price_usercontrol.Instance);
                Item_Price_usercontrol.Instance.Dock = DockStyle.Fill;
                Item_Price_usercontrol.Instance.BringToFront();
            }
            else
            {
                Item_Price_usercontrol.Instance.BringToFront();
            }
        }

        private void profitbutton_Click(object sender, EventArgs e)
        {
            if (!content_panel.Controls.Contains(Profit_usercontrol.Instance))
            {
                content_panel.Controls.Add(Profit_usercontrol.Instance);
                Profit_usercontrol.Instance.Dock = DockStyle.Fill;
                Profit_usercontrol.Instance.BringToFront();
            }
            else
            {
                Profit_usercontrol.Instance.BringToFront();
            }
        }

        private void Trackbutton_Click(object sender, EventArgs e)
        {
            if (!content_panel.Controls.Contains(Track_usercontrol.Instance))
            {
                content_panel.Controls.Add(Track_usercontrol.Instance);
                Track_usercontrol.Instance.Dock = DockStyle.Fill;
                Track_usercontrol.Instance.BringToFront();
            }
            else
            {
                Track_usercontrol.Instance.BringToFront();
            }
        }

        private void content_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
