using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._3_Classes_e_Metodos {
    internal class ValorPadrão {
        //Determina o valor padrão de um parametro de uma função
        public static int Somar(int a = 1, int b = 1) {
            return a + b;
        }
        public static void Main() {
            Console.WriteLine(Somar(10));
            Console.WriteLine(Somar(20, 5));
            //Parametro Nomeado
            Console.WriteLine(Somar(b: 7));
        }
    }
}
