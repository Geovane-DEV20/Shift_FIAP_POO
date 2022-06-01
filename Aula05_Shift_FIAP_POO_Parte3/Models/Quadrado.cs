using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05_Shift_FIAP_POO_Parte3.Models
{
    class Quadrado : Forma
    {

        private double lado;

        public Quadrado(double l)
        {
            lado = l;
        }

        public override double Area()
        {
            return (lado * lado);
        }
    }
}
