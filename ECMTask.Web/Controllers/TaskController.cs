using ECMTask.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
    

namespace ECMTask.Web.Controllers
{
    public class TaskController : Controller
    {
        ITaskRepository taskRepository;        
        public TaskController(ITaskRepository taskRepository) 
        { 
            this.taskRepository = taskRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexGrid()
        {
            try
            {
                var tarefas = taskRepository.ObterTarefas(207886);
                return Json(new { tarefas = tarefas });
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
