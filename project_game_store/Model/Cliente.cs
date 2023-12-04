using System;
using System.Collections.Generic;

namespace project_game_store
{
    public class Cliente
    {
        public List<Jogo> biblioteca = new(); 
        private double _saldo = 100;
        public Cliente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; }
        public int Idade { get; }

        private void SubtaiSaldo(double valorDoJogo)
        {
            _saldo -= valorDoJogo;
        } 

        public bool VerificaSaldo(double valorDoJogo)
        {
            if(_saldo >= valorDoJogo)
            {
                SubtaiSaldo(valorDoJogo);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} - Saldo: {_saldo}";
        }
    }
}
