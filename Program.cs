// See https://aka.ms/new-console-template for more information
using System;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("== калькулятор на С# ===");

        // Ввод двух чисел
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nВыберите операцию:");
        Console.WriteLine("+  Сложение");
        Console.WriteLine("-  Вычитание");
        Console.WriteLine("*  Умножение");
        Console.WriteLine("/  Деление");
        Console.WriteLine("%  Остаток от деления");
        Console.WriteLine("++ Инкремент (увеличить первое число на 1)");
        Console.WriteLine("-- Декремент (уменьшить первое число на 1)");
        Console.Write("Введите операцию: ");

        string operation = Console.ReadLine();

        double result = 0;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"Результат: {num1} + {num2} = {result}");
                break;

            case "-":
                result = num1 - num2;
                Console.WriteLine($"Результат: {num1} - {num2} = {result}");
                break;

            case "*":
                result = num1 * num2;
                Console.WriteLine($"Результат: {num1} * {num2} = {result}");
                break;

            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Результат: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                }
                break;

            case "%":
                result = num1 % num2;
                Console.WriteLine($"Результат: {num1} % {num2} = {result}");
                break;

            case "++":
                num1++;
                Console.WriteLine($"Результат инкремента: {num1}");
                break;

            case "--":
                num1--;
                Console.WriteLine($"Результат декремента: {num1}");
                break;

            default:
                Console.WriteLine("Неизвестная операция!");
                break;
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
