using CadastroContactos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CadastroContactos.Controllers
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
            ContatoModel model = new ContatoModel();

            model.Nome = "David Sanculane";
            model.Endereco = "Cidade de Tete";
            model.Email = "sanculane.dev@gmail.com";

            return View(model);
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
    }
}