using System;

namespace project_games_shop
{
    public class Jogos
    {
        public Jogos(int id, string nome, string genero, float preco)
        {
            Id = id;
            Nome = nome;
            Genero = genero;
            Preco = preco;
        }

        public int Id { get; }
        public string Nome { get; }
        public string Genero { get; }
        public float Preco { get; }
        public string Descricao => $"Jogo: {Nome} - Genero: {Genero} - Preço: R$ {Preco}";

    }
}