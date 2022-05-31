using System;
using Aula04_Shift_FIAP_POO.Models;
using System.Collections.Generic;
using System.Text;

namespace Aula04_Shift_FIAP_POO.Models
{
    class Carro : Veiculo
    {
        public bool Arcondicionado { get; set; }
        public int QuantidadePortas { get; set; }

        // Contrutor invocando o construtor pai com 3 parametros
        public Carro(string cor, string motor, int ano, bool ar, int portas) : base(cor, motor, ano)
        {
            Arcondicionado = ar;
            QuantidadePortas = portas;
        }


        // Invocando o construto padrão da classe veiculo
        public Carro()
        {

        }

        public Carro(int quantidade)
        {
            QuantidadePortas= quantidade;
        }

        public override void Frear(double velocidadeAtual, bool parado,double velocidadeFrenagem)
        {

            var velocidadeFrenagemCarro = velocidadeFrenagem * 0.8;
            Console.WriteLine($"Nova velocidade de frangem {velocidadeFrenagemCarro}");

            base.Frear(velocidadeAtual, parado, velocidadeFrenagem);

        }


        public override string ToString()
        {

            return base.ToString()
            + $" \n Ar-condicionado {(Arcondicionado?"Tem" : "Não Tem")} \nNumero de Portas: {QuantidadePortas}";
        }
    }
}
