using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Admin_controls;

namespace WindowsFormsApp1
{
    public partial class Admin_interface : Form
    {
        int panelWidth;
        bool isCollapsed;

        public Admin_interface()
        {
            InitializeComponent();
            panelWidth = panelleft.Width;
            isCollapsed = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void moveSidePanel(Control btn)
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

        private void addControlToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

        private void U_h_btn_Click(object sender, EventArgs e)
        {
            moveSidePanel(A_h_btn);
            Admin_home uch = new Admin_home();
            addControlToPanel(uch);
            
        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }

        private void A_sb_btn_Click(object sender, EventArgs e)
        {
            moveSidePanel(A_sb_btn);
            Add_books uch = new Add_books();
            addControlToPanel(uch);
        }

        private void A_r_btn_Click(object sender, EventArgs e)
        {
            moveSidePanel(A_r_btn);
            new Form1().Show();
            this.Hide();
        }

        private void A_s_btn_Click(object sender, EventArgs e)
        {
            moveSidePanel(A_s_btn);
            manage_books uch = new manage_books();
            addControlToPanel(uch);
        }

        private void Admin_interface_Load(object sender, EventArgs e)
        {

        }
    }
}
