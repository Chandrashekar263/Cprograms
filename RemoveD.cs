using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cprograms
{
    public class RemoveD    
    {                //using linq ;;;;
        public static void Main()
        {
            string input = "swamiiii";
            string result = new string(input.ToCharArray().Distinct().ToArray());
            Console.WriteLine(result);
        }
    }
}


