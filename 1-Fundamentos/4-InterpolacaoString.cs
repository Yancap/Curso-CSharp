using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp.Fundamentos {
    internal class InterpolacaoString {
        public static void Main() {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5000.00;

            //Concatenação
            Console.WriteLine("O " + nome + " da marca " + 
                marca + " custa " + preco + ".");

            //Interpolação
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);
            Console.WriteLine($"O {nome} da marca {marca} custa {preco}.");

        }
    }
}
