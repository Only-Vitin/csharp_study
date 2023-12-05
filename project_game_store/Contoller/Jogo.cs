using System.Linq;

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

        private static int GeraId()
        {
            int quantJogos = Loja.listaDeJogo.Count;
            if(quantJogos == 0)
            {
                return 1;
            }
            return Loja.listaDeJogo.Max(jogo => jogo.id) + 1;
        }
        
        public int id = GeraId();

        public override string ToString()
        {
            string boolMaior18 = Maior18 == true ? "Sim" : "Não";
            return $"Id: {id} => Nome: {Nome} - Genero: {Genero} - Plataforma: {Plataforma} - +18: {boolMaior18} - Preço: R$ {Preco}";
        }
    }
}