using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using RubikCubeTimer.Entities;
using RubikCubeTimer.Entities.Helpers;

namespace RubikCubeTimer.Entities
{
    class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Record Record { get; set; }
        
        public Usuario()
        {
        }

        public static string ConsultaLogin(string login)
        {
            string retorno = string.Empty;
            using (SqlConnection conexao = new SqlConnection())
            {
                conexao.ConnectionString = "Data Source=DESKTOP-QINDOBS;Initial Catalog=RUBIKCUBE_TIMER;Integrated Security=True;Connect Timeout=30";
                conexao.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = "select * from USUARIO where LOGIN_US = @login";
                    comando.Parameters.Add("@login", SqlDbType.VarChar).Value = login;

                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        retorno = (string)reader["LOGIN_US"];
                    }
                }
            }
            return retorno;
        }

        public static bool CreateUsuario(string nome, string login, string senha)
        {
            bool retorno = false;
            using (SqlConnection conexao = new SqlConnection())
            {
                conexao.ConnectionString = "Data Source=DESKTOP-QINDOBS; Initial Catalog=RUBIKCUBE_TIMER;Integrated Security=True;Connect Timeout=30";
                conexao.Open();
                using(SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = "insert into USUARIO values (@nome, @login, @senha)";
                    comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    comando.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = CriptoHelper.HashMD5(senha);

                    retorno = (comando.ExecuteNonQuery() > 0);
                }
            }
            return retorno;
        }


    }
}
