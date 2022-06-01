using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05_Shift_Fiap_POO.Models
{
    class Loja : Estabelecimento
    {

        public int QuantidadeProduto { get; set; }

        public TipoLoja Tipo { get; set; }


        public override decimal CalcularImposto(decimal faturamento)
        {
            return faturamento * 0.1m;
        }

    }
    enum TipoLoja
    {
        Roupas, Sapatos, Calcados, Alimentos, Bebidas, PetShop
    }
}

