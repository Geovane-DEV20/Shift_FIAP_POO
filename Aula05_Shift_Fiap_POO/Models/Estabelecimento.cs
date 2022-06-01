using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05_Shift_Fiap_POO.Models
{
    abstract class Estabelecimento
    {

        public string Nome { get; set; }

        public string Cnpj { get; set; }

        public abstract decimal CalcularImposto(decimal faturamento);

        public void CadastrarEstabelecimento(string nome)
        {

            Console.WriteLine($"Cadastrando funcionario {nome}, no estabelecimento {Nome}");
        }

        public bool ValidarCnpj()
        {
            if (Cnpj.Length < 20)
            {
                return false;
            }
            return true;

        }

    }
}
