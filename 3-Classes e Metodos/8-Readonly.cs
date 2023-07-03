using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._3_Classes_e_Metodos {

    public class Cliente {

     /*
        READONLY -> Permite que um valor seja determinado para um atributo apenas uma vez, ou seja,
        é equivalente a uma constante, entretanto, o valor é declarado no construtor e não pode ser modificado
     */

        public string Nome;
    // 'readonly' é a palavra reservada
        public readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) { 
            Nome = nome;
            Nascimento = nascimento;
        }
    }
    internal class Readonly {
        public static void Main() {
            var cliente = new Cliente("Yan Gabriel", new DateTime(2003, 11, 22));

            Console.WriteLine(cliente.Nome);
            //Atributo de apenas leitura
            Console.WriteLine(cliente.Nascimento);

            //cliente.Nascimento = new DateTime(2023, 10, 10); //Impossibilidade
        }
    }
}
