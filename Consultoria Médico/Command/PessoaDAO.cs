using ConsultoriaMedico.Model;
using Insfraestrutura.ConsultoriaMedico.Model;
using Insfraestrutura.ConsultoriaMedico.Repository;

namespace ConsultoriaMedico.Command
{
    public static class PessoaDAO
    {

        public static bool InsertDataPeople(Model.PessoaRequestModel people)
        {
            ConsultInsertRepository.InsertPeoples(people.NOME, people.CPF, people.ENDERECO.ID);
            ConsultInsertRepository.insertAddress(
                people.ENDERECO.LOGRADOURO,
                people.ENDERECO.NUMERO,
                people.ENDERECO.CEP,
                people.ENDERECO.BAIRRO,
                people.ENDERECO.CIDADE,
                people.ENDERECO.ESTADO);
            
            foreach (Model.TelefoneRequestModel phone in people.TELEFONES)
            {
                ConsultInsertRepository.insertPeoplePhone(people.ID, phone.ID);
                ConsultInsertRepository.insertTelefone(phone.NUMERO, phone.DDD, phone.TIPO.ID);
            }

            return true;
        }

        public static List<ConsultDataResponse> ConsultDataPeople()
        {
            return ConsultDataRepository.ConsultAllData();
        }

    }
}
