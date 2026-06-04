using System.ComponentModel.Design;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;

namespace ASP_MVC.Controllers;

[Route("Calculus/{action=Derivatives}")]
public class CalculusController : Controller
{
    private readonly IWebHostEnvironment _env;
    
    public CalculusController(IWebHostEnvironment env)
    {
        _env = env;
    }

    public IActionResult Derivatives()
    {
        string file = Path.Combine(_env.WebRootPath, "Calculus", "derivatives.html");
        return PhysicalFile(file, "text/html");
    }
}
