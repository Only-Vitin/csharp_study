using System;

namespace project_game_store
{
    public class FuncoesLojaCliente
    {
        public static void ListaJogos()
        {
            foreach (Jogo jogo in Loja.listaDeJogo)
            {
                Console.WriteLine(jogo);
            }
        }
    }

    public class FuncoesBibliotecaCliente
    {
        public static void ListaJogos(Cliente cliente)
        {
            foreach (Jogo jogo in cliente.biblioteca)
            {
                Console.WriteLine(jogo);
            }
        }
    }
}