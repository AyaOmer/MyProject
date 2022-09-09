namespace clothes_shop
{
    partial class log_in
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
            this.name_tex = new System.Windows.Forms.TextBox();
            this.password_tex = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.manager_rad = new System.Windows.Forms.RadioButton();
            this.sales_rad = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.log_butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_tex
            // 
            this.name_tex.BackColor = System.Drawing.SystemColors.Info;
            this.name_tex.Location = new System.Drawing.Point(338, 64);
            this.name_tex.Multiline = true;
            this.name_tex.Name = "name_tex";
            this.name_tex.Size = new System.Drawing.Size(259, 36);
            this.name_tex.TabIndex = 1;
            this.name_tex.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password_tex
            // 
            this.password_tex.BackColor = System.Drawing.SystemColors.Info;
            this.password_tex.Location = new System.Drawing.Point(338, 196);
            this.password_tex.Multiline = true;
            this.password_tex.Name = "password_tex";
            this.password_tex.PasswordChar = '*';
            this.password_tex.Size = new System.Drawing.Size(259, 32);
            this.password_tex.TabIndex = 1;
            this.password_tex.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(47, 186);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(166, 42);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.name.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(47, 64);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(106, 42);
            this.name.TabIndex = 2;
            this.name.Text = "Name";
            this.name.Click += new System.EventHandler(this.label2_Click);
            // 
            // manager_rad
            // 
            this.manager_rad.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_rad.ForeColor = System.Drawing.Color.White;
            this.manager_rad.Location = new System.Drawing.Point(339, 285);
            this.manager_rad.Name = "manager_rad";
            this.manager_rad.Size = new System.Drawing.Size(125, 35);
            this.manager_rad.TabIndex = 4;
            this.manager_rad.TabStop = true;
            this.manager_rad.Text = "manger";
            this.manager_rad.UseVisualStyleBackColor = true;
            this.manager_rad.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // sales_rad
            // 
            this.sales_rad.AutoSize = true;
            this.sales_rad.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_rad.ForeColor = System.Drawing.Color.White;
            this.sales_rad.Location = new System.Drawing.Point(500, 285);
            this.sales_rad.Name = "sales_rad";
            this.sales_rad.Size = new System.Drawing.Size(120, 32);
            this.sales_rad.TabIndex = 4;
            this.sales_rad.TabStop = true;
            this.sales_rad.Text = "Salesman";
            this.sales_rad.UseVisualStyleBackColor = true;
            this.sales_rad.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a Level";
            // 
            // log_butt
            // 
            this.log_butt.BackColor = System.Drawing.Color.DarkGray;
            this.log_butt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.log_butt.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_butt.Location = new System.Drawing.Point(382, 369);
            this.log_butt.Name = "log_butt";
            this.log_butt.Size = new System.Drawing.Size(151, 36);
            this.log_butt.TabIndex = 5;
            this.log_butt.Text = "log in";
            this.log_butt.UseVisualStyleBackColor = false;
            this.log_butt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(782, 428);
            this.Controls.Add(this.log_butt);
            this.Controls.Add(this.sales_rad);
            this.Controls.Add(this.manager_rad);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.password_tex);
            this.Controls.Add(this.name_tex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "log_in";
            this.Text = "Hello ,user";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_tex;
        private System.Windows.Forms.TextBox password_tex;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.RadioButton manager_rad;
        private System.Windows.Forms.RadioButton sales_rad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button log_butt;
    }
}

