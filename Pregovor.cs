using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregovor
{
    internal class Pregovor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick an option: ");
            Console.WriteLine("(1) Get the sum of the numbers.");
            Console.WriteLine("(2) Get the sum of all the numbers.");
            Console.WriteLine("(3) Make array between the numbers.");
            Console.WriteLine("(4) Print odd numbers.");
            Console.WriteLine("(5) Print even numbers.");
            Console.Write("Enter you option here: ");
            var option = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Enter minimum value: ");
            var minval = int.Parse(Console.ReadLine());
            Console.Write("Enter maximum value: ");
            var maxval = int.Parse(Console.ReadLine());

            if (option == "1")
            {
                int res = GetSum(minval, maxval);
                Console.WriteLine($"Result: {res}");
            }
            else if (option == "2")
            {
                int res = GetAllSum(minval, maxval);
                Console.WriteLine($"Result: {res}");
            }
            else if (option == "3")
            {
                int[] res = MakeArray(minval, maxval);
                Console.WriteLine(string.Join(", ", res));
            }
            else if (option == "4")
            {
                OddNum(minval, maxval);
            }
            else if (option == "5")
            {
                EvenNum(minval, maxval);
            }
        }

        static int GetSum(int minval, int maxval)
        {
            int sum = minval + maxval;
            return sum;
        }
        static int GetAllSum(int minval, int maxval)
        {
            int sum = 0;
            for (int i = minval + 1; i < maxval; i++)
            {
                sum += i;
            }
            return sum;
        }

        static int[] MakeArray(int minval, int maxval)
        {
            int[] arr = new int[maxval - minval - 1];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = minval + i + 1;
            }

            return arr;
        }
        static void OddNum(int minval, int maxval)
        {
            for (int i = minval; i < maxval; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void EvenNum(int minval, int maxval)
        {
            for (int i = minval; i < maxval; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
