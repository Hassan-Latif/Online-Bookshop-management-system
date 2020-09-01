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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void L_s_btn_Click(object sender, EventArgs e)
        {
            new User_sign_up().Show();
            this.Hide();
        }

        private void C_l_btn_Click(object sender, EventArgs e)
        {
            string email = C_n_box.Text;
            string password = C_p_box.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7RPITQ7;Initial Catalog=project;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * FROM Members WHERE Email=@umail and Passwordd=@upas",con);
            cmd.Parameters.AddWithValue("@umail", email);
            cmd.Parameters.AddWithValue("@upas", password);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                new user_interface().Show();
                this.Hide();
                MessageBox.Show("Successfully loged in");
            }
            else
            {
                MessageBox.Show("Invalid login credentials");
            }

        }
    }
}
