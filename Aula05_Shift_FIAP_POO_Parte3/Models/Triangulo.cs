using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05_Shift_FIAP_POO_Parte3.Models
{
    internal class Triangulo : Forma
    {
        private double tbase;
        
        private double faltura;

        public Triangulo(double b, double h)
        {
            this.tbase = b;
            this.faltura = h;
        }

        public override double Area()
        {
            return (0.5 * (tbase - faltura));
        }
    }
}
