using System;

namespace task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   13) 5 dene eded verilib. Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir.
                5 reqemli ededlerin 5% tap ,neticeleri vur bir birine.
                Sonra 3 reqemli ededlerin 3% tap ,neticeleri topla. Sonra yekunda alinan 
               iki cavalarin her birinin 10%-ni tapib topla. */

            double a = 23456;
            double b = 34567;
            double c = 45678;
            double d = 222;
            double e = 333;
            double cem;
            double hasil;

           
            double cem1 = 0;
            double hasil1 = 0;
            double total;







            bool dogru = a >= 10000 && a < 100000 && b >= 10000 && b < 100000 && c >= 10000 && c < 100000;
            bool dogru1 = d >= 100 && d < 1000 && e >= 100 && e < 1000;
            if (dogru)
            {
                //Console.WriteLine("5 reqemlidir");

                a = (a * 5) / 100;
                Console.WriteLine("a % 5: " + a );

                b = (b * 5) / 100;
                Console.WriteLine("b % 5: " + b);

                c = (c * 5) / 100;
                Console.WriteLine("c % 5: " + c);

                hasil = a * b * c;
                Console.WriteLine("hasil a * b * c: " + hasil);

                hasil = (hasil * 10) / 100;
                Console.WriteLine("hasilin 10%'i: " + hasil);

                hasil1 = hasil;


            }
            else
            {
                Console.WriteLine("5 reqemli deyil");
            }
            
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");

            if (dogru1)
            {
                d = (d * 3) / 100;
                Console.WriteLine("d % 3: " + d);

                e = (e * 3) / 100;
                Console.WriteLine("e % 3: " + e);

                cem = d + e;
                Console.WriteLine("cem = " + cem);

                cem = (cem * 10) / 100;
                Console.WriteLine("cem'in 10% " + cem);

                cem1 = cem;
            }
            else
            {
                Console.WriteLine("3 reqemli deyil");
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("");
            
            total = hasil1 + cem1;
            Console.WriteLine("Total Hasil + Cem : " + total);


        }
    }
}
