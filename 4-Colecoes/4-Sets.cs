using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._4_Colecoes {
    
    internal class Sets {
        public static void Main() {
            var livro = new Produto("Game of Throne", 49.9);

        /*
            SET: São estruturas de dados não indexadas, são Homogeneas, Dinanmicas porém NÃO ACEITA 
            REPETIÇÃO.
        */

            //Declarando uma lista em que vai ser armazenados Objetos do tipo 'Produto'
            var carrinho = new HashSet<Produto>();

            Console.WriteLine(carrinho.Count);

            //Adiciona um valor a lista
            carrinho.Add(livro);

            Console.WriteLine(carrinho.Count);
            var listaDeProdutos = new HashSet<Produto> {
                new Produto("Camisa", 4.99),
                new Produto("Calça", 14.99),
                new Produto("Chapéu", 9.99),
                new Produto("Alicate", 2.99),
            };

            //Une os dois Sets
            carrinho.UnionWith(listaDeProdutos);
            Console.WriteLine(carrinho);
        }
    }
}
