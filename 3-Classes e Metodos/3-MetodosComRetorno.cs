using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._3_Classes_e_Metodos {
    class CalculadoraComum {
        //Define uma metodo de instancia, publico e que retorna um inteiro
        public int Somar(int a, int b) {
            return a + b;
        }
        //Define uma metodo de instancia, publico e que retorna um double
        public double Somar(double a, double b) {
            return a + b;
        }
     /*
        O C# permite ter varios metodos com mesmo nome, entretanto, obrigatoriamente deve
        ter diferentes tipos de retornos OU diferentes tipos de parametros
     */
    }
    
    class CalculadoraEmCadeia {
        //Cria uma variavel interna, que não pode ser acessada fora
        private int memoria;

        //Cria um metodo publico, que retorna a propria instancia da classe
        public CalculadoraEmCadeia Somar(int a) {
            memoria += a;
            return this;
        }
        public CalculadoraEmCadeia Subtrair(int a) {
            memoria -= a;
            return this;
        }
        public CalculadoraEmCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public int Resultado() {
            return memoria;
        }
     /*
        Retornar a instancia é algo comum em APIs, pos permite chamar diversos metodos em cadeia
     */
    }
    internal class MetodosComRetorno {
        
        public static void Main() {
            var calculadoraComum = new CalculadoraComum();
            Console.WriteLine(calculadoraComum.Somar(1,1));
            Console.WriteLine(calculadoraComum.Somar(2.5, 3.75));


            var calculadoraEmCadeia = new CalculadoraEmCadeia();
            //Chamada dos metodos em cadeia
            Console.WriteLine(calculadoraEmCadeia.Somar(10).Subtrair(5).Multiplicar(2).Resultado);
        }
    }
}
