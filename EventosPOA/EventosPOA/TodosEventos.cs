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
    public partial class TodosEventos : Form
    {
        Usuario user;
        public TodosEventos(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void TodosEventos_Load(object sender, EventArgs e)
        {
            MySQL mysql = new MySQL();
            mysql.Connect();
            bindingSource1.DataSource  = mysql.ListaTodosEventos();
            dataGridEventos.DataSource = bindingSource1;

        }

        private void btnParticipar_Click(object sender, EventArgs e)
        {
            string idEvento = dataGridEventos.Rows[dataGridEventos.CurrentRow.Index]
                              .Cells["idEvento"].Value.ToString();

            MySQL mysql = new MySQL();
            mysql.Connect();
            MessageBox.Show(mysql.ParticiparEvento(int.Parse(idEvento), user.GetUsername()));

        }

        private void boxEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySQL mysql = new MySQL();
            mysql.Connect();
            bindingSource1.DataSource  = mysql.ListaTodosEventos(boxEvento.SelectedIndex, user.GetUsername());
            dataGridEventos.DataSource = bindingSource1;

            if(boxEvento.SelectedIndex == 1)
            {
                btnCancelarParticipacao.Visible = true;
            }
            else
            {
                btnCancelarParticipacao.Visible = false;
            }
        }

        private void btnCancelarParticipacao_Click(object sender, EventArgs e)
        {
            string idEvento = dataGridEventos.Rows[dataGridEventos.CurrentRow.Index]
                              .Cells["idEvento"].Value.ToString();

            MySQL mysql = new MySQL();
            mysql.Connect();

            MessageBox.Show(mysql.CancelarParticipacao(int.Parse(idEvento), user.GetUsername()));

        }
    }
}
