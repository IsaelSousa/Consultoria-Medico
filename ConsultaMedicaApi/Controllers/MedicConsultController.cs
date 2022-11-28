using ConsultaMedicaApi.Command;
using ConsultaMedicaApi.Model;
using Infrastructure.ConsultoriaMedico.Model;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaMedicaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicConsultController : ControllerBase
    {
        [HttpGet()]
        [Route("GetConsultData")]
        public List<ConsultDataResponse> GetConsultData()
        {
            return PessoaDAO.ConsultDataPeople();
        }

        [HttpPost()]
        [Route("InsertConsult")]
        public bool InsertConsult([FromBody] PessoaRequestModel people)
        {
            bool result = PessoaDAO.InsertDataPeople(people);
            return result;
        }

        [HttpDelete()]
        [Route("DeleteConsult")]
        public bool DeleteDataPeople([FromBody] PessoaRequestModel people)
        {
            bool result = PessoaDAO.DeleteDataPeople(people);
            return result;
        }

        [HttpPut()]
        [Route("UpdateConsult")]
        public bool UpdateDataPeople([FromBody] PessoaRequestModel people)
        {
            bool result = PessoaDAO.UpdateDataPeople(people);
            return result;
        }
    }
}