using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie
{
    internal class Program
    {
        static void Solution() {
            //definiowanie kolekcji liczb
            var kol1 = new List<int>();
            var kol2 = new List<int>();

            //wczytywanie liczb do pierwszej kolekcji
            Console.WriteLine("Hej, podaj liczby do pierwszej kolekcji. Wciśnij s, aby przejść do drugiej kolekcji ");
            while (true) {
                Console.ReadLine();
                if (Console.ReadLine() == "s") break;
                else kol1.Add(int.Parse(Console.ReadLine()));
            }

            // wczytywanie liczb do drugiej kolekcji
            Console.WriteLine("Teraz podaj liczby do drugiej kolekcji. Wciśnij s, aby przejść do wyniku");
            while (true)
            {
                Console.ReadLine();
                if (Console.ReadLine() == "s") break;
                else kol2.Add(int.Parse(Console.ReadLine()));
            }


            // licznik - zmienna służąca do sprawdzenia, czy każda liczba w liście 1 ma swoją potęgę w liście drugiej
            int licznik, koniec = 0;
            for (int i = kol1.Count - 1; i >= 0; i--)
            {
                licznik = 0;
                for (int j = kol2.Count - 1; j >= 0; j--)
                {
                    if ((int)Math.Pow(kol1[i], 2) == kol2[j])
                    {
                        licznik++;
                        koniec++;
                    }
                }
                if (licznik == 0)
                {
                    Console.WriteLine("Fałsz");
                    
                }
                if (koniec == kol1.Count) Console.WriteLine("Prawda");
                
            }

        }
        static void Main()
        {
           // Często się zdarzało, że musiałem nie raz, tylko dwa razy wprowadzać "s", aby przejść dalej. Nie miało to jednak wpłwu na wynik.
              
           
            Solution();
            
        }
    }
}
