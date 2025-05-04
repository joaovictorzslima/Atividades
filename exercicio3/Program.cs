using System;

class Program
{
    static void Main()
    {
        int opcao = 0;

        while (opcao != 3)
        {
            Console.WriteLine("\nConversor de Temperaturas");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");
            
            // Lê a opção do usuário e converte para inteiro
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a temperatura em Celsius: ");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine($"{celsius}°C equivale a {fahrenheit}°F");
                    break;

                case 2:
                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    double fah = double.Parse(Console.ReadLine());
                    double cel = (fah - 32) * 5 / 9;
                    Console.WriteLine($"{fah}°F equivale a {cel}°C");
                    break;

                case 3:
                    Console.WriteLine("Saindo do programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
