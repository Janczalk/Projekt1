using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_1
{
    class Pomocna
    {

            public static int[] Posortowane(int rozmiar)
            {
                int[] tab = new int[rozmiar];

                for(int i = 0; i < tab.Length; i++)
                {
                    tab[i] = i;
                }
                return tab;
            }

            public static int[] Randomowe(int rozmiar, int maxWartosc)
            {
                Random rng = new Random();
                int[] tab = new int[rozmiar];

                for (int i = 0; i < tab.Length; i++)
                    tab[i] = rng.Next(maxWartosc);

                return tab;
            }

    }
}
