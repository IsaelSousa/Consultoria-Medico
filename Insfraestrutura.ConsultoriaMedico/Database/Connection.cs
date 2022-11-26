using System.Data.OleDb;
using System.Data;

namespace Insfraestrutura.ConsultoriaMedico.Database
{
    public static class Connection
    {
        private static string connectionString = "Provider=SQLOLEDB.1;Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=MedicConsult;Data Source=DESKTOP-0Q2AQQM\\SQLEXPRESS";

        public static OleDbConnection connection;

        public static void OpenConnection()
        {
            using (OleDbConnection connect = new OleDbConnection(connectionString))
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
            }
        }

        public static void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
