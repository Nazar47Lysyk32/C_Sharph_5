using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть український номер телефону:");
        string phoneNumber = Console.ReadLine();

        // Регулярний вираз для перевірки українського номера телефону
        string pattern = @"^\+?38(0\d{2}|[3-9]\d{1})\d{7}$";

        // Перевірка за допомогою регулярного виразу
        if (Regex.IsMatch(phoneNumber, pattern))
        {
            Console.WriteLine("Введено коректний український номер телефону.");
        }
        else
        {
            Console.WriteLine("Некоректний український номер телефону.");
        }
    }
}
