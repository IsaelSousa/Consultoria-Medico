using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ConsultoriaMedico.Model
{
    public class TelefoneRequestModel
    {
        public int ID { get; set; }
        public int NUMERO { get; set; }
        public int DDD { get; set; }
        public int TIPO { get; set; }
    }
}
