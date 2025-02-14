﻿using System;

class Program
{
    static void Main()
    {
        double A = 0, B = 0;
        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Ввести A");
            Console.WriteLine("2. Ввести B");
            Console.WriteLine("3. Выполнить операцию '+'");
            Console.WriteLine("4. Выполнить операцию '-'");
            Console.WriteLine("5. Выполнить операцию '*'");
            Console.WriteLine("6. Выполнить операцию '/'");
            Console.WriteLine("7. Выйти");
            Console.Write("Выберите опцию (1-7): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите значение для A: ");
                    A = Convert.ToDouble(Console.ReadLine());
                    break;

                case "2":
                    Console.Write("Введите значение для B: ");
                    B = Convert.ToDouble(Console.ReadLine());
                    break;

                case "3":
                    Console.WriteLine($"Результат A + B: {A + B}");
                    break;

                case "4":
                    Console.WriteLine($"Результат A - B: {A - B}");
                    break;

                case "5":
                    Console.WriteLine($"Результат A * B: {A * B}");
                    break;

                case "6":
                    if (B != 0)
                        Console.WriteLine($"Результат A / B: {A / B}");
                    else
                        Console.WriteLine("Ошибка: деление на ноль.");
                    break;

                case "7":
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, выберите опцию от 1 до 7.");
                    break;
            }

            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}
