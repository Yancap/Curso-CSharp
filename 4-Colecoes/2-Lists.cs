using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._4_Colecoes {
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
    internal class Lists {
        public static void Main() {
         /*
               Generics são uma forma de implementar Interfaces/Regras que um determinado
               tipo de dado ou função deve aceitar, por meio da notação "<Tipo>"
         */
            var livro = new Produto("Game of Throne", 49.9);

         /*
            LIST: São estruturas de dados semelhante aos Array, são Homogeneas porém Dinanmicas, ou seja,
            aceitam apenas um tipo de dado (por meio do <Generic>) e não possuem um tamanho determinado
         */

            //Declarando uma lista em que vai ser armazenados Objetos do tipo 'Produto'
            var carrinho = new List<Produto>();

            //Adiciona um valor a lista
            carrinho.Add(livro);

            var listaDeProdutos = new List<Produto> { 
                new Produto("Camisa", 4.99),
                new Produto("Calça", 14.99),
                new Produto("Chapéu", 9.99),
                new Produto("Alicate", 2.99),
            };

            //Adiciona os items de uma List em outra List
            carrinho.AddRange(listaDeProdutos);

            //Mostra quantos elementos possui uma List
            Console.WriteLine(carrinho.Count);

            //Remove um elemento de uma List com base em seu index
            carrinho.RemoveAt(3);
        }
    }
}
