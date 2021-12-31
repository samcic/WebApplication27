using Microsoft.AspNetCore.Mvc;
namespace WebApplication27.Controllers;

public class HomeController : Controller
{
    public ContentResult Content()
    {
        return Content("hello world");
    }
}