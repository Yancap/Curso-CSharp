using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._3_Classes_e_Metodos {
    public class Moto {
        
        public string Marca;
        public string Modelo;
     // 'private' define que esse membro da classe como sendo privado para dentro da classe
        private int Cilindrada;
     // Obs: O nivel de visibilidade padrão para um atributo ou metodo no C# é 'private'

        public Moto(string marca, string modelo, int cilindrada) {
            Marca = marca;
            Modelo = modelo;
            SetCilindrada(cilindrada);
        }
        public Moto() { }

        //Metodo GET - Apenas Ler e Retorna o atributo privado, de acordo com uma regra de negocio definida no metodo
        public int GetCilindrada() {
            return Cilindrada;
        }

        //Método SET - Modifica o valor de um atributo privado, de acordo com uma regra de negocio definida no metodo
        public void SetCilindrada(int cilindrada) {
            Cilindrada = Math.Abs(cilindrada); //Se o valor for negatitvo, transforma para positivo
        }

     /*
        Os Metodos GET e SET na POO serve para adicionar uma camada de segurança, validação e abstração a mais
        na hora de declarar ou ler valores de atributos privados.
     */
    }
    internal class GetterSetter {
        public static void Main() {
            var moto = new Moto("Kawasaki", "Ninja ZX-68", -636);
            Console.WriteLine(moto.Marca); //Chamando o atributo publico
            Console.WriteLine(moto.Modelo); //Chamando o atributo publico
            Console.WriteLine(moto.GetCilindrada()); //Chamando o atributo privado
        }
    }
}
