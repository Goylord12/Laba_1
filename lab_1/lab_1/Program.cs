using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество иттераций: ");
            int length = Convert.ToInt32(Console.ReadLine());

            double sum = 0;

            if (length < 0) Console.WriteLine("Введите положительное количество итераций");

            for (int i = 1; i <= length; i++)
            { 
                if(i == 1)
                {
                    sum += (x - 1) / (x + 1);
                    Console.WriteLine($"Сумма итераций № {i} = {sum}");
                }
            

                else
                {
                    sum += (Math.Pow((x - 1), (2 * i + 1))) / ((2 * i + 1) * (Math.Pow(x + 1, 2 * i + 1)));
                    Console.WriteLine($"Сумма итераций № {i} = {sum}");

                }
            }
            sum *= 2;
            Console.WriteLine($"Итоговая итерация = {sum}");
        }
    }
}
