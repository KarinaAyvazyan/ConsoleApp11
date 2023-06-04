using System;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int num = 50; num <= 70; num++)

            {
                while (num != 1)
                {
                    if (num % 2 == 0)
                    {
                        num = num / 2;

                    }
                    else if (num % 2 == 1)
                    {
                        num = (num * 3 + 1) / 2;

                    }

                   
                }
              //  Console.WriteLine(num);


            }

      /*  mer num-y  gtnvum e 50-ic 70 mijakayqum,ete num-y zuyg e ,apa bajanenq 2-i,kenti jamanak (num*3+1)/2 .Ayd gorcoxutyunnery num-i (stacvac tvi)
         hamar krknenq aydqan jamanak ,qani der num!=1 .Ayd gorcoxutyunnery hertov aneluc heto ,erb stananq 1 tpenq ayn ...
       */
        }

    }
}
     