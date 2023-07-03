using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._3_Classes_e_Metodos {


    //Interface equivalente ao Typescript
    interface Pontos {
        void MoverNaDiagonal(int delta); //Define o tipo da função e tipo de seus argumentos
    }

 // Define a Struct aderente a Interface 'Ponto'
    struct Coordenada: Pontos {
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta) {
            X += delta;
            Y += delta; 
        }
    }

    internal class Struct {
        public static void Main() {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine($"Coordenada Inicial X: {coordenadaInicial.X} \n" +
                $"Coordenada Inicial Y: {coordenadaInicial.Y}");

            var coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine($"Coordenada Final X: {coordenadaFinal.X} \n" +
                $"Coordenada Final  Y: {coordenadaFinal.Y}");
        }
    }

}
