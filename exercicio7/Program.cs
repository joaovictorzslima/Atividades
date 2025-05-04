using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int somaPares = 0;

        // Lê os 10 números
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Soma apenas os pares
        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] % 2 == 0) // Verifica se é par
            {
                somaPares += numeros[i];
            }
        }

        Console.WriteLine($"\nA soma dos números pares é: {somaPares}");
    }
}