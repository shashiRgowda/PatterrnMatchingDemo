
using System;

namespace patternvalidationdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Patterns pattern = Patterns();
            Console.WriteLine(pattern.validatePinCode("4000088"));
    }
}
