using System;
using System.Drawing;

class Program
{
    static void Main()
    {

        Console.Write("=================== De maior ou De menor =================== ");

        Console.WriteLine("\nDigite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Maior de idade");
            Console.ResetColor();

        }
       
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Menor de idade");
            Console.ResetColor();

        }
    }
}