using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Program
    {
        delegate void Operacao(int num1, int num2);
        // Atribui varios tipos de comportamentos/metodos num unico evento
        static void Main(string[] args)
        {
            Matematica m = new Matematica();
            Operacao conta = null;

            conta += m.Somar;
            conta += m.Subtrair;
            conta += m.Multiplicar;
            conta += m.Dividir;
            conta += m.Multiplicar;

            conta(20, 10);

            Console.WriteLine();

            conta -= m.Dividir;
            conta -= m.Subtrair;

            conta(15, 5);


            Console.ReadKey();
            }
    }
}
