using System;

namespace Methods
{
   static class Program
    {
        static void Main(string[] args)
        {
            // Methods: metotlar verilen işleri yerine getiren kod bloklarıdır

            /*
             * kod tekrarını önlerler 
             * method ismiyle tekrar tekrar kullanmayı saglarlar.
             */

            /*
             * Bu bizi hem kod tekrarından kurtarır hem de daha 
             * okunabilir kod parçaları yazmamızı sağlar. Metotlar tek başlarına kullanılabilen yapılar değildir.
             */

            /* ref: deger tiplerinin referans type gibi davranmasını saglar
             * ilk deger ataması yapmak zorunludur
             * out: ref ile aynı işlevi görür tek fark out başlatırken deger ataması yapmaya gerek yoktur method içinde ger atanmalı.
             */
            /*
             * method overloading: aşırı yükleme
             * aynı metot isimlerine sahip method parametreleri veya verş tipleri farklı birden fazla method tanımlamak.
             */

            //int a, b;
            //Test(out a, out b);

            //int sonuc = Topla(a, b);

            //Console.WriteLine(sonuc);


            //Console.WriteLine("*************************");

            //Metotlar metotlar = new Metotlar();
            //metotlar.EkranaYazdir(sonuc.ToString());


            string sayi = "999";


            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("başarısız");
            }


            Metotlar instance = new Metotlar();
            instance.Toplam(4,5,out int toplamSonucu);
            Console.WriteLine(toplamSonucu);


            int ifade = 999;

            instance.EkranaYazdir(ifade.ToString());
            instance.EkranaYazdir(ifade);


        }

        private static void Test(out int a, out int b)
        {
            a = 2;
            b = 3;
            Console.WriteLine(a + b);
        }

        static  int Topla(int deger1,int deger2)
        {
            return (deger1 + deger2);
        }
    }

    class Metotlar
    { // method overloading
       public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void Toplam(int a,int b,out int toplam)
        {
            toplam = a + b;
        }
    }
}
