using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportLab.Models;

namespace SportLab.Controllers
{
    public class AbonamenteController : Controller
    {
        public IActionResult Index()
        {
            return View(Baza.Abonamente);
        }

        public IActionResult Detalii(int id)
        {
            Abonament abonament = Baza.CautaDupaId(id);
            if (abonament == null)
            {
                return NotFound();
            }
            return View(abonament);
        }

        [HttpGet]
        public IActionResult Adauga()
        {
            PregatesteListele();
            return View();
        }

        [HttpPost]
        public IActionResult Adauga(Abonament abonament)
        {
            if (!ModelState.IsValid)
            {
                return View(abonament);
            }
            Baza.Adauga(abonament);
            return RedirectToAction("Index");
        }

        // Listele de opțiuni pentru formular.
        private void PregatesteListele()
        {
            ViewBag.TipuriAbonament = new SelectList(Optiuni.TipuriAbonament);
            ViewBag.Programe = Optiuni.Programe;
        }
    }
}
