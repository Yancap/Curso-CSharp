using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._3_Classes_e_Metodos {
    internal class DesafioAtributo {
        int a = 10;
        public static void Main() {
            //Acessar a variavel 'a'
            var Desafio = new DesafioAtributo();
            Console.WriteLine(Desafio.a);
        }
    }
}
