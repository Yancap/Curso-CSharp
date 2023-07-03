using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._3_Classes_e_Metodos {
    public class Carros {

        double desconto = 0.1; //Atributo privado por padrão

     /*
        GET -> Método de leitura que retona o atributo com ou sem modificação, mas sem alterar 
        o valor do atributo original

        SET -> Modifica ou Adiciona um valor ao atributo
     */


        string nome;
        public string Nome {
            get { return "Opicional: " + nome; } //Retorna toda vez que for chamado
            set { nome = value; }
        }

        // Propriedade autoimplementada, sem nenhuma modificação
        public double Preco { get; set; }

        //Somente leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); //Função Lambda
        }

        public Carros(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
    internal class Props {
        public static void Main() {
            var carro = new Carros("Carro 1", 2200);

            //Retorna o atributo com a formatalção definida no 'get' do atributo
            Console.WriteLine(carro.Nome);

            //Retorna o atributo sem nenhuma modificação, como determinado no 'get'
            Console.WriteLine(carro.Preco);

            //Retorna o atributo com a modificação do 'get'
            Console.WriteLine(carro.PrecoComDesconto);
        }
    }
}
