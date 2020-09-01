using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            getBill();
            getTotal();
        }
        private void getTotal()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7RPITQ7;Initial Catalog=project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT SUM(item_price) Total FROM Cart", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                label2.Text = (sdr["Total"].ToString()); 
            }
            con.Close();
                }

        private void getBill()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7RPITQ7;Initial Catalog=project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT item_name,item_price from Cart", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            dt.Load(sdr);
            con.Close();

            billdataGridView.DataSource = dt;
        }

        private void order_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7RPITQ7;Initial Catalog=project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE from Cart", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            MessageBox.Show("Your order has been placed Successfully", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new user_interface().Show();
            this.Hide();
        }
    }
}
