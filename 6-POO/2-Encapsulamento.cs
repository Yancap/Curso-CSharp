using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;


namespace iniciando_csharp._6_POO {
    public class FilhoAbandonado : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("Acessos do Filho Abandonado");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular); >> Sem acesso, 'internal'
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoFamilia); >> Sem acesso, 'private protected'
            //Console.WriteLine(amiga.UsaMuitoPhotoshop); >> Sem acesso, 'private'
            Console.WriteLine("_________________________________________________________________");
        }
    }
    class AmigoDistante {
        //Acesso por meio de Composição\Instancia
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("Acesso dos Amigos Distantes da Subcelebridade");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho); >> Sem acesso, 'protected'
            //Console.WriteLine(amiga.NumeroCelular); >> Sem acesso, 'internal'
            //Console.WriteLine(amiga.JeitoDeFalar); >> Sem acesso, 'internal protected'
            //Console.WriteLine(amiga.SegredoFamilia); >> Sem acesso, 'private protected'
            //Console.WriteLine(amiga.UsaMuitoPhotoshop); >> Sem acesso, 'private'
            Console.WriteLine("_________________________________________________________________");
        }

    }
    class Encapsulamento {
        public static void Main() {
            var sub = new SubCelebridade();

            sub.MeusAcessos();
            new FilhoSubCelebridade().MeusAcessos();
            new AmigoProximo().MeusAcessos();
            new FilhoAbandonado().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
