using System;

namespace URI1066
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n;
            int qtdPares = 0;
            int qtdImpares = 0;
            int qtdPositivos = 0;
            int qtdNegativos = 0;

            for(int i = 0; i < 5; i++)
            {
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    qtdPares += 1;
                }
                else
                {
                    qtdImpares += 1;
                }

                if (n > 0)
                {
                    qtdPositivos += 1;
                }
                else if (n < 0)
                {
                    qtdNegativos += 1;
                }
            }

            Console.WriteLine(qtdPares + " valor(es) par(es)");
            Console.WriteLine(qtdImpares + " valor(es) impar(es)");
            Console.WriteLine(qtdPositivos + " valor(es) positivo(s)");
            Console.WriteLine(qtdNegativos + " valor(es) negativo(s)");
        }
    }
}
