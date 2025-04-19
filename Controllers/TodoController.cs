using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using TwTodo.contexts;
using TwTodo.Models;

namespace TwTodo.Controllers
{
    [Route("[controller]")]
    public class TodoController : Controller
    {

            private readonly TWTodoContext _context;

            public TodoController(TWTodoContext context) {
                _context = context;
            }
         [HttpGet]   
        public IActionResult Index()
        {
            ViewData["Title"] = "Lista de tarefas";
            var todos = _context.Todos.ToList();
            return View(todos);
        }

       [HttpGet("Create")]
        public IActionResult Create()
        {
            ViewData["Title"] = "Nova Tarefa";
            return View("Form");
        }

        [HttpPost("Create")]
        public IActionResult Create(Todo todo)
        {
           
                _context.Todos.Add(todo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            
            
}
    }
}