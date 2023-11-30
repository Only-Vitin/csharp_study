using System;

namespace project_game_store
{
    public class Cliente
    {
        public Cliente(string nome, double saldo)
        {
            Nome = nome;
            Saldo = saldo;
        }

        public string Nome { get; }
        public double Saldo { get; }

        
    }
}