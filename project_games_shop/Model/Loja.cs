using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace project_games_shop
{
    public class Loja
    {
        private List<Jogos> ListaJogos = new();

        public void AdicionaJogo(Jogos jogo){
            ListaJogos.Add(jogo);
        }

        public void ExibeJogos(){
            foreach (Jogos jogo in ListaJogos)
            {
                Console.WriteLine(jogo.Descricao);
            }
        }
    }
}