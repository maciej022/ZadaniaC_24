using Powtorzeniowy;

class PlikGłówny
{

    static void Main(string[] args)
    {
        //To jest baza naszego projektu
        Tablice tablice = new Tablice();
        tablice.Wyswietl();
      int[] tab =  tablice.Towrzenie_tablicy();
        for(int i = 0; i < tab.Length; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }
        
}