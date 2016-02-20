using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        public static void Main(string[] args)
        {
            //whilePrintNumbersAscending();
            //whilePrintNumbersDescending();
            //whilePrintEvenNumbers();
            // whilePrintOddNumbers();
            whileBreakForLoop();
            Console.ReadLine();

        }

        /*public static void whilePrintNumbersAscending()
        {
            int inputNumStart, inputNumEnd;

            Console.WriteLine("Enter Start number = ");
            inputNumStart = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ENDs number = ");
            inputNumEnd = int.Parse(Console.ReadLine());

            while (inputNumStart <= inputNumEnd)
            {
                Console.WriteLine(inputNumStart + "\t");
                inputNumStart++;

            }
        }*/

        /*public static void whilePrintNumbersDescending()
        {
            int inputNumStart, inputNumEnd;

            Console.WriteLine("Enter Start number = ");
            inputNumStart = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ENDs number = ");
            inputNumEnd = int.Parse(Console.ReadLine());

            while (inputNumEnd >= inputNumStart)
            {
                Console.WriteLine(inputNumEnd + "\t");
                inputNumEnd--;

            }
        }*/

        /* public static void whilePrintEvenNumbers()
         {
             int inputNumStart = 2, inputNumEnd;


             Console.WriteLine("Enter ENDs number = ");
             inputNumEnd = int.Parse(Console.ReadLine());

             while (inputNumStart <= inputNumEnd)
             {
                 Console.Write(inputNumStart + "\t");
                 inputNumStart += 2;

             }
         }*/


        /* public static void whilePrintOddNumbers()
         {
             int inputNumStart = 1, inputNumEnd;


             Console.WriteLine("Enter ENDs number = ");
             inputNumEnd = int.Parse(Console.ReadLine());

             while (inputNumStart <= inputNumEnd)
             {
                 Console.Write(inputNumStart + "\t");
                 inputNumStart += 2;

             }
         }*/

        public static void whileBreakForLoop()
        {
            int inputNumStart = 0;

            while (inputNumStart < 10)
            {
                if (inputNumStart == 7)
                {
                    break;
                }
                else
                {
                    Console.Write(inputNumStart + "\t");
                    inputNumStart++;
                }
            }
        }

    }
}
