using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.WriteLine("Введите первое число");
                    int x = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    int y = int.Parse(Console.ReadLine());

                    Console.WriteLine("Сумма : {2}", x, y, x + y);

                }
                while (Console.ReadKey().Key != ConsoleKey.Escape);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

    }
}

