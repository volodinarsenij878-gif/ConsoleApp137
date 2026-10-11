using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program94
{
    internal class Program
    {
        static void Main()
        {
            bool result = !(true && !(false || !false));
            Console.WriteLine(result); // True
        }
    }
}

