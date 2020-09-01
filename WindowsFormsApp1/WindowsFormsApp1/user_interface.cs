using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.User_control;

namespace WindowsFormsApp1
{
    public partial class user_interface : Form
    {
        int panelWidth;
        bool isCollapsed;

        public user_interface()
        {
            InitializeComponent();
            panelWidth = panelleft.Width;
            isCollapsed = false;
        }

        private void Addcontrolstopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelcontrols.Controls.Clear();
            panelcontrols.Controls.Add(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveSidePanel(U_h_btn);
            UC_home bt = new UC_home();
            Addcontrolstopanel(bt);
        }

        private void user_interface_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void moveSidePanel (Control btn)
        {
            panelside.Top = btn.Top;
            panelside.Height = btn.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelleft.Width = panelleft.Width + 10;
                if (panelleft.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelleft.Width = panelleft.Width - 10;
                if (panelleft.Width <= 41)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(U_sb_btn);
            cart btt = new cart();
            Addcontrolstopanel(btt);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveSidePanel(U_s_btn);
            UC_view btt = new UC_view();
            Addcontrolstopanel(btt);
        }

        private void U_r_btn_Click(object sender, EventArgs e)
        {
            moveSidePanel(U_r_btn);
            new Form2().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelcontrols_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
