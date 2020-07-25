using System;

namespace URI1131
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int vitoriasInter = 0;
            int vitoriasGremio = 0;
            int empates = 0;
            int novoGrenal = 1;

            while (novoGrenal == 1)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int golsInter = int.Parse(vet[0]);
                int golsGremio = int.Parse(vet[1]);

                if (golsInter > golsGremio)
                {
                    vitoriasInter += 1;
                }

                else if (golsGremio > golsInter)
                {
                    vitoriasGremio += 1;
                }

                else
                {
                    empates += 1;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());
            }

            int total = vitoriasGremio+ vitoriasInter + empates;

            Console.WriteLine(total + " grenais");
            Console.WriteLine("Inter:" + vitoriasInter);
            Console.WriteLine("Gremio:" + vitoriasGremio);
            Console.WriteLine("Empates:" + empates);

            if (vitoriasInter > vitoriasGremio) {
                Console.WriteLine("Inter venceu mais");
            }

            else if (vitoriasGremio > vitoriasInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }

            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
