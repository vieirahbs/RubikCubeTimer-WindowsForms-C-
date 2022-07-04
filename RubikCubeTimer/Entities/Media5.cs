using RubikCubeTimer.Entities.DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RubikCubeTimer.Entities
{
    class Media5
    {
        public int IdMedia { get; set; }
        public int Id_US { get; set; }
        public CubeType TipoCubo { get; set; }
        public TimeSpan MelhorMedia { get; set; }
        public DateTime Data { get; set; }

        public Media5()
        {
        }

        public static List<Media5> RecuperaMelhoresMedia5(int id, CubeType tipoCubo)
        {
            List<Media5> retorno = new List<Media5>();
            try
            {
                using (SqlConnection conexao = DBConnectionString.GetConnectionString())
                {
                    conexao.Open();
                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conexao;
                        comando.CommandText = "select * from MEDIA_DE_CINCO " +
                            "where ID_US = @id and TIPO_CUBO = @tipoCubo order by MELHOR_MEDIA asc";
                        comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        comando.Parameters.Add("@tipoCubo", SqlDbType.Int).Value = tipoCubo;

                        SqlDataReader reader = comando.ExecuteReader();

                        while (reader.Read())
                        {
                            string[] media5String = reader["MELHOR_MEDIA"].ToString().Split(':');
                            int minuto = int.Parse(media5String[0]);
                            int segundo = int.Parse(media5String[1]);
                            int centezimo = int.Parse(media5String[2]);
                            TimeSpan media5 = new TimeSpan(0, 0, minuto, segundo, centezimo);

                            string[] dateString = reader["DATA_MEDIA5"].ToString().Split('/');
                            int day = int.Parse(dateString[0]);
                            int month = int.Parse(dateString[1]);
                            int ano = int.Parse(dateString[2]);

                            DateTime date = new DateTime(ano, month, day);

                            retorno.Add(new Media5
                            {
                                IdMedia = (int)reader["ID_MEDIA"],
                                Id_US = (int)reader["ID_US"],
                                TipoCubo = (CubeType)reader["TIPO_CUBO"],
                                MelhorMedia = media5,
                                Data = date
                            });
                        }
                    }
                    conexao.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("An error occured", "Rubik's Cube Timer");
            }
            return retorno;
        }

        public static Media5 RecuperaMedia5Atual(int id, CubeType cuboTipo)
        {
            Media5 retorno = new Media5();
            try
            {
                using (SqlConnection conexao = DBConnectionString.GetConnectionString())
                {
                    conexao.Open();
                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conexao;
                        comando.CommandText = "select top 1 * from MEDIA_DE_CINCO where ID_US = @id " +
                            "and TIPO_CUBO = @cuboTipo order by MELHOR_MEDIA asc";
                        comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        comando.Parameters.Add("@cuboTipo", SqlDbType.Int).Value = cuboTipo;

                        SqlDataReader reader = comando.ExecuteReader();

                        if (reader.Read())
                        {
                            string[] media5String = reader["MELHOR_MEDIA"].ToString().Split(':');
                            int minuto = int.Parse(media5String[0]);
                            int segundo = int.Parse(media5String[1]);
                            int centezimo = int.Parse(media5String[2]);
                            TimeSpan media5 = new TimeSpan(0, 0, minuto, segundo, centezimo);

                            string[] dateString = reader["DATA_MEDIA5"].ToString().Split('/');
                            int day = int.Parse(dateString[0]);
                            int month = int.Parse(dateString[1]);
                            int ano = int.Parse(dateString[2]);

                            DateTime date = new DateTime(ano, month, day);

                            retorno = new Media5
                            {
                                IdMedia = (int)reader["ID_MEDIA"],
                                Id_US = (int)reader["ID_US"],
                                TipoCubo = (CubeType)reader["TIPO_CUBO"],
                                MelhorMedia = media5,
                                Data = date
                            };
                        }
                    }
                    conexao.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("An error occured", "Rubik's Cube Timer");
            }

            return retorno;
        }

        public static bool CreateNovaMelhorMedia5(int id, CubeType tipoCubo, string media5, string data)
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
                        comando.CommandText = "insert into MEDIA_DE_CINCO " +
                            "values (@id, @tipoCubo, @media5, @data)";
                        comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        comando.Parameters.Add("@tipoCubo", SqlDbType.Int).Value = tipoCubo;
                        comando.Parameters.Add("@media5", SqlDbType.VarChar).Value = media5;
                        comando.Parameters.Add("@data", SqlDbType.VarChar).Value = data;

                        retorno = ((int)comando.ExecuteNonQuery() > 0);
                    }
                    conexao.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("An error occured", "Rubik's Cube Timer");
            }

            return retorno;
        }

        public static bool DeleteLastMedia5(int id, CubeType tipoCubo)
        {
            bool retorno = false;
            Media5 media5 = RecuperaMedia5Atual(id, tipoCubo);
            if (media5.Id_US != 0)
            {
                try
                {
                    using (SqlConnection conexao = DBConnectionString.GetConnectionString())
                    {
                        conexao.Open();
                        using (SqlCommand comando = new SqlCommand())
                        {
                            comando.Connection = conexao;
                            comando.CommandText = "delete from MEDIA_DE_CINCO where ID_MEDIA = @idMedia";
                            comando.Parameters.Add("@idMedia", SqlDbType.Int).Value = media5.IdMedia;

                            retorno = (comando.ExecuteNonQuery() > 0);
                        }
                        conexao.Close();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("An error occured", "Rubik's Cube Timer");
                }
            }
            return retorno;
        }

    }
}
