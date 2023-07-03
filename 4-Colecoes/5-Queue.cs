using System;
using System.Collections.Generic;
using System.Collections;


namespace iniciando_csharp._4_Colecoes {
    internal class Queues {
        public static void Main() {
        /*
            Queue(fila) >> É uma estrutura de dados onde o primeiro item a entrar deve ser o 
            primeiro a sair
         */
            var fila = new Queue<string>();
            //Adiciona um elemento a fila (lista)
            fila.Enqueue("Fulano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Sicrano");

            //Pega o proximo elemento a sair da fila, mas não remove da lista
            Console.WriteLine(fila.Peek());

            //Retira o proximo elemento a sair da fila
            Console.WriteLine(fila.Dequeue());

            foreach(var item in fila) {
                Console.WriteLine(item);
            }

            //Cria uma Queue mas tem um 'Generic', ou seja, aceita qualquer tipo de dado
            var saladaDeDados = new Queue();
            saladaDeDados.Enqueue("String");
            saladaDeDados.Enqueue(2.34);
            saladaDeDados.Enqueue(true);

            //Verifica se um dado está contido nessa Queue
            Console.WriteLine(saladaDeDados.Contains("String"));
        }
    }
}
