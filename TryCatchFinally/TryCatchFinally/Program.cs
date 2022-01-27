using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exception : Uygulama sırasında gelen kod hatalarına karşı önlem almak için kullanılan yapılardır

            /* 2 Türlü hata vardır 
             * 1-Compile  : Derleme zamanı alınan hatalar
             * 2-Runtime : Çalışma anında gelen hatalar
             * 
             */

            // Hataların önüne geçebilmek için try catch blogunu kullanırız veya kendimize ait exception sınıfları yazariz

            /*
             * try: hataya neden olabilecek olan kodun yazıldıgı blokdur
             * catch : gelen hataya karşı alınabilecek davranışı sergiledigimiz kısım
             * finally : her ne olursa olsun çalışacak olan kısımdır.
             */

            try
            {

                Console.WriteLine("Bir sayı giriniz");

                int sayi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Girmiş olduğunuz sayi : {0}", sayi);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Gelen hata : "+exception.Message);
              
            }

            finally
            {
                Console.WriteLine("işlem tamamlandı.");
            }


            // gelebilecek hataları tahmin edebiliyorsak özel catch blokları ile şartlandırabiliriz
            // hangi hatadan dolayı program duruyorsa o catch bloguna girer
            try
            {
                int a = int.Parse(null);
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine("Hata Mesajı : "+exception.Message);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Hata Mesajı : "+ exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Hata Mesajı : " + exception.Message);
            }
            finally
            {
                Console.WriteLine("işlem tamamlandı.");
            }









        }
    }
}
