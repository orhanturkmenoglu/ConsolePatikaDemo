using System;

namespace ConditionalBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditional block : şart blokları 

            /*
             * uygulamamızda belli bir şarta göre programın akışını değiştirdiğimiz yapılardır
             * 
             */

            // if else 

            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
            {
                Console.WriteLine("günaydın");
            }
            else if(time<=18) 
            {
                Console.WriteLine("iyi günler");
            }
            else
            {
                Console.WriteLine("iyi geceler");
            }



            // ternary operators: tek satırlık if else sadece çıktı almamız gereken durumlarda kullanılır

            string sonuc = time <= 18 ? "İyi günler " : "İyi geceler";

            sonuc = time >= 6 && time < 11 ? "Günaydın " : "İyi Günler";
 
            Console.WriteLine(sonuc);




        }
    }
}
