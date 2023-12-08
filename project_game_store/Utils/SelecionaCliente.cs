using System.Linq;

namespace project_game_store
{
    public class SelecionaCliente
    {
        public static Cliente ClienteAtual(string nomeDigitado, int idade)
        {
            foreach(Cliente clienteI in Program.listaDeClientes)
            {
                if(clienteI.Nome == nomeDigitado)
                {
                    return clienteI;
                }
            }
            Cliente cliente = new(nomeDigitado, idade);
            Program.listaDeClientes.Add(cliente);
            return cliente;
        }

        public static Loja SelecionaLoja(Cliente cliente)
        {
            foreach(Loja lojaI in Program.listaDeLojas)
            {
                if(lojaI.NomeLoja == cliente.Nome)
                {
                    return lojaI;
                }
            }
            Loja loja = new(cliente.Nome);
            Program.listaDeLojas.Add(loja);
            Loja firstLoja = Program.listaDeLojas.First();
            Cliente firstCliente = Program.listaDeClientes.First(n => n.Nome == firstLoja.NomeLoja);
            loja.listaDeJogo = firstLoja.listaDeJogo.Concat(firstCliente.biblioteca).ToList();
            return loja;
        }
    }
}
