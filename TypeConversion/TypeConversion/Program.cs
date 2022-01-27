using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type Conversion : Tip dönüşümleri

            /*
             * Bazı zamanlarda veriler arası tür dönüşümüne ihtiyac duydugumuz zaman kullanmamız gereken yapılardır
             */

            /*
             * 
             *  2 Tip dönüşüm mevcut 
             *  1-Implicit conversion : Belirgin olmayan automatic gercekleşen program tarafından yapılır
             *    nedir bu : küçük veri tiplerinin büyük veri tiplernin içine atanmasıdır
             *  
             *  2-Explicit conversion : Belirgin olan farklı türler arasında gerçekleşir büyük veri tiplerinin küçük veri tiplerine dönüşmesidir
             *   veri kaybı yaşanır

             */

            // 1-ımplicit conversion demo


            int myInt = 10;
            long myLong = myInt;

            // 2- Explicit demo

            double myDouble = 15.5;
            float myFloat = (float)myDouble;

            // 2- Explicit demo
            string number = "12";
            int myNumber = int.Parse(number);


            // 2- Explicit demo
            int sinif = 12;
            string mySinif = sinif.ToString();


            // 2- Explicit demo
            char myChar = 'C';
            string convertChar = myChar.ToString();



            byte myByte = 10;
            int myIntt = myByte;


            ParseMethod();




        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam;
            double double1;


            rakam = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("Rakam : "+rakam);
            Console.WriteLine("Rakam :"+double1);

        }
    }
}
