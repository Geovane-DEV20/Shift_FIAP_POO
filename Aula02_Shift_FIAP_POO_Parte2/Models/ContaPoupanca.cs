using Aula02_Shift_FIAP_POO_Parte2.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02_Shift_FIAP_POO_Parte2.Models
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        // Propredades

        public decimal Rendimentos { get; set; }

        public ContaPoupanca(double numero)
        {
            Numero = numero;
        }

        // Métodos
        public void Retirar(decimal valor)
        {
            if (Saldo < valor)
            {

                throw new SaldoInsuficienteException($"Valor maximo para saque {Saldo}");
            }
            Saldo -= valor;
        }

        public decimal CalcularRetornoInvestimento(decimal taxa)
        {
            return Saldo * taxa;
        }
    }
}
