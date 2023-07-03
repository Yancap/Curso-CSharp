using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._4_Colecoes {
    internal class Stacks {
     /*
        STACK >> É uma Pilha, um Array onde o Primeiro a Entrar é o Ultimo a Sair 
     */
        public static void Main() {
            var pilha = new Stack();

            //Método que adiciona valores a pilha
            pilha.Push(1);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14);

            foreach (var item in pilha) {
                Console.WriteLine(item);
            }

            //Remove o ultimo elemento da Pilha e retorna
            Console.WriteLine($"Pop: {pilha.Pop()}");

            //Apenas retorna o ultimo elemento da Pilha
            Console.WriteLine($"Peek: {pilha.Peek()}");

            //Verifica se um valor está contido na pilha
            Console.WriteLine(pilha.Contains("b"));
            
        }
    }
}
