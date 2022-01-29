using System;

namespace task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 11) 4 dene 5 reqemli eded verilib.Her I ededin ustune III ededi gel.
            //    II ededin usutune IV eeddi gel.
            //    Sonra cavablari vur birbirine. Alinan neticeden III ededin 3 % -ni cix.

            double a = 12345;
            double b = 54321;
            double c = 11223;
            double d = 12234;
            double ac; 
            double bd;
            double total;

            bool dogruBeraberlik = a < 100000 && a >= 10000 && 
                b < 100000 && b >= 10000 &&
                c < 100000 && c >= 10000 && 
                d < 100000 && d >= 10000; 

            if (dogruBeraberlik)
            {
              

                ac = a + c;
                Console.WriteLine("1ci eded + 3cu eded = " + ac);

                bd = d + d;
                Console.WriteLine("2ci eded + 4cu eded = " + bd);

                total = (ac * bd) - (c*3)/100;
                Console.WriteLine("ac * bd - c'nin 3%'i : " + total);
                


            }
            else
            {
                Console.WriteLine("5 reqemli deyil");
            }
        }
    }
}
