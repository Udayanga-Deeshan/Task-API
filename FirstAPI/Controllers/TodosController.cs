using FirstAPI.Models;
using FirstAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private TodoService _todoService;

        public TodosController()
        {
            _todoService = new TodoService();
        }
        [HttpGet("{Id?}")]
        public IActionResult GetTodos(int? Id) 
        {
            var mytodos = _todoService.AllTodos();

            if (Id is null) return Ok(mytodos);

            mytodos = mytodos.Where(t => t.Id == Id).ToList();
            return Ok(mytodos);
        }

       
        //[HttpGet]
        //public IActionResult Tasks()
        //{
        //    var tasks = new string[] { "Task1", "Task2", "Task3" };
        //    return Ok(tasks) ;
        //}

        //[HttpPost]
        //public IActionResult NewTask()
        //{
        //    return Ok();
        //}

        //[HttpPut]
        //public IActionResult UpdateTask()
        //{
        //    return Ok();
        //}

        //[HttpDelete]
        //public IActionResult DeleteTask()
        //{
        //    return Ok();
        //}
    }
}
