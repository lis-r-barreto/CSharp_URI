using System;

namespace URI1078
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i ++)
            {
                int resultado = i * N;
                Console.WriteLine(i + " x " + N + " = " + resultado);
            }
        }
    }
}
