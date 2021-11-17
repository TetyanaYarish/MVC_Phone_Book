using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfNumbers
{
   public class UserNumber
    {
        public int amountOfNumbers { get; set; }
         public int NumberOfNumbers()
        {
            Console.WriteLine("Enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            return size;

        }
    }
}
