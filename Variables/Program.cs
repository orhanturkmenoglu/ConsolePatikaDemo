using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables : verilerimizi depolamayı saglar.verileri bellekte depolar
            /*
             *  asıl amaç verileri depolayarak kontrolü kolaylaştırmak.
             * 
             *  
             * */

            /*
             * Değişken özellikleri
             * Case sensitive : büyük küçük harf duyarlıdır.
             * Değişken isimleri rakamla başlayamaz.
             * Class namespace gibi özel isimler kullanılamaz.
             * Değişkenlerin her zaman bir değeri olmak zorundadır. Yoksa null tanımlanmalıdır.
             * Ataması yapılmayan değişkenler kullanıldığında derleyici hata verir.
             * adlandırmada işlem operatoru içeremez.
             */

            int value;
            value = 2;

            string variable = null;

            // işlem operatörü ile adlandırılamaz.
            //string variable+veri = null;

            Console.WriteLine(value);
            Console.WriteLine(variable);

            // Data  type : veri tipleri degişkenlerimizi tanımlamak için tuttugumuz veri tipleridir.

            string degisken = "mesaj";

            // 1 byte = 8 bit;

            byte b = 5;  // tam sayı tipidir bellekte 8bit alan kaplar

            sbyte c = 5; // tam sayı tipidir -128,127 arasında deger alır 8 bit alan kaplar

            short s = 10; // tam sayı tipidir bellekte 16 bit alan kaplar


            Int16 i16 = 2; // tam sayı tipidir 16 bit alan kaplar

            int i = 2;  // tam sayı tipidir bellekte 32 bit alan kaplar

            Int32 i32 = 32;  // bellekte 32 bit alan kaplar

            Int64 i64 = 64;  // bellekte 64 bit alan kaplar.

            long l = 128; // tam sayı tipidir bellekte 128 bit alan kaplar

            float f = 10.5f; // ondalikli sayi tipidir bellekte 32 bit alan kaplar 

            double d = 5.5; // ondalikli sayi tipidir bellekte 64 bit alan kaplar

            decimal de = 5;  // tam sayı tipidir para birimlerinde kullanılır 128 bit alan kaplar


            char karakter = 'c';  // tek karakter tutar. karakterler dizisi stringi oluşturur 16 bit alan kaplar

            string metin = "sınırsız";  // string metinsel veriler tutmak için kullanılır.


            bool cevap = true;  // mantıksal degerdir true(1) false(1) döner


            DateTime dt = DateTime.Now;  // now; şu anki tarih ve saati getirir.
            Console.WriteLine(dt);

            // string ifadeler
            string str1 = "";
            string str2 = null;
            string str3 = string.Empty;
            str1 = "Tekradan atama yap";

            string ad = "Zekiye";
            string soyad = "ürkmez";
            string tamIsim = ad + " " + soyad;

            // ınteger tanımlama şekilleri

            int value1 = 10;
            int? value2 = null;  // ? null deger ataması yapmamızı saglar
            int value3 = 20;
            int calculate = value1 * value3;


            // boolean 

            bool b1 = 10 > 2;
            Console.WriteLine(b1);


            // Conversion data type : değişken dönüşümleri

            string str20 = "20";
            int int20 = 20;

            string birlestir = str20 + int20.ToString();


            int int21 = int20+Convert.ToInt32(str20);
            Console.WriteLine(int21);


            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd//MM//yyyy");
            Console.WriteLine(datetime2);

            string datetime3 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(datetime3);





        }
    }
}
