using System;

namespace URI1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, minutoInicial, horaFinal, minutoFinal, instanteInicial, instanteFinal, duracao, horas, minutos;

            string[] vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            minutoInicial = int.Parse(vet[1]);
            horaFinal = int.Parse(vet[2]);
            minutoFinal = int.Parse(vet[3]);

            instanteInicial = horaInicial * 60 + minutoInicial;
            instanteFinal = horaFinal * 60 + minutoFinal;

            if (instanteFinal > instanteInicial) {
                duracao = instanteFinal - instanteInicial;
            }
            else {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            horas = duracao / 60;
            minutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + horas + " HORA(S) E " + minutos + " MINUTO(S)");
        }
    }
}
