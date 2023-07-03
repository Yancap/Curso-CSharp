using System;

namespace iniciando_csharp.Fundamentos {
    internal class TiposDeDados {
        public static void execute() {
         // Declaração de Variaveis e Constantes
            var variavel = "essa é minha Variavel";
            const string constante = "essa é minha Constante";
            Console.WriteLine(variavel);
            Console.WriteLine(constante);

         /*
                C# é uma linguagem fortemente tipada, ou seja, ela necessita das
                declarações de tipos para suas variaveis e parametros para funções
         */

         // TIPOS DE DADOS INTERNOS

            bool booleano = true || false;

         // Numericos Inteiros
            sbyte numeroN = -127; // 1 Byte === -127 até 127
            byte numeroP = 255; // 1 Byte === 0 até 255
            short numeroM = 32000; // 2 Bytes === -32000 até 32000 
            int inteiro = 200000; // Mais Usados! 4 Byte === -2,147,483,648 até 2,147,483,647
            long numeroXL = 4000000; // 8 Bytes === -9,223,372,036,854,775,808 até 9,223,372,036,854,775,807 

         /*
               o sufixo 'u' antes das declarações dos inteiros
               significa que eles não pode ser negativos 
         */

            uint numeroPositivo = 1000; //4 Byte === 0 até + 4Bilhões
            ushort milhoes = 1_000; // O "_" pode ser usado para facilitar a escrita de numeros grandes
            
         // Numericos Float
            float realF = 1.25f; //Precisa do Sufixo 'f' no final da atribuição
            double realD = 1.2250250; //Armazena o dobro do float
            decimal realDXL = 1.214532351243432m; // Armazena numeros gigantescos

         // Strings e Char
            char letra = 'a'; //Armazena uma letra, utiliza aspas simples ' '
            string palavra = "olá mundo"; //Armazena palavras, utiliza aspas duplas " "
        }

    }
}
