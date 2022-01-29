using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5) 4 reqemli eded verilib.Bu ededin evvelin 4 reqemi ,
                 axirina ise 44 ededini artir. Alinan cavabin 44 % tap.
            */

            double a = 1231;

            bool True = a < 10000 && a >= 1000;

            if (True)
            {
                Console.WriteLine("ilk eded: "+a);

                a = a + 40000;
                Console.WriteLine("evveline 4 artir : " + a);

                a = a * 100 + 44;
                Console.WriteLine("sonuna 44 artir : " +a);

                a = (a * 44) / 100;
                Console.WriteLine("alinan cavabin 44%'i : "+a);


            }
            else
            {
                Console.WriteLine("4 reqemli deyil");
            }

        }
    }
}
