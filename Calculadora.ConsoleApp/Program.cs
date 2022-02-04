using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                float n1 = 0;
                float n2 = 0;
                float resposta = 0;
                int opcao = 0;
                bool sucesso;
                Console.WriteLine("Calculadora 1.0");
                Console.WriteLine("digite o primeiro numero");
                volta1:
                sucesso = float.TryParse(Console.ReadLine(), out n1);
                if (sucesso == false)
                {
                    Console.Clear();
                    Console.WriteLine("valor invalido tente novamente");
                    goto volta1;
                }
            volta2:
                Console.WriteLine("digite a operação ");
                Console.WriteLine("1 - adição ");
                Console.WriteLine("2 - subitração ");
                Console.WriteLine("3 - multiplicação ");
                Console.WriteLine("4 - divisão ");
                sucesso = int.TryParse(Console.ReadLine(), out opcao);
                if (sucesso == false || opcao > 4 || opcao <0)
                {
                    
                    Console.Clear();
                    Console.WriteLine("valor invalido tente novamente");
                    goto volta2;
                }
            volta3:
                Console.WriteLine("digite o segundo numero");
                 sucesso = float.TryParse(Console.ReadLine(), out n2);
                if (sucesso == false)
                {
                    Console.Clear();
                    Console.WriteLine("valor invalido tente novamente");
                    goto volta3;
                }
                switch (opcao)
                {

                    case 1:
                        resposta = n1 + n2;
                        Console.Clear();
                        Console.WriteLine($"{n1} + {n2} = {resposta} ");
                        goto sair; 
                    case 2:
                        resposta = n1 - n2;
                        Console.Clear();
                        Console.WriteLine($"{n1} - {n2} = {resposta} ");
                        goto sair; 
                    case 3:
                        resposta = n1 * n2;
                        Console.Clear();
                        Console.WriteLine($"{n1} * {n2} = {resposta} ");
                        goto sair; 
                    case 4:
                        if (n2 == 0)
                        {
                            Console.WriteLine("não pode dividir por 0");
                            goto volta3;
                        }
                        resposta = n1 / n2;
                        Console.Clear();
                        Console.WriteLine($"{n1} / {n2} = {resposta} ");
                        goto sair;
                }
                sair:
                Console.WriteLine("deseja sair?  s/n");
               char.TryParse(Console.ReadLine(), out char sair);
                if (!(sair == 's'|| sair == 'n' ))
                {
                    Console.Clear();
                    Console.WriteLine("valor invalido tente novamente");
                    goto sair;
                }
                else if (sair == 's')
                {
                    break;
                }
                else if (sair == 'n')
                {
                    continue;
                }
            }
        }
    }
}
