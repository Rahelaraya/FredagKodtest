using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace FredagKodtest
{
    class Program
    {
        static void Main()
        {
            var input = new List<string> { "listen", "silent", "enlist", "rat", "tar", "art", "evil", "vile", "live" };
            var resultat = GrupperaAnagram(input);

            // Skriv ut resultatet
            foreach (var grupp in resultat)
            {
                Console.WriteLine($"[{string.Join(", ", grupp)}]");
            }
        }
        public static List<List<string>> GrupperaAnagram(List<string> ordLista)
            {
                Dictionary<string, List<string>> anagramGrupper = new Dictionary<string, List<string>>();

                foreach (string ord in ordLista)
                {
                    // Sortera bokstäverna i ordet för att få en unik nyckel
                    string sorteratOrd = new string(ord.OrderBy(c => c).ToArray());

                // Använd TryGetValue för effektiv dictionary-uppslagning
                if (!anagramGrupper.ContainsKey(sorteratOrd))
                {
                    anagramGrupper[sorteratOrd] = new List<string>();
                }
                anagramGrupper[sorteratOrd].Add(ord);

            }

            return anagramGrupper.Values.ToList();
            }

            
        

    }
}


