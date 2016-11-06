using Microsoft.AspNetCore.Mvc;
using System.Linq;

[Route("/")]
public class HomeController : Controller
{
    private IRepository<Merch> merchs;
    private IRepository<MerchList> merchlists;
    public HomeController(IRepository<Merch> merchs, IRepository<MerchList> merchlists){
        this.merchs = merchs;
        this.merchlists = merchlists;
    }

    [HttpGet("/{username?}")]
    [HttpGet("Home/Index/{username?}")]
    public IActionResult Root(string username = "you")
    {
        ViewData["Message"] = "Some extra info can be sent to the view";
        ViewData["Username"] = username;
        return View("Index"); // View(new Student) method takes an optional object as a "model", typically called a ViewModel
    }
}