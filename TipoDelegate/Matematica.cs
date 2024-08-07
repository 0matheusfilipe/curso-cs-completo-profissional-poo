using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Matematica
    {
        public void Somar(int n1, int n2)
        {
            Console.WriteLine("Soma: " + (n1 + n2));
        }
        public void Subtrair(int n1, int n2)
        {
            Console.WriteLine("Subtração: " + (n1 - n2));
        }
        public void Multiplicar(int n1, int n2)
        {
            Console.WriteLine("Multiplicação: " + (n1 * n2));
        }
        public void Dividir(int n1, int n2)
        {
            Console.WriteLine("Divisão: " + (n1 / n2));
        }
    }
}
