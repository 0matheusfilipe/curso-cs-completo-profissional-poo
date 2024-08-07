using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    abstract public class Forma
    {
        #region Conceito de Polimorfismo
        /*
         Polimorfismo: princípio pelo qual duas ou mais classes derivadas de uma mesma classe base podem invocar métodos que têm a mesma identificação (mesma assinatura), mas comportamentos diferentes e especializados para cada classe derivada. Ou seja, um objeto criado utilizando polimorfismo pode ter comportamentos diferentes dependendo da forma como ele foi instanciado.
         */
        #endregion

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Raio { get; set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar!");
        }
        public virtual void Area()
        {
            double area = Largura * Altura;
            Console.WriteLine("Área: " + area);
        }
    }
    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um círculo!");
            base.Desenhar();
        }
        public override void Area()
        {
            double area = 3.14 * (Raio * Raio);
            Console.WriteLine("Área do círculo: " + area);
        }
    }

    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um retângulo!");
            base.Desenhar();

        }
        public override void Area()
        {
            base.Area();
        }
    }

    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um triângulo!");
            base.Desenhar();

        }
        public override void Area()
        {
            double area = (Largura * Altura)/2;
            Console.WriteLine("Área do triângulo: " + area);
        }
    }
}
