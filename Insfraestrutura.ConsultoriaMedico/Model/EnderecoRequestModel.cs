using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insfraestrutura.ConsultoriaMedico.Model
{
    public class EnderecoRequestModel
    {
        public int ID { get; set; }
        public string LOGRADOURO { get; set; }
        public int NUMERO { get; set; }
        public int CEP { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string ESTADO { get; set; }
    }
}
