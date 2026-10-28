using System.ComponentModel.DataAnnotations;

namespace AdmitereLab.Models
{
    public class Cerere
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

        [Display(Name = "Telefonul")]
        [Required(ErrorMessage = "Scrie numărul de telefon.")]
        [StringLength(15, ErrorMessage = "Telefonul are cel mult 15 caractere.")]
        public string Telefon { get; set; }

        [Display(Name = "Anul absolvirii gimnaziului")]
        [Range(2015, 2027, ErrorMessage = "Anul este între 2015 și 2027.")]
        public int AnulAbsolvirii { get; set; }

        [Display(Name = "Specialitatea")]
        [Required(ErrorMessage = "Alege specialitatea.")]
        public string Specialitate { get; set; }

        [Display(Name = "Forma de învățământ")]
        [Required(ErrorMessage = "Alege forma de învățământ.")]
        public string FormaInvatamant { get; set; }

        [Display(Name = "Solicit loc în cămin")]
        public bool SolicitaCamin { get; set; }

        [Display(Name = "Motivația")]
        [StringLength(500, ErrorMessage = "Motivația are cel mult 500 de caractere.")]
        public string Motivatie { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Data depunerii")]
        [DataType(DataType.Date)]
        public DateTime DataDepunerii { get; set; }
    }
}
