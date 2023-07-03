using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._4_Colecoes {
    internal class Dictionary {
        public static void Main() {
         /*
            São estruturas de dados equivalentes aos Objects do Javascript e os Dicts do Python.
            São estruturas de "Chave:Valor", em que a tipagem do 'Generic' será <chave, valor>
         */
            var filmes = new Dictionary<int, string>();

            //Método que adiciona a (Chave, Valor) ao Dictionary
            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incriveis");

            //Ver o tamanho do Dictionary
            Console.WriteLine(filmes.Count);

            //Pega o Valor relacionado a Chave no Dictionary
            Console.WriteLine(filmes[2000]);

            //Pega o Valor relacionado a Chave, se a chave não existir, retorna um valor vazio
            Console.WriteLine(filmes.GetValueOrDefault(2008));

            //Método que verifica se uma Chave está contida no Dictionary
            Console.WriteLine(filmes.ContainsKey(2008));
            //Método que verifica se um Valor está contida no Dictionary
            Console.WriteLine(filmes.ContainsValue("Vingadores"));

            //Remove a Chave e Valor
            filmes.Remove(2004);

            filmes.Add(2018, "Guerra Infinita");

            //Tenta pegar o Valor da Chave e gerar uma variavel com esse Valor, caso a Chave não existe, retorna vazio
            filmes.TryGetValue(2018, out string filme2018);
            Console.WriteLine(filme2018);

            //Percorrendo as Chaves do Dictionary
            foreach (var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }
            //Percorrendo os Valores do Dictionary
            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }

            //Duas formas de percorrer Chave e Valor ao mesmo Tempo
            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"Chave: {filme.Key} || Valor: {filme.Key}.");
            }
            foreach (var filme in filmes) {
                Console.WriteLine($"Chave: {filme.Key} || Valor: {filme.Key}.");
            }
            //Limpa o Dictionary
            filmes.Clear();
        }
    }
}
