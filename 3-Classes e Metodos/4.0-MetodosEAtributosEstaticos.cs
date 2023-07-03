using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._3_Classes_e_Metodos {

  /*
     Os Métodos e Atributos Estáticos são Métodos e Atributos da Classe, ou seja,
     Eles pertencem a Classe e podem ser acessados diretamente pela classe
  */
    class CalculadoraEstática {

        public static int ResultadoSubtracao = 0;
        public double ResultadoDivisao = 0;

        //Método de Class ou Método Estático
        public static int Somar(int a, int b) {
            return a + b;
        }
        public static void Subtrair(int a, int b) {
            ResultadoSubtracao = a - b;
        }
        //Método da Instancia
        public int Multiplicar(int a, int b) {
            return a * b;
        }
        public void Dividir(int a, int b) {
            ResultadoDivisao = a / b;
        }
    }
    internal class MetodosEAtributosEstaticos {
        public static void Main() {
            //Chamada do metodo diretamente pela classe
            var resultado = CalculadoraEstática.Somar(5, 5);
            Console.WriteLine(resultado);

            //Chamada do Atributo e Metodo da Classe
            CalculadoraEstática.Subtrair(5, 2);
            Console.WriteLine(CalculadoraEstática.ResultadoSubtracao);

            //Metodo da Instancia
            var Calc = new CalculadoraEstática();
            resultado = Calc.Multiplicar(5, 5);

            //Chamada do Atributo e Metodo da Instancia
            Calc.Dividir(10, 2);
            Console.WriteLine(Calc.ResultadoDivisao);
        }
    }
}
