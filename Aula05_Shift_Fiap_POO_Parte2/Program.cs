using System;

namespace Aula05_Shift_Fiap_POO_Parte2
{
    static class Program
    {
        static void Main(string[] args)
        {
            Calculadora.Soma();
            Calculadora.Soma(12, 8);
            Calculadora.Soma(1f, 9f); 
            Calculadora.Soma(" Olá, mundo! ");

        }
    }
}
