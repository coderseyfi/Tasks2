using System;

namespace task_12
{
    class Program 
    {
        static void Main(string[] args)
        {
            /* 12) 4 dene 6 reqemli eded verilib. 
               Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla.
              Sonra          yekunda alinanlar iki cavabi vur biri birine. 
               Alinan neticenin evvel 10% tap sonra ise hemin cavabin 11% tap.*/

            double a = 111111;
            double b = 222222;
            double c = 333333;
            double d = 444444;
            double a1=a;
            double b1=b;
            double c1=c;
            double d1=d;

            double totalCem10; 
            double totalCem15;
            double totalHasil;

           bool dogruBeraberlik = a >= 100000 && a < 1000000 && 
                b >= 100000 &&
                b < 1000000 &&
                c >= 100000 && c < 1000000 &&
                d >= 100000 && d < 1000000;

            


            if (dogruBeraberlik)
            {
                a = (a * 10) / 100;

                b = (b * 10) / 100;

                c = (c * 10) / 100;

                d = (d * 10) / 100;


                totalCem10 = a + b + c + d;
                Console.WriteLine("ededlerin 10%'i tap topla : " + totalCem10);



                a1 = (a1 * 15) / 100;
                b1 = (b1 * 15) / 100;
                c1 = (c1 * 15) / 100;
                d1 = (d1 * 15) / 100;
               

                totalCem15 = a1 + b1 + c1 + d1;
                Console.WriteLine("ededlerin 15%'i tap topla : " + totalCem15);

                totalHasil = totalCem10 * totalCem15;
                Console.WriteLine("totalHasil neticeleri vur bir birine : " + totalHasil);

                totalHasil = (totalHasil * 10) / 100;
                Console.WriteLine("neticenin 10%'i : " +  totalHasil);

                totalHasil = (totalHasil * 11) / 100;
                Console.WriteLine("Axrinci neticenin 11%'i : " + totalHasil);
            }


            else
            {
                Console.WriteLine("6 reqemli deyil");
            }

           
            


        }
    }
}
