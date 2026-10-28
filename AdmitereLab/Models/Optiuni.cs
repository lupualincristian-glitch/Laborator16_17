namespace AdmitereLab.Models
{
    // Valorile permise pentru câmpurile cu alegere.
    public static class Optiuni
    {
        public static List<string> Specialitati = new List<string>
        {
            "Administrarea site-urilor web",
            "Programare și analiza produselor de program",
            "Rețele de calculatoare",
            "Contabilitate",
            "Turism"
        };

        public static List<string> FormeInvatamant = new List<string>
        {
            "Zi", "Frecvență redusă"
        };
    }
}
