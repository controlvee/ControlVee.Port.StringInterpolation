using System;

namespace ControlVee.Port.StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string sp = " ";
            string world = "World";
            string exp = "!";

            Console.WriteLine("Hello World!");

            //
            // OR
            //

            Console.WriteLine(hello + sp + world + exp);

            //
            // OR
            //

            Console.WriteLine("{0} {1}!", hello, world);

            //
            // OR 
            //

            Console.WriteLine($"{hello} {world}!");
            Console.Read();
        }
    }
}
