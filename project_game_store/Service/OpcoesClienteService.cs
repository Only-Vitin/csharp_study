using System;

using Entidades;

namespace Opcoes
{
    public class FuncoesLojaCliente
    {
        public static void ListaJogos(Loja loja)
        {
            foreach (Jogo jogo in loja.listaDeJogo)
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
