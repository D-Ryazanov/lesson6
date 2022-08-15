using System;

class Program
{
    public static void Main(string[] args)
    {

        void Task41()
        {
            // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

            Console.WriteLine("Укажите количество чисел которые хотите ввести");
            int M = Convert.ToInt32(Console.ReadLine());
            int num, count = 0;
            for (int i = 1; i < M + 1; i++)
            {
                Console.WriteLine("Ввидите " + i + " число");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Всего было введено чисел больше 0 - " + count + ".");
        }



        void Task43()
        {
            // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
            // значения b1, k1, b2 и k2 задаются пользователем.

            Console.WriteLine("Будет найдена точка пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
            Console.WriteLine("Укажите k1");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Укажите b1");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Укажите k2");
            double k2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Укажите b2");
            double b2 = Convert.ToDouble(Console.ReadLine());
            if (k1 == k2)
            {
                Console.WriteLine("Точек пересечения нет, так как прямые параллельны");
            }
            else
            {
                double x = (b2 - b1) / (k1 - k2);
                double y = k1 * x + b1;
                Console.WriteLine($"Две прямые пересекутся в точке А ({Math.Round(x, 2)}, {Math.Round(y, 2)})");
            }

        }
        // Вариант решения с урока (семинара) №7 не подходит, поскольлку если у вводных чисел стоит значение "Int" то программа 
        // не сможет вывести дробные значения, поэтому правильнее принимать все значения в "double".



        //Меню для более легкой проверки.

        Console.WriteLine("Укажите какое задание хотите проверить (41, 43)");
        int task = Convert.ToInt32(Console.ReadLine());
        if (task == 41)
        {
            Task41();
        }
        else if (task == 43)
        {
            Task43();
        }
        else
        {
            Console.WriteLine("Такого задания нет.");
        }
    }
}