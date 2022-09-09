namespace clothes_shop.products
{
    partial class product_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product_list));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_but = new System.Windows.Forms.Button();
            this.refresh_but = new System.Windows.Forms.Button();
            this.par_ctex = new System.Windows.Forms.TextBox();
            this.nameform_tex = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name_tex = new System.Windows.Forms.TextBox();
            this.price_tex = new System.Windows.Forms.TextBox();
            this.qua_tex = new System.Windows.Forms.TextBox();
            this.parcode_tex = new System.Windows.Forms.TextBox();
            this.saved_but = new System.Windows.Forms.Button();
            this.delete_but = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edit_but = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.add_but = new System.Windows.Forms.Button();
            this.mangin_tex = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(255, 123);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(646, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // search_but
            // 
            this.search_but.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_but.Location = new System.Drawing.Point(710, 51);
            this.search_but.Name = "search_but";
            this.search_but.Size = new System.Drawing.Size(92, 36);
            this.search_but.TabIndex = 1;
            this.search_but.Text = "search";
            this.search_but.UseVisualStyleBackColor = true;
            this.search_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // refresh_but
            // 
            this.refresh_but.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_but.Location = new System.Drawing.Point(834, 51);
            this.refresh_but.Name = "refresh_but";
            this.refresh_but.Size = new System.Drawing.Size(100, 36);
            this.refresh_but.TabIndex = 1;
            this.refresh_but.Text = "refresh";
            this.refresh_but.UseVisualStyleBackColor = true;
            this.refresh_but.Click += new System.EventHandler(this.button2_Click);
            // 
            // par_ctex
            // 
            this.par_ctex.BackColor = System.Drawing.Color.Khaki;
            this.par_ctex.Location = new System.Drawing.Point(532, 79);
            this.par_ctex.Multiline = true;
            this.par_ctex.Name = "par_ctex";
            this.par_ctex.Size = new System.Drawing.Size(148, 34);
            this.par_ctex.TabIndex = 2;
            this.par_ctex.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nameform_tex
            // 
            this.nameform_tex.BackColor = System.Drawing.Color.Khaki;
            this.nameform_tex.Location = new System.Drawing.Point(532, 18);
            this.nameform_tex.Multiline = true;
            this.nameform_tex.Name = "nameform_tex";
            this.nameform_tex.Size = new System.Drawing.Size(148, 35);
            this.nameform_tex.TabIndex = 2;
            this.nameform_tex.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(291, 18);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(199, 33);
            this.Password.TabIndex = 3;
            this.Password.Text = "Product Name";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(609, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 44);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Code";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(1243, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(929, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "parcode";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(929, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(929, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(929, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "product name";
            // 
            // name_tex
            // 
            this.name_tex.BackColor = System.Drawing.Color.Khaki;
            this.name_tex.Location = new System.Drawing.Point(1078, 141);
            this.name_tex.Multiline = true;
            this.name_tex.Name = "name_tex";
            this.name_tex.Size = new System.Drawing.Size(117, 32);
            this.name_tex.TabIndex = 4;
            this.name_tex.TextChanged += new System.EventHandler(this.name_tex_TextChanged);
            // 
            // price_tex
            // 
            this.price_tex.BackColor = System.Drawing.Color.Khaki;
            this.price_tex.Location = new System.Drawing.Point(1078, 305);
            this.price_tex.Multiline = true;
            this.price_tex.Name = "price_tex";
            this.price_tex.Size = new System.Drawing.Size(117, 32);
            this.price_tex.TabIndex = 5;
            // 
            // qua_tex
            // 
            this.qua_tex.BackColor = System.Drawing.Color.Khaki;
            this.qua_tex.Location = new System.Drawing.Point(1078, 220);
            this.qua_tex.Multiline = true;
            this.qua_tex.Name = "qua_tex";
            this.qua_tex.Size = new System.Drawing.Size(117, 32);
            this.qua_tex.TabIndex = 6;
            // 
            // parcode_tex
            // 
            this.parcode_tex.BackColor = System.Drawing.Color.Khaki;
            this.parcode_tex.Location = new System.Drawing.Point(1078, 379);
            this.parcode_tex.Multiline = true;
            this.parcode_tex.Name = "parcode_tex";
            this.parcode_tex.Size = new System.Drawing.Size(117, 32);
            this.parcode_tex.TabIndex = 7;
            // 
            // saved_but
            // 
            this.saved_but.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saved_but.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.saved_but.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saved_but.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saved_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saved_but.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saved_but.Location = new System.Drawing.Point(967, 482);
            this.saved_but.Name = "saved_but";
            this.saved_but.Size = new System.Drawing.Size(136, 67);
            this.saved_but.TabIndex = 13;
            this.saved_but.Text = "save";
            this.saved_but.UseVisualStyleBackColor = false;
            this.saved_but.Click += new System.EventHandler(this.button3_Click);
            // 
            // delete_but
            // 
            this.delete_but.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_but.Location = new System.Drawing.Point(1208, 482);
            this.delete_but.Name = "delete_but";
            this.delete_but.Size = new System.Drawing.Size(140, 67);
            this.delete_but.TabIndex = 14;
            this.delete_but.Text = "Delete";
            this.delete_but.UseVisualStyleBackColor = true;
            this.delete_but.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.edit_but);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.add_but);
            this.panel1.Controls.Add(this.mangin_tex);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 568);
            this.panel1.TabIndex = 16;
            // 
            // edit_but
            // 
            this.edit_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_but.Font = new System.Drawing.Font("Kristen ITC", 10.8F, System.Drawing.FontStyle.Bold);
            this.edit_but.ForeColor = System.Drawing.Color.DimGray;
            this.edit_but.Location = new System.Drawing.Point(12, 427);
            this.edit_but.Name = "edit_but";
            this.edit_but.Size = new System.Drawing.Size(207, 69);
            this.edit_but.TabIndex = 1;
            this.edit_but.Text = "Edit Product";
            this.edit_but.UseVisualStyleBackColor = true;
            this.edit_but.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(58, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kristen ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(70, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Hello Manager";
            // 
            // add_but
            // 
            this.add_but.BackColor = System.Drawing.Color.Transparent;
            this.add_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_but.Font = new System.Drawing.Font("Kristen ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_but.ForeColor = System.Drawing.Color.DimGray;
            this.add_but.Location = new System.Drawing.Point(12, 280);
            this.add_but.Name = "add_but";
            this.add_but.Size = new System.Drawing.Size(207, 78);
            this.add_but.TabIndex = 1;
            this.add_but.Text = "Add Product";
            this.add_but.UseVisualStyleBackColor = false;
            this.add_but.Click += new System.EventHandler(this.button4_Click);
            // 
            // mangin_tex
            // 
            this.mangin_tex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mangin_tex.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mangin_tex.ForeColor = System.Drawing.Color.DimGray;
            this.mangin_tex.Location = new System.Drawing.Point(12, 149);
            this.mangin_tex.Name = "mangin_tex";
            this.mangin_tex.Size = new System.Drawing.Size(207, 74);
            this.mangin_tex.TabIndex = 1;
            this.mangin_tex.Text = "Manage Sales men";
            this.mangin_tex.UseVisualStyleBackColor = true;
            this.mangin_tex.Click += new System.EventHandler(this.button5_Click);
            // 
            // product_list
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1488, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.delete_but);
            this.Controls.Add(this.saved_but);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.name_tex);
            this.Controls.Add(this.price_tex);
            this.Controls.Add(this.qua_tex);
            this.Controls.Add(this.parcode_tex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.nameform_tex);
            this.Controls.Add(this.par_ctex);
            this.Controls.Add(this.refresh_but);
            this.Controls.Add(this.search_but);
            this.Controls.Add(this.dataGridView1);
            this.HelpButton = true;
            this.Name = "product_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "product_list";
            this.Load += new System.EventHandler(this.product_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button search_but;
        private System.Windows.Forms.Button refresh_but;
        private System.Windows.Forms.TextBox par_ctex;
        private System.Windows.Forms.TextBox nameform_tex;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_tex;
        private System.Windows.Forms.TextBox price_tex;
        private System.Windows.Forms.TextBox qua_tex;
        private System.Windows.Forms.TextBox parcode_tex;
        private System.Windows.Forms.Button saved_but;
        private System.Windows.Forms.Button delete_but;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button edit_but;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button add_but;
        private System.Windows.Forms.Button mangin_tex;
    }
}