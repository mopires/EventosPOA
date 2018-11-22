using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventosPOA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
               MySQL mysql = new MySQL();
               labelStatus.Text = mysql.Connect();
               labelStatus.Visible = true;
            */

        }


        private void btnCadastro_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadUser = new CadastroUsuario();
            cadUser.ShowDialog();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = false;
            txtSenha.Enabled = false;
            btnlogin.Enabled = false;
            MySQL mysql = new MySQL();
            mysql.Connect();
            try
            {
                //Construir objeto usuario?
                Usuario user = mysql.UserLogin(txtUserName.Text, txtSenha.Text);
                Home home = new Home(user);
                home.ShowDialog();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Falha: " + exception.Message);
                txtUserName.Enabled = true;
                txtSenha.Enabled = true;
                txtSenha.Text = "";
                btnlogin.Enabled = true;
            }

        }
    }
}
