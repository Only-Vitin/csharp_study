using System;
using System.Collections.Generic;
using System.Threading;

using View;
using Entidades;
using Opcoes;
using Utils;

namespace Main
{
    class Program
    {
        public static List<Cliente> listaDeClientes = new();
        public static List<Loja> listaDeLojas = new();
        public static int id;

        static void Main()
        {   
            login:
            Console.Clear();
            Logo.ExibeLogo();
            Console.Write("Quem deseja logar? adm - cliente: ");
            string usuario = Console.ReadLine();
            if(usuario == "cliente")
            {
                Console.Write("\nDigite seu nome: ");
                string nomeDigitado = Console.ReadLine();

                Cliente clienteAtual = SelecionaCliente.ClienteAtual(nomeDigitado);
                Loja lojaAtual = SelecionaCliente.SelecionaLoja(clienteAtual);

                while(true)
                {
                    if(!OpcoesCliente.SelecionaOpcoes(clienteAtual, lojaAtual))
                    {
                        goto login;
                    }
                }
            }
            else if(usuario == "adm")
            {
                Console.Write("Digite a senha: ");
                string senhaDigitada = GetSenha();
                string senha = "123";
                if(senhaDigitada != senha)
                {
                    Console.Clear();
                    Console.WriteLine("*** Senha Errada ***\n");
                    goto login;
                }

                Console.WriteLine("Logado");
                while(true)
                {
                    if(!OpcoesAdm.SelecionaOpcoes())
                    {
                        goto login;
                    }
                }
            }
            else
            {
                Console.WriteLine("\nPor favor, escolha entre administrador ou cliente\n");
                Thread.Sleep(1000);
                goto login;
            }
        }

        static string GetSenha()
        {
            string senha = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace)
                {
                    senha += key.KeyChar;
                    Console.Write("*");
                }

            }while(key.Key != ConsoleKey.Enter);

            return senha;
        }
    }
}
