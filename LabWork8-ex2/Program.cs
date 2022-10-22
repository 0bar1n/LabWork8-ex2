using System;

namespace LabWork8_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x="); //вывод на консоль
            double x = double.Parse(Console.ReadLine());//ввод и задание переменной вещественного типа

            Console.WriteLine("Введите y="); //вывод на консоль
            double y = double.Parse(Console.ReadLine());//ввод и задание переменной вещественного типа

            if (x > y) //проверка выполнения условия
                Console.WriteLine($"Максимальное значение x = {x}"); //вывод на консоль
            else //другой исход
                Console.WriteLine($"Максимальное значение y = {y}"); //вывод на консоль
        }
    }
}
