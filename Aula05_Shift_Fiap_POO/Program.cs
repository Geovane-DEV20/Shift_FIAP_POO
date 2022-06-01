using Aula05_Shift_Fiap_POO.Models;
using System;

namespace Aula05_Shift_Fiap_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loja loja = new Loja()
            {
                Cnpj = "12.123.123/0001-10",
                Nome = "FIAP Store",
                QuantidadeProduto = 750,
                Tipo = TipoLoja.Roupas
            };

        }
    }
}
