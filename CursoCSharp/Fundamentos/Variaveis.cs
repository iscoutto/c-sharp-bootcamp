using System;
namespace CursoCSharp.Fundamentos
{
    public class Variaveis
    {
        public static void Executar()
        {
            // area da circuferencia
            double raio = 4.5;
            const double pi = 3.14;

            raio = 5.5;
            // pi = 3.1415;

            double area = pi * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine($"Área é {area}");

            // tipos internos
            bool chovendo = true;
            Console.WriteLine($"Está chovendo {chovendo}");

            byte idade = 20;

            sbyte sbMin = sbyte.MinValue;   // com negativo
            sbyte sbMax = sbyte.MaxValue;

            short shMin = short.MinValue;   // com negativo
            short shMax = short.MaxValue;

            int inMin = int.MinValue;   // com negativo
            int inMax = int.MaxValue;

            uint uMin = uint.MinValue;
            uint uMax = uint.MaxValue;

            long lMin = long.MinValue;  // com negativo
            long lMax = long.MaxValue;

            ulong ulMin = ulong.MinValue;
            ulong ulMax = ulong.MaxValue;

            float flMin = float.MinValue;   // com negativo
            float flMax = float.MaxValue;

            double dbMin = double.MinValue; // com negativo
            double dbMax = double.MaxValue;

            // usado para números astronomicos
            decimal dcMin = decimal.MinValue;   // com negativo
            decimal dcMax = decimal.MaxValue;

            char letra = 'a';

            string texto = "texto";

            /* byte = 8 bits
             * short = 2 bytes
             * int = 4 bytes
             * long = 8 bytes 
             */
        }
    }
}

