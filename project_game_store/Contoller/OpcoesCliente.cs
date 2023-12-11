using System;
using System.Threading;
using Entidades;
using Utils;
using View;

namespace Opcoes
{
    public class OpcoesCliente
    {
        public static bool SelecionaOpcoes(Cliente cliente, Loja loja)
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
                            FuncoesLojaCliente.ListaJogos(loja);
                            Tecla.TeclaVoltar();
                            break;
                        case 2:
                            Loja.CompraJogo(cliente, loja);
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
                            Console.Write("Qual o id do jogo que deseja instalar? ");
                            int idJogo = int.Parse(Console.ReadLine());
                            cliente.InstalaJogo(idJogo);
                            Tecla.TeclaVoltar();
                            break;
                        case 3:
                            Console.Write("Qual o id do jogo que deseja desinstalar? ");
                            idJogo = int.Parse(Console.ReadLine());
                            cliente.DesinstalaJogo(idJogo);
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
            catch(InvalidOperationException)
            {
                Console.WriteLine("*** Opção Inválida ***");
                Thread.Sleep(1000);
                Console.Clear();
                goto menuCliente;
            }
        }
    }
}
