using System;

namespace URI1132
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n1, n2;
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            int menor = n1;
            int maior = n2;

            if (n1 > n2)
            {
                menor = n2;
                maior = n1;
            }

            int soma = 0;
            for (int i = menor; i <= maior; i++)
            {
                if (i % 13 != 0)
                {
                    soma += i;
                }

            }
            Console.WriteLine(soma);
        }
    }
}
