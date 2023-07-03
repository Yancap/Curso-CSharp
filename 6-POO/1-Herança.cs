using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._6_POO {
    public class Carro {
     //Encapsulando o atributo para ser acessado somente dentro da Classe e suas Heranças
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }
        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0){
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }
        //'virtual' >> significa que o metodo pode ser SOBRESCRITO   
        public virtual int Acelerar() {
           return AlterarVelocidade(5);
        }
        public int Frear() {
            return AlterarVelocidade(-5);
        }
    }

    //Exemplo de Herança > public class ClasseFilha : ClassePai {...}
    public class Uno : Carro {
     /*
        Por padrão, uma Classe pai deve ter um construtor padrão para se usado para as Classes Filhas
        Entretanto, nesse caso, a Classe pai não possui, então deve iniciar o construtor padrão de Pai
        para instanciar a Classe Filha
     */
        public Uno() : base(200) { //Iniciando o Construtor da Classe Pai por meio da palavra "base(<params>)"

        }
    }

    public class Ferrari: Carro {
        public Ferrari() : base(400) {

        }
        //Sobreescrevendo um Método da Classe Pai
        public override int Acelerar() {
            return AlterarVelocidade(15);
        }

        //Oculta e força a Sobrescrição de um Metodo da Classe Pai
        public new int Frear() {
            return AlterarVelocidade(-15);
        }

     /*
        ATENÇÃO: A Diferença entre o 'override' e 'new' está no Polimorfismo.
     
        Quando um objeto que tem o Tipo Classe Pai recebe uma INSTANCIA de Classe Filha, os 
        métodos sobreescritos com a notação 'override' da Classe Filha será herdada por esse
        objeto, entretanto os metodos sobreescritos com a notação 'new' ficaram ocultos desse objeto,
        herdando diretamente da Class Pai
     */
    }
    internal class Herança {
        public static void Main() {
            Console.WriteLine("UNO");
            Uno uno = new Uno();
            Console.WriteLine(uno.Acelerar());
            Console.WriteLine(uno.Frear());

            Console.WriteLine("FERRARI");
            Ferrari ferrari = new Ferrari();
            Console.WriteLine(ferrari.Acelerar());
            Console.WriteLine(ferrari.Frear());

            Console.WriteLine("POLIMORFISMO");
            //Tipo Classe Pai / Instancia Classe Filha
            Carro carro = new Ferrari();
            Console.WriteLine(carro.Acelerar()); //'override' Acelerar herdado de Ferrari(Classe Filha)
            Console.WriteLine(carro.Frear()); //'new' Freiar herdado de Carro(Classe Pai)
        }
    }
}
