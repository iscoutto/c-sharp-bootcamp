using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variáveis - Fundamentos", Variaveis.Executar},
                {"Notação ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lê dados - Fundamentos", LeDados.Executar},
                {"Formata números - Fundamentos", FormataNumeros.Executar},
            });
             
            central.SelecionarEExecutar();
        }
    }
}