using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace AppA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( $"{typeof(Program).FullName} {Library.Class1.Name}");

            Console.ReadKey();
        }
    }
}
