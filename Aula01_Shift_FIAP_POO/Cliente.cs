using System;
using System.Collections.Generic;
using System.Text;

namespace Aula01_Shift_FIAP_POO
{
    class Cliente
    {

        private string _nome;

        private int _idade;

        public Endereco Endereco { get; set; }
        public bool Especial { get; set; }
        public float Altura { get; set; }

        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value > 0)
                    _idade = value;
            }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }
}
