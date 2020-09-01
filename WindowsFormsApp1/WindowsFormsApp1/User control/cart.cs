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

namespace WindowsFormsApp1.User_control
{
    public partial class cart : UserControl
    {
        public cart()
        {
            InitializeComponent();

        }
        public int item_id;
        public string item_name;
        public int item_price;
        private void cart_Load(object sender, EventArgs e)
        {
            searchBooks("");
            cartData();
        }
        public void searchBooks(string valueToSearch)
        {
            string query = "SELECT * FROM Books WHERE Name like '%" + valueToSearch + "%'";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7RPITQ7;Initial Catalog=project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adapter.Fill(tab);
            cartdataGridView.DataSource = tab;
        }
        private void cartData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7RPITQ7;Initial Catalog=project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Books", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            dt.Load(sdr);
            con.Close();

            cartdataGridView.DataSource = dt;
        }

        private void u_b_sea_btn_Click(object sender, EventArgs e)
        {
            new Bill().Show();
            this.Hide();
        }

        private void a_b_pr_Click(object sender, EventArgs e)
        {

        }


        private void cartdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-7RPITQ7;Initial Catalog=project;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Insert into cart(item_id, item_name, item_price) values (@a,@b,@c)", con);
                cmd.Parameters.AddWithValue("@a", item_id);
                cmd.Parameters.AddWithValue("@b", item_name);
                cmd.Parameters.AddWithValue("@c", item_price);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Selected item has been added in the cart", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cartData();
            }
        }

        private bool IsValid()
        {
            if (item_name == string.Empty)
            {
                MessageBox.Show("First select an item from the cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (item_price == 0)
            {
                MessageBox.Show("First select an item from the cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void cartdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            u_b_n_box.Text = cartdataGridView.SelectedRows[0].Cells[0].Value.ToString();

            u_b_g_box.Text = cartdataGridView.SelectedRows[0].Cells[4].Value.ToString();

            u_b_pr_box.Text = cartdataGridView.SelectedRows[0].Cells[6].Value.ToString();
            u_b_a_box.Text = cartdataGridView.SelectedRows[0].Cells[7].Value.ToString();

            item_id = Convert.ToInt32(cartdataGridView.SelectedRows[0].Cells[1].Value);
            item_name = cartdataGridView.SelectedRows[0].Cells[0].Value.ToString();
            item_price = Convert.ToInt32(cartdataGridView.SelectedRows[0].Cells[6].Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string valueToSearch =u_b_sea_box.Text.ToString();
            searchBooks(valueToSearch);
        }

        private void u_b_sea_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
