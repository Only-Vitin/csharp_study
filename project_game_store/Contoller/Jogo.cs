using System.Collections.Generic;
using System.Linq;

using Main;

namespace Entidades
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

        public int GeraId()
        {   
            Loja firstLoja = Program.listaDeLojas.First();
            Cliente firstCliente = Program.listaDeClientes.First(n => n.Nome == firstLoja.NomeLoja);
            List<Jogo> todosJogos = firstLoja.listaDeJogo.Concat(firstCliente.biblioteca).ToList();
            foreach(Jogo jogo in todosJogos)
            {
                if(Nome.Equals(jogo.Nome))
                {
                    return jogo.id;
                }
            }
            Program.id ++;
            return Program.id;
        }

        public bool instalado = false;
        public int id;

        public override string ToString()
        {   
            string boolMaior18 = Maior18 == true ? "Sim" : "Não";
            if(instalado)
            {
                return $"Id: {id} => Nome: {Nome} - Genero: {Genero} - Plataforma: {Plataforma} - +18: {boolMaior18} - Preço: R$ {Preco} (INSTALADO)";
            }
            return $"Id: {id} => Nome: {Nome} - Genero: {Genero} - Plataforma: {Plataforma} - +18: {boolMaior18} - Preço: R$ {Preco}";
        }
    }
}
