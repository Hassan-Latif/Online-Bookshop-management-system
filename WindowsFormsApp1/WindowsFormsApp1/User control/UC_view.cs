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
    public partial class UC_view : UserControl
    {
        public UC_view()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataView books = dt.DefaultView;
            books.RowFilter = "Publisher like '%" + u_b_p_box.Text + "%'";
        }

        private void UC_view_Load(object sender, EventArgs e)
        {
            userSearchRecord();
        }

        private DataTable dt = new DataTable();

        private void userSearchRecord()
        {
            System.Data.SqlClient.SqlConnection con = new SqlConnection("Data Source=DESKTOP-7RPITQ7;Initial Catalog=project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Books", con);
            //DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            dt.Load(sdr);
            con.Close();

            booksdataGridView.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView book = dt.DefaultView;
            book.RowFilter = "Name like '%" + u_b_n_box.Text + "%'";
        }

        private void u_b_id_box_TextChanged(object sender, EventArgs e)
        {
            DataView book = dt.DefaultView;
            book.RowFilter = "Id like '%" + u_b_id_box.Text + "%'";
        }

        private void u_b_au_box_TextChanged(object sender, EventArgs e)
        {
            DataView book = dt.DefaultView;
            book.RowFilter = "Author like '%" + u_b_au_box.Text + "%'";
        }
    }
}
