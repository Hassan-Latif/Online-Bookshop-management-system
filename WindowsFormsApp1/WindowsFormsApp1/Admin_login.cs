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

namespace WindowsFormsApp1
{
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void Admin_login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string email = A_l_box.Text;
            string password = A_p_btn.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7RPITQ7;Initial Catalog=project;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Admin WHERE Email=@mail and Paswordd=@pas", con);
            cmd.Parameters.AddWithValue("@mail", email);
            cmd.Parameters.AddWithValue("@pas", password);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();

            if (dt.Rows.Count >0)
            {
                new Admin_interface().Show();
                this.Hide();
                MessageBox.Show("Successfully logged in");
            }
            else
            {
                MessageBox.Show("Invalid login credentials");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
