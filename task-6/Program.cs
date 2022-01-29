using System;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6) 4 reqemli eded verilib.Bu ededin evvel 20 % -ni ,
                sonra ise cavabin 10 % tap.Alinan cavabin kvadratini tap.*/

            double a = 3344;
            
            bool True = a < 10000 && a >= 1000;
            if (True)
            {
                

                a = (a * 20) / 100;
                Console.WriteLine("a'nin 20%'i : " + a);

                a = (a * 10) / 100;
                Console.WriteLine("cavabin 10%'i : " + a);

                a = a * a;
                Console.WriteLine("alinan cavabin kvadrati : " + a);
                
            }
            else
            {
                Console.WriteLine("4 reqemli deyil");
            }
        }
    }
}
