using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            MinhaClasse mClasse = new MinhaClasse();
            MinhaClasse m2 = null;

            OutraClasse outra = new OutraClasse();
            OutraClasse outra2 = outra;
            #endregion

            #region
            Pessoa p1 = new Pessoa();
            p1.nome = "Logan";
            p1.sobrenome = "Andrew";
            p1.anoNascimento = 2004;

            Pessoa p2 = new Pessoa()
            {
                nome = "Maria",
                sobrenome = "Gabriella de Oliveira",
                anoNascimento = 2003
            };

            p1.nome = "Matheus";
            p1.sobrenome = "Filipe de Deus";

            Console.WriteLine("Pessoa 01: " + p1.nome);
            Console.WriteLine("Pessoa 01: " + p1.sobrenome);
            Console.WriteLine("Pessoa 01: " + p1.anoNascimento);
            p1.Cumprimentar();

            Console.WriteLine();

            Console.WriteLine("Pessoa 02: " + p2.nome);
            Console.WriteLine("Pessoa 02: " + p2.sobrenome);
            Console.WriteLine("Pessoa 02: " + p2.anoNascimento);
            p2.Cumprimentar();
            #endregion

            Console.ReadKey();
        }
    }

    class MinhaClasse
    {

    }
}
