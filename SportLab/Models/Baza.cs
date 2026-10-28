namespace SportLab.Models
{
    public static class Baza
    {
        private static int urmatorulId = 6;

        public static List<Abonament> Abonamente = new List<Abonament>
        {
            new Abonament
            {
                Id = 1, NumeComplet = "Andrei Munteanu", Email = "andrei.m@mail.md", TipAbonament = "Anual",
                Program = "Seara", Activitati = new List<string> { "Fitness", "Box" },
                AntrenorPersonal = true, AcordRegulament = true, Observatii = "Pregătire pentru competiții.",
                DataInscrierii = new DateTime(2026, 9, 1)
            },
            new Abonament
            {
                Id = 2, NumeComplet = "Cristina Bivol", Email = "cristina.b@mail.md", TipAbonament = "Lunar",
                Program = "Dimineața", Activitati = new List<string> { "Yoga", "Pilates" },
                AntrenorPersonal = false, AcordRegulament = true, Observatii = "",
                DataInscrierii = new DateTime(2026, 9, 15)
            },
            new Abonament
            {
                Id = 3, NumeComplet = "Sergiu Rotaru", Email = "sergiu.r@mail.md", TipAbonament = "Trimestrial",
                Program = "Ziua", Activitati = new List<string> { "Înot" },
                AntrenorPersonal = false, AcordRegulament = true, Observatii = "Doar bazinul.",
                DataInscrierii = new DateTime(2026, 10, 1)
            },
            new Abonament
            {
                Id = 4, NumeComplet = "Natalia Ursu", Email = "natalia.u@mail.md", TipAbonament = "Trimestrial",
                Program = "Seara", Activitati = new List<string> { "Fitness", "Yoga" },
                AntrenorPersonal = true, AcordRegulament = true, Observatii = "",
                DataInscrierii = new DateTime(2026, 10, 6)
            },
            new Abonament
            {
                Id = 5, NumeComplet = "Mihai Sârbu", Email = "mihai.s@mail.md", TipAbonament = "Lunar",
                Program = "Seara", Activitati = new List<string> { "Box" },
                AntrenorPersonal = false, AcordRegulament = true, Observatii = "Începător.",
                DataInscrierii = new DateTime(2026, 10, 12)
            }
        };

        public static Abonament CautaDupaId(int id)
        {
            foreach (Abonament abonament in Abonamente)
            {
                if (abonament.Id == id)
                {
                    return abonament;
                }
            }
            return null;
        }

        public static void Adauga(Abonament abonament)
        {
            abonament.Id = urmatorulId;
            urmatorulId = urmatorulId + 1;
            abonament.DataInscrierii = DateTime.Today;
            Abonamente.Add(abonament);
        }

        // Activitățile ca text: „Fitness, Box” sau „—”.
        public static string ActivitatiCaText(List<string> activitati)
        {
            if (activitati == null || activitati.Count == 0)
            {
                return "—";
            }
            return string.Join(", ", activitati);
        }
    }
}
