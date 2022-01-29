using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4) 3 reqemli eded verilib.Bu ededin axirina 7 artir.Sonra cavabin 7 % tap;

            double a = 777;

            if (a < 1000 && a >= 100)
            {
                Console.Write("ilkin eded: ");
                Console.WriteLine(a);

                a = a * 10 + 7;
                Console.Write("sonun 7 artirilan eded: ");
                Console.WriteLine(a);

                a = (a * 7) / 100;
                Console.Write("cavabin 7%'i: ");
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("3 reqemli deyil");
            }

        }
    }
}
