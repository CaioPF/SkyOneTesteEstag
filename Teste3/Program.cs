using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aluno;
            float nota1;
            float nota2;                        
            float media;

            Console.WriteLine("Bem vindo ao teste 3");

            do
            {
                Console.WriteLine("Informe o nome do(a) aluno(a): ");
                aluno = Console.ReadLine();

                Console.WriteLine("Qual foi a nota do primeiro semestre de " + aluno + "?");
                while (!float.TryParse(Console.ReadLine(), out nota1))
                {
                    Console.WriteLine("Valor inválido. Digite um valor numérico: ");
                }

                Console.WriteLine("Qual foi a nota do segundo semestre de " + aluno + "?");
                while (!float.TryParse(Console.ReadLine(), out nota2))
                {
                    Console.WriteLine("Valor inválido. Digite um valor numérico: ");
                }
                media = (nota1 + nota2) / 2;

                Console.WriteLine("Nome do(a) aluno(a): " + aluno);
                Console.WriteLine("Média: " + media);
                Console.Write("Aluno(a) foi: ");
                if (media < 6.5)
                {
                    Console.WriteLine("Reprovado(a)");
                }
                else
                {
                    Console.WriteLine("Aprovado(a)");
                }
                Console.WriteLine();
            }
            while (true);
        }
    }
}
