using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace project_game_store
{
    public class Loja
    {
        public static List<Jogo> listaDeJogo = new();
        private string _nomeLoja = "Steam verde";

        public static void AdicionaJogo()
        {
            Console.Write("Por favor digite o nome, o genero, a plataforma, se é para maiores de 18 (separado por espaço): ");
            string[] infos = Console.ReadLine().Split(' ');
            string nome = infos[0], genero = infos[1], plataforma = infos[2];
            bool maior18 = bool.Parse(infos[3]);
            Console.WriteLine("Qual o preço do jogo? ");
            double preco = double.Parse(Console.ReadLine());

            Jogo jogo = new(nome, genero, plataforma, maior18, preco);

            listaDeJogo.Add(jogo);
        }
    }
}
