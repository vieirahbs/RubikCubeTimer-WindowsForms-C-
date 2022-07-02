using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using RubikCubeTimer.Entities.DBConnection;

namespace RubikCubeTimer.Entities
{
    public class Record
    {
        public int Id_Rec { get; set; }
        public int Id_US { get; set; }
        public CubeType TipoCubo { get; set; }
        public TimeSpan MelhorTempo { get; set; }
        public DateTime Data { get; set; }

        public Record()
        {
        }

        public static List<Record> RecuperaRecords(int id, CubeType cubeType)
        {
            List<Record> retorno = new List<Record>();
            try
            {
                using (SqlConnection conexao = DBConnectionString.GetConnectionString())
                {
                    conexao.Open();
                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conexao;
                        comando.CommandText = "select * from RECORD " +
                            "where ID_US = @id and TIPO_CUBO = @tipoCubo order by MELHOR_TEMPO asc";
                        comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        comando.Parameters.Add("@tipoCubo", SqlDbType.Int).Value = cubeType;

                        SqlDataReader reader = comando.ExecuteReader();

                        while (reader.Read())
                        {
                            string[] recordString = reader["MELHOR_TEMPO"].ToString().Split(':');
                            int minuto = int.Parse(recordString[0]);
                            int segundo = int.Parse(recordString[1]);
                            int centezimo = int.Parse(recordString[2]);
                            TimeSpan record = new TimeSpan(0, 0, minuto, segundo, centezimo);

                            string[] dateString = reader["DATA_REC"].ToString().Split('/');
                            int day = int.Parse(dateString[0]);
                            int month = int.Parse(dateString[1]);
                            int ano = int.Parse(dateString[2]);

                            DateTime date = new DateTime(ano, month, day);

                            retorno.Add(new Record
                            {
                                Id_Rec = (int)reader["ID_REC"],
                                Id_US = (int)reader["ID_US"],
                                TipoCubo = (CubeType)reader["TIPO_CUBO"],
                                MelhorTempo = record,
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

        public static Record RecuperaRecordAtual(int id, CubeType cuboTipo)
        {
            Record retorno = new Record();
            try
            {
                using (SqlConnection conexao = DBConnectionString.GetConnectionString())
                {
                    conexao.Open();
                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conexao;
                        comando.CommandText = "select top 1 * from RECORD where ID_US = @id " +
                            "and TIPO_CUBO = @cuboTipo order by MELHOR_TEMPO asc";
                        comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        comando.Parameters.Add("@cuboTipo", SqlDbType.Int).Value = cuboTipo;

                        SqlDataReader reader = comando.ExecuteReader();

                        if (reader.Read())
                        {
                            string[] recordString = reader["MELHOR_TEMPO"].ToString().Split(':');
                            int minuto = int.Parse(recordString[0]);
                            int segundo = int.Parse(recordString[1]);
                            int centezimo = int.Parse(recordString[2]);
                            TimeSpan record = new TimeSpan(0, 0, minuto, segundo, centezimo);

                            string[] dateString = reader["DATA_REC"].ToString().Split('/');
                            int day = int.Parse(dateString[0]);
                            int month = int.Parse(dateString[1]);
                            int ano = int.Parse(dateString[2]);

                            DateTime date = new DateTime(ano, month, day);

                            retorno = new Record
                            {
                                Id_Rec = (int)reader["ID_REC"],
                                Id_US = (int)reader["ID_US"],
                                TipoCubo = (CubeType)reader["TIPO_CUBO"],
                                MelhorTempo = record,
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

        public static bool CreateNovoRecord(int id, CubeType tipoCubo, string record, string data)
        {
            bool retorno = false;
            try
            {
                using (SqlConnection conexao = DBConnectionString.GetConnectionString())
                {
                    conexao.ConnectionString = "Data Source=DESKTOP-QINDOBS;Initial Catalog=RUBIKCUBE_TIMER;Integrated Security=True;Connect Timeout=30";
                    conexao.Open();
                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conexao;
                        comando.CommandText = "insert into RECORD values (@id, @tipoCubo, @record, @data)";
                        comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        comando.Parameters.Add("@tipoCubo", SqlDbType.Int).Value = tipoCubo;
                        comando.Parameters.Add("@record", SqlDbType.VarChar).Value = record;
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

        public static bool DeleteLastRecord(int id, CubeType tipoCubo)
        {
            bool retorno = false;
            Record record = RecuperaRecordAtual(id, tipoCubo);

            if (record.Id_US != 0)
            {
                try
                {
                    using (SqlConnection conexao = DBConnectionString.GetConnectionString())
                    {
                        conexao.Open();
                        using (SqlCommand comando = new SqlCommand())
                        {
                            comando.Connection = conexao;
                            comando.CommandText = "delete from RECORD where ID_REC = @idRec";
                            comando.Parameters.Add("@idRec", SqlDbType.Int).Value = record.Id_Rec;

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
