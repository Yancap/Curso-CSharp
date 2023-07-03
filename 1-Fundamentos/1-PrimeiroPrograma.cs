using System;

namespace iniciando_csharp.Fundamentos {
    internal class PrimeiroPrograma {
        /* A Função Main() é a função principal de um programa C# 
           ela é responsavel por iniciar o programa
        */
        /* 
          Em um programa C# só é possivel existir uma função Main(), 2 Arquivos com
          função Main() não será possivel de ser executado!
        */
        public static void execute() {
            Console.Write("Primeiro ");
            Console.WriteLine("Programa");
            Console.WriteLine("Terminou!");
        }

        /*
         Para reverter esse Error é so Clicar com botão direito no Programa > 
         Propriedades > Aplicativo > Objeto de Inicialização > Selecionar o arquivo desejado
         
         OU

          renomear a função Main() dos outros arquivos, recomendado: Execute()
         */
    }
}
