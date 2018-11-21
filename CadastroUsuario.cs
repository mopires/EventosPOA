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
            Usuario user = new Usuario(txtUserName.Text, 
                                       txtName.Text, txtSenha.Text);

            MySQL mysql = new MySQL();
            labelErro.Text = mysql.Connect();
            labelErro.Visible = true;

            MessageBox.Show(mysql.CadastroUsuario(user));
            Home home = new Home(user);
            home.Show();
            Close();
            

        }
    }
}
