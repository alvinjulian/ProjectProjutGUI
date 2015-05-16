namespace WindowsFormsApplication1
{
    partial class Frm_MenuBuku
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDbuku = new System.Windows.Forms.TextBox();
            this.txtNamaBuku = new System.Windows.Forms.TextBox();
            this.txtPengarang = new System.Windows.Forms.TextBox();
            this.txtEdisi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTambahBuku = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU BUKU";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(592, 168);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(454, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Buku :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nama Buku : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pengarang Buku : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data Buku : ";
            // 
            // txtIDbuku
            // 
            this.txtIDbuku.Location = new System.Drawing.Point(129, 43);
            this.txtIDbuku.Name = "txtIDbuku";
            this.txtIDbuku.Size = new System.Drawing.Size(210, 20);
            this.txtIDbuku.TabIndex = 8;
            // 
            // txtNamaBuku
            // 
            this.txtNamaBuku.Location = new System.Drawing.Point(129, 73);
            this.txtNamaBuku.Name = "txtNamaBuku";
            this.txtNamaBuku.Size = new System.Drawing.Size(210, 20);
            this.txtNamaBuku.TabIndex = 9;
            // 
            // txtPengarang
            // 
            this.txtPengarang.Location = new System.Drawing.Point(129, 104);
            this.txtPengarang.Multiline = true;
            this.txtPengarang.Name = "txtPengarang";
            this.txtPengarang.Size = new System.Drawing.Size(210, 57);
            this.txtPengarang.TabIndex = 10;
            // 
            // txtEdisi
            // 
            this.txtEdisi.Location = new System.Drawing.Point(129, 172);
            this.txtEdisi.Name = "txtEdisi";
            this.txtEdisi.Size = new System.Drawing.Size(100, 20);
            this.txtEdisi.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Edisi Buku : ";
            // 
            // btnTambahBuku
            // 
            this.btnTambahBuku.Location = new System.Drawing.Point(369, 43);
            this.btnTambahBuku.Name = "btnTambahBuku";
            this.btnTambahBuku.Size = new System.Drawing.Size(75, 46);
            this.btnTambahBuku.TabIndex = 13;
            this.btnTambahBuku.Text = "Tambah Buku";
            this.btnTambahBuku.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(369, 95);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 46);
            this.btnSimpan.TabIndex = 14;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(369, 147);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 46);
            this.btnBatal.TabIndex = 15;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(454, 43);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 46);
            this.btnFilter.TabIndex = 16;
            this.btnFilter.Text = "Filter by Peminjam";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(560, 14);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(53, 20);
            this.btnCari.TabIndex = 17;
            this.btnCari.Text = "Cari!";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // Frm_MenuBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 404);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnTambahBuku);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEdisi);
            this.Controls.Add(this.txtPengarang);
            this.Controls.Add(this.txtNamaBuku);
            this.Controls.Add(this.txtIDbuku);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_MenuBuku";
            this.Text = "Menu Buku";
            this.Load += new System.EventHandler(this.Frm_MenuBuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDbuku;
        private System.Windows.Forms.TextBox txtNamaBuku;
        private System.Windows.Forms.TextBox txtPengarang;
        private System.Windows.Forms.TextBox txtEdisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTambahBuku;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnCari;
    }
}