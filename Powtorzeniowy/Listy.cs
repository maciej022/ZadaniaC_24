using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powtorzeniowy
{
    public class Listy
    {


        public List<int> Main()
        {
            List<int> Lista = new List<int>();
            string decyzja = "";
            while (decyzja == "t")
            {
                Console.WriteLine("Czy chcesz dodać element do listy?");
                decyzja = Console.ReadLine();
                if (decyzja == "t")
                {
                    Console.WriteLine("Podaj element: ");
                    int element = int.Parse(Console.ReadLine());
                    Lista.Add(element);

                }
                else
                {
                    Console.WriteLine("Podano wszystkie elementy");
                }
            }
            return Lista;
        }
    }
}

        
        

            

