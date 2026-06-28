using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("======================= Par ou Impar =====================");
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" \n Número par");
            Console.ResetColor();

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" \n Número ímpar");
            Console.ResetColor();



        }
    }
}