using System;

namespace algoritmoimparpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int P, i, n;

            Console.WriteLine("***Algorítmo que diz se o número digitado é par ou ímpar***");

            Console.Write("\nDigite a quantidade de números que irá consultar: ");
            P = int.Parse(Console.ReadLine());

            for (i = 0; i <= P; i++)
            {
                Console.Write("\n\nDigite um número: ");
                n = int.Parse(Console.ReadLine());
                i = n % 2;
                if (i == 0)
                    Console.Write("Par");
                else
                    Console.Write("Impar");
            }
            Console.ReadKey();
        }
    }
}