using Aula04_Shift_FIAP_POO_Parte2.Models;
using System;

namespace Aula04_Shift_FIAP_POO_Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto sapato = new Produto(1, "Sapato social masculino")
            {
                Preco = 4000
            };

            Eletronico laptop = new Eletronico(1, "Macbook Pro")
            {
                Preco = 4000,
                Garantia = true
            };

            DateTime data = new DateTime(2021, 11, 15);
            DateTime dataHoje = DateTime.Now;

            Perecivel macarrao = new Perecivel(2, "Macarrao parafuso", dataHoje);

            Console.WriteLine($"Data de validade: {macarrao.DataValidade}");
            Console.WriteLine($"Data de validade só com dia: {macarrao.DataValidade.ToShortDateString()}");
            Console.WriteLine($"Dia: {macarrao.DataValidade.Month} \n Ano:{macarrao.DataValidade.Year}");

            var desconto = sapato.CalcularDesconto(15);

            Console.WriteLine($"Valor do produto {sapato.Preco}\n Valor com desconto: {desconto}");

            Console.WriteLine($"Valor da garantia {laptop.GarantiaEstendida()}");
    }
}
}
