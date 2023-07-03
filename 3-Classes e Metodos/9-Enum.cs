using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._3_Classes_e_Metodos {
/*
    ENUM -> São um conjuntos de dados fechados e pré-definidos, como no exemplo a seguir.
 */

    //Definindo uma estrututa fechada de dados do tipo 'enum'
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia }

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;
        public int Id;
    }
    internal class Enum {
        public static void Main() {
            Filme filme = new Filme();
            filme.Titulo = "Tropa de Elite";
            filme.GeneroDoFilme = Genero.Acao;

            //É possivel verificar o indice de dados do tipo enum
            filme.Id = (int)filme.GeneroDoFilme;
            

            Console.WriteLine(filme.GeneroDoFilme);
            Console.WriteLine(filme.Id);

        }
    }
}
