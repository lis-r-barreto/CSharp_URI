using System;
using System.Globalization;

namespace URI1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, reajuste, novoSalario;
            string reajustePercentual;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor >= 0.00 && valor <= 400.00) {
                reajuste = 0.15 * valor;
                reajustePercentual = "15 %";
                novoSalario = valor + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + reajustePercentual);
            }
            else if (valor > 400.00 && valor <= 800.00) {
                reajuste = 0.12 *valor;
                reajustePercentual = "12 %";
                novoSalario = valor + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + reajustePercentual);
            }
            else if (valor > 800.00 && valor <= 1200.00) {
                reajuste = 0.10 * valor;
                reajustePercentual = "10 %";
                novoSalario = valor + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + reajustePercentual);
            }
            else if (valor > 1200.00 && valor <= 2000.00) {
                reajuste = 0.07 * valor;
                reajustePercentual = "7 %";
                novoSalario = valor + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + reajustePercentual);
            }
            else {
                reajuste = 0.04 * valor;
                reajustePercentual = "4 %";
                novoSalario = valor + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + reajustePercentual);
            }
        }
    }
}