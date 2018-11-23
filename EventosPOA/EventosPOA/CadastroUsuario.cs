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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            DateTime dataNascimento = datapicker.Value.Date;

            Usuario user = new Usuario(txtUserName.Text, txtSenha.Text, txtName.Text,
                                       txtSobrenome.Text, dataNascimento);

            MySQL mysql = new MySQL();
            mysql.Connect();
            MessageBox.Show(mysql.CadastroUsuario(user));

            Home home = new Home(user);
            home.Show();
            Close();
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
