using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._3_Classes_e_Metodos {
  /*
     O Construtor padrão de uma Classe é seu proprio nome, quando não for definido
     um METODO CONSTRUTOR o construtor padrão não recebe parametro.
  */
    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        /* 
           Define o metodo construtor, obrigatoriamente seguindo as seguintes regras 
           1 - Mesmo nome que a Classe
           2 - Sem definir o retorno
           3 - public NomeDaClasse(<parametros>) {}
        */

        //1º metodo construtor
        public Carro(string Modelo, string fabricante, int Ano) {
            this.Modelo = Modelo;
            Fabricante = fabricante;
            this.Ano = Ano;
            
        }

        //2º metodo construtor
        public Carro() { }

    }
    internal class Construtores {
        public static void Main() {
            //Metodo 1 para instanciar uma Classe
            var carro1 = new Carro("Spin", "Chevrolet", 2017);

            //Metodo 2 para instanciar uma Classe
            var carro2 = new Carro();
            carro2.Fabricante = "Ford";
            carro2.Modelo = "F2143";
            carro2.Ano = 2019;

            //Metodo 3 para instanciar uma Classe
            var carro3 = new Carro() {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };

        }

    }
}
