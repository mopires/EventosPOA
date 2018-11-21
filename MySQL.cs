using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace EventosPOA
{
    class MySQL
    {
        MySqlConnection conexao;
        MySqlCommand comando;

        public string Connect()
        {
            conexao = new MySqlConnection("server=localhost;user id=root;" +
                                          "database=evento_poa; allow Zero Datetime=True");
            conexao.Open();
            if (CheckConnection())
            {
                return "Conectado";
            }
            else
            {
                return "Desconectado";
            }
            
        }

        public void Close()
        {
            conexao.Close();
        }

        public string CadastroUsuario(Usuario user)
        {

            comando = new MySqlCommand("insert into usuario (username, pass, nome) " +
                                       "values('" + user.GetUsername() +"','"
                                       + user.GetPass() + "','"
                                       + user.GetName() + "');",
                                       conexao);

            try
            {
                comando.ExecuteReader();
                return "Você se cadastrou.";
                
            }
            catch(Exception exception)
            {
                return "Falha: " + exception.Message;
            }

            
        }

        public Usuario UserLogin(string username, string pass)
        {
            string query = "SELECT username, nome, pass FROM usuario WHERE " +
                           "username = '" + username + "' " +
                           "AND pass = '" + pass + "'";

            Connect();
            comando = new MySqlCommand(query, conexao);

            if (CheckConnection())
            {
                MySqlDataReader data = comando.ExecuteReader();

                if (GetHasRows(data))
                {
                    data.Read();
                    try
                    {
                        Usuario user = new Usuario(data.GetString(0),
                                               data.GetString(1),
                                               data.GetString(2)); //erro na senha data.GetString(2)
                        conexao.Close();
                        return user;
                    }
                    catch(MySqlException sqlException)
                    {
                        throw sqlException;
                    }


                }
                else
                {
                    
                    Usuario user = null;
                    return user;
                }
            }
            else
            {
                conexao.Close();
                Usuario user = null;
                return user;
            }

        }

        public string CriarEvento(Evento evento)
        {
            string format = "yyyy-MM-dd HH:mm:ss"; //alterar no banco o formato

            string query = "INSERT INTO eventos (nomeEvento, dia, categoria," +
                                                 "descricao, nomeCriador) " +
                                                 " VALUES (" +
                                                 "'" + evento.GetNome() + "'," +
                                                 "'" + evento.GetHorario().ToString(format) + "'," +
                                                 "'" + evento.GetCategoria() + "'," +
                                                 "'" + evento.GetDescricao() + "'," +
                                                 "'" + evento.GetNomeCriador() + "')";

            comando = new MySqlCommand(query, conexao);

            try
            {
                comando.ExecuteReader();
                Close();
                return evento.GetNome() + " foi cadastrado!";

            }
            catch (MySqlException exception)
            {
                Close();
                return "Falha: " + exception.Message;
            }



        }

        private static bool GetHasRows(MySqlDataReader data)
        {
            return data.HasRows;
        }

        private bool CheckConnection()
        {
            return conexao.State == ConnectionState.Open;
        }
    }
}
