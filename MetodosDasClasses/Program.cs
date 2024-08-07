using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            #region Métodos Simples
            //m.Cumprimentar();
            #endregion

            #region Métodos com parâmetros
            //m.Somar(10, 5);
            //m.Apresentar("Edson Castro", 24);
            #endregion

            #region Passagem de parâmetros por valor e por referência
            /*int valor1 = 100;
            int valor2 = 100;

            m.AumentarValor(valor1);
            m.AumentarRef(ref valor2);
            m.AumentarRef(ref valor2);*/
            #endregion
            #region Métodos com retorno de valores
            /*
            int codigoChar = m.CodigoChar('k');
            double valorPI = m.ValorPI();
            string nomeCompleto = m.MontaNome("Matheus", "Silva");

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(codigoChar);
            Console.WriteLine(valorPI);*/
            #endregion

            #region Sobrecarga de métodos
            m.Cumprimentar();
            m.Cumprimentar("Matheus");
            m.Cumprimentar("Matheus", 15);

            bool res1 = m.Comparar(100, 25 * 4);
            bool res2 = m.Comparar("aaa", "AAA");

            Console.WriteLine(res1);
            Console.WriteLine(res2);
            #endregion



            Console.ReadKey();
        }
    }
}
