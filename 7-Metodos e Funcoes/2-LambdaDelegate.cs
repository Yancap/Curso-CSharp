using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._7_Metodos_e_Funcoes {



    internal class LambdaDelegate {
    /*
        Delegate: são como 'Interfaces' para funções anonimas, arrow functions ou Lambdas. Onde
        é definido a 'Assinatura/Modelo' da Função, declarando seu tipo de Retorno e os parametros e seus tipos.
    */

        delegate double Operacao(double x, double y);
        static double Mult(double a, double b) {
            return a * b;
        }
        public static void Main() {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;

            /* O 'delegate' permite associações com Métodos que possuem o mesmo tipo de retorno,
               mesma quantidade de parametros com os mesmos tipos */
            Operacao mult = Mult;

            Console.WriteLine(sum(10, 5));
            Console.WriteLine(sub(8, 2));
            Console.WriteLine(mult(5, 5));
        }
    }
}
