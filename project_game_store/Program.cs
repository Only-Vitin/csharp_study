using System;
using System.Net.Mail;

namespace project_game_store
{
    class Program
    {
        static void Main(string[] args)
        {
            login:
            Jogo jogo1 = new("Minecraft", "Aventura", "Xbox,Desktop,Mobile", false, 123.32);
            Jogo jogo2 = new("Cuphead", "Ação", "Desktop,Mobile", false, 50);
            Loja.listaDeJogo.Add(jogo1);
            Loja.listaDeJogo.Add(jogo2);

            Logo.ExibeLogo();
            Console.Write("Quem deseja logar? adm - cliente: ");
            string usuario = Console.ReadLine();
            if(usuario == "cliente")
            {
                Console.Write("\nDigite seu nome: ");
                string nome = Console.ReadLine();
                Cliente cliente = new(nome, 100);

                while(true)
                {
                    if(!OpcoesCliente.Executa(cliente)){
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
            }
            else
            {
                Console.WriteLine("Por favor, escolha entre administrador ou cliente\n");
            }
        }
    }
}
