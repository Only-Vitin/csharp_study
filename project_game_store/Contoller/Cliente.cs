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
            
            Console.WriteLine("Você não tem saldo suficiente!");
            return false;
        }

        public bool VerificaIdade(bool maior18)
        {
            if(!maior18) return true;
            if(Idade >= 18) return true;

            Console.WriteLine("Você precisa ter no mínimo 18 anos!");
            return false;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} - Idade: {Idade} - Saldo: {_saldo}";
        }
    }
}
