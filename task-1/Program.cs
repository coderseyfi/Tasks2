using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) 4 reqemli eded verilib.Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir. Example1: 333 = 73338
            int a = 2222;

            if (a >= 1000 && a < 10000)
            {
                

                Console.Write("ilk eded:");
                Console.WriteLine(a);
                a = a + 70000;

                a = a * 10 + 8;
                Console.Write("yeni eded: ");
                Console.WriteLine(a);
            }

            else
            {
                Console.WriteLine("4 reqemli deyil Deyil");
            }

        }
    }
}
