using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04_Shift_FIAP_POO_Parte3.Models
{
    class Tecnologos : Formacao
    {
        public bool PlanoEstendido { get; set; }

        public Tecnologos(string nome) : base(nome)
        {  }

        public override decimal CalcularMensalidade()
        {
            return Mensalidade  = Duracao * 500;
        }

        public override void DefinirDuracao()
        {
            Duracao = 24;
        }

        public override string ToString()
        {
            return base.ToString() + $"Plano estendido: {PlanoEstendido}";
        }

    }
}
