using System;
using Xunit;

namespace ConsoleAppJenkins
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("Bruno's Jenkins Pipeline Example");
            Console.WriteLine(Lib.Class1.Execute("Teste Bruno", dt));

            
            
        }
    }
}
