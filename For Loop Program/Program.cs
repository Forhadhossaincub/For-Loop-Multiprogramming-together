using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} \t");
            }

            Console.WriteLine();
            Console.WriteLine("****************************************");

            for (int i = 1; i <= 10; i = i + 1)
            {
                Console.Write($"{i} \t");
            }

            Console.WriteLine();
            Console.WriteLine("****************************************");

            for (int i = 1; i <= 10; i += 2)
            {
                Console.Write($"{i} \t");
            }

            Console.WriteLine();
            Console.WriteLine("****************************************");

            for (int i = 1; i <= 10; i++)  //Even Number
            {
                if(i%2 ==0)

                Console.Write($"{i} \t");
            }

            Console.WriteLine();
            Console.WriteLine("****************************************");

            for (int i = 1; i <= 10; i++) // Odd Number
            {
                if (i % 2 != 0)

                    Console.Write($"{i} \t");
            }


            Console.WriteLine();
            Console.WriteLine("****************************************");

            int sum=0;

            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"1+2+.......+10 is: {sum}"); // Output 55

            Console.WriteLine();
            Console.WriteLine("****************************************");

            sum =1;

            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"1+2+.......+10 is: {sum}"); // Output 56 

            Console.WriteLine();
            Console.WriteLine("****************************************");
            sum = 1;

            for (int i = 1; i <= 10; i++)
            {
                sum = sum * i;
            }
            Console.WriteLine($"1*2+.......*10 is: {sum}"); // Output 3628800

            Console.WriteLine();
            Console.WriteLine("****************************************");
            sum = 0;
            for (int i = 1; i <= 10; ++i)
            {
                sum += i * i;
            }
            Console.WriteLine($"1^2 + 2^2 + 3^2+......+10^2={sum}");
           
            Console.WriteLine();
            Console.WriteLine("****************************************");

            sum = 0;
            for (int i = 1; i <= 10; ++i)
            {
                sum += i * i * i;
            }
            Console.WriteLine($"1^3 + 2^3 + 3^3+......+10^3={sum}");

            Console.WriteLine();
            Console.WriteLine("****************************************");

            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 1; i <= 10; ++i)
            {
                if (i % 2 == 0)
                {
                    sumEven += i;
                }

                else
                {
                    sumOdd += i;
                }
                    
            }
            Console.WriteLine($"1+3+...+9={sumOdd}");
            Console.WriteLine($"2+4+...+10={sumEven}");






            Console.ReadKey();

        }//main
    } // class
}//namespace
