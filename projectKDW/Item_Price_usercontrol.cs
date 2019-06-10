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
    public partial class Item_Price_usercontrol : UserControl
    {
        private static Item_Price_usercontrol _instance;
        String item,price;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kings\\source\\repos\\YojanSevaKendra\\YojanSevaKendra\\govtdbs.mdf;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataReader dr1;

        public static Item_Price_usercontrol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Item_Price_usercontrol();
                }
                return _instance;

            }
        }
        public Item_Price_usercontrol()
        {
            InitializeComponent();
                con.Open();
                SqlDataAdapter obj7 = new SqlDataAdapter("SELECT * FROM PriceTable ;", con);
                DataTable dtb = new DataTable();
                obj7.Fill(dtb);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtb;
                dataGridView1.ReadOnly = true;
                

            
        }

        private void Item_Price_usercontrol_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
