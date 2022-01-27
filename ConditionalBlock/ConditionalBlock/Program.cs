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


            // Switch case: if else ile yapılacak her şey bu yapı ile de yapılabilir.


            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1: Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 7:
                    Console.WriteLine("Temmuz");
                    break;
                case 8:
                    Console.WriteLine("Ağustos");
                    break;
                case 9:
                    Console.WriteLine("Eylül");
                    break;
                case 10:
                    Console.WriteLine("Ekim");
                    break;
                case 11:
                    Console.WriteLine("Kasım");
                    break;
                case 12:
                    Console.WriteLine("Aralık");
                    break;
                default:
                    Console.WriteLine("Hatalı kullanım !");
                    break;
            }

        }
    }
}
