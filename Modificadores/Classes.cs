using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    internal class Teste
    {
        private string nome;
        public string sobrenome;

        private void Metodo1() { }
        public void Executar() { }
    }
    class Humano
    {
        protected string nome;
        // protected: semelhante ao private. visivel para quem herda, porem objeto nao tem acesso
        private string sobrenome;
        internal int idade;
    }
    class Homem : Humano
    {
        public void Metodo()
        {
            nome = "";
            idade = 0;
        }
    }
}
