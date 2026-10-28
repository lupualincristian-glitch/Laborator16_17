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
        [HttpPost]
        public IActionResult Adauga(Abonament abonament)
        {
            if (!abonament.AcordRegulament)
            {
                ModelState.AddModelError("AcordRegulament", "Bifează acordul cu regulamentul sălii.");
            }

            if (abonament.AntrenorPersonal && abonament.TipAbonament != "Trimestrial" && abonament.TipAbonament != "Anual")
            {
                ModelState.AddModelError("", "Antrenorul personal se oferă doar la abonamentul trimestrial sau anual.");
            }
            if (abonament.Activitati == null || abonament.Activitati.Count == 0)
            {
                ModelState.AddModelError("Activitati", "Alege cel puțin o activitate.");
            }
            if (!ModelState.IsValid)
            {
                
                PregatesteListele();
                
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
            ViewBag.Activitati = new SelectList(Optiuni.Activitati);
        }
    }
}
