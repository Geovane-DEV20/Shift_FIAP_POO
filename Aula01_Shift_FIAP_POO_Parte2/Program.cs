using Aula01_Shift_FIAP_POO_Parte2.Models;
using System;

namespace Aula01_Shift_FIAP_POO_Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da cor: ");
            string nomeCor = Console.ReadLine();

            Console.WriteLine("Digite o R da cor com valores de 0 a 255: ");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o R da cor com valores de 0 a 255: ");
            int g = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o R da cor com valores de 0 a 255: ");
            int b = int.Parse(Console.ReadLine());

            Cor cor = new Cor();

            cor.Nome = nomeCor;
            cor.R = r;
            cor.G = g;
            cor.B = b;

            Console.WriteLine("Digite o fabricante do carro: ");
            string fabricante = Console.ReadLine();

            Console.WriteLine("Digite o Ano do carro: ");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o modelo do carro: ");
            string modelo = Console.ReadLine();

            Console.WriteLine("Digite a placa do carro: ");
            string placa = Console.ReadLine();

            Console.WriteLine("Informe se o carrro tem ar condicionado (true/false): ");
            bool arCondicionado = bool.Parse(Console.ReadLine());

            Console.WriteLine("Informe se o carro tem este (true/false): ");
            bool estepe = bool.Parse(Console.ReadLine());

            Carro carro = new Carro();

            carro.Ano = ano;
            carro.Placa = placa;
            carro.Fabricante = fabricante;
            carro.ArCondicionado = arCondicionado;
            carro.Cor = cor;
            carro.Estepe = estepe;

            //Exibindo os valores

            Console.WriteLine($"Modelo: {carro.Modelo}\n Ano: {carro.Ano}\n Placa: {carro.Placa}\n Fabricante: {carro.Fabricante}" +
                $"\n Ar Condicionado: {carro.ArCondicionado} \n Estepe: {carro.Estepe} \n Cor: {carro.Cor.Nome}");

            // Instanciar um aviao

            Console.WriteLine("Digite o fabricante do Avião: ");
            string modeloJato = Console.ReadLine();

            Console.WriteLine("Digite o ano do avião: ");
            int anoJato = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do fabricante do jato: ");
            string fabricanteJato = Console.ReadLine();

            Console.WriteLine("Valor do Jato");
            decimal valorJato = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o prefixo do aviaão: ");
            string prefixo = Console.ReadLine();

            Console.WriteLine("Digite as horas-voo do avião: ");
            double horasVoo = double.Parse(Console.ReadLine());


            Aviao jato = new Aviao();
            jato.Modelo = modeloJato;
            jato.Ano = anoJato;
            jato.Valor = valorJato;
            jato.Prefixo = prefixo;
            jato.HorasVoo = horasVoo;
            jato.Fabricante = fabricanteJato;


            Console.WriteLine($"Modelo: {jato.Modelo}\n Ano: {jato.Ano}\n Fabricante: {jato.Fabricante}" +
    $"\n Ar Condicionado: {jato.ArCondicionado} \n Cor: {jato.Cor.Nome}");
        }
    }
}
