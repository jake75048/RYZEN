    using System;
    using System.ComponentModel.Design;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("====================Qual o maior ==================");
        
            Console.WriteLine("\nDigite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());


            if (num1 > num2)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("_______________________________________________");
                Console.WriteLine("O maior número é: " + num1);
            }
            else if (num1 < num2)
       
                {
           
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("_______________________________________________");
                Console.WriteLine("O maior número é: " + num2);
   
            }



            else
             {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("_______________________________________________");
                Console.WriteLine("os numeros são iguais ");
            }    


            Console.WriteLine("_______________________________________________");
            Console.ResetColor(); 
        }
    }