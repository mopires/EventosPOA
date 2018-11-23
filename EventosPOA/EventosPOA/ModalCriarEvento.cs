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
    public partial class ModalCriarEvento : Form
    {
        string categoria;
        string usernameCriador;
        public ModalCriarEvento(string categoria, string usernameCriador)
        {
            InitializeComponent();
            this.categoria = categoria; //precisa?
            this.usernameCriador = usernameCriador;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nomeEvento = txtNomeEvento.Text,
                   local      = txtLocal.Text, 
                   descricao  = txtDescricao.Text,
                   IdCriador  = usernameCriador;

            DateTimePicker datepicker = new DateTimePicker();

            int dia  = datePicker.Value.Day;
            int mes  = datePicker.Value.Month;
            int ano  = datePicker.Value.Year;

            string horaInicio = boxHoraInicio.Text;
            int hora = int.Parse(horaInicio.Split(':')[0]);
            int minutos = int.Parse(horaInicio.Split(':')[1]);

            //int horaFim = int.Parse(boxHoraInicio.Text); horario finale

            DateTime horario = new DateTime(ano, mes, dia, hora, minutos,0);

            Evento festa = new Festa(nomeEvento, horario, local, descricao, IdCriador);

            MySQL mysql = new MySQL();
            mysql.Connect();

            MessageBox.Show(mysql.CriarEvento(festa), "Cadastro de Evento");
            
        }
    }
}
