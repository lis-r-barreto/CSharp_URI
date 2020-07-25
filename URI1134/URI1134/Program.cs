using System;

namespace URI1134
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int x = int.Parse(Console.ReadLine());

            while (x != 4)
            {
                switch (x) {
                    case 1:
                        alcool += 1;
                        break;
                    case 2:
                        gasolina += 1;
                        break;
                    case 3:
                        diesel += 1;
                        break;
                }

                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
