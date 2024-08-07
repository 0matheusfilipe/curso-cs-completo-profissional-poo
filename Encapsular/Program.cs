using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conceito de Encapsulamento
            /*
             Encapsulamento: separar o programa em partes mais isoladas possíveis. Ocultar ou esconder os membros de uma classe exterior usando um modificador de acesso. Preservar a integridade dos dados definindo campos privados em vez de públicos;
             */
            #endregion
            Conta c = new Conta();
            c.Cliente = "Matheus";
            //c.Saldo = 100;
            
            // == Operação de depósito ==
            double valor = 100;
            c.Depositar(valor);

            // == Operação de saque
            double valor2 = 50;
            c.Sacar(valor2);

            // == Resultado saldo atual
            Console.WriteLine("Cliente: " + c.Cliente);
            Console.WriteLine("Saldo: " + c.Saldo);

            Console.ReadKey();
        }
    }
}
