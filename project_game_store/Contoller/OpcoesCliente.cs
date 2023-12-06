using System;
using System.Threading;

namespace project_game_store
{
    public class OpcoesCliente
    {
        public static bool SelecionaOpcoes(Cliente cliente)
        {
            menuCliente:
            try
            {
                Menu.ExibeMenuCliente(cliente);
                int opcao = int.Parse(Console.ReadLine());
                if(opcao == 1)
                {
                    Menu.ExibeMenuLojaCliente();
                    opcao = int.Parse(Console.ReadLine());
                    switch(opcao)
                    {
                        case 1:
                            FuncoesLojaCliente.ListaJogos();
                            Tecla.TeclaVoltar();
                            break;
                        case 2:
                            Loja.CompraJogo(cliente);
                            Tecla.TeclaVoltar();
                            break;
                        case 3:
                            goto menuCliente;
                        default:
                            throw new FormatException();
                    }
                    return true;
                }
                else if(opcao == 2)
                {
                    Menu.ExibeMenuBibliotecaCliente();
                    opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            FuncoesBibliotecaCliente.ListaJogos(cliente);
                            Tecla.TeclaVoltar();
                            break;
                        case 2:
                            Tecla.TeclaVoltar();
                            break;
                        case 3:
                            Tecla.TeclaVoltar();
                            break;
                        case 4:
                            goto menuCliente;
                        default:
                            throw new FormatException();
                    }
                    return true;
                }
                else if(opcao == 3) return false;
                else throw new FormatException();
            }
            catch(FormatException)
            {
                Console.WriteLine("*** Digite apenas o número de uma das opções acima ***");
                Thread.Sleep(1000);
                Console.Clear();
                goto menuCliente;
            }
        }
    }
}
