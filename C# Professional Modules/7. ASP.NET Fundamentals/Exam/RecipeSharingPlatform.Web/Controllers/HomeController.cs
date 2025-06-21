using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RecipeSharingPlatform.ViewModels;
using RecipeSharingPlatform.Web.Controllers;
using System.Diagnostics;

public class HomeController : BaseController
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult Index()
    {
        try
        {
            if(IsUserAuthenticated())
            {
                return RedirectToAction(nameof(Index), "Recipe");
            }
            return View();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return RedirectToAction(nameof(Index));
        }
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