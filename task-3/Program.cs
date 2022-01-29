using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3) 5 reqemli eded verilib.Bu ededin evvel 18 % sonra ise 3 % tap.

            double a = 10000;
            double per1; //a'nin 18%'i
            double per2; //a'nin 3%'i


            if (a < 100000 && a >= 10000)
            {
                

                per1 = (a * 18) / 100;
                Console.Write("per1: ");
                Console.WriteLine(per1);

                per2 = (a * 3) / 100;
                Console.Write("per2: ");
                Console.WriteLine(per2);
            }

            else
            {
                Console.WriteLine("5 reqemli deyil");
            }

        }
    }
}
