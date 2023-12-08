using System;
using System.Collections.Generic;
using System.Threading;

namespace project_game_store
{
    class Program
    {
        public static List<Cliente> listaDeClientes = new();
        public static List<Loja> listaDeLojas = new();
        public static int id;

        static void Main(string[] args)
        {   
            Logo.ExibeLogo();
            login:
            Console.Write("Quem deseja logar? adm - cliente: ");
            string usuario = Console.ReadLine();
            if(usuario == "cliente")
            {
                Console.Write("\nDigite seu nome: ");
                string nomeDigitado = Console.ReadLine();
                Console.Write("\nDigite sua idade: ");
                int idade = int.Parse(Console.ReadLine());

                Cliente clienteAtual = SelecionaCliente.ClienteAtual(nomeDigitado, idade);
                Loja lojaAtual = SelecionaCliente.SelecionaLoja(clienteAtual);


                while(true)
                {
                    if(!OpcoesCliente.SelecionaOpcoes(clienteAtual, lojaAtual))
                    {
                        Console.Clear();
                        goto login;
                    }
                }
            }
            else if(usuario == "adm")
            {
                Console.Write("Digite a senha: ");
                string senhaDigitada = Console.ReadLine();
                string senha = "123";
                if(senhaDigitada != senha)
                {
                    Console.Clear();
                    Console.WriteLine("*** Senha Errada ***\n");
                    goto login;
                }

                Console.WriteLine("Logado");
                Loja.AdicionaJogo();
                goto login;
            }
            else
            {
                Console.WriteLine("\nPor favor, escolha entre administrador ou cliente\n");
                Thread.Sleep(1000);
                Console.Clear();
                Logo.ExibeLogo();
                goto login;
            }
        }
    }
}
