using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._4_Colecoes {
    internal class Arrays {
        public static void Main() {
        /*
            Os Arrays no C# é uma estrutura homogenea e estática, ou seja,
            todos os dados são do mesmo tipo e possuem um tamanho pré-definido
        */
            //Inicializando um Array de String com tamanho de 5 posições
            string[] alunos = new string[5];

            //Adicionando valores ao array
            alunos[0] = "Yan";
            alunos[1] = "Gabriel";
            alunos[2] = "Bernardo";
            alunos[3] = "João";
            alunos[4] = "Marcelo";

            //Percorrendo cada index do array
            foreach(var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            //Declarando um array de 'double' já com os valores
            double[] notas = { 9.7, 4.4, 8.2, 10.0, 5.0 };

            for(var index = 0; index < notas.Length; index++) {
                Console.WriteLine($"Aluno: {alunos[index]}, Nota:{notas[index]}");
            }
        }
    }
}
