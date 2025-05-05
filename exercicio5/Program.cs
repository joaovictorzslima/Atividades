using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra ou frase: ");
        string input = Console.ReadLine();

        // Remove espaços e converte para minúsculo
        string textoLimpo = new string(input
            .Where(c => !char.IsWhiteSpace(c))
            .ToArray())
            .ToLower();

        // Inverte o texto
        char[] arrayChar = textoLimpo.ToCharArray();
        Array.Reverse(arrayChar);
        string textoInvertido = new string(arrayChar);

        // Verifica se é palíndromo
        if (textoLimpo == textoInvertido)
        {
            Console.WriteLine("É um palíndromo!");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo.");
        }
    }
}