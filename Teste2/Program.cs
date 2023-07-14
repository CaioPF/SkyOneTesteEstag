using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float nota;
            int cont = 0;
            float soma = 0;
            float media;

            Console.WriteLine("Bem vindo ao teste 2, para iniciarmos qual é o seu nome?");
            nome = Console.ReadLine();

            do
            {
                Console.WriteLine(nome + ", por favor, nos informe qual foi a sua nota na prova?");
                while (!float.TryParse(Console.ReadLine(), out nota))
                {
                    Console.WriteLine("Valor inválido. Digite um valor numérico: ");
                }
                cont += 1;
                soma = soma + nota;
                media = soma/cont;

                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Quantidade de provas: " + cont);
                Console.WriteLine("Total de nota: " + soma);
                Console.WriteLine("Sua média é de " + media);
                Console.WriteLine();
            }
            while (true);            
        }
    }
}
