using System;
using System.Reflection.Metadata;

namespace project_games_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindos a steam do vitin");
            Console.Write("Quem vai logar? Futuramente terá uma senha: (adm) - (user) ");
            string user = Console.ReadLine();
            if(user == "adm")
            {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();
                Administrador adm = new(nome);
            }
        }
    }
}
