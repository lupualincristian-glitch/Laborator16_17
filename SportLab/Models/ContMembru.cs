using System.ComponentModel.DataAnnotations;

namespace SportLab.Models
{
    // Datele formularului „Cont de membru”. Nu se salvează.
    public class ContMembru
    {
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Scrie adresa de e-mail.")]
        [EmailAddress(ErrorMessage = "Adresa de e-mail nu este corectă.")]
        public string Email { get; set; }

        [Display(Name = "Parola")]
        [Required(ErrorMessage = "Scrie o parolă.")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Parola are între 8 și 30 de caractere.")]
        [DataType(DataType.Password)]
        public string Parola { get; set; }

        [Display(Name = "Confirmă parola")]
        [Required(ErrorMessage = "Scrie parola încă o dată.")]
        [DataType(DataType.Password)]
        public string ConfirmareParola { get; set; }
    }
}
