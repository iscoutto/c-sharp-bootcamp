using System;
using System.Globalization;
namespace CursoCSharp.Fundamentos
{
    public class LeDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é seu salário?");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            Console.WriteLine($"\n{nome}, {idade} anos, salário de R${salario}");
        }
    }
}