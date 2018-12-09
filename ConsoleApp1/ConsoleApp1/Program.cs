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
            Console.WriteLine("Вас приветствует программа Екатерины Макеевой");
            Console.WriteLine("Данная программа определяет уровень вашей заработной платы за месяц");
            Console.ReadKey();
            int x,y;
            Console.WriteLine("Введите вашу месячную зарплату");
            x = Convert.ToInt32(Console.ReadLine());
            y = 25000;
            if (x > y)
            { 
                Console.WriteLine("Высокая зп");
            }
            else
            {
                Console.WriteLine("Низкая зп");
            }
            Console.WriteLine("Спасибо за использование программы");
           
            Console.ReadKey();



        }
    }
}
