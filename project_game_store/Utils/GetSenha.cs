using System;

using View;

namespace Utils
{
    public class GetSenha
    {
        public static string Senha()
        {
            string senha = "";
            ConsoleKeyInfo key;
            do
            {
                senha:
                try
                {
                    key = Console.ReadKey(true);
                    if(key.Key == ConsoleKey.Backspace)
                    {
                        senha = senha.Remove(senha.Length - 1);
                        Console.Clear();
                        Logo.ExibeLogo();
                        Console.Write("Quem deseja logar? adm - cliente: adm");
                        Console.Write("\nDigite a senha: ");
                        for(int i = 0; i < senha.Length; i++) Console.Write("*");
                    }
                    else if (key.Key != ConsoleKey.Enter)
                    {   
                        senha += key.KeyChar;
                        Console.Write("*");
                    }
                }
                catch(ArgumentOutOfRangeException)
                {
                    goto senha;
                }
            }while(key.Key != ConsoleKey.Enter);

            return senha;
        }
    }
}