using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeAluno, fimPrograma = null;
            double nota1, nota2, media;

            do
            {
                Console.WriteLine("Digite o nome do Aluno:");
                nomeAluno = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine("Digite a 1ª nota:");
                nota1 = double.Parse(Console.ReadLine());

                Console.WriteLine("");

                Console.WriteLine("Digite a 2ª nota:");
                nota2 = double.Parse(Console.ReadLine());

                media = (nota1 + nota2) / 2;

                if (media < 6.0)
                {
                    double nota3;

                    Console.WriteLine("");

                    Console.WriteLine("A Média Aritmética é " + media);
                    Console.WriteLine("");
                    Console.WriteLine("Digite a 3ª nota:");
                    nota3 = double.Parse(Console.ReadLine());

                    if (nota1 > nota2)
                    {
                        media = (nota1 + nota3) / 2;
                    }
                    else
                    {
                        media = (nota2 + nota3) / 2;
                    }

                    if (media > 6.0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("A Média Aritmética é " + media);
                        Console.WriteLine("Aprovado");
                        Console.WriteLine("");
                        //Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("A Média Aritmética é " + media);
                        Console.WriteLine("Reprovado");
                        Console.WriteLine("");
                        //Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("A Média Aritmética é " + media);
                    Console.WriteLine("Aprovado");
                    Console.WriteLine("");
                    //Console.ReadKey();
                }

                Console.WriteLine("Deseja encerrar o programa?");
                fimPrograma = Console.ReadLine().ToUpper();
                Console.WriteLine("");
            }
            while (fimPrograma != "S");
            Console.ReadKey();
        }
    }
}
