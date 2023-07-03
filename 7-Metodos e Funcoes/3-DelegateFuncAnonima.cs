using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._7_Metodos_e_Funcoes {
    internal class DelegateFuncAnonima {
        delegate string StringOperacao(string str);

        public static void Main() {

            /* É uma outra forma de declarar função anonima, nesse caso
                declara a assinatura do 'delegate', declara a variavel e associa com
                uma função, onde o parametro e seu tipo deve ser declarado */
            StringOperacao inverterFrase = delegate (string str) {
                char[] charArray = str.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine(inverterFrase("Tá Chocando?"));
        }
    }
}
