using System;
using System.Linq;

namespace ArrayOfNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter size of array");
           int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Please insert your numbers: ");
            for (int i = 0; i < size; i++)
            {

                    array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(item => int.Parse(item)).ToArray();
            }
            int sum = 0;
            foreach (int d in array)
            {
                sum += d;
            }
          
            Console.WriteLine("The sum is "+sum);
            }
        }
    }

