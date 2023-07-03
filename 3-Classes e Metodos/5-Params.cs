using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._3_Classes_e_Metodos {
    internal class Params {
        //Definindo que um Método recebera diversos parametros, por meio da palavvra chave 'params'
        public static void Recepcionar(params string[] pessoas) {
            //É equivalente a um array que agrupa diversos valores
            foreach(var pessoa in pessoas) {
                Console.WriteLine($"Olá {pessoa}");
            }
        }

        //Definindo Parametros Nomeados
        public static void FormatarData(int dia, int mes, int ano) {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }
        public static void Main() {
            //Chamada do metodo com diversos parametros
            Recepcionar("Yan", "Pedro", "Fulano");

            //Chamada com parametros nomeados
            FormatarData(mes: 11, dia: 22, ano: 2003);
            
        }
    }
}
