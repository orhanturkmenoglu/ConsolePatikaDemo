using System;

namespace Loops
{
   static class Program
    {
        static void Main(string[] args)
        {


            // Loops  : Döngüler 

            /*
             * Döngüler tekrarlayan veri yapılarını dolaşmak için kullanılır.
             */

            // ekrana girilen sayı kadar olan tek sayıları ekrana yazdır

            Console.WriteLine("Bir sayı giriniz");

            int sayi = Convert.ToInt32(Console.ReadLine());



            

            for (int i = 0; i < sayi; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }

            }


            // 1 ile 100 arasındaki tek ve çift sayıların kendi içlerindeki toplamlarını ekrana yazdır

            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    ciftToplam += i;
                }
                else
                {
                    tekToplam += i;
                }
            }

            Console.WriteLine("Tek sayılar toplamı : "+tekToplam);
            Console.WriteLine("Çift sayılar toplamı : " + ciftToplam);

            // break : döngüden çıkmamızı saglar
            // continue : şart saglandıgı an bir atlar devam eder

            Console.WriteLine("*********************");

            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("*********************");

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
