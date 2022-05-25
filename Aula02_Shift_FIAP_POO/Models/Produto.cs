using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02_Shift_FIAP_POO.Models
{
    class Produto
    {

        //Propriedades - Informações que o objeto pode armazenar
        public string idProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public string Marca { get; set; }

        // void nao tem retorno.
        // Métodos ações que os objetos pode executar
        public void ExibirDados()
        {
            Console.WriteLine($"Id do produto: {idProduto}\nNome {Nome}\n Preco {Preco}\n Estoque {Estoque}\n Marca {Marca}");
        }

        public decimal CalcularDesconto(decimal ValorDesconto)
        {
            decimal valorFinal = Preco - ValorDesconto;
            return valorFinal;

        }
    }
}
