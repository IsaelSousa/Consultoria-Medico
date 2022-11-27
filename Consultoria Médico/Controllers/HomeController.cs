using ConsultoriaMedico.Command;
using ConsultoriaMedico.Model;
using ConsultoriaMedico.Models;
using Insfraestrutura.ConsultoriaMedico.Model;
using Insfraestrutura.ConsultoriaMedico.Repository;
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
        public void DeleteDataPeople()
        {

        }

        [HttpPut()]
        public void UpdateDataPeople()
        {

        }
    }
}