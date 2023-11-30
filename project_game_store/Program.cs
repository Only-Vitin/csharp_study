using System;

namespace project_game_store
{
    class Program
    {
        static void Main(string[] args)
        {
            Logo.ExibeLogo();

            Menu.ExibeMenuCliente();
            int opcao = int.Parse(Console.ReadLine());
        }
    }
}
