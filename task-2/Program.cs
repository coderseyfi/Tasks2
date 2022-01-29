using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) 3 reqemli eded verilib.Bu ededin axirina hemin ededdin ozunu yapishdir.example: 333 = 333333;

            int a = 444;

            if (a >= 100 && a < 1000)
            {
       


                Console.Write("ilk eded:");
                Console.WriteLine(a);


                a = a * 1000 + 444;
                Console.Write("yeni eded:");
                Console.WriteLine(a);

            }

            else
            {
                Console.WriteLine("3 reqemli deyil");
            }

        }
    }
}                                         
