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
        public int Id { get; set; }
        public TimeSpan MelhorTempo { get; set; }
        public DateTime Data { get; set; }


        public static List<Record> RecuperaRecords()
        {
            List<Record> retorno = new List<Record>();
            using (SqlConnection conexao = DBConnectionString.GetConnectionString())
            {
                conexao.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = "select * from RECORD";

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
                            Id = (int)reader["ID_REC"],
                            MelhorTempo = record,
                            Data = date
                        });
                    }
                }
                conexao.Close();
            }
            return retorno;
        }        

        public static Record RecuperaRecordAtual(int id)
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
                        comando.CommandText = "select top 1 * from RECORD where ID_US = @id order by MELHOR_TEMPO asc";
                        comando.Parameters.Add("@id", SqlDbType.Int).Value = id;

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
                                Id = (int)reader["ID_REC"],
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

        //DESKTOP-QINDOBS RUBIKCUBE_TIMER
        public static bool CreateNovoRecord(int id, string record, string data)
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
                        comando.CommandText = "insert into RECORD values (@id, @record, @data)";
                        comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        comando.Parameters.Add("@record", SqlDbType.VarChar).Value = record;
                        comando.Parameters.Add("@data", SqlDbType.VarChar).Value = data;

                        retorno = ((int)comando.ExecuteNonQuery() > 0);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("An error occured", "Rubik's Cube Timer");
            }
            return retorno;
        }

    }




}
