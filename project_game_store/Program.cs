using System;

namespace project_game_store
{
    class Program
    {
        static void Main(string[] args)
        {
            Logo.ExibeLogo();
            Console.Write("Quem deseja logar? adm - cliente: ");
            string usuario = Console.ReadLine();
            if(usuario == "cliente")
            {
                Console.Write("\nDigite seu nome: ");
                string nome = Console.ReadLine();
                Cliente cliente = new(nome, 100);

                OpcoesCliente.Executa(cliente);
            }
            else if(usuario == "adm")
            {

            }
            else
            {
                Console.WriteLine("Por favor, escolha entre administrador ou cliente\n");
            }
        }
    }
}
