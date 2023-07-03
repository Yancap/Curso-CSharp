using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._9_Metodos_de_Dados {
    internal class MetodosDeString {
        public static void Main() {
            var frase = "Essa é minha frase de teste";

            //Length > Propriedade que conta a quantidade de letras em uma string
            Console.WriteLine(frase.Length);

            //Concat > Propriedade usada para concatenar duas ou mais Strings
            var fraseConcat = string.Concat(frase, " Concatenei");
            Console.WriteLine(fraseConcat);
            Console.WriteLine("----------------------------------------------------------");

            /* COMPARAÇÃO */

            //Equals > Método que é usado para comparar duas strings em termos de conteúdo.
            Console.WriteLine("Equals: " + string.Equals("Olá", "Olá"));
            Console.WriteLine("Equals: " + String.Equals(frase, "Olá"));
            Console.WriteLine("Equals: " + frase.Equals(frase));

            //Compare > Compara duas strings e retorna um valor inteiro indicando se uma string é menor, igual ou maior que a outra
            Console.WriteLine("Compare: " + string.Compare("Olá", "Olá")); // 0 > significa que é Igual 
            Console.WriteLine("Compare: " + String.Compare("Olá", frase)); // 1 > significa que é diferente e o da direita é maior
            Console.WriteLine("Compare: " + string.Compare(frase, "Olá")); // -1 > significa que é diferente e da esquerda é maior
            Console.WriteLine("----------------------------------------------------------");

            /* BUSCA */

            //Contains > Verifica se uma determinada sequência de caracteres está presente em uma string.
            Console.WriteLine("Contains: " + frase.Contains("Essa")); //true
            Console.WriteLine("Contains: " + frase.Contains("Olá")); //false
            Console.WriteLine("Contains: " + frase.Contains("te")); //true

            //IndexOf / LastIndexOf > retornam a posição da primeira/ultima ocorrência de uma sequência de caracteres em uma string
            Console.WriteLine("IndexOf: " + frase.IndexOf("e"));
            Console.WriteLine("LastIndexOf: " + frase.LastIndexOf("e"));
            Console.WriteLine("----------------------------------------------------------");

            /* DIVISÃO / ARRAY */

            //Substring(<iniical>,<final>) > é usado para extrair uma parte de uma string com base em uma posição inicial e um comprimento.
            Console.WriteLine("Substring: " + frase.Substring(5)); //A partir do indice 5
            Console.WriteLine("Substringf: " + frase.Substring(2, 10)); //A partir do indice 2 até o indice 10

            //Split > é usado para transforma uma string em array a partir do um delimitador
            foreach(var c in frase.Split(" ")) {
                Console.WriteLine("Splited: "+ c);
            }
            Console.WriteLine("----------------------------------------------------------");
            foreach (var c in "arquivo-de-teste".Split("-")) {
                Console.WriteLine("Splited: " + c);
            }
            Console.WriteLine("----------------------------------------------------------");

            /* CASE */
            Console.WriteLine("Frase Minuscula: " + "EsSa é FrASE".ToLower());
            Console.WriteLine("Frase Maiuscula: " + "essa é frase".ToUpper());
            Console.WriteLine("----------------------------------------------------------");

            /* REPLACE */

            // Replace > substitui todas as ocorrências de uma sequência de caracteres por outra sequência de caracteres em uma string.
            Console.WriteLine("Frase Original: " + frase);
            Console.WriteLine("Frase Replace: " + frase.Replace("frase", "historia"));
            Console.WriteLine("----------------------------------------------------------");

            /* REMOVE */

            //Remove >> Serve para remover os caracteres de uma determinada string.
            Console.WriteLine("Removed: " + frase.Remove(5));
        }
    }
}
