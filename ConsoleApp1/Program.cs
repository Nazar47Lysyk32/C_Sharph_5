using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть електронну адресу:");
        string email = Console.ReadLine();

        // Регулярний вираз для перевірки формату електронної пошти з доменом itstep.ua
        string pattern = @"^[a-zA-Z0-9._%+-]+@itstep\.ua$";

        // Перевірка за допомогою регулярного виразу
        if (Regex.IsMatch(email, pattern))
        {
            Console.WriteLine("Електронна адреса має домен itstep.ua.");
        }
        else
        {
            Console.WriteLine("Електронна адреса не має домену itstep.ua.");
        }
    }
}
