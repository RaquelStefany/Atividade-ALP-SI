using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeProduto, fimPrograma = null;
            double qtdMercadoria = 0, precoMercadoria = 0, totalMercadoria = 0, precoVenda = 0;

            do
            {
                Console.WriteLine("Insira o nome do Produto:");
                nomeProduto = Console.ReadLine();

                if (nomeProduto != "")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Digite o preço da Mercadoria:");
                    precoMercadoria = double.Parse(Console.ReadLine());

                    if (precoMercadoria > 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Digite a quantidade de Mercadorias:");
                        qtdMercadoria = double.Parse(Console.ReadLine());

                        if (qtdMercadoria > 0)
                        {
                            totalMercadoria = (precoMercadoria * 0.3) + (precoMercadoria * qtdMercadoria);
                            precoVenda = totalMercadoria + (totalMercadoria * 0.3);

                            Console.WriteLine("");
                            Console.WriteLine("O valor total da Mercadoria é: " + totalMercadoria);
                            Console.WriteLine("o preço de venda da Mercadoria é: " + precoVenda);

                            Console.WriteLine("");
                            Console.WriteLine("Deseja encerrar o programa?\nS - Sim\nN - Não\n");
                            fimPrograma = Console.ReadLine().ToUpper();
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Digite a quantidade de Mercadorias:");
                            qtdMercadoria = double.Parse(Console.ReadLine());
                        }
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Digite o preço da Mercadoria:");
                        precoMercadoria = double.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Insira o nome do Produto:");
                    nomeProduto = Console.ReadLine();
                }
            }
            while (fimPrograma != "S");
            Console.ReadKey();
        }
    }
}
