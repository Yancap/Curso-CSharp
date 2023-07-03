using iniciando_csharp._3_Classes_e_Metodos;
using System;

namespace iniciando_csharp.Classes_e_Metodos {
    internal class Membros {
        public static void Main() {
            //Instanciando uma classe
            Pessoa fulano = new Pessoa();

            //Inferencia
         /* 
            var sicrano = new Pessoa();
         */
            //Definindo valores aos atributos
            fulano.Nome = "Yan";
            fulano.Idade = 19;
            Console.WriteLine($"Nome: {fulano.Nome}, Idade: {fulano.Idade}");

            //Chamando os metodos publicos
            fulano.ApresentarNoConsole();
            string apresentacao = fulano.Apresentar();
            Console.WriteLine(apresentacao);
        }
    }
}
