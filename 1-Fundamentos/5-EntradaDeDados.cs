using System;
using System.Globalization;

namespace iniciando_csharp.Fundamentos {
    internal class EntradaDeDados {
        public static void Main() {
         // Estrada de Dados
            Console.WriteLine("Qual é o seu Nome? ");
            string nome = Console.ReadLine();

         /*
             Por Padrão, o Console.ReadLine() converte em texto.
             para converter para int, deve usar alguns metodos
         */

            Console.WriteLine("Qual é o sua Idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu Salario? ");
            double salario = double.Parse(Console.ReadLine(), 
                CultureInfo.InvariantCulture);
           
         /*
             "CultureInfo.InvariantCulture" permite que seja digitados valores com
             "," seja forçado a serem digitados com "."
         */
            Console.WriteLine($"{nome} {idade} {salario}");
        }
    }
}
