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
    public partial class frm_Login : Form
    {

        SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=db_Perpustakaan;Data Source=localhost");
        SqlDataAdapter daUser;
        DataSet dsUser;

        bool login = false;

        string user = "";

        public frm_Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void clearTXT()
        {
            txtID.Clear();
            txtPass.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "" && txtPass.Text.Trim() == "")
            {
                MessageBox.Show("ID dan Password Harus diisi!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTXT();
                txtID.Focus();
            }
            else
            {
                daUser = new SqlDataAdapter("SELECT * FROM tbl_User", conn);
                dsUser = new DataSet();
                daUser.Fill(dsUser, "MsUser");

                for (int i = 0; i <= dsUser.Tables["MsUser"].Rows.Count; i++)
                {
                    if (txtID.Text.Trim() == dsUser.Tables["MsUser"].Rows[i][0].ToString() && txtPass.Text.Trim() == dsUser.Tables["MsUser"].Rows[i][1].ToString())
                    {
                        login = true;
                        user = dsUser.Tables["MsUser"].Rows[i][0].ToString();
                        break;
                    }
                }

                if (login == true)
                {
                    MessageBox.Show("Login Success!" + '\n' + "Welcome " + user + "!", "Login Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //string user = dsUser.Tables["MsUser"].Rows[i][0].ToString();
                    var formMain = new Frm_Main();
                    formMain.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Wrong User ID or Password!", "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearTXT();
                    txtID.Focus();

                }
            }
        }

        private void frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
