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
    public partial class User_sign_up : Form
    {
       
        public User_sign_up()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (U_s_n_box.Text == "" || U_s_e_box.Text == "" || U_s_id_box.Text == "" || U_s_p_box.Text == "" || U_s_cp_box.Text == "")
            {
                MessageBox.Show("Kindly fill all the boxes");
            }
            else if (U_s_p_box.Text != U_s_cp_box.Text)
            {
                MessageBox.Show("Passwords do not match");
            }
            else
            {
                string name = U_s_n_box.Text;
                string email = U_s_e_box.Text;
                string contact = U_s_id_box.Text;
                string password = U_s_p_box.Text;
                string C_password = U_s_cp_box.Text;

                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7RPITQ7;Initial Catalog=project;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Members VALUES(@a,@b,@c,@d)",conn);
                cmd.Parameters.AddWithValue("@a", name);
                cmd.Parameters.AddWithValue("@b", email);
                cmd.Parameters.AddWithValue("@c", contact);
                cmd.Parameters.AddWithValue("@d", password);
              

                cmd.ExecuteNonQuery();

                MessageBox.Show("Sign up completed");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
            
        {
            new Form2().Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
