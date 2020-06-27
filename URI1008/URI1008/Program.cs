using System;
using System.Globalization;

namespace URI1008
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numFuncionario, numHoras;
            double valorHora, salario;

            numFuncionario = int.Parse(Console.ReadLine());
            numHoras = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * numHoras;

            Console.WriteLine("NUMBER = " + numFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}