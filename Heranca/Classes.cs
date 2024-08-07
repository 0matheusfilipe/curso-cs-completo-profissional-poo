using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Humano
    {
        // Método virtual: semelhante a métodos abstratos -> diferença que o método declarado como abstract não pode ter implementação na sua declaração na classe base.
        public virtual void Olhos()
        {
            Console.WriteLine("Humanos.Olhos");
        }
        public virtual void Cabelos()
        {
            Console.WriteLine("Humanos.Cabelos");
        }
    }
    class Pessoa : Humano
    {
        public sealed override void Olhos() 
        {
            Console.WriteLine("Pessoa.Olhos");
        }
        public override void Cabelos()
        {
            Console.WriteLine("Pessoa.Cabelos");
        }
    }

    class Homem : Pessoa
    {
        //public override void Olhos()
        //{
        //    Console.WriteLine("Homem.Olhos");
        //}
        public override void Cabelos()
        {
            Console.WriteLine("Homem.Cabelos");
        }
    }
}
