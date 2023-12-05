using System;
using System.Collections.Generic;
using System.Linq;

namespace project_game_store
{
    public class FuncoesLoja
    {
        public static void AdicionaJogoService(string nome, string genero, string plataforma, bool maior18, double preco)
        {
            Jogo jogo = new(nome, genero, plataforma, maior18, preco);
            Loja.listaDeJogo.Add(jogo);
        }

        public static void CompraJogoService(Cliente cliente, int idJogo)
        {
            Jogo jogoEscolhido = Loja.listaDeJogo.First(j => j.id.Equals(idJogo));

            if(cliente.VerificaSaldo(jogoEscolhido.Preco) && cliente.VerificaIdade(jogoEscolhido.Maior18))
            {
                cliente.biblioteca.Add(jogoEscolhido);
                Loja.listaDeJogo.Remove(jogoEscolhido);
                Console.WriteLine("Comprado, verifique a biblioteca");
            }
        }
    }
}