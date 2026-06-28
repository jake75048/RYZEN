<<<<<<< HEAD
﻿Console.WriteLine("Hello, World!");
=======
﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("======================= Média =====================");
        Console.Write("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;

        if (media >= 7)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("              \n    Aprovado");
            Console.ResetColor();
        }
        else if (media >= 5)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                \n  Recuperação");
            Console.ResetColor();


        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("               \n    Reprovado");
            Console.ResetColor();
        }
    }
}
>>>>>>> 3c064890a614dd8880e4743bf6feafbc2b686a23
