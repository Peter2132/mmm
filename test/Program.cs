using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using test;

class Program
{
    static void Main()
    {
        do
        {
            Console.Write("Введите свое имя: ");
            string userName = Console.ReadLine();

            Test.StartTest(userName);

            Console.WriteLine("Нажмите Enter, чтобы перезапустить тест");
        } while (Console.ReadKey().Key == ConsoleKey.Enter);
    }
}