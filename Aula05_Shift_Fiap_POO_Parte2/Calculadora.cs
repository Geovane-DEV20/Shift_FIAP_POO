using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05_Shift_Fiap_POO_Parte2
{
    static class Calculadora
    {

        public static void Soma()
        {
            Console.WriteLine("Sem valor inserido");
        }

        public static void Soma(int x, int y)
        {
            Console.WriteLine($"A soma de {x} + {y} é igual a {x + y}");
        }

        public static void Soma(float x, float y)
        {
            Console.WriteLine($"A soma de {x} + {y} é igual a {x + y}");
        }
        public static void Soma(string s)
        {
            Console.WriteLine($"{s} não é um valor numérico");
        }

    }
}
