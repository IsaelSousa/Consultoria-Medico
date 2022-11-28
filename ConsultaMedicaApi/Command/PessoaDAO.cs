using ConsultaMedicaApi.Model;
using Infrastructure.ConsultoriaMedico.Model;
using Infrastructure.ConsultoriaMedico.Repository;

namespace ConsultaMedicaApi.Command
{
    public static class PessoaDAO
    {

        public static bool InsertDataPeople(PessoaRequestModel people)
        {

            ConsultInsertRepository.insertAddress(
                people.ENDERECO.LOGRADOURO,
                people.ENDERECO.NUMERO,
                people.ENDERECO.CEP,
                people.ENDERECO.BAIRRO,
                people.ENDERECO.CIDADE,
                people.ENDERECO.ESTADO);
            ConsultInsertRepository.InsertPeoples(people.NOME, people.CPF, people.ENDERECO.ID);

            foreach (TelefoneRequestModel phone in people.TELEFONES)
            {
                ConsultInsertRepository.insertTelefone(phone.NUMERO, phone.DDD, phone.TIPO.ID);
                ConsultInsertRepository.insertPeoplePhone(people.ID, phone.ID);
            }

            return true;
        }

        public static List<ConsultDataResponse> ConsultDataPeople()
        {
            return ConsultDataRepository.ConsultAllData();
        }

        public static bool DeleteDataPeople(PessoaRequestModel people)
        {
            ConsultDeleteRepository.DeletePeoples(people.ID);
            ConsultDeleteRepository.DeleteAddress(people.ENDERECO.ID);
            foreach (Model.TelefoneRequestModel phone in people.TELEFONES)
            {
                ConsultDeleteRepository.DeletePeoplePhone(people.ID, phone.ID);
                ConsultDeleteRepository.DeletePhone(phone.ID);
            }
            return true;
        }

        public static bool UpdateDataPeople(Model.PessoaRequestModel people)
        {
            ConsultUpdateRepository.UpdatePeople(people.NOME, people.CPF, people.ID);
            ConsultUpdateRepository.UpdateAddress(people.ENDERECO.LOGRADOURO,
                people.ENDERECO.NUMERO,
                people.ENDERECO.CEP,
                people.ENDERECO.BAIRRO,
                people.ENDERECO.CIDADE,
                people.ENDERECO.ESTADO,
                people.ENDERECO.ID);
            foreach (Model.TelefoneRequestModel phone in people.TELEFONES)
            {
                ConsultUpdateRepository.UpdatePhone(phone.NUMERO, phone.DDD, phone.TIPO.ID, phone.ID);
            }
            return true;
        }
    }
}
