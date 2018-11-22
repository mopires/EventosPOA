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
    public partial class Home : Form
    {
        Usuario user;
        public Home(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }
        

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void festaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ModalCriarEvento ModalEvento = new ModalCriarEvento("Festa", user.GetUsername());
            ModalEvento.ShowDialog();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            labelUserName.Text = "Bem vindo, " + user.GetName();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TodosEventos TE = new TodosEventos(user);
            TE.ShowDialog();
        }

        private void meusEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
