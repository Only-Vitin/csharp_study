using System;
using System.Collections.Generic;
using System.Threading;

using Main;
using Opcoes;

namespace Entidades
{
    public class Loja
    {
        public List<Jogo> listaDeJogo = new();

        public Loja(string nomeLoja)
        {
            NomeLoja = nomeLoja;
        }

        public string NomeLoja { get; }

        public static void AdicionaJogo()
        {   
            inicioAddJogo:
            try
            {
                if(Program.listaDeLojas.Count == 0)
                {
                    Console.WriteLine("Não tem nenhuma loja para adicionar");
                }

                Console.Write("Digite o nome, o genero, a plataforma, se é para maiores de 18 e o preço (separado por espaço): ");
                string[] infos = Console.ReadLine().Split(' ');
                string nome = infos[0], genero = infos[1], plataforma = infos[2];
                bool maior18 = bool.Parse(infos[3]);
                double preco = double.Parse(infos[4]);
                
                foreach(Loja loja in Program.listaDeLojas)
                {
                    FuncoesLoja.AdicionaJogoService(nome, genero, plataforma, maior18, preco, loja);
                }
                Console.WriteLine("\nJogo adicionado");
            }
            catch(FormatException)
            {
                Console.WriteLine("*** Algum parâmetro está errado ***\n");
                Thread.Sleep(1000);
                Console.Clear();
                goto inicioAddJogo;
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("*** Por favor digite todas as informações pedidas ***\n");
                Thread.Sleep(1000);
                Console.Clear();
                goto inicioAddJogo;
            }
        }

        public static void CompraJogo(Cliente cliente, Loja loja)
        {
            Console.WriteLine("Qual o id do jogo deseja comprar? ");
            int idJogo = int.Parse(Console.ReadLine());

            FuncoesLoja.CompraJogoService(cliente, idJogo, loja);
        }
    }
}
