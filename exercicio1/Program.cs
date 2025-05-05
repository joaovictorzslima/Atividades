using System;
using System.Text.RegularExpressions;

class ValidadorDeSenha
{
    static void Main()
    {
        string senha;
        string resultado;

        do
        {
            Console.Write("Digite sua senha para validar: ");
            senha = Console.ReadLine();
            resultado = ValidarSenha(senha);
            Console.WriteLine(resultado);
        }
        while (resultado != "Senha forte! ✅");
    }

    static string ValidarSenha(string senha)
    {
        if (senha.Length < 8)
            return "A senha deve ter pelo menos 8 caracteres.";
        if (!Regex.IsMatch(senha, "[A-Z]"))
            return "A senha deve conter pelo menos uma letra maiúscula.";
        if (!Regex.IsMatch(senha, "[0-9]"))
            return "A senha deve conter pelo menos um número.";
        if (!Regex.IsMatch(senha, "[!@#$%^&*()\\-_=+]"))
            return "A senha deve conter pelo menos um caractere especial (!@#$%^&*()-_+=).";

        return "Senha forte! ✅";
    }
}