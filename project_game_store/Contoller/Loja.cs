using System;
using System.Collections.Generic;

namespace project_game_store
{
    public class Loja
    {
        public static List<Jogo> listaDeJogo = new();

        public static void AdicionaJogo()
        {
            Console.Write("Por favor digite o nome, o genero, a plataforma, se é para maiores de 18 e o preço (separado por espaço): ");
            string[] infos = Console.ReadLine().Split(' ');
            string nome = infos[0], genero = infos[1], plataforma = infos[2];
            bool maior18 = bool.Parse(infos[3]);
            double preco = double.Parse(infos[4]);

            FuncoesLoja.AdicionaJogoService(nome, genero, plataforma, maior18, preco);
        }

        public static void CompraJogo(Cliente cliente)
        {
            Console.WriteLine("Qual o id do jogo deseja comprar? ");
            int idJogo = int.Parse(Console.ReadLine());

            FuncoesLoja.CompraJogoService(cliente, idJogo);
        }
    }
}
