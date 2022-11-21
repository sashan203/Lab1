using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива  ");
            //int size = Convert.ToInt32(Console.ReadLine());//в переменную size записывается число которое ввёл пользователь

            int X;

            String size = Console.ReadLine();

            while (!Int32.TryParse(size, out X))//цикл пока не будет введено действительное число
            {
                Console.WriteLine("НЕКОРРЕКТНЫЙ ВВОД");

                size = Console.ReadLine();
            }
        
            double[] numbers = new double[X]; //создаётся массив с размером соответствующим числу, которое ввёл пользователь
            FillArrayRandomNumbers(numbers); //вызов функции
            Console.WriteLine("массив: ");
            PrintArray(numbers);
            double min = Int32.MaxValue;
            double max = Int32.MinValue;

            for (int z = 0; z < numbers.Length; z++)//цикл в котором перебором находится максимальное и минимальное число в массиве
            {
                if (numbers[z] > max)
                {
                    max = numbers[z];
                }
                if (numbers[z] < min)
                {
                    min = numbers[z];
                }
            }

            Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
            Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

            void FillArrayRandomNumbers(double[] number)//заполнение массива рандомными значениями через цикл
            {
                for (int i = 0; i < number.Length; i++)
                {
                    numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
                }
            }
             void PrintArray( double[] number)//функция вывода заполненого массива
            {
                Console.Write("[ ");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.Write("]");
                Console.WriteLine();
            }
            int size1 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
