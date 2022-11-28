using Infrastructure.ConsultoriaMedico.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ConsultoriaMedico.Repository
{

    public static class ConsultDataRepository
    {
        static string connectionString = Environment.GetEnvironmentVariable("connectionString");
		static OleDbConnection connection;

        public static List<ConsultDataResponse> ConsultAllData()
        {
            string query = string.Empty;

			query += Environment.NewLine +  "SELECT								";
			query += Environment.NewLine +  "   p.ID,							";
			query += Environment.NewLine +  "	p.NOME,							";
			query += Environment.NewLine +  "	p.CPF,							";
			query += Environment.NewLine +  "	p.ENDERECO AS ID_ENDERECO,		";
			query += Environment.NewLine +  "	e.LOGRADOURO,					";
			query += Environment.NewLine +  "	e.NUMERO,						";
			query += Environment.NewLine +  "	e.CEP,							";
			query += Environment.NewLine +  "	e.BAIRRO,						";
			query += Environment.NewLine +  "	e.CIDADE,						";
			query += Environment.NewLine +  "	e.ESTADO,						";
			query += Environment.NewLine +  "	t.ID AS ID_TELEFONE,			";
			query += Environment.NewLine +  "	t.DDD,							";
			query += Environment.NewLine +  "	t.NUMERO AS NUMERO_TELEFONE,	";
            query += Environment.NewLine + "	tt.ID AS ID_TIPO,           	";
            query += Environment.NewLine +  "	tt.TIPO							";
			query += Environment.NewLine +  "FROM PESSOA as p					";
			query += Environment.NewLine +  "LEFT JOIN ENDERECO as e			";
			query += Environment.NewLine +  "ON e.ID = p.ENDERECO				";
			query += Environment.NewLine +  "LEFT JOIN PESSOA_TELEFONE as pt	";
			query += Environment.NewLine +  "ON pt.ID_PESSOA = p.ID				";
			query += Environment.NewLine +  "LEFT JOIN TELEFONE as t			";
			query += Environment.NewLine +  "ON t.ID = pt.ID_TELEFONE			";
			query += Environment.NewLine +  "LEFT JOIN TELEFONE_TIPO as tt		";
			query += Environment.NewLine + "ON tt.ID = t.TIPO					";

            try
            {
                List<ConsultDataResponse> list = new List<ConsultDataResponse>();
				using (connection = new OleDbConnection(connectionString))
				{
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ConsultDataResponse consult = new ConsultDataResponse();
                                consult.ID = Int64.Parse(reader[0].ToString());
                                consult.NOME = reader[1].ToString();
                                consult.CPF = Int64.Parse(reader[2].ToString());
                                consult.ID_ENDERECO = Int64.Parse(reader[3].ToString());
                                consult.LOGRADOURO = reader[4].ToString();
                                consult.NUMERO = Int64.Parse(reader[5].ToString());
                                consult.CEP = Int64.Parse(reader[6].ToString());
                                consult.BAIRRO = reader[7].ToString();
                                consult.CIDADE = reader[8].ToString();
                                consult.ESTADO = reader[9].ToString();
                                consult.ID_TELEFONE = Int64.Parse(reader[10].ToString());
                                consult.DDD = Int64.Parse(reader[11].ToString());
                                consult.NUMERO_TELEFONE = Int64.Parse(reader[12].ToString());
                                consult.ID_TIPO = Int64.Parse(reader[13].ToString());
                                consult.TIPO = reader[14].ToString();

                                list.Add(consult);
                            }
                        }
                        connection.Close();
                        return list;
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
