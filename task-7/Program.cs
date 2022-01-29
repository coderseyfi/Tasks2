using System;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7) 2 dene 5 reqemli eded verilib. Bu ededleri toplayib.
            Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap*/

            double a = 55555;
            double b = 66666;
            double totalCem; 

            bool True = a < 100000 && a >= 10000 && b < 100000 && b >= 10000;

            if (True)
            {
                

                totalCem = a + b;
                Console.WriteLine("totalCem : "+totalCem);

                totalCem = totalCem + 5000000;
                
                totalCem = totalCem * 10 + 5;
                Console.WriteLine("evveline ve sonuna 5 artir : " + totalCem);

                totalCem = (totalCem * 5) / 100;
                Console.WriteLine("Neticenin 5%'i : " + totalCem);
            }
            else
            {
                Console.WriteLine("5 reqemli deyil");
            }
        }
    }
}
