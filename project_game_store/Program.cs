using System;
using System.Threading;

namespace project_game_store
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo1 = new("Minecraft", "Aventura", "Xbox,Desktop,Mobile", false, 123.32);
            Loja.listaDeJogo.Add(jogo1);
            
            login:
            Logo.ExibeLogo();
            Console.Write("Quem deseja logar? adm - cliente: ");
            string usuario = Console.ReadLine();
            if(usuario == "cliente")
            {
                Console.Write("\nDigite seu nome: ");
                string nome = Console.ReadLine();
                Cliente cliente = new(nome, 17);

                while(true)
                {
                    if(!OpcoesCliente.Executa(cliente))
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
                    goto login;
                }

                Console.WriteLine("Logado");
                Loja.AdicionaJogo();

                goto login;
            }
            else
            {
                Console.WriteLine("\nPor favor, escolha entre administrador ou cliente\n");
                Thread.Sleep(2000);
                Console.Clear();
                goto login;
            }
        }
    }
}
