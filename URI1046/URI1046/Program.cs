using System;

namespace URI1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, fim, duracao;
            
            string[] vet = Console.ReadLine().Split();
            inicio = int.Parse(vet[0]);
            fim = int.Parse(vet[1]);
            
            if (inicio < fim) {
                duracao = fim - inicio;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
            else {
                duracao = 24 - inicio + fim;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
        }
    }
}
