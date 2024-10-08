using Microsoft.AspNetCore.Mvc;
using PizzaMVCApp.Models;

namespace PizzaMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel model = new DogViewModel() { Name = "BUBBLES", Age= 5 };
            return View(model);
        }

        public string Hello()
        {
            return "Hi There! Welcome page!";
        }
    }
}
