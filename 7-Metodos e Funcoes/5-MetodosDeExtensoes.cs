using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._7_Metodos_e_Funcoes {
/*
    No C# é possivel extender Métodos e Tipos de Dados pré-existentes, permitindo
    seu uso como se fosse Funções Nativas da API do C#
*/

    //Criar a Classe Estática
    public static class ExtensoesInteiros {

        //Método Estático com o parametro 'this int num' sendo o valor que terá o método declarado
        public static int Soma(this int num, int outroNum) {
            return num += outroNum;
        }
        public static double SomaReal(this double num, double outroNum) {
            return num += outroNum;
        }
    }
    internal class MetodosDeExtensoes {
        public static void Main() {
            int numeroInteiro = 5;
            double numeroReal = 5.25;

            //Método 'Soma' extendido para o tipo "int"
            Console.WriteLine(numeroInteiro.Soma(10));
            Console.WriteLine(10.Soma(2));

            //Método 'SomaReal' extendido para o tipo "double"
            Console.WriteLine(numeroReal.SomaReal(1.5));
            Console.WriteLine(0.5.SomaReal(2));
        }   

    }
}
