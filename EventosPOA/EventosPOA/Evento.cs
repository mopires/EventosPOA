using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosPOA
{
    abstract class Evento
    {
        protected string nome, local, descricao, IdCriador, categoria;
        protected DateTime horario;

        public string GetNome()
        {
            return nome;
        }

        public string GetLocal()
        {
            return local;
        }

        public string GetDescricao()
        {
            return descricao;
        }

        public DateTime GetHorario()
        {
            return horario;
        }

        public string GetCategoria()
        {
            return categoria;
        }

        public string GetNomeCriador()
        {
            return IdCriador;
        }


        //public abstract void CriarEvento();

        //public abstract void AlterarEvento(int idEvento);

        //public abstract void DeletarEvento(int idEvento);




    }
}
