﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            //t.nome = " ";
            t.sobrenome = " ";
            t.Executar();
            //t.Metodo1();

            Homem h = new Homem();
            h.idade = 18;
        }
    }
}
