using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o seu peso em KG, Ex: 75.5");
        float peso = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe a sua altura em metros, Ex: 1.75");
        float altura = float.Parse(Console.ReadLine());

        float imc = peso / (altura * altura);
        float imcArredondado = (float)Math.Round(imc, 1);

        Console.Write("Seu IMC é: " + imcArredondado + ", ");

        if (imc < 18.5)
        {
            Console.WriteLine("você está abaixo do peso.");
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            Console.WriteLine("você está com o peso normal.");
        }
        else if (imc >= 25 && imc <= 29.9)
        {
            Console.WriteLine("você está com sobrepeso.");
        }
        else
        {
            Console.WriteLine("você está com obesidade.");
        }
    }
}
