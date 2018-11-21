using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosPOA
{
    public class Usuario
    {
        protected string username, nome, senha; //adicionar atributos

        public Usuario(string username, string nome, string senha)
        {
            this.username = username;
            this.nome     = nome;
            this.senha    = senha;

        }

        public string GetUsername()
        {
            return username;
        }

        public string GetName()
        {
            return nome;
        }

        public string GetPass()
        {
            return senha;
        }

        


    }
}
