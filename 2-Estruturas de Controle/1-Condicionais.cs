using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp.Estruturas_de_Controle {
    internal class Condicionais {
        public static void Main() {
         // IF - ELSE
         /*
            if( condição 1 ) {
                codigos se condição 1 for verdadeira
            } else if ( condição 2 ){
                codigos se condição 1 for falsa e condição 2 for verdadeira
            } else {
                codigos se as outras condições forem falsas
            }
         */
            Console.WriteLine("Digite a nota do aluno");
            int.TryParse(Console.ReadLine(), out int nota);
            if (nota >= 6) {
                Console.WriteLine("Aprovado");
            } else if (nota >= 4) {
                Console.WriteLine("Recuperação");
            } else {
                Console.WriteLine("Reprovado");
            }
            //Ou
            if (nota >= 6) Console.WriteLine("Aprovado");
            else if (nota >= 4) Console.WriteLine("Recuperação");
            else Console.WriteLine("Reprovado");

         // SWITCH CASE
         /*
            switch (valor) {
                case 0:
                    codigo caso o valor for 0;
                    break;
                case 1:
                case 2:
                    codigo caso o valor for 1 ou 2;
                    break;
                default:
                    Codigo caso não tenham atendido as sentenças;
                    break;
            }
         */
            Console.WriteLine("Avalie meu comportamento");
            int.TryParse(Console.ReadLine(), out int comportamento);

            switch (comportamento) {
                case 0:
                    Console.WriteLine("`Pessimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3: Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5: { 
                    Console.WriteLine("Otimo");
                    break;
                 }
                    
                default:
                    Console.WriteLine("Nota Invalida");
                    break;
            }
        }
    }
}
