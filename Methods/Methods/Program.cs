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


            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);

           int sonuc = Topla(a,b);

            Console.WriteLine(sonuc);


            Console.WriteLine("*************************");

            Metotlar metotlar = new Metotlar();
            metotlar.EkranaYazdir(sonuc.ToString());


        }

       static  int Topla(int deger1,int deger2)
        {
            return (deger1 + deger2);
        }
    }

    class Metotlar
    {
       public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
    }
}
