using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosPOA
{
    class Festa : Evento
    {

        public Festa(string nome, DateTime horario, string local, string descricao, 
                     string IdCriador, string categoria = "Festa")
        {
            this.nome      = nome;
            this.horario   = horario;
            this.local     = local;
            this.descricao = descricao;
            this.IdCriador = IdCriador;
            this.categoria = categoria;

        }



    }
}
