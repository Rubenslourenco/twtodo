
using Microsoft.AspNetCore.Mvc;

namespace TwTodo.Controllers;

public class TesteController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

      public IActionResult Teste02()
    {
        return View();
    }
}