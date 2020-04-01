using System;
using System.Diagnostics;

namespace Projekt_1
{
    class Program
    {
        static int licznik = 0;
        public static int WyszukiwanieBinarne(int[] tab, int szukanie)
        {
            int left = 0;
            int right = tab.Length - 1;

            while(left <= right)
            {
                int CurrentPosition = left + (right - left) / 2;

                if (tab[CurrentPosition] == szukanie)
                    return CurrentPosition;
                if (tab[CurrentPosition] < szukanie)
                    left = CurrentPosition + 1;
                if (tab[CurrentPosition] > szukanie)
                    right = CurrentPosition - 1;
            }
            return -1;
        }

        

        public static int WyszukiwanieBinarneZInstrumentacja(int[] tab, int szukanie)
        {
            int left = 0;
            int right = tab.Length - 1;

            while (left <= right)
            {
                int CurrentPosition = left + (right - left) / 2;

                licznik++;
                if (tab[CurrentPosition] == szukanie)
                    return CurrentPosition;  

                else
                {
                    licznik++;
                    if (tab[CurrentPosition] < szukanie)
                        left = CurrentPosition + 1;
                    else
                        right = CurrentPosition - 1;
                }             
            }
            return -1;
        }


        public static int WyszukiwanieLiniowe(int[] tab, int element)
        {
            for(int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == element)
                    return i;
            }
            return -1;
        }

        public static int WyszukiwanieLinioweInstrumentacja(int[] tab, int element)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                licznik++;
                if (tab[i] == element)
                    return i;
            }
            return -1;
        }


        static void Main(string[] args)
        {
            // int[] tablica = Pomocna.Randomowe(11,50);
            // Array.Sort(tablica);
            int rTablicy = Convert.ToInt32(Math.Pow(2, 28)); // rozmiar tablicy
            int[] tablica = Pomocna.Posortowane(rTablicy); // tablica posortowana

            Stopwatch stoperek = new Stopwatch();
            double wynik = 0;

            /* for(int i = 0; i < rTablicy; i+=800000)
            {
                stoperek.Reset();
                stoperek.Start();
                WyszukiwanieBinarne(tablica, -1);
                stoperek.Stop();
                wynik = stoperek.ElapsedTicks;
                Console.WriteLine($"{i};{wynik}");

            } */

            /*for(int i = 0; i < rTablicy; i+=8000000) // binarne instrumentacja pesymistyczne
            {
                tablica = Pomocna.Posortowane(i);
                licznik = 0;
                WyszukiwanieBinarneZInstrumentacja(tablica, -1);
                Console.WriteLine($"{licznik};{i}");
            }*/

            /*for(int i = 0; i < rTablicy; i+=8000000 ) // wyszukiwanie liniowe pesymistyczne
            {
                tablica = Pomocna.Posortowane(i);
                stoperek.Reset();
                stoperek.Start();
                WyszukiwanieLiniowe(tablica, -1);
                stoperek.Stop();
                wynik = stoperek.ElapsedMilliseconds;
                Console.WriteLine($"{wynik};{i}");
            }*/

            /* for(int i = 0; i <rTablicy; i+=8000000) // wyszukiwanie liniowe pesymistyczne instrumentacja
             {
                 tablica = Pomocna.Posortowane(i);
                 licznik = 0;
                 WyszukiwanieLinioweInstrumentacja(tablica, -1);
                 Console.WriteLine($"{licznik};{i}");
             }*/


            /* int counter = 0;
            for(int i = 0; i < rTablicy; i+=8000000) // binarne srednie pesymistyczne
            {
                tablica = Pomocna.Posortowane(i);
                stoperek.Reset();
                stoperek.Start();
                counter++;
                WyszukiwanieBinarne(tablica, -1);
                wynik += stoperek.ElapsedTicks;
                stoperek.Stop();
                Console.WriteLine($"{wynik};{i};{counter}");
            }
            double srednia = wynik / counter;
            Console.WriteLine($"{srednia:F02}"); */


            /* for(int i = 0; i <rTablicy; i+=8000000) // binarne srednie pesymistyczne instrumentacja
            {
                tablica = Pomocna.Posortowane(i);
                licznik = 0;
                WyszukiwanieBinarneZInstrumentacja(tablica, -1);
                wynik += licznik;
                Console.WriteLine($"{wynik};{i}");
            }
            double srednia = wynik / licznik;
            Console.WriteLine($"srednia arytmetyczna;{srednia:F02}"); */

            /* int counter = 0;
            double suma = 0;
            for(int i = 0; i < rTablicy; i+=8000000) // liniowe srednie (pierwszy element + ostatni element)/2
            {
                tablica = Pomocna.Posortowane(i);
                int srodek_kurwa_michal_przestan_KURWA_mlaskac = rTablicy / 2;
                stoperek.Reset();
                stoperek.Start();
                WyszukiwanieLiniowe(tablica, srodek_kurwa_michal_przestan_KURWA_mlaskac);
                wynik = stoperek.ElapsedTicks;
                stoperek.Stop();
                suma += wynik;
                counter++;
                Console.WriteLine($"wynik;{wynik};{counter}");

            }
            Console.WriteLine($"srednia;{(suma/counter):F02}"); */



        }
    }
}
