using System;
using System.Collections.Generic;
using System.Linq;

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

        public static void CompraJogo(Cliente cliente)
        {
            Console.WriteLine("Qual o id do jogo deseja comprar? ");
            int idJogo = int.Parse(Console.ReadLine());

            Jogo jogoEscolhido = listaDeJogo.First(j => j.id.Equals(idJogo));

            if(cliente.VerificaSaldo(jogoEscolhido.Preco) && cliente.VerificaIdade(jogoEscolhido.Maior18))
            {
                cliente.biblioteca.Add(jogoEscolhido);
                listaDeJogo.Remove(jogoEscolhido);
                Console.WriteLine("Comprado, verifique a biblioteca");
            }
        }
    }
}
