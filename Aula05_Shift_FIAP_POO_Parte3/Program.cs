using Aula05_Shift_FIAP_POO_Parte3.Models;
using System;

namespace Aula05_Shift_FIAP_POO_Parte3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo(5.0);
            Console.WriteLine($"Area do Circulo: {circulo.Area()}");

            Quadrado quadrado = new Quadrado(1.74);
            Console.WriteLine($"Area do quadrado {quadrado.Area()}");

            Triangulo triangulo = new Triangulo(2.74, 6.2);
            Console.WriteLine($"Area do triangulo {triangulo.Area()}");

        }
    }
}
