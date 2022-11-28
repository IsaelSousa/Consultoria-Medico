
using Infrastructure.ConsultoriaMedico.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
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
        public static bool InsertPeoples(string nome, int cpf, int endereco)
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
                    using (OleDbCommand command = new OleDbCommand(query))
                    {
                        command.Parameters.Add(nome);
                        command.Parameters.Add(cpf);
                        command.Parameters.Add(endereco);

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
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool insertAddress(string logradouro, int numero, int cep, string bairro, string cidade, string estado)
        {
            string query = String.Empty;

            query += Environment.NewLine + "INSERT INTO ENDERECO(";
            query += Environment.NewLine + "    LOGRADOURO,      ";
            query += Environment.NewLine + "    NUMERO,          ";
            query += Environment.NewLine + "    CEP,             ";
            query += Environment.NewLine + "    BAIRRO,          ";
            query += Environment.NewLine + "    CIDADE,          ";
            query += Environment.NewLine + "    ESTADO           ";
            query += Environment.NewLine + ") VALUES(            ";
	        query += Environment.NewLine + "    ?,               ";
            query += Environment.NewLine + "    ?,               ";
            query += Environment.NewLine + "    ?,               ";
            query += Environment.NewLine + "    ?,               ";
            query += Environment.NewLine + "    ?,               ";
            query += Environment.NewLine + "    ?                ";
            query += Environment.NewLine + ")                    ";

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

        public static bool insertPeoplePhone(int idPessoa, int idTelefone)
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
                    using (OleDbCommand command = new OleDbCommand(query))
                    {
                        command.Parameters.Add(idPessoa);
                        command.Parameters.Add(idTelefone);

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
                    using (OleDbCommand command = new OleDbCommand(query))
                    {
                        command.Parameters.Add(numero);
                        command.Parameters.Add(ddd);
                        command.Parameters.Add(tipo);

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
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
