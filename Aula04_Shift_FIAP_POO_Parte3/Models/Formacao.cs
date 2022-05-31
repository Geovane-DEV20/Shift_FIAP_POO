using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04_Shift_FIAP_POO_Parte3.Models
{
    // Classe abstrata -> não pode ser isntanciada e pode conter métodos abstratos.
    abstract class Formacao
    {

        public string Nome { get; set; }

        public int Duracao { get; set; }
        public decimal Mensalidade { get; set; }
        public Instituicao Instituicao { get; set; }

        public Formacao(string nome)
        {
            Nome = nome;
            DefinirDuracao();
        }

        public abstract void DefinirDuracao();

        public float CalcularMedia(float nota1,  float nota2)
        {
            return (nota1 + nota2) / 2;
        }

        public float CalcularMedia(float nota1, float nota2, float nota3)
        {

            if(nota1 < nota2  && nota1 < nota3)
            {
                CalcularMedia(nota1, nota2);
            }
            else if  (nota2 < nota1 && nota2  < nota3) 
            {
                return CalcularMedia(nota1, nota3);
            }
            return CalcularMedia(nota1, nota2);
        }

        public virtual decimal CalcularMensalidade()
        {
            return Mensalidade = Duracao * 400;
        }


    }
}
