using ConsultoriaMedico.Command;
using ConsultoriaMedico.Model;
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

        [HttpPost()]
        public bool InsertConsult(PessoaRequestModel people)
        {
            bool result = PessoaDAO.InsertDataPeople(people);
            return result;
        }
    }
}