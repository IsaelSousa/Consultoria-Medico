using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ConsultoriaMedico.Model
{
    public class ConsultDataResponse
    {
        public int ID { get; set; }
        public string NOME { get; set; }
        public int CPF { get; set; }
        public int ID_ENDERECO { get; set; }
        public string LOGRADOURO { get; set; }
        public int NUMERO { get; set; }
        public int CEP { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string ESTADO { get; set; }
        public int ID_TELEFONE { get; set; }
        public int DDD { get; set; }
        public int NUMERO_TELEFONE { get; set; }
        public int ID_TIPO { get; set; }
        public string TIPO { get; set; }
    }
}
