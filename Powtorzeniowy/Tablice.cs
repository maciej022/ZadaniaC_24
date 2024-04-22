using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powtorzeniowy
{
    public class Tablice
    {
        public void Wyswietl(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i] + ", ");
            }
            Console.WriteLine();
        }




        public int[] Towrzenie_tablicy()
        {
            Console.WriteLine("Ile znakow ma miec tablica? ");
            int dl = int.Parse(Console.ReadLine());
            int[] ints = new int[dl];
            for (int i = 0; i < dl; i++)
            {
                Console.Write("Podaj kolejny element ");
                ints[i] = int.Parse(Console.ReadLine());
            }
            return ints;
        }
        public void SortowanieBabelkowe(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 1; j < tablica.Length - i; j++)
                {
                    int temp = tablica[j - 1];
                    tablica[j - 1] = tablica[j];
                    tablica[j] = temp;
                }
            }

        }
        public void Przeszukaj(int[] tab)
        {
            Console.WriteLine("Jakiej liczy szukasz w tablicy? ");
            int szukana = int.Parse(Console.ReadLine());

            bool liczba_istnieje = false;
            int ile_powtorzen = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == szukana)
                {
                    liczba_istnieje = true;
                    ile_powtorzen++;
                }

            }
            if (liczba_istnieje == true)
            {
                Console.Write($"Liczba jest w tablicy, wystepuje {ile_powtorzen} razy, ");
            }
            else
            {
                Console.WriteLine("Liczby nie ma w tablicy ");






            }

        }
    }
}
