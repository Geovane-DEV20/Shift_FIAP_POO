using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04_Shift_FIAP_POO_Parte2.Models
{
    class Produto
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Produto(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public decimal CalcularDesconto(decimal porcentagem)
        {
            return Preco - Preco * porcentagem / 100;
        }
    }
}
