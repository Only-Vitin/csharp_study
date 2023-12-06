using System;

namespace project_game_store
{
    public class SelecionaCliente
    {
        public static Cliente Executa(string nomeDigitado, int idade)
        {
            foreach(Cliente clienteI in Program.listaDeClientes)
                if(clienteI.Nome == nomeDigitado)
                {
                    return clienteI;
                }
                Cliente cliente = new(nomeDigitado, idade);
                Program.listaDeClientes.Add(cliente);
                return cliente;
        }
    }
}