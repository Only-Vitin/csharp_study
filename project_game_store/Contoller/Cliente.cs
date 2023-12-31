using System;
using System.Collections.Generic;
using System.Linq;

namespace Entidades
{
    public class Cliente
    {
        public List<Jogo> biblioteca = new(); 
        private double _saldo = GeraSaldo();
        public Cliente(string nome, int idade)
        {
            Nome = nome;
            if(idade > 0 && idade < 200)
            {
                Idade = idade;
            }
            else
            {
                throw new FormatException();
            }
        }

        public string Nome { get; }
        public int Idade { get; }

        private static double GeraSaldo()
        {   
            double min = 150;
            double max = 1000;
            Random random = new();
            double numeroRandom = random.NextDouble() * (max - min) + min;
            return Math.Round(numeroRandom, 2);
        }

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

        public void InstalaJogo(int idJogo)
        {
            Jogo jogoEscolhido = biblioteca.First(j => j.id.Equals(idJogo));
            if(!jogoEscolhido.instalado)
            {
                jogoEscolhido.instalado = true;
                Console.WriteLine("\nJogo instalado com sucesso");
            }
            else
            {
                Console.WriteLine("\nO jogo já está instalado");
            }
        }

        public void DesinstalaJogo(int idJogo)
        {
            Jogo jogoEscolhido = biblioteca.First(j => j.id.Equals(idJogo));
            if(jogoEscolhido.instalado)
            {
                jogoEscolhido.instalado = false;
                Console.WriteLine("\nJogo desinstalado com sucesso");
            }
            else
            {
                Console.WriteLine("\nO jogo não está instalado");
            }
        }

        public override string ToString()
        {
            return $"Nome: {Nome} - Idade: {Idade} - Saldo: {_saldo}";
        }
    }
}
