using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ConsultoriaMedico.Model
{
    public class ConsultDataResponse
    {
        public Int64 ID { get; set; }
        public string NOME { get; set; }
        public Int64 CPF { get; set; }
        public Int64 ID_ENDERECO { get; set; }
        public string LOGRADOURO { get; set; }
        public Int64 NUMERO { get; set; }
        public Int64 CEP { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string ESTADO { get; set; }
        public Int64 ID_TELEFONE { get; set; }
        public Int64 DDD { get; set; }
        public Int64 NUMERO_TELEFONE { get; set; }
        public Int64 ID_TIPO { get; set; }
        public string TIPO { get; set; }
    }
}
