namespace WindowsFormsApp1.User_control
{
    partial class UC_view
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_view));
            this.booksdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.u_b_n_box = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.u_b_p_box = new System.Windows.Forms.TextBox();
            this.u_b_id_box = new System.Windows.Forms.TextBox();
            this.u_b_au_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.booksdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // booksdataGridView
            // 
            this.booksdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksdataGridView.Location = new System.Drawing.Point(158, 217);
            this.booksdataGridView.Name = "booksdataGridView";
            this.booksdataGridView.Size = new System.Drawing.Size(714, 214);
            this.booksdataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(210, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(197, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Publisher";
            // 
            // u_b_n_box
            // 
            this.u_b_n_box.Location = new System.Drawing.Point(309, 73);
            this.u_b_n_box.Name = "u_b_n_box";
            this.u_b_n_box.Size = new System.Drawing.Size(144, 20);
            this.u_b_n_box.TabIndex = 2;
            this.u_b_n_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(573, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(573, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Author";
            // 
            // u_b_p_box
            // 
            this.u_b_p_box.Location = new System.Drawing.Point(309, 139);
            this.u_b_p_box.Name = "u_b_p_box";
            this.u_b_p_box.Size = new System.Drawing.Size(144, 20);
            this.u_b_p_box.TabIndex = 2;
            this.u_b_p_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // u_b_id_box
            // 
            this.u_b_id_box.Location = new System.Drawing.Point(707, 76);
            this.u_b_id_box.Name = "u_b_id_box";
            this.u_b_id_box.Size = new System.Drawing.Size(135, 20);
            this.u_b_id_box.TabIndex = 2;
            this.u_b_id_box.TextChanged += new System.EventHandler(this.u_b_id_box_TextChanged);
            // 
            // u_b_au_box
            // 
            this.u_b_au_box.Location = new System.Drawing.Point(707, 134);
            this.u_b_au_box.Name = "u_b_au_box";
            this.u_b_au_box.Size = new System.Drawing.Size(135, 20);
            this.u_b_au_box.TabIndex = 4;
            this.u_b_au_box.TextChanged += new System.EventHandler(this.u_b_au_box_TextChanged);
            // 
            // UC_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.u_b_au_box);
            this.Controls.Add(this.u_b_p_box);
            this.Controls.Add(this.u_b_id_box);
            this.Controls.Add(this.u_b_n_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.booksdataGridView);
            this.Name = "UC_view";
            this.Size = new System.Drawing.Size(1094, 434);
            this.Load += new System.EventHandler(this.UC_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView booksdataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox u_b_n_box;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox u_b_p_box;
        private System.Windows.Forms.TextBox u_b_id_box;
        private System.Windows.Forms.TextBox u_b_au_box;
    }
}
