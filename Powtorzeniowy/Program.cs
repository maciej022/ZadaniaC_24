using Powtorzeniowy;

class PlikGłówny
{

    static void Main(string[] args)
    {
        Listy abc = new Listy();
        abc.Dodawanie();
        Console.WriteLine(abc.Dodawanie1(123, 5));

        Tablice tablice = new Tablice();
        
      int[] tab =  tablice.Towrzenie_tablicy();
        tablice.Wyswietl(tab);
        tablice.SortowanieBabelkowe(tab);
        tablice.Przeszukaj(tab);
        
    }
        
}