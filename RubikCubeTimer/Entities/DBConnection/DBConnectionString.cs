﻿using System.Data.SqlClient;

namespace RubikCubeTimer.Entities.DBConnection
{
    class DBConnectionString
    {
        public static SqlConnection GetConnectionString()
        {
            SqlConnection retorno = new SqlConnection();
            retorno.ConnectionString = "Data Source=DESKTOP-QINDOBS;Initial Catalog=RUBIKCUBE_TIMER;Integrated Security=True;Connect Timeout=30";
            return retorno;
        }
    }
}
