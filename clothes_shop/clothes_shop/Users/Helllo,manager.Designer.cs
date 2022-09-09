namespace clothes_shop.Users
{
    partial class Helllo_manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Helllo_manager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.editp_but = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addp_but = new System.Windows.Forms.Button();
            this.mageu_but = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.editp_but);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addp_but);
            this.panel1.Controls.Add(this.mageu_but);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 471);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.editp_but.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(70, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello Manager";
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
            this.addp_but.Click += new System.EventHandler(this.button2_Click);
            // 
            // mageu_but
            // 
            this.mageu_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mageu_but.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mageu_but.ForeColor = System.Drawing.Color.DimGray;
            this.mageu_but.Location = new System.Drawing.Point(12, 149);
            this.mageu_but.Name = "mageu_but";
            this.mageu_but.Size = new System.Drawing.Size(207, 74);
            this.mageu_but.TabIndex = 1;
            this.mageu_but.Text = "Manage Sales men";
            this.mageu_but.UseVisualStyleBackColor = true;
            this.mageu_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // Helllo_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1083, 471);
            this.Controls.Add(this.panel1);
            this.Name = "Helllo_manager";
            this.Text = "Helllo_manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mageu_but;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addp_but;
        private System.Windows.Forms.Button editp_but;
    }
}