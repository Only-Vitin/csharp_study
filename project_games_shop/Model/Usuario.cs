using System;

namespace project_games_shop
{
    public class Usuario
    {
        public Usuario(string nome, double saldo)
        {
            Nome = nome;
            Saldo = saldo;
        }

        public string Nome { get; }
        public double Saldo { get; }
    }
}