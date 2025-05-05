using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma senha: ");
        string senha = Console.ReadLine();

        bool tamanhoMinimo = senha.Length >= 8;
        bool temMaiuscula = Regex.IsMatch(senha, "[A-Z]");
        bool temNumero = Regex.IsMatch(senha, "[0-9]");
        bool temEspecial = Regex.IsMatch(senha, "[!@#\$%\^&\*]");

        if (tamanhoMinimo && temMaiuscula && temNumero && temEspecial)
            Console.WriteLine("Senha forte.");
        else
        {
            Console.WriteLine("Senha fraca. Requisitos:");
            if (!tamanhoMinimo) Console.WriteLine("- Mínimo de 8 caracteres");
            if (!temMaiuscula) Console.WriteLine("- Pelo menos uma letra maiúscula");
            if (!temNumero) Console.WriteLine("- Pelo menos um número");
            if (!temEspecial) Console.WriteLine("- Pelo menos um caractere especial (!, @, #, etc)");
        }
    }
}