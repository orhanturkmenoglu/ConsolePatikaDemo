using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays: Diziler 

            /* Birden fazla aynı tipte veri tanımlamak yerine
             * aynı tipte tek bir veride depolamak için kullanılır
             * sıralı bir biçimde tanımlanır
             */

            // dizi tanımlama şekilleri

            //1
            string[] renkler = new string[5];
            renkler[0] = "sarı";
            renkler[1] = "kırmızı";
            renkler[2] = "mavi";
            renkler[3] = "yeşil";
            renkler[4] = "gri";

            Console.WriteLine("Renk :",renkler[1]);

            //2
            string[] hayvanlar = {"kedi","köpek","kuş","maymun" };
            Console.WriteLine(hayvanlar[0]);
            

            //3
            int[] dizi;
            dizi = new int[3];
            dizi[1] = 10;

            Console.WriteLine(dizi[1]);

            Console.WriteLine("***********************");

            // klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.WriteLine("Lütfen dizinin eleman sayisini giriniz");

            int diziUzunlugu = int.Parse(Console.ReadLine());
            
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz.",i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }


            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }

            Console.WriteLine("Ortalama : "+(toplam/diziUzunlugu));


            // arrays metotları.

            // sort sıralama


            int[] sayilar = {23,12,17,55,42,7 };

            Console.WriteLine("*****Sırasız dizi ****************");
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("*****Sıralı dizi ****************");

            Array.Sort(sayilar);

            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            // clear : dizi sıfırlama

            Array.Clear(sayilar,0,sayilar.Length);


            // reverse : ters cevirme 


            Array.Reverse(sayilar);


            // IndexOf(): aranan verinin index nosunu getirir

            Array.IndexOf(sayilar,12);


            // Resize : yeniden boyutlandırma yapar.

            Array.Resize<int>(ref sayiDizisi,9);




        }
    }
}
