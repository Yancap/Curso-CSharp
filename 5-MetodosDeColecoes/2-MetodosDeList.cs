using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._5_MetodosDeColecoes {
    class Guitarra {
        public string Marca;
        public string Modelo;
        public double Preco;
        public Guitarra(string marca, string modelo, double preco) {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Preco = preco;
        }
        public Guitarra() { }
    }
    internal class MetodosDeList {
        
        public static void Main() {
            var lespaul = new Guitarra("Gibson", "Les Paul", 3000);
            var sg = new Guitarra("Gibson", "SG", 1500);
            var strato = new Guitarra("Fender", "Stratocaster", 2000);

            var listaDeCompras = new List<Guitarra>();

            //Adiciona um valor a List
            listaDeCompras.Add(lespaul);
            listaDeCompras.Add(sg);

            //Verifica se um valor está contido na List
            Console.WriteLine(listaDeCompras.Contains(sg));
            Console.WriteLine(listaDeCompras.Contains(strato));

            //Verifica a quantidade de items que tem na List
            Console.WriteLine(listaDeCompras.Count);

            //Remove a primeira ocorrencia de um elemento da List
            listaDeCompras.Remove(sg);
            //Remove um elemento com base em seu indice
            listaDeCompras.RemoveAt(0);
            

            //Ordena a List em ordem alfbetica ou crescente <Apenas para string e numeros>
            listaDeCompras.Sort();
            //Inverete a List em ordem alfbetica ou decrescente <Apenas para string e numeros>
            listaDeCompras.Reverse();

            //Transforma a List em Array
            var arrayDeCompras = listaDeCompras.ToArray();

            listaDeCompras.Add(lespaul);
            listaDeCompras.Add(strato);
            listaDeCompras.Add(sg);

            //Retorna o Indice de um determinado elemento
            Console.WriteLine(listaDeCompras.IndexOf(strato));

            //Itera sobre cada indice da List
            listaDeCompras.ForEach((guitarra) => {
                Console.WriteLine(
                    $"Marca: {guitarra.Marca}, " +
                    $"Modelo: {guitarra.Modelo}, " +
                    $"Preco: {guitarra.Preco}");
            });


            //Itera sobre a lista até achar o elemento que corresponde a condição
            Console.WriteLine(
            listaDeCompras.Find((guitarra) => guitarra.Modelo == "Stratocaster").Modelo
            );

            //Itera sobre a lista até achar todos elemento que corresponde a condição e retorna
            listaDeCompras.FindAll((guitarra) => guitarra.Marca == "Gibson")
            .ForEach(guitarra => Console.WriteLine(
                    $"Marca: {guitarra.Marca}, " +
                    $"Modelo: {guitarra.Modelo}, " +
                    $"Preco: {guitarra.Preco}")
            );

            //Método que retorna True se achar um elemento corresponder a condição
            Console.WriteLine(
            listaDeCompras.Exists(guitarra => guitarra.Modelo == "Telecaster")
            );

            //Método que retorna True se todos elemento corresponder a condição
            Console.WriteLine(
            listaDeCompras.Exists(guitarra => guitarra.Preco > 1000)
            );

            //Limpa a List
            listaDeCompras.Clear();
        }
    }
}
