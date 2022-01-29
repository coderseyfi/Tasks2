using System;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 9) 3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. 
             Alinan cavabin 10% tap. */

            double m = 111111;
            double n = 222222;
            double z = 333333;
            double totalCemPer;

            bool dogrudur = m >= 100000 && m < 1000000 && n >= 100000 &&
                n < 1000000 && 
                z >= 100000 && z < 1000000;

            if (dogrudur)
            {
                Console.WriteLine("6 reqemlidir");
                Console.WriteLine("-------------");

                m = (m * 10) / 100;
                Console.WriteLine("1 ci ededin 10%'i : " + m);

                n = (n * 10) / 100;
                Console.WriteLine("2 ci ededin 10%'i : "+n);

                z = (z * 10) / 100;
                Console.WriteLine("3 ci ededin 10%'i : "+z);

                totalCemPer = ((m + n + z) * 10) / 100;
                Console.WriteLine("Neticeleri topla 10%'ni tap : " +totalCemPer );


            }
            else
            {
                Console.WriteLine("6 reqemli deyil");
            }
        }
    }
}
