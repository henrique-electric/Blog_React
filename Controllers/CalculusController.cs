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

    public IActionResult DoubleIntegral()
    {
        string file = Path.Combine(_env.WebRootPath, "Calculus", "double_integral.html");
        return PhysicalFile(file, "text/html");
    }

    public IActionResult Jacobian()
    {
        string file = Path.Combine(_env.WebRootPath, "Calculus", "jacobian.html");
        return PhysicalFile(file, "text/html");
    }

    
}
