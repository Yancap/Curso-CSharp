using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp.Fundamentos {
    internal class Conversoes {
        public static void Main() {

         // Um int cabe em um double sem que haja perda de informação
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

         // Um double não pode ser convetido explicitamente em um int, pois haverá perda de informação
            double nota = 9.7;
            Console.WriteLine("Informação Completa: " + nota);
         // Entretando, pode forçar a conversão por meio da diretiva (int) com perda de informação 
            int notaQuebrada = (int) nota; // casting
            Console.WriteLine("Perda de Informação: " + notaQuebrada);

         // Convertendo na Entrada de Dados
            Console.WriteLine("Digite sua idade");
            string idade = Console.ReadLine();

            //Metodo 1 para inteiro
            int idadeInt = int.Parse(idade);
            //Metodo 2 para inteiro
            idadeInt = Convert.ToInt32(idadeInt);

            Console.WriteLine($"Idade {idadeInt}");


         // Conversão Segura de String para Int
            Console.WriteLine("Digite um Numero");
            string palavra = Console.ReadLine();
            int.TryParse(palavra, out int numero); //Caso não consiga converte em int, a função retorna 0
            Console.WriteLine($"Resultado {numero}");

         // Mesmo código assim de uma maneira mais otimizada
            Console.WriteLine("Digite outro Numero");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Resultado: {numero2}");
        }
    }
}
