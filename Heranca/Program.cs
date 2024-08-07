using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conceito de Herança 
            /*
             Herança: permite que uma classe herde métodos, atributos e comportamentos de uma outra classe e a partir disso haver um reaproveitamento de código. Além disso, facilita também a manutenção.;
             */
            #endregion

            #region Classe Abstrata 
            /*
             Modificador abstrato: indica que o item que está sendo modificado tem uma iomplementação ausente ou incompleta.
            Declaração de classe abstrata: indica que a classe se destina somente a ser uma classe base de outras classes, não instanciada por conta própria;
            Membros marcados como abstratos precisam ser implementadas por classes não abstratas que derivam da classe abstrata
             */
            #endregion

            #region Classe Sealed 
            /*
             Modificador sealed: quando aplicado a uma classe, impede que outras classes herdem dela. Funciona de forma inversa ao modificador abstrato. Dessa forma, serve apenas para criar objetos. Pode receber herança, mas não pode ser herdada.
             */
            #endregion

            #region Membros Sealed - parte 1
            /*
             Membro sealed: quando aplicado a uma classe, impede que outras classes herdem dela. Porém, é possível usar em um método ou propriedade para que substitua o método ou propriedade virtual em uma classe base. Isso impede que classes que herdam, ou seja, que derivam de uma determinada classe seja impedida de substituirem os métodos ou propriedades virtuais.

            Carro c = new Carro();
            Bicicleta b = new Bicicleta();
            b.Cor = "Vermelho";
            c.Marca = "Honda";
            c.Acelerar();
            b.Acelerar();
             */
            #endregion

            Humano a = new Humano();
            Pessoa b = new Pessoa();
            Homem c = new Homem();

            Console.WriteLine("\nHumano");
            a.Olhos();
            a.Cabelos();

            Console.WriteLine("\nPessoa");
            b.Olhos();
            b.Cabelos();

            Console.WriteLine("\nHomem");
            c.Olhos();
            c.Cabelos();

            Console.ReadKey();
        }
    }
}
