using Aula02_Shift_FIAP_POO.Models;
using System;

namespace Aula02_Shift_FIAP_POO
{
    class Program
    {
        static void Main(string[] args)
        {

            // VAR declara uma variavel do tipo do valor associado
            Console.WriteLine("Digite o ID do produto: ");
            var idProduto = Console.ReadLine();

            Console.WriteLine("Digite o nome do produto:");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite a marca do produto: ");
            var  marca = Console.ReadLine();

            Console.WriteLine("Digite o preco do produto: ");
            decimal preco = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite  a quantidade em estoque do produto: ");
            int estoque = Convert.ToInt32(Console.ReadLine());

            Produto p = new Produto();
            p.Nome = nome;
            p.Marca = marca;
            p.Preco = preco;
            p.Estoque = estoque;
            p.idProduto = idProduto;

            p.ExibirDados();
            Console.WriteLine("Digite o desconto: ");
            var desconto = decimal.Parse(Console.ReadLine());
            decimal valor = p.CalcularDesconto(desconto);
            Console.WriteLine($"Valor do produto com desconto aplicado {valor}");
             
        }
    }
}
