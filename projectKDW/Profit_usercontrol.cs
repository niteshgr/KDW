using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectKDW
{
    public partial class Profit_usercontrol : UserControl
    {

        private static Profit_usercontrol _instance;


        public static Profit_usercontrol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Profit_usercontrol();
                }
                return _instance;

            }
        }
        public Profit_usercontrol()
        {
            InitializeComponent();
        }

        private void Profit_usercontrol_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
