using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciando_csharp._8_Erros_e_Excessoes {
    public class Conta {
        double Saldo;
        public Conta(double saldo) {
            this.Saldo = saldo;
        }
        public void Sacar(double valor) {
            if(valor > Saldo) {
                //Lança uma Excessão e um tipo determinado de Excessão
                throw new ArgumentException("Saldo insuficiente");
            }
            Saldo -= valor;
        }
    }
    internal class TratandoErros {
        public static void Main() {
            var conta = new Conta(1_200.50);

            //Bloco de tratamento para erros
            try {
                conta.Sacar(100);
                Console.WriteLine("Saque realizado com sucesso");
            } catch (Exception ex) {
                /* 'Exception' serve para tratar todos os tipos de Erros */
                //Executado se houver erros e excessões

                //Pega o tipo da Exception 
                Console.WriteLine(ex.GetType().Name);

                Console.WriteLine(ex.Message);
            } finally {
                //Executado independentemente
                Console.WriteLine("Obrigado!");
            }

            //Bloco de tratamento para erros
            try {
                conta.Sacar(100);
                Console.WriteLine("Saque realizado com sucesso");
            } catch (ArgumentException ex) {
                /* 'ArgumentException' serve para tratar apenas esse erro especifico
                 Outros tipos de erros não serão tratados */
                //Executado se houver erros e excessões
                Console.WriteLine(ex.Message);
            } finally {
                //Executado independentemente
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
