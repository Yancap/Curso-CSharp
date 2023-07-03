using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp.MetodosDeColecoes {
    internal class MetodosDeArray {
        public static void Main() {
            string[] vetor = new string[5];
            vetor[0] = "Yan";
            vetor[1] = "Gabriel";
            vetor[2] = "João";
            vetor[3] = "Julia";
            vetor[4] = "Marselo";

            //Verifica o tamanho do Array
            Console.WriteLine(vetor.Length);

            //Adiciona ou modifica o valor do array em uma posição
            vetor.SetValue("Jorge", 1);

            //Pega o valor de uma Array em uma determinada posição
            Console.WriteLine("Valor Adicionado: " + vetor.GetValue(1));

            //Itera sobre cada elemento do Array
            Array.ForEach(vetor, (element) => {
                Console.WriteLine(element);
            });

            //Busca o indice de um determinado valor no array
            Console.WriteLine("Indice do Yan: " + 
                Array.IndexOf(vetor, "Yan"));

            //Retorna 'True' se TODOS os valores atender a condição
            Console.WriteLine("TrueForAll: " +
            Array.TrueForAll(vetor, (element) => element.Length >= 3)
            );

            //Retorna 'True' se PELO MENOS UM valor atende a condição
            Console.WriteLine("Yan Existe? " + 
            Array.Exists(vetor, (element) => element == "Yan"));

            //Retorna o PRIMEIRO VALOR que atender a condição
            Console.WriteLine(
            Array.Find(vetor, element => element == "Yan"));

            //Retorna uma ARRAY de TODOS OS VALORES que atender a condição
            Console.WriteLine(
            Array.FindAll(vetor, element => element.Length > 5));

            //Modifica o tamanho do Array
            Array.Resize(ref vetor, 6);
            vetor[5] = "Joaquim";

            //Ordena um Array em ordem alfabetica ou numerica
            Array.Sort(vetor);
            Console.WriteLine("Array Ordenado");
            Array.ForEach(vetor, (element) => {
                Console.WriteLine(element);
            });

            //Limpa o Array
            Array.Clear(vetor);

         /*
            MATRIZES 
         */
            //Inicia uma matriz
            string[,] matriz1 = new string[2, 3]; //inicia vazia
            int[,] matriz2 = new int[3, 3] { 
                { 1, 2, 3 }, 
                { 4, 5, 6 }, 
                { 7, 8, 9 } 
            }; //inicia com valores
        }
    }
}
