using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byndyusoft
{
    class Program
    {
        static void Main()
        {            
            var exampleArray = new int[5] { -10, 5, 0, 7, 167 };
            Console.WriteLine(Summator.GetSumOfMinElements(exampleArray));
            Console.ReadKey();
        }
    }
}
