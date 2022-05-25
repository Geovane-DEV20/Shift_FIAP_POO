using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02_Shift_FIAP_POO_Parte2.Models
{
    class Conta
    {

        // Propriedade da conta

        public decimal Saldo { get; protected set; }
        public double Numero { get; protected set; }

        public void Depositar(decimal valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("O Valor não pode ser negativo");
            }
            
            Saldo += valor; // Saldo = saldo + valor;
            
        }



    }
}
