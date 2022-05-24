using System;
using System.Collections.Generic;
using System.Text;

namespace Aula01_Shift_FIAP_POO_Parte2.Models
{
    class Carro
    {
        public String Modelo { get; set; }
        public String Fabricante { get; set; }
        public int Ano { get; set; }
        public Cor Cor { get; set; }
        public String Placa { get; set; }
        public decimal Valor { get; set; }
        public bool ArCondicionado { get; set; }
        public bool Estepe { get; set; }
    }
}
