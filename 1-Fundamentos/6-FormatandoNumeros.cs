using System;
using System.Globalization;

namespace iniciando_csharp.Fundamentos {
    internal class FormatandoNumeros {
        public static void Main() {
         // Formatando Numeros

            double valor = 15.175;
            Console.WriteLine("Arredondando para cima com uma casa decimal " + valor.ToString("F1"));
            Console.WriteLine("Arredondando para cima com duas casa decimal " + valor.ToString("F2"));
            Console.WriteLine("Arredondando para cima com duas casa decimal " + valor.ToString("#.##"));
            Console.WriteLine("Transforma em Moeda de acordo com a cultura local " + valor.ToString("C"));
            Console.WriteLine("Valor Percentual e Multiplica por 100 " + valor.ToString("P"));

            CultureInfo culturaBR = new CultureInfo("pt-BR");
            Console.WriteLine("Transforma em Moeda sem casa decimal de acordo com a cultura brasileira " + 
                valor.ToString("C0", culturaBR));

            CultureInfo culturaUS = new CultureInfo("en-US");
            Console.WriteLine("Transforma em Moeda com tres casas decimais de acordo com a cultura americana " +
                valor.ToString("C3", culturaUS));


        }
    }
}
