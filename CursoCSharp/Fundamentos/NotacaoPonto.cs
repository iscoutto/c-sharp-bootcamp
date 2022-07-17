using System;
namespace CursoCSharp.Fundamentos
{
    public class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "hello".ToUpper().Insert(3, " Mundo!")
                .Replace("Mundo!", "World!");
            Console.WriteLine(saudacao);

            Console.WriteLine("teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
            // '?' = navegação segura, só sera acessado se o valor estiver preenchido
        }
    }
}

