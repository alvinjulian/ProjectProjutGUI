namespace WindowsFormsApplication1
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMuridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMuridLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMuridPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukuYangDipinjamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinjamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overdueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagihBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kembaliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem,
            this.muridToolStripMenuItem,
            this.bukuToolStripMenuItem,
            this.peminjamanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // muridToolStripMenuItem
            // 
            this.muridToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMuridToolStripMenuItem,
            this.dataMuridLToolStripMenuItem,
            this.dataMuridPToolStripMenuItem,
            this.tambahEntryToolStripMenuItem});
            this.muridToolStripMenuItem.Name = "muridToolStripMenuItem";
            this.muridToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.muridToolStripMenuItem.Text = "&Murid";
            // 
            // bukuToolStripMenuItem
            // 
            this.bukuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBukuToolStripMenuItem,
            this.bukuYangDipinjamToolStripMenuItem});
            this.bukuToolStripMenuItem.Name = "bukuToolStripMenuItem";
            this.bukuToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bukuToolStripMenuItem.Text = "&Buku";
            // 
            // peminjamanToolStripMenuItem
            // 
            this.peminjamanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pinjamToolStripMenuItem,
            this.overdueToolStripMenuItem,
            this.tagihBukuToolStripMenuItem,
            this.kembaliToolStripMenuItem});
            this.peminjamanToolStripMenuItem.Name = "peminjamanToolStripMenuItem";
            this.peminjamanToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.peminjamanToolStripMenuItem.Text = "&Peminjaman";
            // 
            // dataMuridToolStripMenuItem
            // 
            this.dataMuridToolStripMenuItem.Name = "dataMuridToolStripMenuItem";
            this.dataMuridToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dataMuridToolStripMenuItem.Text = "Data Murid";
            // 
            // dataMuridLToolStripMenuItem
            // 
            this.dataMuridLToolStripMenuItem.Name = "dataMuridLToolStripMenuItem";
            this.dataMuridLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dataMuridLToolStripMenuItem.Text = "Data Murid (L)";
            // 
            // dataMuridPToolStripMenuItem
            // 
            this.dataMuridPToolStripMenuItem.Name = "dataMuridPToolStripMenuItem";
            this.dataMuridPToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dataMuridPToolStripMenuItem.Text = "Data Murid (P)";
            // 
            // tambahEntryToolStripMenuItem
            // 
            this.tambahEntryToolStripMenuItem.Name = "tambahEntryToolStripMenuItem";
            this.tambahEntryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tambahEntryToolStripMenuItem.Text = "Tambah Entry";
            // 
            // dataBukuToolStripMenuItem
            // 
            this.dataBukuToolStripMenuItem.Name = "dataBukuToolStripMenuItem";
            this.dataBukuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataBukuToolStripMenuItem.Text = "Data Buku";
            // 
            // bukuYangDipinjamToolStripMenuItem
            // 
            this.bukuYangDipinjamToolStripMenuItem.Name = "bukuYangDipinjamToolStripMenuItem";
            this.bukuYangDipinjamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bukuYangDipinjamToolStripMenuItem.Text = "Buku yang dipinjam";
            // 
            // pinjamToolStripMenuItem
            // 
            this.pinjamToolStripMenuItem.Name = "pinjamToolStripMenuItem";
            this.pinjamToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pinjamToolStripMenuItem.Text = "Pinjam";
            // 
            // overdueToolStripMenuItem
            // 
            this.overdueToolStripMenuItem.Name = "overdueToolStripMenuItem";
            this.overdueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.overdueToolStripMenuItem.Text = "Overdue";
            // 
            // tagihBukuToolStripMenuItem
            // 
            this.tagihBukuToolStripMenuItem.Name = "tagihBukuToolStripMenuItem";
            this.tagihBukuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tagihBukuToolStripMenuItem.Text = "Tagih Buku";
            // 
            // kembaliToolStripMenuItem
            // 
            this.kembaliToolStripMenuItem.Name = "kembaliToolStripMenuItem";
            this.kembaliToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kembaliToolStripMenuItem.Text = "Kembali";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 419);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Main";
            this.Text = "Sistem Perpustakaan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMuridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMuridLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMuridPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukuYangDipinjamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peminjamanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinjamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overdueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagihBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kembaliToolStripMenuItem;
    }
}

