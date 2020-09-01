namespace WindowsFormsApp1
{
    partial class user_interface
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_interface));
            this.panelleft = new System.Windows.Forms.Panel();
            this.U_r_btn = new System.Windows.Forms.Button();
            this.U_s_btn = new System.Windows.Forms.Button();
            this.U_sb_btn = new System.Windows.Forms.Button();
            this.panelside = new System.Windows.Forms.Panel();
            this.U_h_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelcontrols = new System.Windows.Forms.Panel();
            this.panelleft.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelleft.Controls.Add(this.U_r_btn);
            this.panelleft.Controls.Add(this.U_s_btn);
            this.panelleft.Controls.Add(this.U_sb_btn);
            this.panelleft.Controls.Add(this.panelside);
            this.panelleft.Controls.Add(this.U_h_btn);
            this.panelleft.Controls.Add(this.panel3);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(176, 679);
            this.panelleft.TabIndex = 0;
            // 
            // U_r_btn
            // 
            this.U_r_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.U_r_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_r_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.U_r_btn.Image = ((System.Drawing.Image)(resources.GetObject("U_r_btn.Image")));
            this.U_r_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.U_r_btn.Location = new System.Drawing.Point(12, 347);
            this.U_r_btn.Name = "U_r_btn";
            this.U_r_btn.Size = new System.Drawing.Size(149, 41);
            this.U_r_btn.TabIndex = 3;
            this.U_r_btn.Text = "Log out";
            this.U_r_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.U_r_btn.UseVisualStyleBackColor = false;
            this.U_r_btn.Click += new System.EventHandler(this.U_r_btn_Click);
            // 
            // U_s_btn
            // 
            this.U_s_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.U_s_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_s_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.U_s_btn.Image = ((System.Drawing.Image)(resources.GetObject("U_s_btn.Image")));
            this.U_s_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.U_s_btn.Location = new System.Drawing.Point(12, 262);
            this.U_s_btn.Name = "U_s_btn";
            this.U_s_btn.Size = new System.Drawing.Size(149, 41);
            this.U_s_btn.TabIndex = 2;
            this.U_s_btn.Text = "Search";
            this.U_s_btn.UseVisualStyleBackColor = false;
            this.U_s_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // U_sb_btn
            // 
            this.U_sb_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.U_sb_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_sb_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.U_sb_btn.Image = ((System.Drawing.Image)(resources.GetObject("U_sb_btn.Image")));
            this.U_sb_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.U_sb_btn.Location = new System.Drawing.Point(12, 178);
            this.U_sb_btn.Name = "U_sb_btn";
            this.U_sb_btn.Size = new System.Drawing.Size(149, 43);
            this.U_sb_btn.TabIndex = 1;
            this.U_sb_btn.Text = "Buy Books";
            this.U_sb_btn.UseVisualStyleBackColor = false;
            this.U_sb_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelside.Location = new System.Drawing.Point(3, 81);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(10, 44);
            this.panelside.TabIndex = 1;
            // 
            // U_h_btn
            // 
            this.U_h_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.U_h_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_h_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.U_h_btn.Image = ((System.Drawing.Image)(resources.GetObject("U_h_btn.Image")));
            this.U_h_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.U_h_btn.Location = new System.Drawing.Point(12, 81);
            this.U_h_btn.Name = "U_h_btn";
            this.U_h_btn.Size = new System.Drawing.Size(149, 44);
            this.U_h_btn.TabIndex = 1;
            this.U_h_btn.Text = "Home";
            this.U_h_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.U_h_btn.UseVisualStyleBackColor = false;
            this.U_h_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 53);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(176, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 53);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Readings ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelcontrols
            // 
            this.panelcontrols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontrols.Location = new System.Drawing.Point(176, 53);
            this.panelcontrols.Name = "panelcontrols";
            this.panelcontrols.Size = new System.Drawing.Size(958, 626);
            this.panelcontrols.TabIndex = 1;
            this.panelcontrols.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcontrols_Paint);
            // 
            // user_interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 679);
            this.Controls.Add(this.panelcontrols);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelleft);
            this.Name = "user_interface";
            this.Text = " ";
            this.Load += new System.EventHandler(this.user_interface_Load);
            this.panelleft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Button U_h_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Button U_sb_btn;
        private System.Windows.Forms.Button U_s_btn;
        private System.Windows.Forms.Button U_r_btn;
        private System.Windows.Forms.Panel panelcontrols;
    }
}