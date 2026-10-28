namespace SportLab.Models
{
    // Valorile permise pentru câmpurile cu alegere.
    public static class Optiuni
    {
        public static List<string> TipuriAbonament = new List<string>
        {
            "Lunar", "Trimestrial", "Anual"
        };

        public static List<string> Programe = new List<string>
        {
            "Dimineața", "Ziua", "Seara"
        };

        public static List<string> Activitati = new List<string>
        {
            "Fitness", "Yoga", "Înot", "Box", "Pilates"
        };
    }
}
