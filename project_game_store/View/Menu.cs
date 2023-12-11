using System;

using Entidades;

namespace View
{
    public class Menu
    {
        public static void ExibeMenuCliente(Cliente cliente)
        {
            Console.Clear();
            Console.WriteLine(cliente + "\n");
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("1 -> Loja\n2 -> Biblioteca\n3 -> Logout\n");
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
            Console.WriteLine("1 -> Listar os jogos comprados.\n2 -> Instalar um jogo.\n3 -> Desinstalar um jogo\n4 -> Voltar\n");
        }

        public static void ExibeMenuAdm()
        {
            Console.Clear();
            Console.WriteLine("Menu do rapaz que manda\n");
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("1 -> Adicionar jogo\n2 -> Logout\n");
        }
    }
}
