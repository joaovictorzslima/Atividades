using System;

//9. Jogo da Adivinhação
//Gere um número aleatório entre 1 e 100. Peça que o usuário tente adivinhar. Após cada tentativa, informe se o número é maior ou menor. Conte o número de tentativas.

class Program
{
    static void Main(string[] args){

        int numeroAleatorio = new Random().Next(1,100);        
        int quantidadeTentativas = 0;
        
        while (true){
  
            Console.WriteLine("Tente adivinhar qual número aleatório entre 1 e 100 foi gerado: ");
            int numeroTentativa = int.Parse(Console.ReadLine());
            quantidadeTentativas++; 

            if (numeroAleatorio == numeroTentativa){
            Console.WriteLine("Você acertou! O número gerado foi: " + numeroTentativa + ".");
            Console.WriteLine("\nNúmero total de tentativas: " + quantidadeTentativas + ".");
            break; 
            }   
                    
                else if (numeroAleatorio > numeroTentativa){
                Console.WriteLine("O número gerado é maior que a sua tentativa.");
                }
                    else {
                    Console.WriteLine("O número gerado é menor que a sua tentativa.");
                    }
        }
    }
}
