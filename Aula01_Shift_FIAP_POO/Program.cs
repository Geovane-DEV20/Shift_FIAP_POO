using System;

namespace Aula01_Shift_FIAP_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando (instanciando) objetos a partir da classe cliente

            Cliente cliente = new Cliente();

            cliente.Nome = "Cleber";
            cliente.Idade = 25;
            cliente.Altura = 1.90F;

            Console.WriteLine($"Idade {cliente.Idade}");

            Cliente cliente2 = new Cliente();

            cliente2.Nome = "Vanessa";
            cliente.Idade = 20;
            cliente.Altura = 1.67F;

            Console.WriteLine($"Idade {cliente.Idade}");


            //Criando o objeto a partir do endereço

            Endereco end = new Endereco();
            end.Logradouro = "Av São Joao";
            end.Cep = "12345-678";
            end.Cidade = "12345-678";
            end.Numero = "278";

            cliente2.Endereco = end;

            Console.WriteLine($"Nome do cliente: {cliente.Nome}, " +
                $"Idade {cliente2.Idade}" + $"Cidade : {cliente.Endereco}");
        }
    }
}
