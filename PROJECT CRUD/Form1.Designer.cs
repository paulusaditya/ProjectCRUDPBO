namespace PROJECT_CRUD
{
    partial class Form1
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
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.keyword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.satuan = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DELETE = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.stock = new System.Windows.Forms.TextBox();
            this.harga = new System.Windows.Forms.TextBox();
            this.namabarang = new System.Windows.Forms.TextBox();
            this.idbarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EXIT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Cari Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(452, 178);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(198, 22);
            this.keyword.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 29);
            this.label6.TabIndex = 38;
            this.label6.Text = "Welcome Admin";
            // 
            // satuan
            // 
            this.satuan.FormattingEnabled = true;
            this.satuan.Items.AddRange(new object[] {
            "PCS",
            "PAK",
            "BOTOL",
            "BOX",
            "UNIT",
            "SACHET"});
            this.satuan.Location = new System.Drawing.Point(185, 215);
            this.satuan.Name = "satuan";
            this.satuan.Size = new System.Drawing.Size(165, 24);
            this.satuan.TabIndex = 37;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(694, 274);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(452, 254);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(86, 40);
            this.DELETE.TabIndex = 33;
            this.DELETE.Text = "DELETE ()";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(261, 255);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(89, 40);
            this.UPDATE.TabIndex = 32;
            this.UPDATE.Text = "UPDATE ()";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(92, 255);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(95, 39);
            this.SAVE.TabIndex = 31;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(185, 171);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(165, 22);
            this.stock.TabIndex = 30;
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(185, 136);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(165, 22);
            this.harga.TabIndex = 29;
            // 
            // namabarang
            // 
            this.namabarang.Location = new System.Drawing.Point(185, 101);
            this.namabarang.Name = "namabarang";
            this.namabarang.Size = new System.Drawing.Size(434, 22);
            this.namabarang.TabIndex = 28;
            // 
            // idbarang
            // 
            this.idbarang.Location = new System.Drawing.Point(185, 63);
            this.idbarang.Name = "idbarang";
            this.idbarang.Size = new System.Drawing.Size(165, 22);
            this.idbarang.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "SATUAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "STOCK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "HARGA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "NAMA ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID BARANG";
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(623, 255);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(87, 40);
            this.EXIT.TabIndex = 34;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.satuan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.namabarang);
            this.Controls.Add(this.idbarang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Warung";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox satuan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.TextBox namabarang;
        private System.Windows.Forms.TextBox idbarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EXIT;
    }
}

