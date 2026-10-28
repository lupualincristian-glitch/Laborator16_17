using Microsoft.AspNetCore.Mvc;
using SportLab.Models;

namespace SportLab.Controllers
{
    public class MembriController : Controller
    {
        [HttpGet]
        public IActionResult Inregistrare()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Inregistrare(ContMembru cont)
        {
            if (!ModelState.IsValid)
            {
                return View(cont);
            }
            return View("Confirmare", cont);
        }
    }
}
