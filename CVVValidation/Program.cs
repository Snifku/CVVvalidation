using System;

namespace CVVValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your cvv card number: ");
            //int code = Int32.Parse(Console.ReadLine());
            
            string cvv = Console.ReadLine();
            Console.WriteLine($"Your ccv {cvv}");

            if (Num(cvv))
            {
                Console.WriteLine("All good");
            }

        }

        public static bool Num(string cvv)
        {
            if(cvv.Length == 3)
            {
                try
                {
                    Int32.Parse(cvv);
                    return true;
                }
                catch(Exception e)
                {
                    Console.WriteLine($"wrong format {e}");
                    return false;
                }

            }
            else
            {
                Console.WriteLine("wrong format");
                return false;
            }
        }

        

    }

}

