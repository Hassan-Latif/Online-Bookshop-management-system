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
using System.Data;

namespace WindowsFormsApp1.Admin_controls
{
    public partial class Add_books : UserControl
    {
        public Add_books()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_books_Load(object sender, EventArgs e)
        {
            getBooksRecord();
        }

        private void getBooksRecord()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7RPITQ7;Initial Catalog=project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Books",con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            dt.Load(sdr);
            con.Close();

            adminDataGridView.DataSource = dt; 

        }

        private void a_b_btn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string name = a_b_n_box.Text;
                string Id = a_b_id_box.Text;
                string publisher = a_b_p_box.Text;
                string copies = a_b_nc_box.Text;
                string genre = a_b_g_box.Text;
                string edition = a_b_e_box.Text;
                string price = a_b_pr_box.Text;
                string author = a_b_a_box.Text;

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-7RPITQ7;Initial Catalog=project;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("INSERT INTO Books VALUES (@Name,@Id,@Publisher,@No_of_Copies,@Genre,@Edition,@Price,@Author)",con);

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Publisher", publisher);
                cmd.Parameters.AddWithValue("@no_of_copies", copies);
                cmd.Parameters.AddWithValue("@Genre", genre);
                cmd.Parameters.AddWithValue("@Edition", edition);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Author", author);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("New Book has been Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                getBooksRecord();
                ResetBooks();
            }
        }

        private bool IsValid()
        {
            if (a_b_n_box.Text == string.Empty)
            {
                MessageBox.Show("Book name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void a_reset_btn_Click(object sender, EventArgs e)
        {
            ResetBooks();
        }

        private void ResetBooks()
        {
            a_b_n_box.Clear();
            a_b_e_box.Clear();
            a_b_id_box.Clear();
            a_b_p_box.Clear();
            a_b_pr_box.Clear();
            a_b_a_box.Clear();
            a_b_nc_box.Clear();
            a_b_g_box.Clear();

            a_b_n_box.Focus();
        }

    }
}
