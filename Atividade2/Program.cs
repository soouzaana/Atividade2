using System;
using ProjetoLanchonete.Classes;

class Program
{
    static void Main()
    {
        Console.Clear();

        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Valor do pedido: ");
        double valor = double.Parse(Console.ReadLine());

        Console.Write("Deseja entrega (s/n)? ");
        string entrega = Console.ReadLine().ToLower();

        Console.Clear();

        Pedido pedido;

        if(entrega == "s") {
            Console.Write("Digite a taxa de entrega: ");
            double taxa = double.Parse(Console.ReadLine());

            pedido = new Pedido(nome, valor, taxa);
        }
        else
        {
            pedido = new Pedido(nome, valor);
        }

        Console.Clear();

        pedido.ExibirDetalhes();
    }
}