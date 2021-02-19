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
                bool f = false;
                double num3 = 0;
                double num2 = 0;
                char oper = default;
                while (f == false)
                {
                    Console.WriteLine("Выберите операцию");
                    Console.WriteLine("+ Сложение");
                    Console.WriteLine("- Вычитание");
                    Console.WriteLine("* Умножение");
                    Console.WriteLine("/ Деление");
                    Console.WriteLine("^ Возведение в степень");

                    string k = Console.ReadLine();
                    oper = k[0];
                    if ((oper == '+') || (oper == '-') || (oper == '*') || (oper == '/') || (oper == '^'))
                    {
                        f = true;
                    }
                    else
                        Console.WriteLine("попробуйте заново");

                }
                if (oper != '^')
                {
                    Console.WriteLine("Введите второе число");
                    string z = Console.ReadLine();
                    bool b = Double.TryParse(z, out num2);
                    while (b == false)
                    {
                        Console.WriteLine("Попробуйте ещё раз");
                        Console.WriteLine("Введите второе число");
                        z = Console.ReadLine();
                        b = Double.TryParse(z, out num2);
                    }
                }
                switch (oper)
                    {
                    case '+':
                        
                        
                            num3 = num1 + num2;
                        Console.WriteLine(num3);

                        break;

                    case '-':
                        num3 = num1 - num2;
                        Console.WriteLine(num3);
                        break;
                    case '*':
                        num3 = num1 * num2;
                        Console.WriteLine(num3);
                        break;
                    case '/': 
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
                    case '^':
                        num3 = num1 * num1;
                        Console.WriteLine(num3);
                        break;
                   
                    }
                


            }
        }
    }
}
