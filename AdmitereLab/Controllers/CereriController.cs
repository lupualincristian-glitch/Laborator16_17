using Microsoft.AspNetCore.Mvc;
using AdmitereLab.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AdmitereLab.Controllers
{
    public class CereriController : Controller
    {
        public IActionResult Index()
        {
            return View(Baza.Cereri);
        }

        public IActionResult Detalii(int id)
        {
            Cerere cerere = Baza.CautaDupaId(id);
            if (cerere == null)
            {
                return NotFound();
            }
            return View(cerere);
        }

        [HttpGet]
        public IActionResult Adauga()
        {
            PregatesteListele();
            Cerere cerere = new Cerere();
            cerere.AnulAbsolvirii = 2026;
            return View(cerere);
        }

        [HttpPost]
        public IActionResult Adauga(Cerere cerere)
        {
            if (!ModelState.IsValid)
            {
                PregatesteListele();
                return View(cerere);
            }
            Baza.Adauga(cerere);
            return RedirectToAction("Index");
        }

        // Listele de opțiuni pentru formular (Sarcinile 2 și 3).
        private void PregatesteListele()
        {
            ViewBag.Specialitati = new SelectList(Optiuni.Specialitati);
        }
    }
}
