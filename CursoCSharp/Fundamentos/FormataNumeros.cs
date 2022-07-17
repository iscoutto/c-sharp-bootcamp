using System;
using System.Globalization;
namespace CursoCSharp.Fundamentos
{
    public class FormataNumeros
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));    // arredonda para uma casa decimal
            Console.WriteLine(valor.ToString("C"));     // transforma para valor monetário
            Console.WriteLine(valor.ToString("P"));     // transforma em percentual
            Console.WriteLine(valor.ToString("#.##"));  // transforma para o formato das '#

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura));   // transforma para o formato monetário brasileiro

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // acrescenta zeros a esquerda para ter 10 números 
        }
    }
}

