using System;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*10) 3 dene 4 reqemli eded verilib. I ededin 1%-ni, II ededin 2% , III ededin 3 % tap.
            Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7 % faizini gel */

            double a = 8888;
            double b = 9999;
            double c = 1000;
            double d;
            double TOTAL;
            double c1 = c; 


            bool dogruBeraberlik = a >= 1000 && a < 10000 && b >= 1000 && b < 10000 && c >= 1000 && c < 10000;
            if (dogruBeraberlik)
            {

                a = (a * 1) / 100;
                Console.WriteLine("1 ci ededin 1%'i :" + a);

                b = (b * 2) / 100;
                Console.WriteLine("2 ci ededin 2%'i :" + b);

                c = (c * 3) / 100;
                Console.WriteLine("3 ci ededin 3%'i :" + c);

                d = a - b - c;
                Console.WriteLine("neticeleri birbirinden cix : " + d);

                
                c1 = ( c1 * 7 )/ 100;
                Console.WriteLine("3 cu ededin 7%'i : " + c1);

                TOTAL = d + c1;
                Console.WriteLine("TOTAL totalferq + c1 = " + TOTAL);





            }
            else
            {
                Console.WriteLine("deyil");
            }
        }
    }
}
