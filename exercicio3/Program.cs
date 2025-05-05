using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("Número inválido.");
            return;
        }

        int resultado = 1, i = 1;
        while (i <= numero)
        {
            resultado *= i;
            i++;
        }

        Console.WriteLine($"Fatorial de {numero} é {resultado}");
    }
}