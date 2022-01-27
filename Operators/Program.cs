using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operatörler.

            // Atama ve işlemli atama

            int x = 10;
            int y = 20;

            y = y + 2;  // atama ve artırma işlemi
            x += 2;     // veya bu şekilde de yapabiliriz işlemli atama

            y /= 3;     // bölü atama işlemi

            x *= 2;  // x = x*2 karşılıgıdır


            // Mantıksal operatörler 


            // || veya  && ve ! değil

            bool isSuccess = true;

            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect");
            }

            if (isSuccess || isCompleted)
                Console.WriteLine("Great");

            if (isSuccess && !isCompleted)
                Console.WriteLine("Fine !");


            // ilişkisel operatorler 
            // <  >  >= <= == !=

            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);

            sonuc = a > b;
            Console.WriteLine(sonuc);

            sonuc = a >= b;
            Console.WriteLine(sonuc);

            sonuc = a <= b;
            Console.WriteLine(sonuc);

            sonuc = a != b;
            Console.WriteLine(sonuc);

            sonuc = a == b;
            Console.WriteLine(sonuc);

            // Aritmetik operatörler 

            // +, -, /, *, %

            int sayi1 = 10;
            int sayi2 = 5;

            int sonuc1 = sayi1 /sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 - sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 % sayi2;
            Console.WriteLine(sonuc1);



        }
    }
}
