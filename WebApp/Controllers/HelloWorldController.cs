using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebApp.Controllers;

public class HelloWorldController : Controller
{

    //GET :/HelloWorld/
    public IActionResult Index()
    {
        return View();
    }

    //GET: /HelloWorld/Welcome/
    public string Welcome()
    {
        return "This is the welcome action method";
    }

}
