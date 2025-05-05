using System;

class Program
{
    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("\nConversor de Temperaturas");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a temperatura em Celsius: ");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine($"Resultado: {fahrenheit:F2} °F");
                    break;
                case 2:
                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    fahrenheit = double.Parse(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"Resultado: {celsius:F2} °C");
                    break;
                case 3:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (opcao != 3);
    }
}