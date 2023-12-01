using System;

namespace project_game_store
{
    public class OpcoesCliente
    {
        public static void Executa(Cliente cliente)
        {
            inicio:
            Menu.ExibeMenuCliente(cliente);
            int opcao = int.Parse(Console.ReadLine());
            if(opcao == 1)
            {
                Menu.ExibeMenuLojaCliente();
                opcao = int.Parse(Console.ReadLine());
                switch(opcao)
                {
                    case 1:
                        //Listar
                        break;
                    case 2:
                        //Comprar
                        break;
                    case 3:
                        goto inicio;
                }
            }
            else if(opcao == 2)
            {
                Menu.ExibeMenuBibliotecaCliente();
                opcao = int.Parse(Console.ReadLine());
            }
        }
    }
}