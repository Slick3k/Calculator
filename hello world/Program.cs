using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            int exampleint = 50;
            double exampledouble = 50.5;
            Console.WriteLine("Hello World!");
            string[] hellos = { "hallo", "hello", "ciao", "salve" };

            //for (int i = 0; i < exampleint; i++)
            int i = 0;
            foreach (string hello in hellos)
            {
                Console.WriteLine(hello);
                i++;
                Console.WriteLine("вы продолжили" + i + "раз");
            }
            /*if (Console.ReadKey().Key == ConsoleKey.N)
            {
                Console.WriteLine("\nвы продолжили");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nнажми N");
                Console.ReadKey();
            }*/
        }
    }
}
