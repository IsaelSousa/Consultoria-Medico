using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaMedicaApi.Model
{
    public class PessoaRequestModel
    {
        public int ID { get; set; }
        public string NOME { get; set; }
        public int CPF { get; set; }
        public EnderecoRequestModel ENDERECO { get; set; }
        public List<TelefoneRequestModel> TELEFONES { get; set; }
    }
}
