using System;

namespace task_15
{
    class Program
    {
        static void Main(string[] args)
        {
//15)* 7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.
//1 denesi ise 6 reqemlidir.

 //3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan
 //alinan cavabi.

  //Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli
   //ededlerin cemini.

 //Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.

  //Sonra alinan cavabin ustune gel 6 reqemli ededi.
 
  //Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
  
  //Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.

  //Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.

            double a = 100;
            double b = 200;
            double reqemli3topla;
            double reqemli3vurartir1;

            double c = 3000;
            double d = 4000;
            double reqemli4vur;

            double reqemli34topla;
            
            

            double e = 50000;
            double f = 60000;


            double g = 700000;

            bool dogru1 = 
             a >= 100 && a < 1000 && b >= 100 && b < 1000 && 
             c >= 1000 && c < 10000 && d >= 1000 && d < 10000 &&
             e >= 10000 && e < 100000 && f >= 10000 && f < 100000 &&
             g >= 100000 && g < 1000000;



            if (dogru1)
            {
                
              

                reqemli3topla = (a + b);
                Console.WriteLine("3 reqemli ededlerin cemi = "+reqemli3topla); //100+200

                reqemli4vur = c * d;
                Console.WriteLine("4 reqemli ededlerin hasili : " + reqemli4vur); // 3000*4000 = 12000000

                reqemli34topla = reqemli3topla + reqemli4vur;
                Console.WriteLine("3 reqemli ededlerin cemi + 4 reqemli ededlerin hasili :" + reqemli34topla); //300 + 12000000 = 12000300

                reqemli34topla = reqemli34topla*10 + 7;
                Console.WriteLine("alinan neticenin axirina 7 artir: " + reqemli34topla); // neticenin axirina 7 artir = 120003007

                reqemli34topla = reqemli34topla + (e + f);
                Console.WriteLine("axirina 7 artirilan neticenin ustune 5 reqemli ededlerin cemi : " + reqemli34topla);

                reqemli3vurartir1 = a * b; // 3 reqemli ededlerin hasili
                Console.WriteLine("3 reqemli ededlerin hasili : " + reqemli3vurartir1);

                reqemli3vurartir1 = reqemli3vurartir1 * 10 + 1;
                Console.WriteLine("3 reqemli ededlerin hasilinin sonun 1 artir : " + reqemli3vurartir1);

                reqemli34topla = reqemli34topla - reqemli3vurartir1;
                Console.WriteLine("neticeden cix sonuna 1 artirilms varianti : " + reqemli34topla);

                reqemli34topla = reqemli34topla + g;
                Console.WriteLine("neticeni ustune 6 reqemli ededi gel : " + reqemli34topla);

                reqemli34topla = reqemli34topla - ((a + b) + (c + d));
                Console.WriteLine("alinan cavabdan cix 3 ve 4 reqemli ededlerin cemini : " + reqemli34topla );

                reqemli34topla = (reqemli34topla * 18)/100;
                Console.WriteLine("alinan cavabin 18%'i : " + reqemli34topla);

                reqemli34topla = (reqemli34topla * 3) / 100;
                Console.WriteLine("sonra cavabin 3%'i : " + reqemli34topla);

                reqemli34topla = (reqemli34topla * 1) / 100;
                Console.WriteLine("sonra cavabin 1%'i : " + reqemli34topla);

                reqemli34topla = reqemli34topla + (e + f);
                Console.WriteLine("en sonda alinan cavabin uzerine 5 reqemli ededlerin cemini gel : " +reqemli34topla);

                



            }
            else
            {
                Console.WriteLine("3 reqemli deyil");
                Console.WriteLine("4 reqemli deyil");
                Console.WriteLine("5 reqemli deyil");
                Console.WriteLine("6 reqemli deyil");

            }




        }
    }
}
