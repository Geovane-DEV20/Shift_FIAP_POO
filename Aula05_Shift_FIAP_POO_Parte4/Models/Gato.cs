using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05_Shift_FIAP_POO_Parte4.Models
{
    internal class Gato : Animais
    {
        //Utilizar o modificador override, para que o método herdado sobrescreva o método da classe Pai.
        public override void Som()
        {

            Console.WriteLine("Esse animal faz miau.");
        }

    }
}
