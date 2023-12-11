using System;
using System.Linq;

using Entidades;

namespace Opcoes
{
    public class FuncoesLoja
    {
        public static void AdicionaJogoService(string nome, string genero, string plataforma, bool maior18, double preco, Loja loja)
        {   
            Jogo jogo = new(nome, genero, plataforma, maior18, preco);
            jogo.id = jogo.GeraId();
            loja.listaDeJogo.Add(jogo);
        }

        public static void CompraJogoService(Cliente cliente, int idJogo, Loja loja)
        {
            Jogo jogoEscolhido = loja.listaDeJogo.First(j => j.id.Equals(idJogo));

            if(cliente.VerificaSaldo(jogoEscolhido.Preco) && cliente.VerificaIdade(jogoEscolhido.Maior18))
            {
                cliente.biblioteca.Add(jogoEscolhido);
                loja.listaDeJogo.Remove(jogoEscolhido);
                Console.WriteLine("Comprado, verifique a biblioteca");
            }
        }
    }
}
