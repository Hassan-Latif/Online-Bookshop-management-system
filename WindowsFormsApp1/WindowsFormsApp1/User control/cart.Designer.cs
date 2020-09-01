namespace WindowsFormsApp1.User_control
{
    partial class cart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cartdataGridView = new System.Windows.Forms.DataGridView();
            this.u_b_sea_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.u_b_n_box = new System.Windows.Forms.TextBox();
            this.u_b_n = new System.Windows.Forms.Label();
            this.u_b_pr_box = new System.Windows.Forms.TextBox();
            this.u_b_pr = new System.Windows.Forms.Label();
            this.u_b_a_box = new System.Windows.Forms.TextBox();
            this.u_b_aut = new System.Windows.Forms.Label();
            this.u_b_g_box = new System.Windows.Forms.TextBox();
            this.u_b_g = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cartdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cartdataGridView
            // 
            this.cartdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartdataGridView.Location = new System.Drawing.Point(61, 275);
            this.cartdataGridView.Name = "cartdataGridView";
            this.cartdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartdataGridView.Size = new System.Drawing.Size(860, 216);
            this.cartdataGridView.TabIndex = 0;
            this.cartdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartdataGridView_CellClick);
            this.cartdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartdataGridView_CellContentClick);
            // 
            // u_b_sea_box
            // 
            this.u_b_sea_box.Location = new System.Drawing.Point(294, 161);
            this.u_b_sea_box.Multiline = true;
            this.u_b_sea_box.Name = "u_b_sea_box";
            this.u_b_sea_box.Size = new System.Drawing.Size(284, 26);
            this.u_b_sea_box.TabIndex = 1;
            this.u_b_sea_box.TextChanged += new System.EventHandler(this.u_b_sea_box_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button1.Location = new System.Drawing.Point(381, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // u_b_n_box
            // 
            this.u_b_n_box.Location = new System.Drawing.Point(253, 28);
            this.u_b_n_box.Name = "u_b_n_box";
            this.u_b_n_box.Size = new System.Drawing.Size(179, 20);
            this.u_b_n_box.TabIndex = 6;
            // 
            // u_b_n
            // 
            this.u_b_n.AutoSize = true;
            this.u_b_n.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.u_b_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_b_n.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.u_b_n.Location = new System.Drawing.Point(133, 28);
            this.u_b_n.Name = "u_b_n";
            this.u_b_n.Size = new System.Drawing.Size(61, 24);
            this.u_b_n.TabIndex = 5;
            this.u_b_n.Text = "Name";
            // 
            // u_b_pr_box
            // 
            this.u_b_pr_box.Location = new System.Drawing.Point(712, 28);
            this.u_b_pr_box.Name = "u_b_pr_box";
            this.u_b_pr_box.Size = new System.Drawing.Size(179, 20);
            this.u_b_pr_box.TabIndex = 8;
            // 
            // u_b_pr
            // 
            this.u_b_pr.AutoSize = true;
            this.u_b_pr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.u_b_pr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_b_pr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.u_b_pr.Location = new System.Drawing.Point(602, 22);
            this.u_b_pr.Name = "u_b_pr";
            this.u_b_pr.Size = new System.Drawing.Size(61, 25);
            this.u_b_pr.TabIndex = 7;
            this.u_b_pr.Text = "Price";
            this.u_b_pr.Click += new System.EventHandler(this.a_b_pr_Click);
            // 
            // u_b_a_box
            // 
            this.u_b_a_box.Location = new System.Drawing.Point(253, 83);
            this.u_b_a_box.Name = "u_b_a_box";
            this.u_b_a_box.Size = new System.Drawing.Size(179, 20);
            this.u_b_a_box.TabIndex = 10;
            // 
            // u_b_aut
            // 
            this.u_b_aut.AutoSize = true;
            this.u_b_aut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.u_b_aut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_b_aut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.u_b_aut.Location = new System.Drawing.Point(132, 83);
            this.u_b_aut.Name = "u_b_aut";
            this.u_b_aut.Size = new System.Drawing.Size(75, 25);
            this.u_b_aut.TabIndex = 9;
            this.u_b_aut.Text = "Author";
            // 
            // u_b_g_box
            // 
            this.u_b_g_box.Location = new System.Drawing.Point(712, 78);
            this.u_b_g_box.Name = "u_b_g_box";
            this.u_b_g_box.Size = new System.Drawing.Size(179, 20);
            this.u_b_g_box.TabIndex = 12;
            // 
            // u_b_g
            // 
            this.u_b_g.AutoSize = true;
            this.u_b_g.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.u_b_g.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_b_g.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.u_b_g.Location = new System.Drawing.Point(600, 78);
            this.u_b_g.Name = "u_b_g";
            this.u_b_g.Size = new System.Drawing.Size(63, 24);
            this.u_b_g.TabIndex = 11;
            this.u_b_g.Text = "Genre";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(620, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Bill";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.u_b_sea_btn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(620, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 13;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.u_b_g_box);
            this.Controls.Add(this.u_b_g);
            this.Controls.Add(this.u_b_a_box);
            this.Controls.Add(this.u_b_aut);
            this.Controls.Add(this.u_b_pr_box);
            this.Controls.Add(this.u_b_pr);
            this.Controls.Add(this.u_b_n_box);
            this.Controls.Add(this.u_b_n);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.u_b_sea_box);
            this.Controls.Add(this.cartdataGridView);
            this.Name = "cart";
            this.Size = new System.Drawing.Size(1122, 522);
            this.Load += new System.EventHandler(this.cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cartdataGridView;
        private System.Windows.Forms.TextBox u_b_sea_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox u_b_n_box;
        private System.Windows.Forms.Label u_b_n;
        private System.Windows.Forms.TextBox u_b_pr_box;
        private System.Windows.Forms.Label u_b_pr;
        private System.Windows.Forms.TextBox u_b_a_box;
        private System.Windows.Forms.Label u_b_aut;
        private System.Windows.Forms.TextBox u_b_g_box;
        private System.Windows.Forms.Label u_b_g;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
