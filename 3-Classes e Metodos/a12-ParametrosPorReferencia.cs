using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._3_Classes_e_Metodos {
    internal class a12_ParametrosPorReferencia {
     //  Por padrão, uma função não tem a capacidade de modificar valores de variaveis "globais"

      /*
          Entretanto, por meio da palavra reservada 'ref', esssa função tem a capacidade de alterar
          o valor global da variavel que for passada como parametro.
      */
        public static void AlterarRef(ref int numero) {
            numero = numero + 1000;
            //Alterações por referencia podem gerar Bugs!!!
        }

      /*
          O 'out' não permite receber o valor que está na variavel, apenas o seu nome. 
          E essa variavel é inicializada dentro da função e seu valor também é adicionado dentro da função. 
          Ou Seja, por meio do 'out', a função pode criar variaveis com valores determinados
      */
        public static void AlterarOut(out int numero) {
            numero =  15;
            //Estrategia mais interessante, pois não gera nenhum efeito colateral!!!
        }
        public static void Main() {
            int a = 3;

            //passa a referencia da variavel na função e modifica seu valor
            AlterarRef(ref a);
            Console.WriteLine(a);

            //int b = 2; >> Errado
            AlterarOut(out int b); //Variavel 'b' criada dentro do função
            Console.WriteLine(b);
        }
    }
}
