using Microsoft.AspNetCore.Mvc;

namespace PraiasParadisiacasWeb.Controllers
{
    public class PraiaController : Controller
    {


        public async Task<IActionResult> IndexPraias() 
        {

            return View();
        }
    }
}
