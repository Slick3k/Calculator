using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pro Calculator");
            Console.WriteLine("");
            Console.WriteLine("");
            while (true)
            {
                Console.WriteLine("Введите первое число");
                string i = Console.ReadLine();
                bool p = Double.TryParse(i, out double num1);
                while (p == false)
                {
                    Console.WriteLine("Попробуйте ещё раз");
                    Console.WriteLine("Введите первое число");
                    i = Console.ReadLine();
                    p = Double.TryParse(i, out num1);

                }
                Console.WriteLine("Выберите операцию");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.ReadLine();
                string k = Console.ReadLine();
                char oper = k[0];

                Console.WriteLine("Введите второе число");
                string z = Console.ReadLine();
                bool b = Double.TryParse(z, out double num2);
                while (b == false)
                {
                    Console.WriteLine("Попробуйте ещё раз");
                    Console.WriteLine("Введите второе число");
                    z = Console.ReadLine();
                    b = Double.TryParse(z, out num2);
                }
                double num3 = 0;
                

                switch (oper)
                    {
                    case '1':
                        
                        
                            num3 = num1 + num2;
                        Console.WriteLine(num3);

                        break;

                    case '2':
                        num3 = num1 - num2;
                        Console.WriteLine(num3);
                        break;
                    case '3':
                        num3 = num1 * num2;
                        Console.WriteLine(num3);
                        break;
                    case '4': 
                        if (num2 == 0)
                        {
                            Console.WriteLine("На ноль делить нельзя");
                        }    
                        else
                        {
                            num3 = num1 / num2;
                            Console.WriteLine(num3);
                        }
                        break;
                   

                    default: 
                        Console.WriteLine("Ну там же всего 4 операции, выберите заново");
                        break;

                      


                    }
                


            }
        }
    }
}
