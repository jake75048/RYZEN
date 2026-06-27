using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("======================= Tabuada =====================");
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        for (int count = 1; count <= 10; count++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n");
            Console.WriteLine(  numero + " x " + count + " = " + (numero * count));
            Console.ResetColor();

        }
    }
}