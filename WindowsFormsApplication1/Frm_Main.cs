﻿using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void muridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmBuku = new Frm_MenuBuku();
            FrmBuku.Show();
            FrmBuku.MdiParent = this;
        }

        private void bukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormBuku = new Frm_MenuBuku();
            FormBuku.Show();
            FormBuku.MdiParent = this;
        }
    }
}
