using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._2_Estruturas_de_Controle {
    internal class Looping {
        public static void Main() {

         // WHILE
            var contador = 0;
            while (contador < 10) {
                Console.WriteLine("Contador: " + contador);
                contador++;
            }

         // DO - WHILE
            var numero = 0;
            do {
                Console.WriteLine("Numero: " + numero);
                numero++;
                if (numero == 9) {
                    break;
                }
            } while (numero < 10);

         // FOR
            for (int index = 0; index < 10; index++) {
                if (index == 5) {
                    Console.WriteLine("Metade do indice");
                    continue;
                }
                Console.WriteLine("Indice: " + index);
            }

         // FOR EACH
         /*
            Pecorre os valores de uma String ou Array
            e retorna esse valor de forma individual 
         */
            var palavra = "Olá Mundo!";
            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }

            var pessoas = new string[] { "Yan", "Gabriel", "Ferreira" };
            foreach(string nome in pessoas) {
                Console.WriteLine(nome);
            }
        }
    }
}
