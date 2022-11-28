
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Infrastructure.ConsultoriaMedico.Repository
{
    public static class ConsultUpdateRepository
    {
        static string connectionString = Environment.GetEnvironmentVariable("connectionString");
        static OleDbConnection connection;
        public static bool UpdatePeople(string name, int cpf, int id)
        {
            string query = String.Empty;

            query += Environment.NewLine + "UPDATE PESSOA";
            query += Environment.NewLine + "SET NOME = ?,";
            query += Environment.NewLine + "CPF = ?      ";
            query += Environment.NewLine + "WHERE ID = ? ";

            try
            {
                using (connection = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand command = new OleDbCommand(query))
                    {
                        command.Parameters.Add(name);
                        command.Parameters.Add(cpf);
                        command.Parameters.Add(id);

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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool UpdateAddress(string logradouro, int numero, int cep, string bairro, string cidade, string estado, int id)
        {
            string query = String.Empty;

            query += Environment.NewLine + "UPDATE ENDERECO     ";
            query += Environment.NewLine + "SET LOGRADOURO = ?, ";
            query += Environment.NewLine + "NUMERO = ?,         ";
            query += Environment.NewLine + "CEP = ?,            ";
            query += Environment.NewLine + "BAIRRO = ?,         ";
            query += Environment.NewLine + "CIDADE = ?,         ";
            query += Environment.NewLine + "ESTADO = ?          ";
            query += Environment.NewLine + "WHERE ID = ?        ";

            try
            {
                using (connection = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand command = new OleDbCommand(query))
                    {
                        command.Parameters.Add(logradouro);
                        command.Parameters.Add(numero);
                        command.Parameters.Add(cep);
                        command.Parameters.Add(bairro);
                        command.Parameters.Add(cidade);
                        command.Parameters.Add(estado);
                        command.Parameters.Add(id);

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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool UpdatePhone(int numero, int ddd, int tipo, int id)
        {
            string query = String.Empty;

            query += Environment.NewLine + "UPDATE TELEFONE";
            query += Environment.NewLine + "SET NUMERO = ?,";
            query += Environment.NewLine + "DDD = ?,       ";
            query += Environment.NewLine + "TIPO = ?       ";
            query += Environment.NewLine + "WHERE ID = ?   ";

            try
            {
                using (connection = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand command = new OleDbCommand(query))
                    {
                        command.Parameters.Add(numero);
                        command.Parameters.Add(ddd);
                        command.Parameters.Add(tipo);
                        command.Parameters.Add(id);

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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
