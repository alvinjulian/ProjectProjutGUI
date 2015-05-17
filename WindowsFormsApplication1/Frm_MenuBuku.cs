using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Frm_MenuBuku : Form
    {

        SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AK-Store;Data Source=localhost");
        SqlDataAdapter daBuku;
        DataSet dsBuku;

        public Frm_MenuBuku()
        {
            InitializeComponent();
        }

        public void lockBtn(bool stat)
        {
            btnTambahBuku.Enabled = stat;
            btnFilter.Enabled = stat;
            btnSimpan.Enabled = !stat;
            btnBatal.Enabled = !stat;
        }

        public void lockTxt(bool stat)
        {
            txtIDbuku.Enabled = stat;
            txtNamaBuku.Enabled = stat;
            txtPengarang.Enabled = stat;
            txtEdisi.Enabled = stat;
        }

        public void clearTxt()
        {
            txtIDbuku.Clear();
            txtNamaBuku.Clear();
            txtPengarang.Clear();
            txtEdisi.Clear();
        }

        private void Frm_MenuBuku_Load(object sender, EventArgs e)
        {
            lockBtn(true);
            lockTxt(false);
            clearTxt();
            dsBuku = new DataSet();
            daBuku = new SqlDataAdapter("Select * From tbl_Buku", conn);
            daBuku.Fill(dsBuku, "MasterBuku");

            dataGridView1.DataSource = dsBuku.Tables["MasterBuku"];

            SqlCommandBuilder cmb = new SqlCommandBuilder(daBuku);
        }

        private void btnTambahBuku_Click(object sender, EventArgs e)
        {
            lockBtn(false);
            lockTxt(true);
            clearTxt();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataRow dr = new DataRow();

            if(txtIDbuku.Text=="" && txtNamaBuku.Text=="" && txtPengarang.Text=="" && txtEdisi.Text=="")
            {
                MessageBox.Show("Data buku belum lengkap!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int idx = 0;
                idx = dataGridView1.CurrentRow.Index;
                dr = dsBuku.Tables["MasterBuku"].Rows[idx];
                dr["idBuku"] = this.txtIDbuku.Text.Trim();
                dr["namaBuku"] = this.txtNamaBuku.Text.Trim();
                dr["pengarang"] = this.txtPengarang.Text.Trim();
                dr["edisi"] = this.txtEdisi.Text.Trim();
                dr["tglPeminjam"] = null;
                dr["nimPeminjam"] = null;

                daBuku.Update(dsBuku, "MasterBuku");
                lockBtn(true);
                lockTxt(false);
                clearTxt();

                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            lockBtn(true);
            lockTxt(false);
            clearTxt();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                txtIDbuku.Text = row.Cells["idBuku"].Value.ToString();
                txtNamaBuku.Text = row.Cells["namaBuku"].Value.ToString();
                txtPengarang.Text = row.Cells["pengarang"].Value.ToString();
                txtEdisi.Text = row.Cells["edisi"].Value.ToString();
            }
        }
    }
}
