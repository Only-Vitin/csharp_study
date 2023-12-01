using System;

namespace project_game_store
{
    public class Jogo
    {
        public Jogo(string nome, string genero, string plataforma, bool maior18, double preco)
        {
            Nome = nome;
            Genero = genero;
            Plataforma = plataforma;
            Maior18 = maior18;
            Preco = preco;
        }

        public string Nome { get; }
        public string Genero { get; }
        public string Plataforma { get; }
        public bool Maior18 { get; }
        public double Preco { get; }
    }
}