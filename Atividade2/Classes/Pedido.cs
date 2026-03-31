using System;

namespace ProjetoLanchonete.Classes
{
    public class Pedido
    {
        private string nomeCliente;
        private double valor;
        private double taxaEntrega;

        public Pedido(string nomeCliente, double valor)
        {
            this.nomeCliente = nomeCliente;
            this.valor = valor;
            this.taxaEntrega = 0;
        }

        public Pedido(string nomeCliente, double valor, double taxaEntrega)
        {
            this.nomeCliente = nomeCliente;
            this.valor = valor;
            this.taxaEntrega = taxaEntrega;
        }

        public double CalcularTotal()
        {
            return valor + taxaEntrega;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("---------- DETALHES DO PEDIDO ----------");
            Console.WriteLine($"Cliente: {nomeCliente}");
            Console.WriteLine($"Valor do pedido: R${valor:F2}");
            if (taxaEntrega > 0)
            {
                Console.WriteLine($"Taxa de entrega: R${taxaEntrega:F2}");
            }
            Console.WriteLine($"Total a pagar: R${CalcularTotal():F2}");
            Console.WriteLine("-----------------------------------------");
        }  

    }
}