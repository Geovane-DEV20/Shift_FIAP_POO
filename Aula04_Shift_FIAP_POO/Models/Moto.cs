using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04_Shift_FIAP_POO.Models
{
    class Moto : Veiculo
    {
        public bool PartidaEletrica { get; set; }


        //Construtor que invoca o construtor veiculo, contendo 3 parametros
        public Moto(string cor, string motor, int ano, bool partida): base(cor, motor, ano)
        {
            PartidaEletrica = partida;
        }

        public Moto()
        {

        }

        public override void Acelerar()
        {
            Console.WriteLine($"Moto acelerando");
        }
        public override string ToString()
        {
            return base.ToString() + $" \nPartida elétrica: {(PartidaEletrica ? "Sim" : "Não")}";
        }

    }
}
