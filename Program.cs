using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;


            if (time >= 6 && time <= 11)//Koşul sağlanır ise kod bloğu içerisine girer.
            {
                Console.WriteLine("Günaydın");
            }
            else if (time <= 18)//Koşul sağlanır ise kod bloğu içerisine girer.
            {
                Console.WriteLine("İyi günler");
            }
            else //Koşulun sağlanmadığı durumda kod bloğu içerisine girer.
            {
                Console.WriteLine("İyi akşamlar");
            }

            string sonuc = time <= 18 ? "iyi günler" : "İyi akşamlar"; // time koşulu doğru ise iyi günler, yanlış ise iyi akşamlar, sonuc a atanır.
            sonuc = time >= 6 && time <= 11 ? "Günaydın" : time <= 18 ? "iyi günler" : "iyi akşamlar"; // if-else if-else
            Console.WriteLine(sonuc);
        }
    }
}
