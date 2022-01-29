using System;

namespace task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*14) 6 dene 6 reqemli eded verilib.Evvel hamisini topla.
                Sonra I ve III ededi bir birine yapishdir ve bir eded al.
                 I neticeden II neticeni cix.
                Alinan cavabin 10 % tap.Neticenin uzerine V ve VI ededleri gel. 
                Yekunda alinan cavabin 11 % tap. */

            double a = 123456;
            double b = 234567;
            double c = 345678;
            double d = 456789;
            double e = 567890;
            double f = 100000;
            double ac; //1 ci ededi 2 e yapishdir
            double totalferq;
            double totalcem;

            bool dogru = a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000 && d >= 100000 && d < 1000000 && e >= 100000 && e < 1000000;

            if (dogru)
            {
                double hamsintopla;
                hamsintopla = a + b + c + d + e + f;
                Console.WriteLine("hamisintopla : "+ hamsintopla);

                a = a * 1000000;
                ac = a + c;
                Console.WriteLine("ac 1ci ededi 3cu edede yapishdir : " + ac);

                totalferq = hamsintopla - ac;
                Console.WriteLine("totalferq :" + totalferq);

                totalferq = (totalferq * 10) / 100;
                Console.WriteLine("totalferq : " + totalferq);

                totalcem = totalferq + e + f;
                Console.WriteLine("totalcem:" + totalcem);

                totalcem = (totalcem * 11) / 100;
                Console.WriteLine("totalcemin 11%'i : " + totalcem);
            }
            else
            {
                Console.WriteLine("No");
            }


        }
    }
}
