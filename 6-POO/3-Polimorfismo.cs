using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._6_POO {

    //Adição de uma Classe Pai para representar o Polimorfismo
    public class Comida {
        public double Peso;
        public Comida(double peso) {
            this.Peso = peso;
        }
        public Comida() { }
    }

    public class Feijao : Comida {
    }

    public class Arroz : Comida {
    }

    public class Carne : Comida {
    }

    public class Pessoa {
        public double Peso;

    /*
        Ao invés de ter 3 métodos para cada tipo de Objeto, por meio do
        POLIMORFISMO, é possivel ter um método unico que lida com as heranças de
        uma Classe Pai!

        public void Comer(Feijao feijao) {
            Peso += feijao.Peso;
        }
        public void Comer(Arroz arroz) {
            Peso += arroz.Peso;
        }
        public void Comer(Carne carne) {
            Peso += carne.Peso;
        }
    */
        
        //Método único capaz de lidar com uma mesma Classe assumindo diferentes formas - POLIMORFISMO.
        public void Comer(Comida comida) {
            Peso += comida.Peso;
        }
    }
    class Polimorfismo {
        public static void Main() {
            var feijao = new Feijao();
            feijao.Peso = 0.3;
            var arroz = new Arroz();
            arroz.Peso = 0.25;
            var carne = new Carne();
            carne.Peso = 0.3;

            var cliente = new Pessoa();
            cliente.Comer(carne);
            cliente.Comer(feijao);
            cliente.Comer(arroz);
        }
    }
}
