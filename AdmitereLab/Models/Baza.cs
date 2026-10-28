namespace AdmitereLab.Models
{
    public static class Baza
    {
        private static int urmatorulId = 7;

        public static List<Cerere> Cereri = new List<Cerere>
        {
            new Cerere
            {
                Id = 1, NumeComplet = "Ana Rusu", Email = "ana.rusu@mail.md", Telefon = "069123456",
                AnulAbsolvirii = 2026, Specialitate = "Administrarea site-urilor web", FormaInvatamant = "Zi",
                SolicitaCamin = true, Motivatie = "Îmi place să fac pagini web.", DataDepunerii = new DateTime(2026, 10, 1)
            },
            new Cerere
            {
                Id = 2, NumeComplet = "Ion Ciobanu", Email = "ion.ciobanu@mail.md", Telefon = "068234567",
                AnulAbsolvirii = 2025, Specialitate = "Rețele de calculatoare", FormaInvatamant = "Zi",
                SolicitaCamin = false, Motivatie = "Vreau să lucrez ca administrator de rețea.", DataDepunerii = new DateTime(2026, 10, 2)
            },
            new Cerere
            {
                Id = 3, NumeComplet = "Maria Lungu", Email = "maria.lungu@mail.md", Telefon = "079345678",
                AnulAbsolvirii = 2026, Specialitate = "Contabilitate", FormaInvatamant = "Zi",
                SolicitaCamin = true, Motivatie = "", DataDepunerii = new DateTime(2026, 10, 3)
            },
            new Cerere
            {
                Id = 4, NumeComplet = "Victor Popa", Email = "victor.popa@mail.md", Telefon = "060456789",
                AnulAbsolvirii = 2019, Specialitate = "Programare și analiza produselor de program", FormaInvatamant = "Frecvență redusă",
                SolicitaCamin = false, Motivatie = "Lucrez și vreau o calificare.", DataDepunerii = new DateTime(2026, 10, 5)
            },
            new Cerere
            {
                Id = 5, NumeComplet = "Elena Moraru", Email = "elena.moraru@mail.md", Telefon = "078567890",
                AnulAbsolvirii = 2026, Specialitate = "Turism", FormaInvatamant = "Zi",
                SolicitaCamin = false, Motivatie = "Vreau să fiu ghid turistic.", DataDepunerii = new DateTime(2026, 10, 7)
            },
            new Cerere
            {
                Id = 6, NumeComplet = "Dan Cojocaru", Email = "dan.cojocaru@mail.md", Telefon = "069678901",
                AnulAbsolvirii = 2026, Specialitate = "Administrarea site-urilor web", FormaInvatamant = "Zi",
                SolicitaCamin = true, Motivatie = "Am făcut deja un blog.", DataDepunerii = new DateTime(2026, 10, 9)
            }
        };

        public static Cerere CautaDupaId(int id)
        {
            foreach (Cerere cerere in Cereri)
            {
                if (cerere.Id == id)
                {
                    return cerere;
                }
            }
            return null;
        }

        public static void Adauga(Cerere cerere)
        {
            cerere.Id = urmatorulId;
            urmatorulId = urmatorulId + 1;
            cerere.DataDepunerii = DateTime.Today;
            Cereri.Add(cerere);
        }

        public static void Actualizeaza(Cerere cerere)
        {
            Cerere veche = CautaDupaId(cerere.Id);
            if (veche == null)
            {
                return;
            }
            cerere.DataDepunerii = veche.DataDepunerii;
            int pozitia = Cereri.IndexOf(veche);
            Cereri[pozitia] = cerere;
        }
    }
}
