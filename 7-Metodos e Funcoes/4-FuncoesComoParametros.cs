using iniciando_csharp._6_POO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._7_Metodos_e_Funcoes {
    
    internal class FuncoesComoParametros {
        delegate int Operacao(int a, int b);
        static int Soma(int a, int b) {
            return a + b;
        }

        //Passando Delegates
        static int CalcDelegate(Operacao op, int a, int b) {
            var result = op(a, b);
            return result;
        }
        //Passando Funcs
        static int CalcFunction(Func<int, int, int> op, int b, int a) {
            return op(b, a);
        }

        static void CalcAction(Action<int,int> op, int a, int b) {
            op(a, b);
        }
        public static void Main() {
            //Passando uma função como parametro
            CalcDelegate(Soma, 10, 5);
            CalcFunction(Soma, 5, 5);
            

            //Passando uma Lambda como parametro
            CalcDelegate((int a, int b) => a - b, 10, 15);
            CalcFunction((int x, int y) => x - y, 15, 5);

            CalcAction((a, b) => {
                Console.WriteLine("Resultado: " + Soma(a, b));
            }, 15, 20);

            //Passando uma Função Anonima como parametro
            Operacao mult = (int x, int y) => x * y;
            CalcDelegate(mult, 20, 5);
            // CalcFunction(mult, 20, 5); >> Não é possivel
        }
    }
}
