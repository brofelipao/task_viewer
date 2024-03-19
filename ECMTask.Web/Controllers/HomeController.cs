using ECMTask.Application.Interfaces;
using ECMTask.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ECMTask.Web.Controllers
{
    public class HomeController : Controller
    {
        ITaskRepository taskRepository;
        public HomeController(ITaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public IActionResult Index()
        {
            var tarefas = taskRepository.ObterTarefas(252529);
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
    }
}
