using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ConsultoriaMedico.Model
{
    public class PessoaRequestModel
    {
        public int ID { get; set; }
        public string NOME { get; set; }
        public int CPF { get; set; }
        public int ENDERECO { get; set; }
    }
}
