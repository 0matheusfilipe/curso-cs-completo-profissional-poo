using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeral
{
    internal class Aluno
    {
        public string Nome { get; private set; }
        private double[] _notas;
        public double Media 
        {
            get
            {
                return CalcularMedia();
            } 
        }

        public Aluno(string nome, int qtdProvas)
        {
            Nome = nome;
            _notas = new double[qtdProvas];
        }
        
        public void ArmazenarNotas()
        {
            for(int i = 0;  i < _notas.Length; i++)
            {
                Console.Write($"Informe a {i}ª nota: ");
                _notas[i] = double.Parse(Console.ReadLine());
            }
        }

        private double CalcularMedia()
        {
            double total = 0;
            for (int i = 0; i < _notas.Length; i++)
            {
                total += _notas[i];
            }
            return (total/_notas.Length);
        }
    }
}
