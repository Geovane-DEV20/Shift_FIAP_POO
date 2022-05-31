using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04_Shift_FIAP_POO.Models
{
    class Fabricante 
    {

        public string Nome { get; set; }
        public override string ToString()
        {
            return $"Fabricante: {Nome}";
        }
    }
}
