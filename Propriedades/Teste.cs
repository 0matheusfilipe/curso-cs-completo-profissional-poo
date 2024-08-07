using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Teste
    {
        // Definição de um campo
        // controle de acesso de um campo com private
        private string _nome;
        public string Sobrenome
        { get; } = "de Deus Silva";
        
        private int _idade;

        // Definição de uma propriedade
        // Deve ser acessivel, portanto, public
        public string Nome
        {
            get
            {
                // Retorna o valor do campo em que essa propriedade trabalha
                return _nome;
            }

            set
            {
                // Atribui o valor para o determinado campo -> valor que for definido para a propriedade "Nome" será atribuido para o campo _nome
                _nome = value;
            }
        }
        public int Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                if(value < 18)
                {
                    Console.WriteLine("Idade não pode ser inferior a 18 anos.");
                }
                else
                {
                    _idade = value;
                }
            }
        }

        public void Apresentar()
        {
            if (_nome != "")
            {
                Console.WriteLine("Seja bem-vindo, " + _nome);
            }
        }
    }
}
