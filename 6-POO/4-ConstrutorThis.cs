using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._6_POO {
    class Animais {
        string Nome { set; get; }

        public Animais(string nome) {
            Nome = nome;
        }
    }
    
    class Cachorro : Animais {
        double Altura { set; get; }
        string Raca { set; get; }
     /*
      O 'This' em um construtor, serve para chamar outro Construtor de uma mesma Classe
     */

        //Esse Construtor chamará o Contrutor da Classe Pai
        public Cachorro(string nome) : base(nome) {
            Console.WriteLine("---------------------");
            Console.WriteLine("Construtor 1 Iniciado");
        }
        //Esse Construtor iniciará a Altura e Chamará o Construtor acima
        public Cachorro(string nome, double altura) : this(nome) {
            Altura = altura;
            Console.WriteLine("Construtor 2 Iniciado");
        }
        //Esse Construtor iniciará a Raça e Chamará o Construtor acima
        public Cachorro(string nome, double altura, string raca) : this(nome, altura) {
            Raca = raca;
            Console.WriteLine("Construtor 3 Iniciado");
        }
    }

    internal class ConstrutorThis {
        public static void Main() {

            //Vai inicializar o Contrutor 1 que herdará de Animais
            var mike = new Cachorro("Mike");

            //Vai inicializar o Contrutor 2 que adicionará o valor Altura e chamará o Construtor 1.
            var tor = new Cachorro("Mike", 1.30);

            //Vai inicializar o Contrutor 3 que adicionará o valor Raça e chamará o Construtor 2 e que chamará o Construtor 1.
            var persio = new Cachorro("Persio", 1.10, "Salsichinha");
        }
    }
}
