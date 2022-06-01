using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05_Shift_Fiap_POO.Models
{
    class Clinica : Estabelecimento
    {
        public override decimal CalcularImposto(decimal faturamento)
        {
            return faturamento * 0.065m;
        }
    }
}
