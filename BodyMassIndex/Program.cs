using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Добро пожаловать. Это программа позволит вам узнать индекс массы тела." +
                "Для начала введите вес тела и рост.");

            Console.Write("\nВес тела: ");
            int bodyMass = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nРост: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double bodyMassIndex = bodyMass / (height * height);

            if (bodyMassIndex < 18)
            {
                Console.WriteLine("\nНиже нормального веса.");
            }

            else if (bodyMassIndex > 18 && bodyMassIndex < 25)
            {
                Console.WriteLine("\nНормальный вес.");
            }

            else if (bodyMassIndex > 25)
            {
                Console.WriteLine("\nОжирение.");
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Проверьте правильность ввода.");
            }

            Console.ReadLine();
        }
    }
}
