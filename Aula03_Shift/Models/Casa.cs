using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Shift_FIAP_POO.Models
{
    class Casa
    {

        public int Comodos { get; set; }
        public bool Piscina { get; set; }
        public double AreaTotal { get; set; }

        public Casa(int comodos, bool piscina, double areaTotal)
        {
            Comodos = comodos;
            Piscina = piscina;
            AreaTotal = areaTotal;
        }
        public Casa(double areaTotal)
        {
            AreaTotal = areaTotal; 
        }

        //Construtor sem parametros
        public Casa()
        {

        }

    }
}
