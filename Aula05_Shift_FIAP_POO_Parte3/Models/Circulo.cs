using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05_Shift_FIAP_POO_Parte3.Models
{
    class Circulo : Forma
    {

        private double radius;

        public Circulo(double r)
        {
            radius = r;
        }

        public override double Area()
        {
            return (3.14 * radius * radius);
        }
    }
}
