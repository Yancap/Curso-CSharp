using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._4_Colecoes {
    internal class ArrayLists {
        public static void Main() {
         /*
            ArrayList >> São um conjunto de dados que podem ser Heterogeneos, ou seja,
            podem receber qualquer tipo de dados
         */
            var arrayList = new ArrayList {
                "String",
                1,
                true
            };

            arrayList.Add(3.14);

            foreach (var item in arrayList) {
                Console.WriteLine($"{item} >> {item.GetType()}");
            }
        }
    }
}
