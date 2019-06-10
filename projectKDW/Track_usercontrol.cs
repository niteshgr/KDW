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
    public partial class Track_usercontrol : UserControl
    {
        private static Track_usercontrol _instance;


        public static Track_usercontrol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Track_usercontrol();
                }
                return _instance;

            }
        }
        public Track_usercontrol()
        {
            InitializeComponent();
        }

        private void Track_usercontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
