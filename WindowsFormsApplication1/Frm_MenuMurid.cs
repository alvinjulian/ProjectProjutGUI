using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Frm_MenuMurid : Form
    {

        SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AK-Store;Data Source=localhost");
        SqlDataAdapter daMurid;
        DataSet dsMurid;

        public Frm_MenuMurid()
        {
            InitializeComponent();
        }

        void lockBtn(bool stat)
        {

        }

        void lockTxt(bool stat)
        {

        }

        void clearTxt()
        {

        }

        public static bool emailIsValid(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private static bool isValid(String str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z]+$");
        }

        private void Frm_MenuMurid_Load(object sender, EventArgs e)
        {
            lockBtn(true);
            lockTxt(false);
            clearTxt();
            dsMurid = new DataSet();
            daMurid = new SqlDataAdapter("Select * From tbl_Murid", conn);
            daMurid.Fill(dsMurid, "MasterMurid");

            dataGridView1.DataSource = dsMurid.Tables["MasterMurid"];

            SqlCommandBuilder cmb = new SqlCommandBuilder(daMurid);
        }

        private void btnTammbahBuku_Click(object sender, EventArgs e)
        {
            lockBtn(false);
            lockTxt(true);
            clearTxt();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNIM.Text == "" && txtNama.Text == "" && txtEmail.Text == "" && cmbKelamin.Text == "")
            {
                MessageBox.Show("Data tidak lengkap!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool number;
                bool nama = isValid(txtNama.Text);
                int nim;

                number = int.TryParse(txtNIM.Text, out nim);
                if(number==true)
                {
                    nim = int.Parse(txtNIM.Text);
                    if (isValid(txtNama.Text) == true)
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Nama Tidak Valid!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("NIM Tidak Valid!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
