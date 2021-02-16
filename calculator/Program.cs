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
                double num1 = Convert.ToDouble(i);
                Console.WriteLine("Выберите операцию");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
               
                string k = Console.ReadLine();
                char oper = Convert.ToChar(k);
                Console.WriteLine("Введите второе число");
                string z = Console.ReadLine();
                double num2 = Convert.ToDouble(z);
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
                        Console.WriteLine("Ну там же всего 4 действия, выбери заново");
                        break;

                      


                }
                


            }
        }
    }
}
