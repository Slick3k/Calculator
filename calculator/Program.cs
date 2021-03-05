using System;

namespace calculator_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("При использовании дробных чисел записывать через запятую");
            while (true)
            {

                Console.WriteLine("Введите число, операцию и второе число через Enter.");
                
                try
                {

                    Console.WriteLine("Ответ: "+ Calculate(Convert.ToDouble(Console.ReadLine()), Convert.ToChar(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Что-то на татарском");
                    
                }
                
            }

        }
        static double Calculate(double x, char oper, double y)
        {
            if ((oper == '+') || (oper == '-') || (oper == '*') || (oper == '/') || (oper == '^'))
                switch (oper)
                {
                    case '+':
                        return add(x, y);
                    case '-':
                        return sub(x, y);
                    case '*':
                        return mul(x, y);
                    case '/':
                        return div(x, y);
                    case '^':
                        return pow(x, y);
                    default:
                        throw new Exception("Введено не действие");
                }
            else
            {
                Console.WriteLine("Введено не действие");
                return 0;
            }
        }
        static double add(double x, double y)
        {
            return x + y;
        }
        static double sub(double x, double y)
        {
            return x - y;
        }
        static double div(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
                return 0;
            }
            else 
            return x / y;
        }
        static double mul(double x, double y)
        {
            return x * y;
        }
        static double pow(double x, double y)
        {
            return Math.Pow (x,y);
            
        }
    }
}
