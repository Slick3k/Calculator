using System;

namespace calculator_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число, операцию и второе число через Enter.");
                try
                {

                    Console.WriteLine("Ответ: " Calculate(Convert.ToDouble(Console.ReadLine()), Convert.ToChar(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                }
                catch
                {

                }
            }

        }
        static double Calculate(double x, char oper, double y)
        {

            switch (oper)
            {
                case '+';
                    return add(x, y);
                case '-';
                    return sub(x, y);
                case '*';
                    return mul(x, y);
                case '/';
                    return div(x, y);
                case '^';
                    return pow(x.y);
            }


        }
        double add(double x, double y)
        {

            return x + y;
        }
        double sub(double x, double y)
        {

            return x - y;
        }
        double mul(double x, double y)
        {

            return x * y;
        }
        double div(double x, double y)
        {

            return x / y;
        }
        double pow(double x, double y)
        {

            return x * y;
        }
    }

}
