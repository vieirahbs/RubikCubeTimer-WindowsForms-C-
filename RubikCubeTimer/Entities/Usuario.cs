using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using RubikCubeTimer.Entities;
using RubikCubeTimer.Entities.DBConnection;
using RubikCubeTimer.Entities.Helpers;

namespace RubikCubeTimer.Entities
{
    public class Usuario
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
            try
            {
                using (SqlConnection conexao = DBConnectionString.GetConnectionString())
                {
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
                    conexao.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("An error occured", "Rubik's Cube Timer - Create your account");
            }

            return retorno;
        }

        public static bool CreateUsuario(string nome, string login, string senha)
        {
            bool retorno = false;
            try
            {
                using (SqlConnection conexao = DBConnectionString.GetConnectionString())
                {
                    conexao.Open();
                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conexao;
                        comando.CommandText = "insert into USUARIO values (@nome, @login, @senha)";
                        comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                        comando.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                        comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = CriptoHelper.HashMD5(senha);

                        retorno = (comando.ExecuteNonQuery() > 0);
                    }
                    conexao.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("An error occured", "Rubik's Cube Timer - Create your account");
            }

            return retorno;
        }

        public static Usuario ValidaUsuario(string login, string senha)
        {
            Usuario retorno = new Usuario();
            try
            {
                using (SqlConnection conexao = DBConnectionString.GetConnectionString())
                {
                    conexao.Open();
                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conexao;
                        comando.CommandText = "select * from USUARIO where LOGIN_US = @login and SENHA = @senha";
                        comando.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                        comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = CriptoHelper.HashMD5(senha);

                        SqlDataReader reader = comando.ExecuteReader();
                        if (reader.Read())
                        {
                            retorno = new Usuario
                            {
                                Id = (int)reader["ID_US"],
                                Nome = (string)reader["NOME"],
                                Login = (string)reader["LOGIN_US"]
                            };
                        }
                    }
                    conexao.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("An error occured", "Rubik's Cube Timer - Create your account");
            }
            return retorno;
        }

        //DESKTOP-QINDOBS RUBIKCUBE_TIMER

        public static bool UpdateUsuario(int id, string nome = "", string senha = "")
        {
            bool retorno = false;
            try
            {
                using (SqlConnection conexao = DBConnectionString.GetConnectionString())
                {
                    conexao.Open();
                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conexao;
                        if (nome != "")
                        {
                            comando.CommandText = "update USUARIO set NOME = @nome where ID_US = @id";
                            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                            comando.Parameters.Add("@id", SqlDbType.Int).Value = id;

                            retorno = (comando.ExecuteNonQuery() > 0);
                        }
                        else if (senha != "")
                        {
                            comando.CommandText = "update USUARIO set SENHA = @senha where ID_US = @id";
                            comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = CriptoHelper.HashMD5(senha);
                            comando.Parameters.Add("@id", SqlDbType.Int).Value = id;

                            retorno = (comando.ExecuteNonQuery() > 0);
                        }
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("An error occured", "Rubik's Cube Timer - Update name");
            }
            return retorno;
        }

        public static bool DeleteUsuario(int id, string login, string senha)
        {
            bool retorno = false;
            try
            {
                Usuario usuario = ValidaUsuario(login, senha);
                if (usuario.Login != null)
                {
                    using (SqlConnection conexao = DBConnectionString.GetConnectionString())
                    {
                        conexao.Open();
                        using (SqlCommand comando = new SqlCommand())
                        {
                            comando.Connection = conexao;
                            comando.CommandText = "delete from RECORD where ID_US = @id; " +
                                "delete from USUARIO where ID_US = @id";
                            comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
                            retorno = (comando.ExecuteNonQuery() > 0);
                        }
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("An error occured", "Rubik's Cube Timer - Delete account");
            }

            return retorno;
        }

    }
}
