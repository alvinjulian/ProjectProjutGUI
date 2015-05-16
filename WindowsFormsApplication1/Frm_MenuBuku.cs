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

        }

        private void Frm_MenuBuku_Load(object sender, EventArgs e)
        {

        }
    }
}
