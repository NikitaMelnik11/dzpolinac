using System;

class Program
{
    static void Main()
    {
        try
        {
            // Перевірка на ділення без залишку
            Console.Write("Введіть число x: ");
            string? input_x = Console.ReadLine();
            if (string.IsNullOrEmpty(input_x))
            {
                Console.WriteLine("Помилка: Введіть число!");
                return;
            }
            
            Console.Write("Введіть число d: ");
            string? input_d = Console.ReadLine();
            if (string.IsNullOrEmpty(input_d))
            {
                Console.WriteLine("Помилка: Введіть число!");
                return;
            }

            int x = int.Parse(input_x);
            int d = int.Parse(input_d);
            
            if (d == 0)
            {
                Console.WriteLine("Помилка: Ділення на нуль неможливе!");
                return;
            }
            
            if (x % d == 0)
                Console.WriteLine("Ділиться");
            else
                Console.WriteLine("Не ділиться");
            
            // Визначення рівня оцінки
            Console.Write("Введіть оцінку (score): ");
            string? input_score = Console.ReadLine();
            if (string.IsNullOrEmpty(input_score))
            {
                Console.WriteLine("Помилка: Введіть оцінку!");
                return;
            }
            
            int score = int.Parse(input_score);
            
            if (score < 0 || score > 100)
            {
                Console.WriteLine("Помилка: Оцінка повинна бути від 0 до 100!");
                return;
            }
            
            if (score < 50)
                Console.WriteLine("Низький");
            else if (score < 70)
                Console.WriteLine("Середній");
            else if (score < 90)
                Console.WriteLine("Високий");
            else
                Console.WriteLine("Відмінний");
            
            // Знаходження суми двох найбільших чисел
            Console.Write("Введіть три числа (a, b, c) через пробіл: ");
            string? input_numbers = Console.ReadLine();
            if (string.IsNullOrEmpty(input_numbers))
            {
                Console.WriteLine("Помилка: Введіть три числа!");
                return;
            }
            
            string[] numbers = input_numbers.Split(' ');
            if (numbers.Length != 3)
            {
                Console.WriteLine("Помилка: Потрібно ввести рівно три числа!");
                return;
            }
            
            double a = double.Parse(numbers[0]);
            double b = double.Parse(numbers[1]);
            double c = double.Parse(numbers[2]);
            
            double sum = a + b + c - Math.Min(a, Math.Min(b, c));
            Console.WriteLine("Сума двох найбільших чисел: " + sum);
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка: Введено некоректні дані. Будь ласка, вводьте тільки числа.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Виникла помилка: {ex.Message}");
        }
    }
}
