using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._3_Classes_e_Metodos {
    internal class Pessoa {
        //Definindo um atributo publico e seu tipo, com a escrita PascalCase por convensão
        public string Nome;
        public int Idade;


     /* 
        Declarando um metodo/função!
        public - chave de acesso (Nesse caso é acesso publico)
        static - se é Metodo de Classe ou Instancia (Nesse caso é metodo de classe)
        void - tipo de retorno (Nesse caso não possui retorno)
        public static void Main(){...}
     */


        //Definindo um metodo publico com retorno em string
        public string Apresentar() {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} Anos");
        }

        //Definindo um metodo publico e sem retorno
        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }


    }
}
