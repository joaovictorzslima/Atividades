using System;
using System.Collections.Generic;

//10. Lista de Tarefas (To-Do List)
//Permita que o usuário adicione tarefas a uma lista e, ao final, mostre todas as tarefas inseridas. Use List<string> e ofereça uma opção para marcar tarefas como concluídas.

class Program
{
    static void Main(string[] args){

        
        List<string> tarefas = new List<string>();
        List<string> tarefasConcluidas = new List<string>();

        
        
        while (true){

            Console.WriteLine("\nDigite o número para selecionar uma das seguintes opções ou digite 'sair' para finalizar. ");
            Console.WriteLine("\n1 - Adicione uma tarefa à lista. ");
            Console.WriteLine("\n2 - Concluir uma tarefa. ");
            Console.WriteLine("\n3 - Mostrar a lista de tarefas. ");            
  
            string comando = Console.ReadLine();

            switch (comando){
                case "sair":
                return; 

                case "1":
                Console.WriteLine("\nDigite uma tarefa para adicionar à lista:");
                string tarefa = Console.ReadLine();
                tarefas.Add(tarefa);
                break;

                case "2":

                if (tarefas.Count == 0){
                    Console.WriteLine("\nNão há tarefas para marcar como concluídas.");
                    break;
                } else {
                    Console.WriteLine("\nInforme qual tarefa você concluiu: ");
                    string input = Console.ReadLine();
                        if (int.TryParse(input, out int numeroTarefa)){                    
                            string tarefasConcluida = tarefas[numeroTarefa - 1];
                            tarefasConcluidas.Add(tarefasConcluida);
                            tarefas.RemoveAt(numeroTarefa - 1);
                            Console.WriteLine("\nTarefa " + tarefasConcluida + " foi marcada como concluída.");
                } else {
                    Console.WriteLine("\nPor favor, informe um número válido.");
                };
                }
                break;

                case "3":
                Console.WriteLine("\nTarefas inseridas: ");
                foreach (string t in tarefas){
                    Console.WriteLine(t);
                }

                Console.WriteLine("\nTarefas concluídas:");
                foreach (string t in tarefasConcluidas){
                    Console.WriteLine(t);
                }
                break;

                default:
                    Console.WriteLine("\nOpção inválida, tente novamente.");
                    break;
        }
    }
}

}
