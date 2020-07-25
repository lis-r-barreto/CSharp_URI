using System;

namespace URI1114
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int senhaDigitada, senhaCorreta;

            senhaDigitada = int.Parse(Console.ReadLine());
            senhaCorreta = 2002;

            while (senhaDigitada != senhaCorreta)
            {
                Console.WriteLine("Senha Invalida");
                senhaDigitada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
