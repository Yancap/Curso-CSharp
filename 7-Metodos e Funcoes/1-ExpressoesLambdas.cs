using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp.Metodos_e_Funcoes {
    internal class ExpressoesLambdas {
    /*
        Expressões Lambdas: São funções anonimas/Arrow Functions que podem ser armazenadas em variáveis ou
        podem ser passadas como parametros para outros Metodos, Estruturas de Controles e Repetições, etc.
    */
        public static void Main() {
            //'Action' é uma Função do tipo void, que não tem retorno
            Action algoNoConsole = () => {
                Console.WriteLine("Lambda no C#");
            };
            algoNoConsole();

            //'Func' é uma Função que possui retorno, que é declarado no Generic
            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };
            Console.WriteLine(jogarDado());

            //Func< tipoParams, tipoReturn > : No final sempre deve vir o tipo do Retorno
            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(33456));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => {
                return String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            };
            Console.WriteLine(formatarData(22,1,2003));
        }
    }
}
