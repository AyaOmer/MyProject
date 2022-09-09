namespace clothes_shop.products
{
    partial class products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(products));
            this.parcode_tex = new System.Windows.Forms.TextBox();
            this.price_tex = new System.Windows.Forms.TextBox();
            this.quan_tex = new System.Windows.Forms.TextBox();
            this.name_tex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.product_photo = new System.Windows.Forms.PictureBox();
            this.save_but = new System.Windows.Forms.Button();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDataSet = new clothes_shop.salesDataSet();
            this.categoryTableAdapter = new clothes_shop.salesDataSetTableAdapters.CategoryTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edit_but = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addp_but = new System.Windows.Forms.Button();
            this.mangeu_tex = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.product_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // parcode_tex
            // 
            this.parcode_tex.BackColor = System.Drawing.Color.Khaki;
            this.parcode_tex.Location = new System.Drawing.Point(583, 305);
            this.parcode_tex.Name = "parcode_tex";
            this.parcode_tex.Size = new System.Drawing.Size(148, 22);
            this.parcode_tex.TabIndex = 0;
            // 
            // price_tex
            // 
            this.price_tex.BackColor = System.Drawing.Color.Khaki;
            this.price_tex.Location = new System.Drawing.Point(583, 229);
            this.price_tex.Name = "price_tex";
            this.price_tex.Size = new System.Drawing.Size(148, 22);
            this.price_tex.TabIndex = 0;
            // 
            // quan_tex
            // 
            this.quan_tex.BackColor = System.Drawing.Color.Khaki;
            this.quan_tex.Location = new System.Drawing.Point(583, 171);
            this.quan_tex.Name = "quan_tex";
            this.quan_tex.Size = new System.Drawing.Size(148, 22);
            this.quan_tex.TabIndex = 0;
            this.quan_tex.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // name_tex
            // 
            this.name_tex.BackColor = System.Drawing.Color.Khaki;
            this.name_tex.Location = new System.Drawing.Point(584, 79);
            this.name_tex.Name = "name_tex";
            this.name_tex.Size = new System.Drawing.Size(148, 22);
            this.name_tex.TabIndex = 0;
            this.name_tex.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 10.2F);
            this.label1.Location = new System.Drawing.Point(410, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "product name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 10.2F);
            this.label2.Location = new System.Drawing.Point(410, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 10.2F);
            this.label3.Location = new System.Drawing.Point(410, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 10.2F);
            this.label4.Location = new System.Drawing.Point(410, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "parcode";
            // 
            // product_photo
            // 
            this.product_photo.BackColor = System.Drawing.Color.White;
            this.product_photo.Location = new System.Drawing.Point(786, 84);
            this.product_photo.Name = "product_photo";
            this.product_photo.Size = new System.Drawing.Size(333, 265);
            this.product_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.product_photo.TabIndex = 2;
            this.product_photo.TabStop = false;
            this.product_photo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // save_but
            // 
            this.save_but.Font = new System.Drawing.Font("Kristen ITC", 10.2F);
            this.save_but.Location = new System.Drawing.Point(549, 380);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(224, 67);
            this.save_but.TabIndex = 3;
            this.save_but.Text = "save";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.salesDataSet;
            // 
            // salesDataSet
            // 
            this.salesDataSet.DataSetName = "salesDataSet";
            this.salesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.edit_but);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.addp_but);
            this.panel1.Controls.Add(this.mangeu_tex);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 479);
            this.panel1.TabIndex = 5;
            // 
            // edit_but
            // 
            this.edit_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_but.Font = new System.Drawing.Font("Kristen ITC", 10.8F, System.Drawing.FontStyle.Bold);
            this.edit_but.ForeColor = System.Drawing.Color.DimGray;
            this.edit_but.Location = new System.Drawing.Point(12, 351);
            this.edit_but.Name = "edit_but";
            this.edit_but.Size = new System.Drawing.Size(207, 69);
            this.edit_but.TabIndex = 1;
            this.edit_but.Text = "Edit Product";
            this.edit_but.UseVisualStyleBackColor = true;
            this.edit_but.Click += new System.EventHandler(this.button3_Click);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(70, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hello Manager";
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
            this.addp_but.Click += new System.EventHandler(this.button4_Click);
            // 
            // mangeu_tex
            // 
            this.mangeu_tex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mangeu_tex.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mangeu_tex.ForeColor = System.Drawing.Color.DimGray;
            this.mangeu_tex.Location = new System.Drawing.Point(12, 149);
            this.mangeu_tex.Name = "mangeu_tex";
            this.mangeu_tex.Size = new System.Drawing.Size(207, 74);
            this.mangeu_tex.TabIndex = 1;
            this.mangeu_tex.Text = "Manage Sales men";
            this.mangeu_tex.UseVisualStyleBackColor = true;
            this.mangeu_tex.Click += new System.EventHandler(this.button5_Click);
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1173, 479);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.product_photo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_tex);
            this.Controls.Add(this.price_tex);
            this.Controls.Add(this.quan_tex);
            this.Controls.Add(this.parcode_tex);
            this.Name = "products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "products add";
            ((System.ComponentModel.ISupportInitialize)(this.product_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox parcode_tex;
        private System.Windows.Forms.TextBox price_tex;
        private System.Windows.Forms.TextBox quan_tex;
        private System.Windows.Forms.TextBox name_tex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox product_photo;
        private System.Windows.Forms.Button save_but;
        private salesDataSet salesDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private salesDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button edit_but;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addp_but;
        private System.Windows.Forms.Button mangeu_tex;
    }
}