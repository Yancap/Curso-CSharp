using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._3_Classes_e_Metodos {
    /*
        A Diferença entre o STRUCT e a CLASS

        STRUCT: Programação Funcional, e suas atribuições são por VALOR, ou seja, qualquer modificação do valor
        da instancia original não modificará o valor da CÓPIA da instancia, pois
    não aponta para o mesmo local de memoria

        CLASS: Programação Orientada a Objetos, e suas atribuições são por REFERENCIA, ou seja, qualquer modificação do valor
        da instancia original modificará o valor da CÓPIA dessa instancia, já que aponta para o mesmo local de memoria

    */
    public struct StructPonto {
        public int X;
        public int Y;
    }
    public class ClassPonto {
        public int X;
        public int Y;
    }
    internal class StructVsClass {
        public static void Main() {

            StructPonto ponto1 = new StructPonto { X = 1, Y = 3 };
            StructPonto copiaPonto1 = ponto1; //Atribuição por VALOR!!!

            ponto1.X = 3;

            //A Alteração do valor da instancia original não altera o valor da cópia
            Console.WriteLine("Ponto 1 X: " + ponto1.X);
            Console.WriteLine("Cópia do Ponto 1 X: " + copiaPonto1.X);

         // --------------------------------------------------------------------------

            ClassPonto ponto2 = new ClassPonto { X = 2, Y = 4 };
            ClassPonto copiaPonto2 = ponto2; //Atribuição por REFERENCIA!!!

            ponto2.X = 3;

            //A Alteração do valor da instancia original alterou o valor da cópia
            Console.WriteLine("Ponto 2 X: " + ponto2.X);
            Console.WriteLine("Cópia do Ponto 2 X: " + copiaPonto2.X);

        }

    }
}
