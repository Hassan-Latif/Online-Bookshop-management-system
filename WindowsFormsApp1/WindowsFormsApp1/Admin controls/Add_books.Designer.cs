namespace WindowsFormsApp1.Admin_controls
{
    partial class Add_books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_books));
            this.adminDataGridView = new System.Windows.Forms.DataGridView();
            this.a_b_n = new System.Windows.Forms.Label();
            this.a_b_id = new System.Windows.Forms.Label();
            this.a_b_n_box = new System.Windows.Forms.TextBox();
            this.a_b_nc = new System.Windows.Forms.Label();
            this.a_b_id_box = new System.Windows.Forms.TextBox();
            this.a_b_nc_box = new System.Windows.Forms.TextBox();
            this.a_b_p = new System.Windows.Forms.Label();
            this.a_b_p_box = new System.Windows.Forms.TextBox();
            this.a_b_g = new System.Windows.Forms.Label();
            this.a_b_pr = new System.Windows.Forms.Label();
            this.a_b_aut = new System.Windows.Forms.Label();
            this.a_b_ed = new System.Windows.Forms.Label();
            this.a_b_g_box = new System.Windows.Forms.TextBox();
            this.a_b_pr_box = new System.Windows.Forms.TextBox();
            this.a_b_a_box = new System.Windows.Forms.TextBox();
            this.a_b_e_box = new System.Windows.Forms.TextBox();
            this.a_b_btn = new System.Windows.Forms.Button();
            this.a_reset_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // adminDataGridView
            // 
            this.adminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.adminDataGridView.Location = new System.Drawing.Point(123, 296);
            this.adminDataGridView.Name = "adminDataGridView";
            this.adminDataGridView.Size = new System.Drawing.Size(656, 229);
            this.adminDataGridView.TabIndex = 1;
            this.adminDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // a_b_n
            // 
            this.a_b_n.AutoSize = true;
            this.a_b_n.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.a_b_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_b_n.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.a_b_n.Location = new System.Drawing.Point(119, 33);
            this.a_b_n.Name = "a_b_n";
            this.a_b_n.Size = new System.Drawing.Size(61, 24);
            this.a_b_n.TabIndex = 2;
            this.a_b_n.Text = "Name";
            // 
            // a_b_id
            // 
            this.a_b_id.AutoSize = true;
            this.a_b_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.a_b_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_b_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.a_b_id.Location = new System.Drawing.Point(119, 85);
            this.a_b_id.Name = "a_b_id";
            this.a_b_id.Size = new System.Drawing.Size(25, 24);
            this.a_b_id.TabIndex = 3;
            this.a_b_id.Text = "Id";
            this.a_b_id.Click += new System.EventHandler(this.label2_Click);
            // 
            // a_b_n_box
            // 
            this.a_b_n_box.Location = new System.Drawing.Point(239, 33);
            this.a_b_n_box.Name = "a_b_n_box";
            this.a_b_n_box.Size = new System.Drawing.Size(179, 20);
            this.a_b_n_box.TabIndex = 4;
            // 
            // a_b_nc
            // 
            this.a_b_nc.AutoSize = true;
            this.a_b_nc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.a_b_nc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_b_nc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.a_b_nc.Location = new System.Drawing.Point(103, 138);
            this.a_b_nc.Name = "a_b_nc";
            this.a_b_nc.Size = new System.Drawing.Size(124, 24);
            this.a_b_nc.TabIndex = 3;
            this.a_b_nc.Text = "No. of Copies";
            this.a_b_nc.Click += new System.EventHandler(this.label2_Click);
            // 
            // a_b_id_box
            // 
            this.a_b_id_box.Location = new System.Drawing.Point(239, 85);
            this.a_b_id_box.Name = "a_b_id_box";
            this.a_b_id_box.Size = new System.Drawing.Size(179, 20);
            this.a_b_id_box.TabIndex = 4;
            this.a_b_id_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // a_b_nc_box
            // 
            this.a_b_nc_box.Location = new System.Drawing.Point(239, 140);
            this.a_b_nc_box.Name = "a_b_nc_box";
            this.a_b_nc_box.Size = new System.Drawing.Size(179, 20);
            this.a_b_nc_box.TabIndex = 4;
            this.a_b_nc_box.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // a_b_p
            // 
            this.a_b_p.AutoSize = true;
            this.a_b_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.a_b_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_b_p.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.a_b_p.Location = new System.Drawing.Point(103, 201);
            this.a_b_p.Name = "a_b_p";
            this.a_b_p.Size = new System.Drawing.Size(89, 24);
            this.a_b_p.TabIndex = 3;
            this.a_b_p.Text = "Publisher";
            this.a_b_p.Click += new System.EventHandler(this.label2_Click);
            // 
            // a_b_p_box
            // 
            this.a_b_p_box.Location = new System.Drawing.Point(239, 201);
            this.a_b_p_box.Name = "a_b_p_box";
            this.a_b_p_box.Size = new System.Drawing.Size(179, 20);
            this.a_b_p_box.TabIndex = 4;
            this.a_b_p_box.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // a_b_g
            // 
            this.a_b_g.AutoSize = true;
            this.a_b_g.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.a_b_g.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_b_g.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.a_b_g.Location = new System.Drawing.Point(544, 31);
            this.a_b_g.Name = "a_b_g";
            this.a_b_g.Size = new System.Drawing.Size(63, 24);
            this.a_b_g.TabIndex = 2;
            this.a_b_g.Text = "Genre";
            // 
            // a_b_pr
            // 
            this.a_b_pr.AutoSize = true;
            this.a_b_pr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.a_b_pr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_b_pr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.a_b_pr.Location = new System.Drawing.Point(544, 85);
            this.a_b_pr.Name = "a_b_pr";
            this.a_b_pr.Size = new System.Drawing.Size(61, 25);
            this.a_b_pr.TabIndex = 2;
            this.a_b_pr.Text = "Price";
            // 
            // a_b_aut
            // 
            this.a_b_aut.AutoSize = true;
            this.a_b_aut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.a_b_aut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_b_aut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.a_b_aut.Location = new System.Drawing.Point(544, 140);
            this.a_b_aut.Name = "a_b_aut";
            this.a_b_aut.Size = new System.Drawing.Size(75, 25);
            this.a_b_aut.TabIndex = 2;
            this.a_b_aut.Text = "Author";
            // 
            // a_b_ed
            // 
            this.a_b_ed.AutoSize = true;
            this.a_b_ed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.a_b_ed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_b_ed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.a_b_ed.Location = new System.Drawing.Point(544, 199);
            this.a_b_ed.Name = "a_b_ed";
            this.a_b_ed.Size = new System.Drawing.Size(68, 24);
            this.a_b_ed.TabIndex = 2;
            this.a_b_ed.Text = "Edition";
            // 
            // a_b_g_box
            // 
            this.a_b_g_box.Location = new System.Drawing.Point(653, 31);
            this.a_b_g_box.Name = "a_b_g_box";
            this.a_b_g_box.Size = new System.Drawing.Size(179, 20);
            this.a_b_g_box.TabIndex = 4;
            // 
            // a_b_pr_box
            // 
            this.a_b_pr_box.Location = new System.Drawing.Point(653, 85);
            this.a_b_pr_box.Name = "a_b_pr_box";
            this.a_b_pr_box.Size = new System.Drawing.Size(179, 20);
            this.a_b_pr_box.TabIndex = 4;
            // 
            // a_b_a_box
            // 
            this.a_b_a_box.Location = new System.Drawing.Point(653, 138);
            this.a_b_a_box.Name = "a_b_a_box";
            this.a_b_a_box.Size = new System.Drawing.Size(179, 20);
            this.a_b_a_box.TabIndex = 4;
            // 
            // a_b_e_box
            // 
            this.a_b_e_box.Location = new System.Drawing.Point(653, 199);
            this.a_b_e_box.Name = "a_b_e_box";
            this.a_b_e_box.Size = new System.Drawing.Size(179, 20);
            this.a_b_e_box.TabIndex = 4;
            // 
            // a_b_btn
            // 
            this.a_b_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.a_b_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_b_btn.Location = new System.Drawing.Point(315, 251);
            this.a_b_btn.Name = "a_b_btn";
            this.a_b_btn.Size = new System.Drawing.Size(128, 39);
            this.a_b_btn.TabIndex = 5;
            this.a_b_btn.Text = "Add Book";
            this.a_b_btn.UseVisualStyleBackColor = false;
            this.a_b_btn.Click += new System.EventHandler(this.a_b_btn_Click);
            // 
            // a_reset_btn
            // 
            this.a_reset_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.a_reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_reset_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.a_reset_btn.Location = new System.Drawing.Point(571, 251);
            this.a_reset_btn.Name = "a_reset_btn";
            this.a_reset_btn.Size = new System.Drawing.Size(130, 39);
            this.a_reset_btn.TabIndex = 7;
            this.a_reset_btn.Text = "Reset";
            this.a_reset_btn.UseVisualStyleBackColor = false;
            this.a_reset_btn.Click += new System.EventHandler(this.a_reset_btn_Click);
            // 
            // Add_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.a_reset_btn);
            this.Controls.Add(this.a_b_btn);
            this.Controls.Add(this.a_b_p_box);
            this.Controls.Add(this.a_b_nc_box);
            this.Controls.Add(this.a_b_id_box);
            this.Controls.Add(this.a_b_e_box);
            this.Controls.Add(this.a_b_a_box);
            this.Controls.Add(this.a_b_pr_box);
            this.Controls.Add(this.a_b_g_box);
            this.Controls.Add(this.a_b_n_box);
            this.Controls.Add(this.a_b_p);
            this.Controls.Add(this.a_b_nc);
            this.Controls.Add(this.a_b_id);
            this.Controls.Add(this.a_b_ed);
            this.Controls.Add(this.a_b_aut);
            this.Controls.Add(this.a_b_pr);
            this.Controls.Add(this.a_b_g);
            this.Controls.Add(this.a_b_n);
            this.Controls.Add(this.adminDataGridView);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Name = "Add_books";
            this.Size = new System.Drawing.Size(978, 545);
            this.Load += new System.EventHandler(this.Add_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView adminDataGridView;
        private System.Windows.Forms.Label a_b_n;
        private System.Windows.Forms.Label a_b_id;
        private System.Windows.Forms.TextBox a_b_n_box;
        private System.Windows.Forms.Label a_b_nc;
        private System.Windows.Forms.TextBox a_b_id_box;
        private System.Windows.Forms.TextBox a_b_nc_box;
        private System.Windows.Forms.Label a_b_p;
        private System.Windows.Forms.TextBox a_b_p_box;
        private System.Windows.Forms.Label a_b_g;
        private System.Windows.Forms.Label a_b_pr;
        private System.Windows.Forms.Label a_b_aut;
        private System.Windows.Forms.Label a_b_ed;
        private System.Windows.Forms.TextBox a_b_g_box;
        private System.Windows.Forms.TextBox a_b_pr_box;
        private System.Windows.Forms.TextBox a_b_a_box;
        private System.Windows.Forms.TextBox a_b_e_box;
        private System.Windows.Forms.Button a_b_btn;
        private System.Windows.Forms.Button a_reset_btn;
    }
}
