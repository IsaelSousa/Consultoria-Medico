
using Infrastructure.ConsultoriaMedico.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ConsultoriaMedico.Repository
{
    public static class ConsultInsertRepository
    {
        static string connectionString = Environment.GetEnvironmentVariable("connectionString");
        static OleDbConnection connection;
        public static int InsertPeoples(string nome, int cpf, int endereco)
        {
            string query = String.Empty;

            query += Environment.NewLine + "INSERT INTO PESSOA(";
            query += Environment.NewLine + "    NOME,          ";
            query += Environment.NewLine + "    CPF,           ";
            query += Environment.NewLine + "    ENDERECO       ";
            query += Environment.NewLine + ") VALUES(          ";
	        query += Environment.NewLine + "    ?,             ";
            query += Environment.NewLine + "    ?,             ";
            query += Environment.NewLine + "    ?              ";
            query += Environment.NewLine + ")                  ";

            try
            {
                using (connection = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.Add(new OleDbParameter("?", nome));
                        command.Parameters.Add(new OleDbParameter("?", cpf));
                        command.Parameters.Add(new OleDbParameter("?", endereco));

                        connection.Open();
                        object result = command.ExecuteScalar();
                        connection.Close();
                        return int.Parse(result.ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool insertAddress(string logradouro, int numero, int cep, string bairro, string cidade, string estado)
        {
            string query = String.Empty;

            query += Environment.NewLine + "INSERT INTO ENDERECO (";
            query += Environment.NewLine + "    LOGRADOURO,       ";
            query += Environment.NewLine + "    NUMERO,           ";
            query += Environment.NewLine + "    CEP,              ";
            query += Environment.NewLine + "    BAIRRO,           ";
            query += Environment.NewLine + "    CIDADE,           ";
            query += Environment.NewLine + "    ESTADO            ";
            query += Environment.NewLine + ") VALUES(             ";
	        query += Environment.NewLine + "    ?,                ";
            query += Environment.NewLine + "    ?,                ";
            query += Environment.NewLine + "    ?,                ";
            query += Environment.NewLine + "    ?,                ";
            query += Environment.NewLine + "    ?,                ";
            query += Environment.NewLine + "    ?                 ";
            query += Environment.NewLine + ")                     ";

            try
            {
                using (connection = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.Add(new OleDbParameter("LOGRADOURO", logradouro));
                        command.Parameters.Add(new OleDbParameter("NUMERO", numero));
                        command.Parameters.Add(new OleDbParameter("CEP", cep));
                        command.Parameters.Add(new OleDbParameter("BAIRRO", bairro));
                        command.Parameters.Add(new OleDbParameter("CIDADE", cidade));
                        command.Parameters.Add(new OleDbParameter("ESTADO", estado));

                        object obj = command.ExecuteScalar();

                        connection.Close();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static int insertPeoplePhone(int idPessoa, int idTelefone)
        {
            String query = String.Empty;
            query += Environment.NewLine + "INSERT INTO PESSOA_TELEFONE(";
            query += Environment.NewLine + "    ID_PESSOA,              ";
            query += Environment.NewLine + "    ID_TELEFONE             ";
            query += Environment.NewLine + ") VALUES(                   ";
	        query += Environment.NewLine + "    ?,                      ";
            query += Environment.NewLine + "    ?                       ";
            query += Environment.NewLine + ")                           ";

            try
            {
                using (connection = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.Add(new OleDbParameter("?", idPessoa));
                        command.Parameters.Add(new OleDbParameter("?", idTelefone));

                        connection.Open();
                        object id = command.ExecuteScalar();
                        connection.Close();
                        return int.Parse(id.ToString());
                    }
                }
            }
            catch (Exception ex) 
            { 
                throw new Exception(ex.Message);
            }
        }

        public static bool insertTelefone(int numero, int ddd, int tipo)
        {
            string query = String.Empty;

            query += Environment.NewLine + "INSERT INTO TELEFONE(";
            query += Environment.NewLine + "    NUMERO,          ";
            query += Environment.NewLine + "    DDD,             ";
            query += Environment.NewLine + "    TIPO             ";
            query += Environment.NewLine + ") VALUES (           ";
	        query += Environment.NewLine + "    ?,               ";
            query += Environment.NewLine + "    ?,               ";
            query += Environment.NewLine + "    ?                ";
            query += Environment.NewLine + ")                    ";

            try
            {
                using (connection = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.Add(new OleDbParameter("?", numero));
                        command.Parameters.Add(new OleDbParameter("?", ddd));
                        command.Parameters.Add(new OleDbParameter("?", tipo));
                        command.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
