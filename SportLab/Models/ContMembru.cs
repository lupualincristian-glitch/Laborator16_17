using System.ComponentModel.DataAnnotations;

namespace SportLab.Models
{

    // Datele formularului „Cont de membru”. Nu se salvează.
    public class ContMembru
    {
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Scrie e-mailul.")]
        [EmailAddress(ErrorMessage = "Adresa de e-mail nu este validă.")]
        public string Email { get; set; }

        [Display(Name = "Parola")]
        [Required(ErrorMessage = "Scrie parola.")]
        [MinLength(8, ErrorMessage = "Parola trebuie să aibă cel puțin 8 caractere.")]
        public string Parola { get; set; }

        [Display(Name = "Confirmă parola")]
        [Required(ErrorMessage = "Confirmă parola.")]
        [Compare("Parola", ErrorMessage = "Parolele nu coincid.")]
        public string ConfirmareParola { get; set; }
    }
}




