using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosPOA
{
    public class Usuario
    {
        protected string username, senha, nome, sobrenome;
        DateTime dataNascimento; //adicionar atributos

        public Usuario(string username, string senha, string nome,
                       string sobrenome, DateTime dataNascimento)
        {
            this.username       = username;
            this.senha          = senha;
            this.nome           = nome;
            this.sobrenome      = sobrenome;
            this.dataNascimento = dataNascimento;

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

        public string GetSobrenome()
        {
            return sobrenome;
        }

        public DateTime GetDataNascimento()
        {
            return dataNascimento;
        }

    }
}
