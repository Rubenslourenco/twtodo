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
            
        public IActionResult Index()
        {

            var todo = _context.Todos.First();
            return View(todo);
        }

       
    }
}