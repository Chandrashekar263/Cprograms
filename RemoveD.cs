using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cprograms
{
    public class RemoveD    
    {                //using linq chandrashekar
        public static void Main()
        {
            //hi
            string input = "swamiiii";
            string result = new string(input.ToCharArray().Distinct().ToArray());
            Console.WriteLine(result);
        }
    }
}
/*1. input.ToCharArray(): This converts the input string into a character array.

2.Distinct(): This method is part of the LINQ (Language Integrated Query) library in C#.
It removes duplicate elements from a sequence, in this case, the character array.

3. ToArray(): This converts the result of the Distinct() method back into an array.

4. new string(...): This creates a new string from the character array*/



