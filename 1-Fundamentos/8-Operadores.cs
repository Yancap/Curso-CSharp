using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp.Fundamentos {
    internal class Operadores {
        public static void Main() {
         // Operadores Aritméticos
            double total;
            total = 10 + 5;             //Soma
            total = 10 - 5;             //Subtração
            total = 10 * 5;             //Multiplicação
            total = 10 / 5;             //Divisão
            total = 10 % 2;             //Modulo
            total = Math.Pow(10, 2);    //Potenciação ---> Math.Pow(numero, elevado a potencia de)

         // ----------------------------------------------------------------------------------------------

         // Operadores Relacionais
            bool relacao;
            relacao = 10 > 5;   //Verdadeiro - Maior que
            relacao = 10 < 5;   //Falso - Menor que
            relacao = 10 == 5;  //Falso - Igual a 
            relacao = 10 != 5;  //Verdadeiro - Diferente a 
            relacao = 10 >= 5;  //Verdadeiro - Maior ou Igual a
            relacao = 10 < 5;   //Falso - Menor ou Igual a

         // ----------------------------------------------------------------------------------------------

         // Operadores Lógicos
            bool logico;
            logico = 10 > 5 && 5 < 10; // And = && 'e' / Verdadeiro && Verdadeiro = Verdadeiro
            logico = 10 > 5 || 5 > 10; // Or = || 'ou' / Verdadeiro || Falso = Verdadeiro
            logico = !(10 > 5); // Not = ! 'não' / !(Verdadeiro) = Falso

            //Xor (Ou Exclusivo) - ^
         /*
            Obrigatoriamente deve ter 1 Verdadeiro e 1 Falso para que resulte verdadeiro
            Se tiver 2 verdadeiros, resultado é falso
            Se tiver 2 Falsos, resultado é falso
         */
            logico = 10 > 5 ^ 5 < 10;    //Verdadeiro ^ Verdadeiro = Falso
            logico = 10 > 5 ^ 5 == 10;   //Verdadeiro ^ Falso = Verdadeiro
            logico = 10 == 5 ^ 5 > 10;   //Falso ^ Falso = Falso

            // ----------------------------------------------------------------------------------------------

         // Operadores de Atribuição

            var numero = 10; // Atribui 10
            numero += 5; // numero = numero + 5 >>> 15
            numero -= 10;  // numero = numero - 10 >>> 5
            numero *= 2;  // numero = numero * 2 >>> 10
            numero /= 2;  // numero = numero / 2 >>> 5

            numero++; // numero = numero + 1 >>> 6
            numero--; // numero = numero - 1 >>> 6
            

        }
    }
}
