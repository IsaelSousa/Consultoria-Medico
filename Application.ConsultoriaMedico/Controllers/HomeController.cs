using ConsultoriaMedico.Command;
using Application.ConsultoriaMedico.Models;
using Infrastructure.ConsultoriaMedico.Model;
using Infrastructure.ConsultoriaMedico.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConsultoriaMedico.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet()]
        [Route("GetConsultData")]
        public List<ConsultDataResponse> GetConsultData()
        {
            return PessoaDAO.ConsultDataPeople();
        }

        [HttpPost()]
        public bool InsertConsult(Model.PessoaRequestModel people)
        {
            bool result = PessoaDAO.InsertDataPeople(people);
            return result;
        }

        [HttpDelete()]
        public bool DeleteDataPeople(Model.PessoaRequestModel people)
        {
            bool result = PessoaDAO.DeleteDataPeople(people);
            return result;
        }

        [HttpPut()]
        public bool UpdateDataPeople(Model.PessoaRequestModel people)
        {
            bool result = PessoaDAO.UpdateDataPeople(people);
            return result;
        }
    }
}