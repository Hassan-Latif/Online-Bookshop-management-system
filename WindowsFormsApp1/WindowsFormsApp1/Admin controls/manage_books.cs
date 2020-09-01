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
    public partial class manage_books : UserControl
    {
        public manage_books()
        {
            InitializeComponent();
        }

        private void manage_books_Load(object sender, EventArgs e)
        {
            manageBooksRecord();
            searchBooks("");
        }
        public void searchBooks(string valueToSearch)
        {
            string query = "SELECT * FROM Books WHERE CONCAT(Name, Id,Publisher,Author) like '%" + valueToSearch + "%'";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7RPITQ7;Initial Catalog=project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adapter.Fill(tab);
            managedataGridView.DataSource = tab;
        }

        private void manageBooksRecord()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7RPITQ7;Initial Catalog=project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Books", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            dt.Load(sdr);
            con.Close();

            managedataGridView.DataSource = dt;
        }

        private void managedataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a_b_n_box.Text = managedataGridView.SelectedRows[0].Cells[0].Value.ToString();
            a_b_id_box.Text = managedataGridView.SelectedRows[0].Cells[1].Value.ToString();
            a_b_p_box.Text= managedataGridView.SelectedRows[0].Cells[2].Value.ToString();
            a_b_nc_box.Text= managedataGridView.SelectedRows[0].Cells[3].Value.ToString();
            a_b_g_box.Text= managedataGridView.SelectedRows[0].Cells[4].Value.ToString();
            a_b_e_box.Text= managedataGridView.SelectedRows[0].Cells[5].Value.ToString();
            a_b_pr_box.Text= managedataGridView.SelectedRows[0].Cells[6].Value.ToString();
            a_b_a_box.Text= managedataGridView.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a_b_n_box.Text!="")
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
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Books SET Name=@Name,id=@Id,Publisher=@Publisher,No_of_Copies=@No_of_Copies,Genre=@Genre,Edition=@Edition,Price=@Price,Author=@Author WHERE Id=@id", con);

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Id",Id );
                cmd.Parameters.AddWithValue("@Publisher", publisher);
                cmd.Parameters.AddWithValue("@no_of_copies", copies);
                cmd.Parameters.AddWithValue("@Genre", genre);
                cmd.Parameters.AddWithValue("@Edition", edition);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Author", author);

                
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Book has been Successfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                manageBooksRecord();
                ResetBooks();
            }
            else
            {
                MessageBox.Show("First select a Book record", "Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void a_reset_btn_Click(object sender, EventArgs e)
        {
            ResetBooks();
        }

        private void ResetBooks()
        {
            a_b_n_box.Text = "";
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (a_b_nc_box.Text!="")
            {
           
                string Id = a_b_id_box.Text;
           
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-7RPITQ7;Initial Catalog=project;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Books WHERE Id=@id", con);
                cmd.Parameters.AddWithValue("@Id", Id);

                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Book has been Successfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                manageBooksRecord();
                ResetBooks();
            }
            else
            {
              MessageBox.Show("First select a Book record", "Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void a_b_sea_btn_Click(object sender, EventArgs e)
        {
            string valueToSearch = a_b_sea_box.Text.ToString();
            searchBooks(valueToSearch);
        }

        private void a_b_sea_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
