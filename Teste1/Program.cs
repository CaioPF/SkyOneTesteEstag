using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1;
            float nota2;
            float media;

            Console.WriteLine("Bem vindo ao teste 1");
            Console.WriteLine("Digite a nota do primeiro semestre: ");
            while (!float.TryParse(Console.ReadLine(), out nota1))
            {
                Console.WriteLine("Valor inválido. Digite um valor numérico: ");
            }

            Console.WriteLine("Digite a nota do segundo semestre: ");
            while (!float.TryParse(Console.ReadLine(), out nota2))
            {
                Console.WriteLine("Valor inválido. Digite um valor numérico: ");
            }

            media = (nota1 + nota2) / 2;

            Console.Write("Sua média é de " + media);
            Console.ReadKey();
        }
    }
}
