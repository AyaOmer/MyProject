namespace clothes_shop
{
    partial class Bill
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProdID = new System.Windows.Forms.TextBox();
            this.prodPrice = new System.Windows.Forms.TextBox();
            this.billp_but = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.nameform_tex = new System.Windows.Forms.TextBox();
            this.parcod_tex = new System.Windows.Forms.TextBox();
            this.refreh_but = new System.Windows.Forms.Button();
            this.search_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(516, 201);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(383, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(27, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product code:";
            // 
            // ProdID
            // 
            this.ProdID.BackColor = System.Drawing.SystemColors.Info;
            this.ProdID.Location = new System.Drawing.Point(197, 71);
            this.ProdID.Name = "ProdID";
            this.ProdID.Size = new System.Drawing.Size(144, 22);
            this.ProdID.TabIndex = 2;
            this.ProdID.TextChanged += new System.EventHandler(this.ProdID_TextChanged);
            // 
            // prodPrice
            // 
            this.prodPrice.BackColor = System.Drawing.SystemColors.Info;
            this.prodPrice.Location = new System.Drawing.Point(534, 351);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(144, 22);
            this.prodPrice.TabIndex = 4;
            this.prodPrice.TextChanged += new System.EventHandler(this.prodPrice_TextChanged);
            // 
            // billp_but
            // 
            this.billp_but.Location = new System.Drawing.Point(421, 96);
            this.billp_but.Name = "billp_but";
            this.billp_but.Size = new System.Drawing.Size(127, 23);
            this.billp_but.TabIndex = 5;
            this.billp_but.Text = "Add to bill";
            this.billp_but.UseVisualStyleBackColor = true;
            this.billp_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(665, 125);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(513, 201);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(928, -4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 44);
            this.label4.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(614, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 33);
            this.label5.TabIndex = 22;
            this.label5.Text = "Product Code";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(591, 19);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(199, 33);
            this.Password.TabIndex = 23;
            this.Password.Text = "Product Name";
            // 
            // nameform_tex
            // 
            this.nameform_tex.BackColor = System.Drawing.Color.Khaki;
            this.nameform_tex.Location = new System.Drawing.Point(825, 17);
            this.nameform_tex.Multiline = true;
            this.nameform_tex.Name = "nameform_tex";
            this.nameform_tex.Size = new System.Drawing.Size(148, 35);
            this.nameform_tex.TabIndex = 19;
            this.nameform_tex.TextChanged += new System.EventHandler(this.nameform_tex_TextChanged);
            // 
            // parcod_tex
            // 
            this.parcod_tex.BackColor = System.Drawing.Color.Khaki;
            this.parcod_tex.Location = new System.Drawing.Point(825, 71);
            this.parcod_tex.Multiline = true;
            this.parcod_tex.Name = "parcod_tex";
            this.parcod_tex.Size = new System.Drawing.Size(148, 34);
            this.parcod_tex.TabIndex = 20;
            this.parcod_tex.TextChanged += new System.EventHandler(this.par_ctex_TextChanged);
            // 
            // refreh_but
            // 
            this.refreh_but.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreh_but.Location = new System.Drawing.Point(1078, 17);
            this.refreh_but.Name = "refreh_but";
            this.refreh_but.Size = new System.Drawing.Size(100, 36);
            this.refreh_but.TabIndex = 17;
            this.refreh_but.Text = "refresh";
            this.refreh_but.UseVisualStyleBackColor = true;
            this.refreh_but.Click += new System.EventHandler(this.refreh_but_Click);
            // 
            // search_but
            // 
            this.search_but.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_but.Location = new System.Drawing.Point(1086, 88);
            this.search_but.Name = "search_but";
            this.search_but.Size = new System.Drawing.Size(92, 36);
            this.search_but.TabIndex = 18;
            this.search_but.Text = "search";
            this.search_but.UseVisualStyleBackColor = true;
            this.search_but.Click += new System.EventHandler(this.serch_but_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1221, 385);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.nameform_tex);
            this.Controls.Add(this.parcod_tex);
            this.Controls.Add(this.refreh_but);
            this.Controls.Add(this.search_but);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.billp_but);
            this.Controls.Add(this.prodPrice);
            this.Controls.Add(this.ProdID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProdID;
        private System.Windows.Forms.TextBox prodPrice;
        private System.Windows.Forms.Button billp_but;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox nameform_tex;
        private System.Windows.Forms.TextBox parcod_tex;
        private System.Windows.Forms.Button refreh_but;
        private System.Windows.Forms.Button search_but;
    }
}