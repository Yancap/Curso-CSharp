using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._6_POO {
/*
    "Sealed" >> Quando usado nas Class, não permite a Herança, ou seja, a Classe Pai 'sealed' não
    terá Classes Filhas. Quando usado nos métodos, não permite subescrição, ou seja, um Método 'sealed'
    da Classe Pai não sofrerá 'override' das Classes Filhas 
*/
    sealed class SemFilho {
        public double Fortuna() {
            return 1_400_000.50;
        }
    }
    //class Filho : SemFilho { } >> Não permitido

    class Avo {
        public virtual bool Sobrenome() {
            return true;
        }
    }
    class Pai : Avo {
        public override sealed bool Sobrenome() {
            return true;
        }
    }

    class FilhoRebelde : Pai {
    /* 
        public override bool Sobrenome() {
            return true;    
        } 
    */
    }

    internal class Sealed {
    }
}
