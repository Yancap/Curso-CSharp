using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._4_Colecoes {
    public class Compras {
        string Produto;
        double Preco;
        public Compras(string produto, double preco) {
            Produto = produto;
            Preco = preco;
        }

        /*
             É Possivel sobreescrever esse método para ele comparar os valores de um 
             mesmo Objeto.
        */
        public override bool Equals(object? obj) {
            return obj is Compras compras &&
                   Produto == compras.Produto &&
                   Preco == compras.Preco;
        }
     /*
        GetHashCode >> Serve para comparar, de forma mais performática, Objetos, por meio 
        de um HashCode que é gerado a partir dos atributos desses objetos.
     */
        public override int GetHashCode() {
            return HashCode.Combine(Produto, Preco);
        }
        //Método gerado a partir do ( CTRL + . ) encima da Class

    }
    internal class IgualdadeEntreObjetos {
        public static void Main() {
            var p1 = new Compras("Caneta", 1);
            var p2 = new Compras("Caneta", 1);
            var copiaP1 = p1;
         /*
            Nas Comparações entre objetos, o que é comparado é a referenciu/local/espaço da memoria que o 
            Objeto foi armazenadoe não seus dados armazenados.
         */
            Console.WriteLine(p1 == p2); //False >> Locais diferentes na memoria
            Console.WriteLine(p1 == copiaP1); //True >> Mesmo local na memoria

            //Esse metodo sem subscrição também compara endereços de memoria
            Console.WriteLine(p1.Equals(p2));
        }
    }
}
