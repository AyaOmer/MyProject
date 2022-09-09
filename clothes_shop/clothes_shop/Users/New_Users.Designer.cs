namespace clothes_shop.Users
{
    partial class New_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Users));
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.password_tex = new System.Windows.Forms.TextBox();
            this.name_tex = new System.Windows.Forms.TextBox();
            this.save_but = new System.Windows.Forms.Button();
            this.user_photo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editp_but = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addp_but = new System.Windows.Forms.Button();
            this.manageu_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.user_photo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(350, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Password.Location = new System.Drawing.Point(350, 128);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(166, 42);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password";
            // 
            // password_tex
            // 
            this.password_tex.Location = new System.Drawing.Point(530, 128);
            this.password_tex.Multiline = true;
            this.password_tex.Name = "password_tex";
            this.password_tex.Size = new System.Drawing.Size(174, 42);
            this.password_tex.TabIndex = 4;
            this.password_tex.UseSystemPasswordChar = true;
            // 
            // name_tex
            // 
            this.name_tex.Location = new System.Drawing.Point(530, 43);
            this.name_tex.Multiline = true;
            this.name_tex.Name = "name_tex";
            this.name_tex.Size = new System.Drawing.Size(174, 42);
            this.name_tex.TabIndex = 5;
            this.name_tex.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // save_but
            // 
            this.save_but.BackColor = System.Drawing.Color.Transparent;
            this.save_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_but.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.save_but.FlatAppearance.BorderSize = 0;
            this.save_but.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.save_but.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_but.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.save_but.Location = new System.Drawing.Point(544, 333);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(131, 59);
            this.save_but.TabIndex = 3;
            this.save_but.Text = "Save";
            this.save_but.UseVisualStyleBackColor = false;
            this.save_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_photo
            // 
            this.user_photo.BackColor = System.Drawing.Color.White;
            this.user_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user_photo.Location = new System.Drawing.Point(530, 203);
            this.user_photo.Name = "user_photo";
            this.user_photo.Size = new System.Drawing.Size(174, 84);
            this.user_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_photo.TabIndex = 8;
            this.user_photo.TabStop = false;
            this.user_photo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(350, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Photo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.editp_but);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addp_but);
            this.panel1.Controls.Add(this.manageu_but);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 482);
            this.panel1.TabIndex = 10;
            // 
            // editp_but
            // 
            this.editp_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editp_but.Font = new System.Drawing.Font("Kristen ITC", 10.8F, System.Drawing.FontStyle.Bold);
            this.editp_but.ForeColor = System.Drawing.Color.DimGray;
            this.editp_but.Location = new System.Drawing.Point(12, 351);
            this.editp_but.Name = "editp_but";
            this.editp_but.Size = new System.Drawing.Size(207, 69);
            this.editp_but.TabIndex = 1;
            this.editp_but.Text = "Edit Product";
            this.editp_but.UseVisualStyleBackColor = true;
            this.editp_but.Click += new System.EventHandler(this.button2_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(70, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hello Manager";
            // 
            // addp_but
            // 
            this.addp_but.BackColor = System.Drawing.Color.Transparent;
            this.addp_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addp_but.Font = new System.Drawing.Font("Kristen ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addp_but.ForeColor = System.Drawing.Color.DimGray;
            this.addp_but.Location = new System.Drawing.Point(12, 244);
            this.addp_but.Name = "addp_but";
            this.addp_but.Size = new System.Drawing.Size(207, 78);
            this.addp_but.TabIndex = 1;
            this.addp_but.Text = "Add Product";
            this.addp_but.UseVisualStyleBackColor = false;
            this.addp_but.Click += new System.EventHandler(this.button3_Click);
            // 
            // manageu_but
            // 
            this.manageu_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageu_but.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageu_but.ForeColor = System.Drawing.Color.DimGray;
            this.manageu_but.Location = new System.Drawing.Point(12, 149);
            this.manageu_but.Name = "manageu_but";
            this.manageu_but.Size = new System.Drawing.Size(207, 74);
            this.manageu_but.TabIndex = 1;
            this.manageu_but.Text = "Manage Sales men";
            this.manageu_but.UseVisualStyleBackColor = true;
            this.manageu_but.Click += new System.EventHandler(this.button4_Click);
            // 
            // New_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(945, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_photo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.password_tex);
            this.Controls.Add(this.name_tex);
            this.Controls.Add(this.save_but);
            this.Name = "New_Users";
            this.Text = "New_Users";
            ((System.ComponentModel.ISupportInitialize)(this.user_photo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox password_tex;
        private System.Windows.Forms.TextBox name_tex;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.PictureBox user_photo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editp_but;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addp_but;
        private System.Windows.Forms.Button manageu_but;
    }
}