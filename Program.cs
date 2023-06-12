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

        }

    }
}
     
