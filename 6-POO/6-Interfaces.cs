using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._6_POO {
/*
    Interfaces são Modelos de Classes onde é definido a Estrutura de uma Classe, os Atributos e seus tipos e
    os Métodos e seus tipos de parametros e retornos. Tudo definido dentro de uma 'Interface' é Abstrato, ou seja
    não pode ser implementado dentro da Interface, apenas nas Classes.
*/
    interface OperacaoBin {
        int Operacao(int a, int b);
       
    }

    interface VerificaSeSomou {
        bool Somou(int a);
    }
    //Implementação de multiplas Interfaces
    class Soma : OperacaoBin, VerificaSeSomou {
        public int Operacao(int a, int b) {
            return a + b;
        }
        public bool Somou(int a) {
            return a > 0 ? true : false;
        }
    }
    class Subtracao : OperacaoBin {
        public int Operacao(int a, int b) {
            return a - b;
        }
    }
    internal class Interfaces {
        public static void main() {

        }
    }
}
