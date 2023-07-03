using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._8_Erros_e_Excessoes {
    //Criando uma Excessão Personalizada
    public class NegativeException : Exception {

        //Construtor Padrão que herda de "Exception"
        public NegativeException() { }
        //Construtor que gerá a mensagem de Excessão
        public NegativeException(string message) : base(message) { }
        //Construtor que gerá a mensagem de Excessão e recebe uma outra Excessão
        public NegativeException(string message, Exception inner) 
            : base(message, inner) { }
    }
    public class OddException : Exception {
        public OddException(string message) : base(message) { }
    }
    internal class ExcessoesPersonalizadas {
        public static int ParPositivo() {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if (valor < 0) {
                throw new NegativeException("Numéro Negativc...");
            } 

            if(valor % 2 == 1) {
                throw new OddException("Valor Impar...");
            }
            return valor;
        }
        public static void Main() {
            try {
                var valor = ParPositivo();
                Console.WriteLine(valor);
            } catch (NegativeException ex) {
                Console.WriteLine(ex.Message);
            } catch (OddException ex) {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
