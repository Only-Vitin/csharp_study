using System;

namespace project_game_store
{
    public class Menu
    {
        public static void ExibeMenuCliente(Cliente cliente)
        {
            Console.Clear();
            Console.WriteLine(cliente + "\n");
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("1 -> Loja\n2 -> Biblioteca\n");
        }

        public static void ExibeMenuLojaCliente()
        {
            Console.Clear();
            Console.WriteLine("Opções da Loja: ");
            Console.WriteLine("1 -> Listar os jogos disponiveis.\n2 -> Comprar um jogo.\n3 -> Voltar\n");
        }

        public static void ExibeMenuBibliotecaCliente()
        {
            Console.Clear();
            Console.WriteLine("Opções da Biblioteca: ");
            Console.WriteLine("1 -> Listar os jogos disponiveis.\n2 -> Comprar um jogo.\n3 -> Voltar\n");
        }
    }
}
