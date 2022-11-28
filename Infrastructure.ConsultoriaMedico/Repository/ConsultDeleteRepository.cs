
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ConsultoriaMedico.Repository
{
    public static class ConsultDeleteRepository
    {
        static string connectionString = Environment.GetEnvironmentVariable("connectionString");
        static OleDbConnection connection;
        public static bool DeletePeoples(int userID)
        {
            string query = "DELETE FROM PESSOA WHERE ID = ?";

            using (connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query))
                {
                    command.Parameters.Add(userID);
                    object result = command.ExecuteScalar();
                    connection.Close();
                    int value;
                    if (int.TryParse(result.ToString(), out value))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public static bool DeleteAddress(int addressID)
        {
            string query = "DELETE FROM ENDERECO WHERE ID = ?";

            using (connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query))
                {
                    command.Parameters.Add(addressID);
                    object result = command.ExecuteScalar();
                    connection.Close();
                    int value;
                    if (int.TryParse(result.ToString(), out value))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public static bool DeletePeoplePhone(int userID, int phoneID)
        {
            string query = "DELETE FROM PESSOA_TELEFONE WHERE ID_PESSOA = ? AND ID_TELEFONE = ?";

            using (connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.Add(userID);
                    command.Parameters.Add(phoneID);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    connection.Close();
                    int value;
                    if (int.TryParse(result.ToString(), out value))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public static bool DeletePhone(int phoneID)
        {
            string query = "DELETE FROM TELEFONE WHERE ID = ?";

            using (connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.Add(phoneID);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    connection.Close();
                    return true;
                }
            }
        }
    }
}
