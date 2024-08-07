using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Carro : Veiculo
    {
        public int VelocidadeMaxima {  get; set; }
        public void LigarMotor()
        {
            Console.WriteLine("O motor do carro foi ligado.");
        }
        public override void Acelerar()
        {
            Console.WriteLine("Velocidade do carro aumentada!");
        }
        public override void Parar()
        {
            Console.WriteLine("Parou o carro!");
        }
    }
}
