using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_and_even_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");

            try
            {
                int numInput = Convert.ToInt32(Console.ReadLine());

                 if (numInput % 2 == 0)
                    {
                      Console.WriteLine("The number is even");
                    }
                 else
                 {
                     Console.WriteLine("The number is odd");
                 }

            }catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }


            

             Console.ReadLine();
            

        }
    }
}
