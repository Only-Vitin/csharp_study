using System;
using System.Threading;

using Entidades;
using Utils;
using View;

namespace Opcoes
{
    public class OpcoesAdm
    {
        public static bool SelecionaOpcoes()
        {
            menuAdm:
            try
            {
                Menu.ExibeMenuAdm();
                int opcao = int.Parse(Console.ReadLine());
                if(opcao == 1)
                {
                    Loja.AdicionaJogo();
                    Tecla.TeclaVoltar();
                    return true;
                }
                else if(opcao == 2)
                {
                    return false;
                }
                else throw new FormatException();
            }
            catch(FormatException)
            {
                Console.WriteLine("*** Digite apenas o número de uma das opções acima ***");
                Thread.Sleep(1000);
                Console.Clear();
                goto  menuAdm;
            }
        }
    }
}