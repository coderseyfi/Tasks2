using System;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             8) 2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
             I ededin 4%-ni tap.
             Sonra II ededin 9% ni tap.
              Sonra Cavalari toplayib 10 %ni tap.
            */


            double a = 2233;
            double b = 1234567;
            double totalSumPer;

            bool True = a < 10000 && a >= 1000 && b < 10000000 && b >= 1000000;
            if (True)
            {
                a = (a * 4) / 100;
                Console.WriteLine("1 ci ededin 4%'i : " + a);

                b = (b * 9) / 100;
                Console.WriteLine("2 ci ededin 9%'i : " + b);

                totalSumPer = ((a + b)*10)/100;
                Console.WriteLine("Cavablari topla 10%'i tap : " + totalSumPer);

                
            }
            else
            {
                Console.WriteLine("4 reqemli deyil");
                Console.WriteLine("3 reqemli deyil");
            }
        }
    }
}
