using System;

namespace Class_na_temat_aut
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochód Samochód1 = new Samochód();
           
            Samochód1.Marka = "BMW M4";
            Samochód1.Cena = 750000;
            
        }
    }

    class Samochód
    {
        public string Marka;
        public string Kolor;
        public int Cena;
        public int Dataprodukcji;
        public int Prędkość;

        public Samochód(string Marka, int Cena)
        {
            Console.WriteLine(Marka);
            Console.WriteLine(Cena);
        }

        public Samochód(string Marka, string Kolor, int Cena, int Dataprodukcji)
        {
            Console.WriteLine(Marka);
            Console.WriteLine(Kolor);
            Console.WriteLine(Cena);
            Console.WriteLine(Dataprodukcji);
        }
    }
}
