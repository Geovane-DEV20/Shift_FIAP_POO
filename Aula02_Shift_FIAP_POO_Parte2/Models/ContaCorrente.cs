using Aula02_Shift_FIAP_POO_Parte2.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02_Shift_FIAP_POO_Parte2.Models
{
    class ContaCorrente : Conta
    {
        // Propriedades da conta corrente
        public bool Especial { get; set; }
        public decimal Limite { get; set; }
        public Cliente Cliente { get; set; }
        public ContaPoupanca ContaPoupanca { get; set; }
        public double Juros { get; set; }

        //Construtor
        public ContaCorrente(double numero, bool especial, decimal limite, Cliente cliente,
            double juros, ContaPoupanca contaPoupanca)
        {
            Numero = numero;
            Limite = limite;
            Cliente = cliente;
            Especial = especial;
            Juros = juros;
            ContaPoupanca = contaPoupanca;
        }

        public void Retirar(decimal valor)
        {
            if (!((Especial && valor <= Saldo + Limite) || (valor <= Saldo)))
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para realizar a operação.");

            }
        }
        public decimal RetornarSaldoTotal()
        {
            if (Especial)
            {
                return Saldo + Limite;
            }
            return Saldo;
        }

        public void TrasferirParaPoupanca(decimal valor)
        {

            Retirar(valor);
            ContaPoupanca.Depositar(valor);
            
        }

        public decimal CalcularValorTaxaJuros(int dias)
        {
            if(Saldo < 0)
            {
                return Convert.ToDecimal(Juros) * dias * Saldo;
            }
            return 0;
        }
    }
}
