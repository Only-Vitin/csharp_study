using System;
using System.Linq;

using Entidades;
using Main;

namespace Utils
{
    public class SelecionaCliente
    {
        public static Cliente ClienteAtual(string nomeDigitado)
        {
            foreach(Cliente clienteI in Program.listaDeClientes)
            {
                if(clienteI.Nome == nomeDigitado)
                {
                    return clienteI;
                }
            }

            digitarIdade:
            try
            {
                Console.Write("\nDigite sua idade: ");
                int idade = int.Parse(Console.ReadLine());
                Cliente cliente = new(nomeDigitado, idade);
                Program.listaDeClientes.Add(cliente);
                return cliente;
            }
            catch(FormatException)
            {
                Console.WriteLine("Algo de errado com o valor digitado");
                goto digitarIdade;
            }
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
