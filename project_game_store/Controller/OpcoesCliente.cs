using System;
using System.Runtime.InteropServices;

namespace project_game_store
{
    public class OpcoesCliente
    {
        public static bool Executa(Cliente cliente)
        {
            menuCliente:
            Menu.ExibeMenuCliente(cliente);
            int opcao = int.Parse(Console.ReadLine());
            if(opcao == 1)
            {
                Menu.ExibeMenuLojaCliente();
                opcao = int.Parse(Console.ReadLine());
                switch(opcao)
                {
                    case 1:
                        foreach (Jogo jogo in Loja.listaDeJogo)
                        {
                            Console.WriteLine(jogo);
                        }
                        break;
                    case 2:
                        //Comprar
                        break;
                    case 3:
                        goto menuCliente;
                    default:
                        Console.WriteLine("Digite uma dar opções acima");
                        break;
                }
                return true;
            }
            else if(opcao == 2)
            {
                Menu.ExibeMenuBibliotecaCliente();
                opcao = int.Parse(Console.ReadLine());
                return true;
            }
            else if(opcao == 3)
            {
                return false;
            }
            return true;
        }
    }
}