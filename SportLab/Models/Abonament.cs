using System.ComponentModel.DataAnnotations;

namespace SportLab.Models
{
    public class Abonament
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Numele și prenumele")]
        [Required(ErrorMessage = "Scrie numele și prenumele.")]
        [StringLength(60, ErrorMessage = "Numele are cel mult 60 de caractere.")]
        public string NumeComplet { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Scrie adresa de e-mail.")]
        [EmailAddress(ErrorMessage = "Adresa de e-mail nu este corectă.")]
        public string Email { get; set; }

        [Display(Name = "Tipul abonamentului")]
        [Required(ErrorMessage = "Alege tipul abonamentului.")]
        public string TipAbonament { get; set; }

        [Display(Name = "Programul")]
        [Required(ErrorMessage = "Alege programul.")]
        public string Program { get; set; }

        [Display(Name = "Activitățile care te interesează")]
        public List<string> Activitati { get; set; }

        [Display(Name = "Vreau antrenor personal")]
        public bool AntrenorPersonal { get; set; }

        [Display(Name = "Am citit și accept regulamentul sălii")]
        public bool AcordRegulament { get; set; }

        [Display(Name = "Observații")]
        [StringLength(300, ErrorMessage = "Observațiile au cel mult 300 de caractere.")]
        public string Observatii { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Data înscrierii")]
        [DataType(DataType.Date)]
        public DateTime DataInscrierii { get; set; }
    }
}
