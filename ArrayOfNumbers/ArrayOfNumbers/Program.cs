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
            int sum = 0;
            array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(item => int.Parse(item)).ToArray();
            var num = array.Length;
            for (int i = 0; i < size; i++)
            {
               
                if (size==num)
                {
                    foreach (int d in array)
                    {
                        sum += d;
                    }
                }
                else if (size!=num)
                {
                    Console.WriteLine("The array size of your numbers does not match the numbers of your input.");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("The sum is "+sum/size);
            Console.ReadKey();
            }
        }
    }

