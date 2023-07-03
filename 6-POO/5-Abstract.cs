using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._6_POO {
/*
    Uma Class Abstract é como se fosse um modelo de classe a ser implementada por Herança,
    onde essa classe não pode ser instanciada e seus métodos abstract não podem ser utilizados, apenas os
    métodos "abstract" serão modelos. Abstract permite a implmentação de Métodos Concretos.
*/
    public abstract class Celular {
        public abstract string Assistente(); //Modelo de Métodos a ser implementado
        public static string Tocar() { //Método já implementado
            return "Trim Trim";
        }
    }

    public class Samsung: Celular {
        public override string Assistente() {
            return "Assistente do Samsung";
        }
    }
    internal class Abstract {
        //var celular = new Celular(); >> Não é possivel instanciar classes abstratas
        public static void Main() {
            var samsung = new Samsung();
            samsung.Assistente();
            
        }

    }
}
