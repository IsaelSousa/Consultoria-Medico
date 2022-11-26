using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insfraestrutura.ConsultoriaMedico.Database
{
    public static class Connection
    {
        private static string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3641;Database=MedicConsultUnip;";

        static NpgsqlConnection connection;

        public static void OpenConnection()
        {
            connection = new NpgsqlConnection(connectionString);
            connection.Open();
        }

        public static void CloseConnection()
        {
            connection.Close();
        }

    }
}
