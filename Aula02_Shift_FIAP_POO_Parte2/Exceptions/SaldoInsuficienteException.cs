using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02_Shift_FIAP_POO_Parte2.Exceptions
{
    class SaldoInsuficienteException : Exception
    {

        //Construtor que recebe mensagem

        public SaldoInsuficienteException(string msg) : base(msg)
        {

        }
    }
}
