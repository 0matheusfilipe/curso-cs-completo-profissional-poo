using MediaGeral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "=== Média Geral dos Alunos ===";

            Console.Write("Qual a quantidade de aluno?");
            int numAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno[] alunos = new Aluno[numAlunos];
            
            for(int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Insira o nome do {i}º aluno: ");
                string nome = Console.ReadLine();
                Console.WriteLine($"Insira o número de provas realizadas pelo {i}º aluno: ");
                int numProvas = int.Parse(Console.ReadLine());
                
                alunos[i] = new Aluno(nome, numProvas);
                Console.WriteLine($"Insira as notas do aluno {nome}: ");
                alunos[i].ArmazenarNotas();
            }

            Console.Clear();

            double mediaGeral = 0;
            foreach(Aluno aluno in alunos)
            {
                Console.WriteLine($"Aluno: {aluno.Nome}");
                Console.WriteLine($"Média: {aluno.Media}");

                mediaGeral += aluno.Media;
            }

            double resultadoFinal = mediaGeral / alunos.Length;

            Console.WriteLine($"Média geral dos alunos: {resultadoFinal}");

            Console.ReadKey();
        }
    }
}
