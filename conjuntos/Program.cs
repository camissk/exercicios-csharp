using System;
using System.Collections.Generic;

namespace conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.WriteLine("O curso A possui quantos alunos?");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o código dos alunos");
            for (int i = 0; i < a; i++)
            {
                int codA = int.Parse(Console.ReadLine());
                A.Add(codA);
            }

            Console.WriteLine("O curso B possui quantos alunos?");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o código dos alunos");
            for (int i = 0; i < b; i++)
            {
                int codB = int.Parse(Console.ReadLine());
                B.Add(codB);
            }

            Console.WriteLine("O curso C possui quantos alunos?");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o código dos alunos: ");
            for (int i = 0; i < c; i++)
            {
                int codC = int.Parse(Console.ReadLine());
                C.Add(codC);
            }

            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(B);
            Novo.UnionWith(C);
            Console.WriteLine("Total de alunos: " + Novo.Count);
        }
    }
}

