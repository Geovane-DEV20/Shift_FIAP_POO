using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04_Shift_FIAP_POO_Parte3.Models
{
    class Bacharelado : Formacao
    {
        public string ProjetoConclusao { get; set; }
        public int CargaHorarioEstagio { get; set; }
        public Bacharelado(string nome, int carga) : base(nome)
        {
            CargaHorarioEstagio = carga;
        }

        public override decimal CalcularMensalidade()
        {
            return Mensalidade = Duracao * 600 + CargaHorarioEstagio * 12;

        }

        public decimal CalcularMensalidade(decimal desconto)
        {
            return Mensalidade = CalcularMensalidade() - CalcularMensalidade() * desconto / 100;

        }

        public override void DefinirDuracao()
        {
            if (Nome.ToLower().Contains("engenharia"))
            {
                Duracao = 60;

            }
            else
            {
                Duracao = 48;
            }


        }
    }
}
