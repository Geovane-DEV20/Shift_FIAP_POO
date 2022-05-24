using System;
using System.Collections.Generic;
using System.Text;

namespace Aula01_Shift_FIAP_POO_Parte2.Models
{
    class Aviao
    {
        public string Modelo { get; set; }
        public string Fabricante { get; set; }
        public bool ArCondicionado { get; set; }
        public int Ano { get; set; }
        public decimal Valor { get; set; }
        public Cor Cor { get; set; }
        public string Prefixo { get; set; }
        public double HorasVoo { get; set; }
    }
}
